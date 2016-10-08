using Ftims.Pai.Service.TimesheetService.Entity;
using System.Runtime.Serialization;

namespace Ftims.Pai.Service.TimesheetService.DTO
{
    [DataContract]
    public class Project
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }

        public Project(int id, string code, string name)
        {
            Id = id;
            Code = code;
            Name = name;
        }

    }
}