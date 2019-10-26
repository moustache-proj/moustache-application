﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoustacheApp.Data;

namespace MoustacheApp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190927112112_CreateMoustacheSchema")]
    partial class CreateMoustacheSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MoustacheApp.Models.MoAnswer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<uint>("Correct")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'0'");

                    b.Property<string>("QuestionId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId")
                        .HasName("QuestionId");

                    b.ToTable("MoAnswer");
                });

            modelBuilder.Entity("MoustacheApp.Models.MoPlayResult", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<uint>("Attempt")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'0'");

                    b.Property<string>("Feedback")
                        .HasColumnType("text");

                    b.Property<DateTime>("PlayedDt")
                        .HasColumnName("PlayedDT")
                        .HasColumnType("datetime");

                    b.Property<uint>("QuestCount")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'0'");

                    b.Property<string>("QuizId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<uint?>("Result");

                    b.Property<uint?>("ResultAdjusted");

                    b.Property<DateTime>("SubmittedDt")
                        .HasColumnName("SubmittedDT")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("QuizId")
                        .HasName("QuizId");

                    b.ToTable("MoPlayResult");
                });

            modelBuilder.Entity("MoustacheApp.Models.MoQuestion", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("QuizId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("QuizId")
                        .HasName("QuizId");

                    b.ToTable("MoQuestion");
                });

            modelBuilder.Entity("MoustacheApp.Models.MoQuizDetail", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<uint>("Attempts")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'1'");

                    b.Property<string>("CommonId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<uint>("Current")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'0'");

                    b.Property<string>("Information")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LockedUntil")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<uint>("Played")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'0'");

                    b.Property<string>("PreviousId")
                        .HasColumnType("varchar(255)");

                    b.Property<uint>("Published")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'0'");

                    b.Property<uint>("QuestToPlay")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'0'");

                    b.Property<DateTime?>("QuizStart")
                        .HasColumnType("datetime");

                    b.Property<uint>("Randomise")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'0'");

                    b.Property<uint>("ResultLocked")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'0'");

                    b.Property<uint>("TimeLimit")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'0'");

                    b.Property<uint>("Type")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'0'");

                    b.HasKey("Id");

                    b.HasIndex("CommonId")
                        .HasName("CommonId");

                    b.HasIndex("PreviousId")
                        .HasName("PreviousId");

                    b.ToTable("MoQuizDetail");
                });

            modelBuilder.Entity("MoustacheApp.Models.MoQuizOwner", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("QuizId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("QuizId")
                        .HasName("QuizId");

                    b.HasIndex("UserId")
                        .HasName("UserId");

                    b.ToTable("MoQuizOwner");
                });

            modelBuilder.Entity("MoustacheApp.Models.MoQuizUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("QuizId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("QuizId")
                        .HasName("QuizId");

                    b.HasIndex("UserId")
                        .HasName("UserId");

                    b.ToTable("MoQuizUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MoustacheApp.Models.MoAnswer", b =>
                {
                    b.HasOne("MoustacheApp.Models.MoQuestion", "Question")
                        .WithMany("MoAnswer")
                        .HasForeignKey("QuestionId")
                        .HasConstraintName("MoAnswer_ibfk_1");
                });

            modelBuilder.Entity("MoustacheApp.Models.MoPlayResult", b =>
                {
                    b.HasOne("MoustacheApp.Models.MoQuizDetail", "Quiz")
                        .WithMany("MoPlayResult")
                        .HasForeignKey("QuizId")
                        .HasConstraintName("MoPlayResult_ibfk_1");
                });

            modelBuilder.Entity("MoustacheApp.Models.MoQuestion", b =>
                {
                    b.HasOne("MoustacheApp.Models.MoQuizDetail", "Quiz")
                        .WithMany("MoQuestion")
                        .HasForeignKey("QuizId")
                        .HasConstraintName("MoQuestion_ibfk_1");
                });

            modelBuilder.Entity("MoustacheApp.Models.MoQuizDetail", b =>
                {
                    b.HasOne("MoustacheApp.Models.MoQuizDetail", "Previous")
                        .WithMany("InversePrevious")
                        .HasForeignKey("PreviousId")
                        .HasConstraintName("MoQuizDetail_ibfk_1");
                });

            modelBuilder.Entity("MoustacheApp.Models.MoQuizOwner", b =>
                {
                    b.HasOne("MoustacheApp.Models.MoQuizDetail", "Quiz")
                        .WithMany("MoQuizOwner")
                        .HasForeignKey("QuizId")
                        .HasConstraintName("MoQuizOwner_ibfk_1");
                });

            modelBuilder.Entity("MoustacheApp.Models.MoQuizUser", b =>
                {
                    b.HasOne("MoustacheApp.Models.MoQuizDetail", "Quiz")
                        .WithMany("MoQuizUser")
                        .HasForeignKey("QuizId")
                        .HasConstraintName("MoQuizUser_ibfk_1");
                });
#pragma warning restore 612, 618
        }
    }
}
