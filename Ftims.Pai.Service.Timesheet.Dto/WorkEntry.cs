using System.Runtime.Serialization;

namespace Ftims.Pai.Service.TimesheetService.DTO
{
    [DataContract]
    public class WorkEntry
    {
        [DataMember]
        public string ProjectCode
        {
            get;
            set;
        }

        [DataMember]
        public string TaskCode
        {
            get;
            set;
        }

        [DataMember]
        public int Hours
        {
            get;
            set;
        }
    }
}