using System.Runtime.Serialization;

namespace Ftims.Pai.Service.DTO
{
    [DataContract]
    public class ProjectWithDetails : Project
    {
        public ProjectWithDetails(int id, string code, string name, int type, Employee manager) : base(id, code, name, type)
        {
            Manager = manager;
        }

        [DataMember]
        public Employee Manager { get; set; }
  
    }
}