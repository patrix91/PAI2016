using System.Runtime.Serialization;

namespace Ftims.Pai.Service.DTO
{
    [DataContract]
    public class ProjectWithDetails : Project
    {
        public ProjectWithDetails(int id, string code, string name, Employee manager) : base(id, code, name)
        {
            Manager = manager;
        }

        [DataMember]
        public Employee Manager { get; set; }
        [DataMember]
        public int Type { get; set; }
    }
}