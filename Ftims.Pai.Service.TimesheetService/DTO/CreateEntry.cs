using System;
using System.Runtime.Serialization;

namespace Ftims.Pai.Service.DTO
{
    public class CreateEntry
    {
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public int ProjectId { get; set; }
        [DataMember]
        public int TaskId { get; set; }
        [DataMember]
        public int Hours { get; set; }
    }
}