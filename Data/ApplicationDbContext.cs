using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MoustacheApp.Services;
using MoustacheApp.Models;

namespace MoustacheApp.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        private readonly ICurrentUserService _currentUserService;

        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, ICurrentUserService currentUserService)
            : base(options)
        {
            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(currentUserService));
        }

        public virtual DbSet<MoAnswer> MoAnswer { get; set; }
        public virtual DbSet<MoPlayResult> MoPlayResult { get; set; }
        public virtual DbSet<MoQuestion> MoQuestion { get; set; }
        public virtual DbSet<MoQuizDetail> MoQuizDetail { get; set; }
        public virtual DbSet<MoQuizOwner> MoQuizOwner { get; set; }
        public virtual DbSet<MoQuizUser> MoQuizUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.

                optionsBuilder.UseMySql(@"server=moustache-app.ddns.net;userid=remote_user;pwd=access2remoteDB;database=remote_test_db;persistsecurityinfo=True");
                //optionsBuilder.UseMySql(@"server=localhost;userid=root;pwd=6gdeyaT93y2p;database=moustache_db;persistsecurityinfo=True");
                
                //IConfigurationRoot configuration = new ConfigurationBuilder()
                //    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                //    .AddJsonFile("appsettings.json")
                //    .Build();
                //optionsBuilder.UseMySql(configuration.GetConnectionString("ServerConnection"));
            }
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            //OnBeforeSaving();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            //OnBeforeSaving();
            return base.SaveChangesAsync(cancellationToken);
        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
                                            CancellationToken cancellationToken = default(CancellationToken))
        {
            //OnBeforeSaving();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void OnBeforeSaving()
        {
            var currentTime = DateTimeOffset.UtcNow;
            var currentUser = _currentUserService.GetCurrentUserName();

            foreach (var item in ChangeTracker.Entries()
                    .Where(e => e.State == EntityState.Added && e.Entity is Audit))
            {
                var entity = item.Entity as Audit;
                entity.CreatedDate = currentTime;
                entity.CreatedBy = currentUser;
                entity.ModifiedDate = currentTime;
                entity.ModifiedBy = currentUser;
            }

            foreach (var item in ChangeTracker.Entries()
                    .Where(predicate: e => e.State == EntityState.Modified && e.Entity is Audit))
            {
                var entity = item.Entity as Audit;
                entity.ModifiedDate = currentTime;
                entity.ModifiedBy = currentUser;
                item.Property(nameof(entity.CreatedDate)).IsModified = false;
                item.Property(nameof(entity.CreatedBy)).IsModified = false;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.Property<uint>("Anonymous")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("'0'");

                entity.Property<uint>("Disabled")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<MoAnswer>(entity =>
            {
                entity.HasIndex(e => e.QuestionId)
                    .HasName("QuestionId");

                entity.Property(e => e.Correct).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.MoAnswer)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MoAnswer_ibfk_1");
            });

            modelBuilder.Entity<MoPlayResult>(entity =>
            {
                entity.HasIndex(e => e.QuizId)
                    .HasName("QuizId");

                entity.Property(e => e.Attempt).HasDefaultValueSql("'0'");

                entity.Property(e => e.QuestCount).HasDefaultValueSql("'0'");

                //entity.Property(e => e.SubmittedDt).HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.MoPlayResult)
                    .HasForeignKey(d => d.QuizId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MoPlayResult_ibfk_1");
            });

            modelBuilder.Entity<MoQuestion>(entity =>
            {
                entity.HasIndex(e => e.QuizId)
                    .HasName("QuizId");

                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.MoQuestion)
                    .HasForeignKey(d => d.QuizId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MoQuestion_ibfk_1");
            });

            modelBuilder.Entity<MoQuizDetail>(entity =>
            {
                entity.HasIndex(e => e.CommonId)
                    .HasName("CommonId");

                entity.HasIndex(e => e.PreviousId)
                    .HasName("PreviousId");

                entity.Property(e => e.Attempts).HasDefaultValueSql("'1'");

                entity.Property(e => e.Current).HasDefaultValueSql("'0'");

                entity.Property(e => e.Played).HasDefaultValueSql("'0'");

                entity.Property(e => e.Published).HasDefaultValueSql("'0'");

                entity.Property(e => e.QuestToPlay).HasDefaultValueSql("'0'");

                entity.Property(e => e.Randomise).HasDefaultValueSql("'0'");

                entity.Property(e => e.ResultLocked).HasDefaultValueSql("'0'");

                entity.Property(e => e.TimeLimit).HasDefaultValueSql("'0'");

                entity.Property(e => e.Type).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Previous)
                    .WithMany(p => p.InversePrevious)
                    .HasForeignKey(d => d.PreviousId)
                    .HasConstraintName("MoQuizDetail_ibfk_1");
            });

            modelBuilder.Entity<MoQuizOwner>(entity =>
            {
                entity.HasIndex(e => e.QuizId)
                    .HasName("QuizId");

                entity.HasIndex(e => e.UserId)
                    .HasName("UserId");

                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.MoQuizOwner)
                    .HasForeignKey(d => d.QuizId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MoQuizOwner_ibfk_1");
            });

            modelBuilder.Entity<MoQuizUser>(entity =>
            {
                entity.HasIndex(e => e.QuizId)
                    .HasName("QuizId");

                entity.HasIndex(e => e.UserId)
                    .HasName("UserId");

                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.MoQuizUser)
                    .HasForeignKey(d => d.QuizId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MoQuizUser_ibfk_1");
            });
        }
    }
}
