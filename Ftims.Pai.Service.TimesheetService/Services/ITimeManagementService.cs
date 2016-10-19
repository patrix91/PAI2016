using System.Collections.Generic;

namespace Ftims.Pai.Service.Services
{
    public interface ITimeManagementService
    {
        DTO.Project CreateProject(DTO.CreateProject project);
        DTO.Project GetProject(int id);
        List<DTO.Project> GetProjects();
        void DeleteProject(int id);
        DTO.Project UpdateProject(int id, DTO.Project project);
        List<DTO.Project> FindProjects(string query);
        List<DTO.Project> ProjectsManagedBy(int id);
        DTO.Employee GetProjectManager(int id);
        void SetProjectManager(int iprojectId, int employeeId);

    }
}
