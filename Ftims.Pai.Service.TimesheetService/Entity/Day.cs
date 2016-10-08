using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ftims.Pai.Service.Entity
{
    public class Day
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DayOfWeek DayOfWeek { get; set; }

        public virtual List<TimeEntry> TimeEntries { get; set; }
        public virtual Timesheet Timesheet { get; set; }
    }
}