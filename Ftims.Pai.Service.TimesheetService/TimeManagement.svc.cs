using System;
using System.Collections.Generic;
using Ftims.Pai.Service.DTO;
using Ftims.Pai.Service.Services;

namespace Ftims.Pai.Service
{
    public class TimeManagement : ITimeManagement
    {
        private ITimeManagementService businessService;

        public TimeManagement(ITimeManagementService businessService)
        {
            this.businessService = businessService;
        }

        public Timesheet AcceptTimesheet(string id, CreateAudit createAudit)
        {
            throw new NotImplementedException();
        }

        public List<Employee> AddSubordinate(string employeeId, string subordinateId)
        {
            throw new NotImplementedException();
        }

        public Employee CreateEmployee(CreateEmployee createEmployee)
        {
            throw new NotImplementedException();
        }

        public Project CreateProject(CreateProject createProject)
        {
            throw new NotImplementedException();
        }

        public Task CreateTask(CreateTask createTask)
        {
            throw new NotImplementedException();
        }

        public Timesheet CreateTimesheet(CreateTimesheet createTimesheet)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(string id)
        {
            throw new NotImplementedException();
        }

        public void DeleteProject(string id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> DeleteSubordinate(string employeeId, string subordinateId)
        {
            throw new NotImplementedException();
        }

        public void DeleteTask(string id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(string id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployeeSubordinates(string id)
        {
            throw new NotImplementedException();
        }

        public List<Timesheet> GetEmployeeTimesheetsForPeriod(string id, string start, string end)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetManagedProjects(string id)
        {
            throw new NotImplementedException();
        }

        public Project GetProject(string id)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetProjects()
        {
            throw new NotImplementedException();
        }

        public List<Timesheet> GetProjectTimesheetsForPeriod(string id, string start, string end)
        {
            throw new NotImplementedException();
        }

        public Task GetTask(string id)
        {
            throw new NotImplementedException();
        }

        public List<Task> GetTasks()
        {
            throw new NotImplementedException();
        }

        public Timesheet GetTimesheet(string id)
        {
            throw new NotImplementedException();
        }

        public List<Audit> GetTimesheetHistory(string id)
        {
            throw new NotImplementedException();
        }

        public List<Timesheet> GetTimesheets()
        {
            throw new NotImplementedException();
        }

        public List<Timesheet> GetTimesheetsNeedAction(string id)
        {
            throw new NotImplementedException();
        }

        public List<Project> QueryForProjects(string query)
        {
            throw new NotImplementedException();
        }

        public List<Task> QueryForTaks(string query)
        {
            throw new NotImplementedException();
        }

        public Timesheet RejectTimesheet(string id, CreateAudit createAudit)
        {
            throw new NotImplementedException();
        }

        public Project SetProjectManager(string projectId, string employeeId)
        {
            throw new NotImplementedException();
        }

        public Employee UpdateEmployee(string id, Employee project)
        {
            throw new NotImplementedException();
        }

        public Project UpdateProject(string id, Project project)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTask(string id, Task project)
        {
            throw new NotImplementedException();
        }
    }
}
