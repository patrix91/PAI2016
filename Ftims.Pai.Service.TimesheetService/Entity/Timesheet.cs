using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ftims.Pai.Service.Entity
{
    public class Timesheet
    {
        public int Id { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public TimesheetStatus Status { get; set; }

        public virtual List<Day> Days { get; set; }
        public virtual Employee Applicant { get; set; }
        public virtual List<Audit> AuditData { get; set; }
    }
}