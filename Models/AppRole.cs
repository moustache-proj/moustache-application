using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace MoustacheApp.Models
{
    public class AppRole : IdentityRole<string>
    {
        public AppRole() { }

        public AppRole(string name)
        {
            Name = name;
        }
        public AppRole(string name, string description)
        {
            Name = name;
            Description = description;
        }

        [Column(TypeName = "varchar(256)")]
        public string Description { get; set; }
    }
}
