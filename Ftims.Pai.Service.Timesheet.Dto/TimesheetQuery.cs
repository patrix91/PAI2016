using System;
using System.Runtime.Serialization;

namespace Ftims.Pai.Service.TimesheetService.DTO
{
    [DataContract]
    public class TimesheetQuery
    {
        [DataMember]
        public DateTime Begin
        {
            get;
            set;
        }

        [DataMember]
        public DateTime End
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