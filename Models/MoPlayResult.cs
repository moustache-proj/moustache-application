using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MoustacheApp.Models;

namespace MoustacheApp.Models
{
    [Table("MoPlayResult")]
    public partial class MoPlayResult : Audit
    {
        [Column(TypeName = "varchar(255)")]
        public new string Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string QuizId { get; set; }
        [Column("PlayedDT", TypeName = "datetime")]
        public DateTime PlayedDt { get; set; }
        [Column("SubmittedDT", TypeName = "datetime")]
        public DateTime SubmittedDt { get; set; } = DateTime.Now;
        public uint Attempt { get; set; }
        public uint QuestCount { get; set; }
        public uint? Result { get; set; }
        public uint? ResultAdjusted { get; set; }
        [Column(TypeName = "text")]
        public string Feedback { get; set; }

        [ForeignKey("QuizId")]
        [InverseProperty("MoPlayResult")]
        public virtual MoQuizDetail Quiz { get; set; }
    }
}
