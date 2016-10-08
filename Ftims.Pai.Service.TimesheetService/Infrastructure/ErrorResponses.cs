using System.Net;
using System.ServiceModel.Web;

namespace Ftims.Pai.Service.Infrastructure
{
    public static class ErrorResponses
    {
        public static void BadRequest(this TimeManagement svc, string message)
        {
            OutgoingWebResponseContext response = WebOperationContext.Current.OutgoingResponse;
            response.StatusCode = HttpStatusCode.BadRequest;
            response.StatusDescription = message;
        }
    }
}