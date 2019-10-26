using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MoustacheApp.Models;

namespace MoustacheApp.Models
{
    [Table("MoQuizDetail")]
    public partial class MoQuizDetail : Audit
    {
        public MoQuizDetail()
        {
            InversePrevious = new HashSet<MoQuizDetail>();
            MoPlayResult = new HashSet<MoPlayResult>();
            MoQuestion = new HashSet<MoQuestion>();
            MoQuizOwner = new HashSet<MoQuizOwner>();
            MoQuizUser = new HashSet<MoQuizUser>();
        }

        [Column(TypeName = "varchar(255)")]
        public new string Id { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string PreviousId { get; set; }
        [Range(0, 1)]
        public uint Current { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string CommonId { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Name { get; set; }
        [Column(TypeName = "text")]
        public string Information { get; set; }
        [Range(0, 1)]
        public uint Type { get; set; }
        [Range(0, 1)]
        public uint Published { get; set; }
        public uint Attempts { get; set; }
        [Range(0, 1)]
        public uint Played { get; set; }
        public uint Randomise { get; set; }
        public uint QuestToPlay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? QuizStart { get; set; }
        public uint TimeLimit { get; set; }
        public uint ResultLocked { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LockedUntil { get; set; }

        [ForeignKey("PreviousId")]
        [InverseProperty("InversePrevious")]
        public virtual MoQuizDetail Previous { get; set; }
        [InverseProperty("Previous")]
        public virtual ICollection<MoQuizDetail> InversePrevious { get; set; }
        [InverseProperty("Quiz")]
        public virtual ICollection<MoPlayResult> MoPlayResult { get; set; }
        [InverseProperty("Quiz")]
        public virtual ICollection<MoQuestion> MoQuestion { get; set; }
        [InverseProperty("Quiz")]
        public virtual ICollection<MoQuizOwner> MoQuizOwner { get; set; }
        [InverseProperty("Quiz")]
        public virtual ICollection<MoQuizUser> MoQuizUser { get; set; }
    }
}
