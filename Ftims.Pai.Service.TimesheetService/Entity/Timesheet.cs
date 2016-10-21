using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ftims.Pai.Service.DTO;

namespace Ftims.Pai.Service.Entity
{
    public class Timesheet : IEntity<DTO.Timesheet>
    {
        public int Id { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public TimesheetStatus Status { get; set; }
        public virtual List<TimeEntry> Entries { get; set; }
        public virtual Employee Applicant { get; set; }
        public virtual List<Audit> AuditData { get; set; }

        public DTO.Timesheet ToDto()
        {
            return new DTO.Timesheet(Id, StartDay, EndDay, (int)Status, Entries.Select(e => e.ToDto()).ToList());
        }
    }
}