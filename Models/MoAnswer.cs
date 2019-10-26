using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MoustacheApp.Models;

namespace MoustacheApp.Models
{
    [Table("MoAnswer")]
    public partial class MoAnswer : Audit
    {
        [Column(TypeName = "varchar(255)")]
        public new string Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string QuestionId { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Answer { get; set; }
        public uint Correct { get; set; }

        [ForeignKey("QuestionId")]
        [InverseProperty("MoAnswer")]
        public virtual MoQuestion Question { get; set; }
    }
}
