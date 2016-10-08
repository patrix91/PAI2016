using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ftims.Pai.Service.Timesheet.DTO
{
    [DataContract]
    public class DayEntry
    {
        [DataMember]
        public DateTime Date
        {
            get;
            set;
        }

        [DataMember]
        public IList<WorkEntry> Work
        {
            get;
            set;
        }

    }
}