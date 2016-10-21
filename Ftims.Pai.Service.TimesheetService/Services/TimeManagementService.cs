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
            return projectEntity.ToDto();
        }

        public Employee CreateEmployee(CreateEmployee employee)
        {
            var employeeEntity = new Entity.Employee();
            employeeEntity.LastName = employee.LastName;
            employeeEntity.Name = employee.Name;
            employeeEntity.Email = employee.Email;
            unitOfWork.EmployeeRepository.Add(employeeEntity);
            unitOfWork.Commit();
            return employeeEntity.ToDto();
        }

        public Task CreateTask(CreateTask task)
        {
            var taskEntity = new Entity.ProjectTask();
            taskEntity.Code = task.Code;
            taskEntity.Name = task.Name;
            unitOfWork.TaskRepository.Add(taskEntity);
            unitOfWork.Commit();
            return taskEntity.ToDto();
        }

        public void DeleteEmployee(int id)
        {
            var employee = unitOfWork.EmployeeRepository.GetById(id);
            unitOfWork.EmployeeRepository.Delete(employee);
            unitOfWork.Commit();
        }

        public void DeleteProject(int id)
        {
            var project = unitOfWork.ProjectRepository.GetById(id);
            unitOfWork.ProjectRepository.Delete(project);
            unitOfWork.Commit();
        }

        public void DeleteTask(int id)
        {
            var task = unitOfWork.TaskRepository.GetById(id);
            unitOfWork.TaskRepository.Delete(task);
            unitOfWork.Commit();
        }

        public List<Project> FindProjects(string query)
        {
            return unitOfWork.ProjectRepository.Find(x => x.Name.Contains(query) || x.Code.Contains(query)).Select(t => t.ToDto()).ToList();
        }

        public List<Task> FindTasks(string query)
        {
            return unitOfWork.TaskRepository.Find(x => x.Name.Contains(query) || x.Code.Contains(query)).Select(t => t.ToDto()).ToList();
        }

        public Employee GetEmployee(int id)
        {
            var employee = unitOfWork.EmployeeRepository.GetById(id);
            return employee.ToDto();
        }

        public List<Employee> GetEmployees()
        {
            return unitOfWork.EmployeeRepository.GetAll().Select(t => t.ToDto()).ToList();
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

        public Task GetTask(int id)
        {
            var taskEntity = unitOfWork.TaskRepository.GetById(id);
            return taskEntity.ToDto();
        }

        public List<Task> GetTasks()
        {
            return unitOfWork.TaskRepository.GetAll().Select(t => t.ToDto()).ToList();
        }

        public void SetProjectManager(int iprojectId, int employeeId)
        {
            var manager = unitOfWork.EmployeeRepository.GetById(employeeId);
            var project = unitOfWork.ProjectRepository.GetById(iprojectId);
            project.ProjectManager = manager;
            unitOfWork.Commit();
        }

        public Employee UpdateEmployee(int id, Employee employee)
        {
            var entity = unitOfWork.EmployeeRepository.GetById(id);
            entity.Name = employee.Name;
            entity.LastName = employee.LastName;
            entity.Email = employee.Email;
            unitOfWork.EmployeeRepository.Attach(entity);
            unitOfWork.Commit();
            return unitOfWork.EmployeeRepository.GetById(id).ToDto();
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

        public Task UpdateTask(int id, Task task)
        {
            var entity = unitOfWork.ProjectRepository.GetById(id);
            entity.Code = task.Code;
            entity.Name = task.Name;
            unitOfWork.ProjectRepository.Attach(entity);
            unitOfWork.Commit();
            return unitOfWork.TaskRepository.GetById(id).ToDto();
        }

        List<Project> ITimeManagementService.ProjectsManagedBy(int id)
        {
            var manager = unitOfWork.EmployeeRepository.GetById(id);
            return manager.ManagingProjects.Select(t => t.ToDto()).ToList();
        }

        public List<Employee> GetEmployeeSubordinates(int id)
        {
            return unitOfWork.EmployeeRepository.GetById(id).Subordinates.Select(t => t.ToDto()).ToList();
        }

        public List<Employee> AddSubordinate(int employeeId, int subordinateId)
        {
            var manager = unitOfWork.EmployeeRepository.GetById(employeeId);
            var employee = unitOfWork.EmployeeRepository.GetById(subordinateId);
            employee.Manager = employee;
            unitOfWork.Commit();
            return unitOfWork.EmployeeRepository.GetById(employeeId).Subordinates.Select(t => t.ToDto()).ToList();
        }

        public List<Employee> DeleteSubordinate(int employeeId, int subordinateId)
        {
            var employee = unitOfWork.EmployeeRepository.GetById(subordinateId);
            employee.Manager = employee;
            unitOfWork.Commit();
            return unitOfWork.EmployeeRepository.GetById(employeeId).Subordinates.Select(t => t.ToDto()).ToList();
        }

        public List<Timesheet> GetProjectTimesheets(int projectId, DateTime start, DateTime end)
        {
            return unitOfWork.TimesheetRepository.Find(t => t.Entries.Any(x => x.Project.Id == projectId)).Select(s=>s.ToDto()).ToList();
        }

        public List<Timesheet> GetEmployeeTimesheets(int employeeId, DateTime start, DateTime end)
        {
            return unitOfWork.TimesheetRepository.Find(t => t.Applicant.Id == employeeId).Select(s => s.ToDto()).ToList();
        }
    }
}