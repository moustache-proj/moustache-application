using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoustacheApp.Models;

namespace MoustacheApp.Models
{
    public abstract class Audit
    {
        public string Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }

        //[ForeignKey("CreatedBy")]
        //public virtual AppUser CreatedId { get; set; }
        //[ForeignKey("ModifiedBy")]
        //public virtual AppUser ModifiedId { get; set; }
    }
}