using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MoustacheApp.Models;

namespace MoustacheApp.Models
{
    [Table("MoQuizUser")]
    public partial class MoQuizUser : Audit
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
        [InverseProperty("MoQuizUser")]
        public virtual MoQuizDetail Quiz { get; set; }
    }
}
