using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MoustacheApp.Models;

namespace MoustacheApp.Models
{
    [Table("MoQuestion")]
    public partial class MoQuestion : Audit
    {
        public MoQuestion()
        {
            MoAnswer = new HashSet<MoAnswer>();
        }

        [Column(TypeName = "varchar(255)")]
        public new string Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string QuizId { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Question { get; set; }

        [ForeignKey("QuizId")]
        [InverseProperty("MoQuestion")]
        public virtual MoQuizDetail Quiz { get; set; }
        [InverseProperty("Question")]
        public virtual ICollection<MoAnswer> MoAnswer { get; set; }
    }
}
