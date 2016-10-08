using Ftims.Pai.Service.DTO;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Ftims.Pai.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITimesheetService" in both code and config file together.
    [ServiceContract]
    public interface ITimesheetService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/task/{id}")]
        Timesheet Get(string id);
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/task/")]
        Timesheet[] GetAll();
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/task/", RequestFormat = WebMessageFormat.Json)]
        Timesheet Create(CreateTimesheet task);
        [OperationContract]
        [WebInvoke(Method = "PUT", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/task/{id}", RequestFormat = WebMessageFormat.Json)]
        void Update(string id, Timesheet task);
        [OperationContract]
        [WebInvoke(Method = "DELETE", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/task/{id}")]
        void Delete(string id);
    }
}
