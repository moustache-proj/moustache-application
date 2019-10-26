using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MoustacheApp.Models;

namespace MoustacheApp.Models
{
    [Table("MoQuizOwner")]
    public partial class MoQuizOwner : Audit
    {
        [Column(TypeName = "varchar(255)")]
        public new string Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string QuizId { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string UserId { get; set; }

        [ForeignKey("QuizId")]
        [InverseProperty("MoQuizOwner")]
        public virtual MoQuizDetail Quiz { get; set; }
    }
}
