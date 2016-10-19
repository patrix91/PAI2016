using System.Collections.Generic;
using Ftims.Pai.Service.DAL;
using Ftims.Pai.Service.DTO;
using System.Linq;
using System;

namespace Ftims.Pai.Service.Services
{
    public class TimeManagementService : ITimeManagementService
    {
        private IUnitOfWork unitOfWork;

        public TimeManagementService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public Project CreateProject(CreateProject project)
        {
            var projectEntity = new Entity.Project();
            projectEntity.Code = project.Code;
            projectEntity.Name = project.Name;
            projectEntity.Type = (Entity.ProjectType)project.Type;
            unitOfWork.ProjectRepository.Add(projectEntity);
            unitOfWork.Commit();
            return new Project(projectEntity.Id, projectEntity.Code, projectEntity.Name, (int)projectEntity.Type);
        }

        public void DeleteProject(int id)
        {
            var project = unitOfWork.ProjectRepository.GetById(id);
            unitOfWork.ProjectRepository.Delete(project);
            unitOfWork.Commit();
        }

        public List<Project> FindProjects(string query)
        {
            return unitOfWork.ProjectRepository.Find(x => x.Name.Contains(query) || x.Code.Contains(query)).Select(t => t.ToDto()).ToList();
        }

        public Project GetProject(int id)
        {
            var projectEntity = unitOfWork.ProjectRepository.GetById(id);
            return projectEntity.ToDto();
        }

        public Employee GetProjectManager(int id)
        {
            var project = unitOfWork.ProjectRepository.GetById(id);
            return project.ProjectManager.ToDto();
        }

        public List<Project> GetProjects()
        {
            return unitOfWork.ProjectRepository.GetAll().Select(t => t.ToDto()).ToList();
        }

        public void SetProjectManager(int iprojectId, int employeeId)
        {
            var manager = unitOfWork.EmployeeRepository.GetById(employeeId);
            var project = unitOfWork.ProjectRepository.GetById(iprojectId);
            project.ProjectManager = manager;
            unitOfWork.Commit();
        }

        public Project UpdateProject(int id, Project project)
        {
            var entity = unitOfWork.ProjectRepository.GetById(id);
            entity.Code = project.Code;
            entity.Name = project.Name;
            entity.Type = (Entity.ProjectType)project.Type;
            unitOfWork.ProjectRepository.Attach(entity);
            unitOfWork.Commit();
            return unitOfWork.ProjectRepository.GetById(id).ToDto();
        }

        List<Project> ITimeManagementService.ProjectsManagedBy(int id)
        {
            var manager = unitOfWork.EmployeeRepository.GetById(id);
            return manager.ManagingProjects.Select(t => t.ToDto()).ToList();
        }
    }
}