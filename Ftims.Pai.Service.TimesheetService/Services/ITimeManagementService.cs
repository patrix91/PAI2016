using System;
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

        DTO.Task CreateTask(DTO.CreateTask task);
        DTO.Task GetTask(int id);
        List<DTO.Task> GetTasks();
        void DeleteTask(int id);
        DTO.Task UpdateTask(int id, DTO.Task task);
        List<DTO.Task> FindTasks(string query);
        DTO.Employee CreateEmployee(DTO.CreateEmployee employee);
        DTO.Employee GetEmployee(int id);
        List<DTO.Employee> GetEmployees();
        void DeleteEmployee(int id);
        DTO.Employee UpdateEmployee(int id, DTO.Employee task);
        List<DTO.Employee> GetEmployeeSubordinates(int id);
        List<DTO.Employee> AddSubordinate(int employeeId, int subordinateId);
        List<DTO.Employee> DeleteSubordinate(int employeeId, int subordinateId);
        List<DTO.Timesheet> GetProjectTimesheets(int projectId, DateTime start, DateTime end);
        List<DTO.Timesheet> GetEmployeeTimesheets(int employeeId, DateTime start, DateTime end);


    }
}
