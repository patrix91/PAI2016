using System.Runtime.Serialization;

namespace Ftims.Pai.Service.DTO
{
    [DataContract]
    public class EmployeeWithDetails : Employee
    {
        public EmployeeWithDetails(int id, string name, string lastName, string email, Employee manager) : base(id, name, lastName, email)
        {
            Manager = manager;
        }

        [DataMember]
        public Employee Manager { get; set; }



    }
}