using Ftims.Pai.Service.DTO;
using System;

namespace Ftims.Pai.Service.Entity
{
    public class TimeEntry : IEntity<Entry>
    {
        public int Id { get; set; }
        public DateTime Date{get;set;}
        public int Hours { get; set; }
        
        public virtual Project Project { get; set; }
        public virtual ProjectTask Task { get; set; }

        public virtual Timesheet Timesheet { get; set; }

        public Entry ToDto()
        {
            return new Entry(Id, Date, Project.Id, Task.Id, Hours);
        }
    }
}