using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ftims.Pai.Service.DTO
{
    [DataContract]
    public class CreateTimesheet
    {
        [DataMember]
        public DateTime WeekStart { get; set; }
        [DataMember]
        public DateTime WeekEnd { get; set; }
        [DataMember]
        public List<CreateEntry> Entries { get; set; }
        /// Do usunięcia jak będzie autoryzacja
        public int UserId { get; set; }
    }
}