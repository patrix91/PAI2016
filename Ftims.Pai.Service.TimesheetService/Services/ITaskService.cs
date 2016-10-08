using Ftims.Pai.Service.DTO;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Ftims.Pai.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IITaskService" in both code and config file together.
    [ServiceContract]
    public interface ITaskService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/query/task/{expression}")]
        Task[] Find(string expression);
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/task/{id}")]
        Task Get(string id);
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/task/")]
        Task[] GetAll();
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/task/", RequestFormat = WebMessageFormat.Json)]
        Task Create(CreateTask task);
        [OperationContract]
        [WebInvoke(Method = "PUT", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/task/{id}", RequestFormat = WebMessageFormat.Json)]
        void Update(string id, Task task);
        [OperationContract]
        [WebInvoke(Method = "DELETE", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/task/{id}")]
        void Delete(string id);
    }
}
