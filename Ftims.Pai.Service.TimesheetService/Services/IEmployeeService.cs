using Ftims.Pai.Service.DTO;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Ftims.Pai.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/employee/{id}")]
        Employee Get(string id);
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/employee/{id}/subordinates")]
        Employee[] GetSubordinates(string id);
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/employee/{id}/details")]
        EmployeeWithDetails GetDetails(string id);
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/employee/")]
        Employee[] GetAll();
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/employee/", RequestFormat = WebMessageFormat.Json)]
        Employee Create(CreateEmployee task);
        [OperationContract]
        [WebInvoke(Method = "PUT", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/employee/{id}", RequestFormat = WebMessageFormat.Json)]
        void Update(string id, Employee task);
        [OperationContract]
        [WebInvoke(Method = "DELETE", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/employee/{id}")]
        void Delete(string id);
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/employee/{id}/timesheets")]
        Timesheet[] GetTimesheets(string id);
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/employee/{id}/projects")]
        Project[] GetProjects(string id);
    }
}
