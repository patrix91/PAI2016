using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ftims.Pai.Service.TimesheetService.DTO
{
    [DataContract]
    public class Timesheet
    {
        [DataMember]
        public IList<DayEntry> Days
        {
            get;
            set;
        }

        [DataMember(IsRequired = false)]
        public int Id
        {
            get;
            set;
        }

        [DataMember]
        public int UserId
        {
            get;
            set;
        }


    }
}