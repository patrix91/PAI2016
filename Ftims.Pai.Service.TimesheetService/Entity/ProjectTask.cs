using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ftims.Pai.Service.DTO;

namespace Ftims.Pai.Service.Entity
{
    public class ProjectTask : IEntity<DTO.Task>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual List<TimeEntry> Entries { get; set; }

        public Task ToDto()
        {
            return new Task(Id, Code, Name);
        }
    }
}