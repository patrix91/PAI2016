using Ftims.Pai.Service.DTO;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Ftims.Pai.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProjectSvc" in both code and config file together.
    [ServiceContract]
    public interface IProjectService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/query/project/{expression}")]
        DTO.Project[] Find(string expression);
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/project/{id}")]
        Project Get(string id);
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/project/{id}/details")]
        ProjectWithDetails GetDetails(string id);
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/project/")]
        DTO.Project[] GetAll();
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/project/", RequestFormat =WebMessageFormat.Json)]
        Project Create(CreateProject project);
        [OperationContract]
        [WebInvoke(Method = "PUT", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/project/{id}", RequestFormat = WebMessageFormat.Json)]
        void Update(string id, DTO.Project project);
        [OperationContract]
        [WebInvoke(Method = "DELETE", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/project/{id}")]
        void Delete(string id);
    }
}
