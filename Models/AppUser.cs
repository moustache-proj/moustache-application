using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace MoustacheApp.Models
{
    public class AppUser : IdentityUser<string>
    {
        [Display(Name = "Alt Name")]
        [Column(TypeName = "varchar(256)")]
        public string AltName { get; set; }

        public uint Anonymous { get; set; }

        public uint Disabled { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DisableDate { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string DisabledBy { get; set; }

        [ForeignKey("DisabledBy")]
        public virtual AppUser UserId { get; set; }
    }
}
