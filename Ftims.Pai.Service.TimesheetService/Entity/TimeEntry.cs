using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ftims.Pai.Service.Entity
{
    public class TimeEntry
    {
        public int Id { get; set; }
        public int Hours { get; set; }
        
        public virtual Project Project { get; set; }
        public virtual ProjectTask Task { get; set; }

        public virtual Day Day { get; set; }
    }
}