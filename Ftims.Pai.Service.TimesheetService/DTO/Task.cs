using System.Runtime.Serialization;

namespace Ftims.Pai.Service.DTO
{
    [DataContract]
    public class Task
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }

        public Task(int id, string code, string name)
        {
            Id = id;
            Code = code;
            Name = name;
        }
    }
}