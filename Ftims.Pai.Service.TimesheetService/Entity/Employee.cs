using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ftims.Pai.Service.DTO;

namespace Ftims.Pai.Service.Entity
{
    public class Employee : IEntity<DTO.Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual List<Timesheet> Timesheets { get; set; }
        public virtual List<Project> ManagingProjects { get; set; }
        public virtual List<Employee> Subordinates { get; set; }
        public virtual Employee Manager { get; set; }
        public virtual List<Audit> Actions { get; set; }

        public DTO.Employee ToDto()
        {
            return new DTO.Employee(Id, Name, LastName, Email);
        }
    }
}