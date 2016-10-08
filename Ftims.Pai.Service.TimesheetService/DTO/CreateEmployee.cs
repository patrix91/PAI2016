using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ftims.Pai.Service.DTO
{
    [DataContract]
    public class CreateEmployee
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public int ManagerId { get; set; }

        public CreateEmployee( string name, string lastName, string email, int managerId)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            ManagerId = managerId;
        }
    }
}