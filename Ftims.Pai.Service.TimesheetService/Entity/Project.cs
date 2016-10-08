using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ftims.Pai.Service.DTO;

namespace Ftims.Pai.Service.Entity
{
    public class Project : IEntity<DTO.Project>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public ProjectType Type{ get; set; }

        public virtual List<TimeEntry> Entries { get; set; }
        public virtual Employee ProjectManager { get; set; }

        public DTO.Project ToDto()
        {
            return new DTO.Project(Id, Code, Name);
        }
    }
}