using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ftims.Pai.Service.Entity
{
    public class Audit
    {
        public int Id { get; set; }
        public DateTime Change { get; set; }
        public TimesheetStatus PreviousStatus { get; set; }
        public TimesheetStatus NewStatus { get; set; }

        public virtual Employee Operator { get; set; }
        public virtual Timesheet Timesheet { get; set; }
    }
}