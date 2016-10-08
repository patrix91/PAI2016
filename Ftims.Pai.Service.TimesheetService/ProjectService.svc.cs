using Ftims.Pai.Service.BLL;
using Ftims.Pai.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Ftims.Pai.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProjectSvc" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProjectSvc.svc or ProjectSvc.svc.cs at the Solution Explorer and start debugging.
    public class ProjectService : IProjectService
    {
        private IProjectBLL _projectBll;

        public ProjectService(IProjectBLL projectBll)
        {
            _projectBll = projectBll;
        }

        public Project Create(CreateProject project)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public DTO.Project[] Find(string expression)
        {
            throw new NotImplementedException();
        }

        public Project Get(string id)
        {
            throw new NotImplementedException();
        }

        public DTO.Project[] GetAll()
        {
            throw new NotImplementedException();
        }

        public ProjectWithDetails GetDetails(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, DTO.Project project)
        {
            throw new NotImplementedException();
        }
    }
}
