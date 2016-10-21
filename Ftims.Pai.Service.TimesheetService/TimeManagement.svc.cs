using System;
using System.Collections.Generic;
using Ftims.Pai.Service.DTO;
using Ftims.Pai.Service.Services;
using Ftims.Pai.Service.Infrastructure;

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
            int timesheetId;
            bool correctFormat = int.TryParse(id, out timesheetId);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }
            return new Timesheet();
        }

        public List<Employee> AddSubordinate(string employeeId, string subordinateId)
        {
            int employeeID;
            bool correctFormat = int.TryParse(employeeId, out employeeID);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }
            int subordinateID;
            correctFormat = int.TryParse(subordinateId, out subordinateID);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }
            return businessService.AddSubordinate(employeeID, subordinateID);
        }

        public Employee CreateEmployee(CreateEmployee createEmployee)
        {
            throw new NotImplementedException();
        }

        public Project CreateProject(CreateProject createProject)
        {
            return businessService.CreateProject(createProject);
        }

        public Task CreateTask(CreateTask createTask)
        {
           return businessService.CreateTask(createTask);
        }

        public Timesheet CreateTimesheet(CreateTimesheet createTimesheet)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(string id)
        {
            int employeeId;
            bool correctFormat = int.TryParse(id, out employeeId);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return;
            }
            businessService.DeleteEmployee(employeeId);
        }

        public void DeleteProject(string id)
        {
            int projectId;
            bool correctFormat = int.TryParse(id, out projectId);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return;
            }
            businessService.DeleteProject(projectId);
        }

        public List<Employee> DeleteSubordinate(string employeeId, string subordinateId)
        {
            int employeeID;
            bool correctFormat = int.TryParse(employeeId, out employeeID);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }
            int subortinateID;
            correctFormat = int.TryParse(subordinateId, out subortinateID);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }
            return businessService.DeleteSubordinate(employeeID, subortinateID);
        }

        public void DeleteTask(string id)
        {
            int taskId;
            bool correctFormat = int.TryParse(id, out taskId);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return;
            }
            businessService.DeleteTask(taskId);
        }

        public Employee GetEmployee(string id)
        {
            int employeeId;
            bool correctFormat = int.TryParse(id, out employeeId);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }
            return businessService.GetEmployee(employeeId);
        }

        public List<Employee> GetEmployees()
        {
            return businessService.GetEmployees();
        }

        public List<Employee> GetEmployeeSubordinates(string id)
        {
            int employeeId;
            bool correctFormat = int.TryParse(id, out employeeId);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }
            return businessService.GetEmployeeSubordinates(employeeId);
        }

        public List<Timesheet> GetEmployeeTimesheetsForPeriod(string id, string start, string end)
        {
            int employeeId;
            bool correctFormat = int.TryParse(id, out employeeId);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }
            DateTime startDate;
            correctFormat = DateTime.TryParse(start, out startDate);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of date");
                return null;
            }
            DateTime endDate;
            correctFormat = DateTime.TryParse(start, out endDate);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of date");
                return null;
            }
            return new List<Timesheet>();
        }

        public List<Project> GetManagedProjects(string id)
        {
            int employeeId;
            bool correctFormat = int.TryParse(id, out employeeId);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }
            return businessService.ProjectsManagedBy(employeeId);
        }

        public Project GetProject(string id)
        {
            int projectId;
            bool correctFormat = int.TryParse(id, out projectId);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }
            return businessService.GetProject(projectId);
        }

        public Employee GetProjectManager(string projectId)
        {
            int id;
            bool correctFormat = int.TryParse(projectId, out id);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }
            return businessService.GetProjectManager(id);
        }

        public List<Project> GetProjects()
        {
            return businessService.GetProjects();
        }

        public List<Timesheet> GetProjectTimesheetsForPeriod(string id, string start, string end)
        {
            int projectId;
            bool correctFormat = int.TryParse(id, out projectId);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }
            DateTime startDate;
            correctFormat = DateTime.TryParse(start, out startDate);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of date");
                return null;
            }
            DateTime endDate;
            correctFormat = DateTime.TryParse(start, out endDate);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of date");
                return null;
            }
            return new List<Timesheet>();
        }

        public Task GetTask(string id)
        {
            int taskId;
            bool correctFormat = int.TryParse(id, out taskId);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }
            return businessService.GetTask(taskId);
        }

        public List<Task> GetTasks()
        {
            return businessService.GetTasks();
        }

        public Timesheet GetTimesheet(string id)
        {
            int timesheetId;
            bool correctFormat = int.TryParse(id, out timesheetId);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }
            return new Timesheet();
        }

        public List<Audit> GetTimesheetHistory(string id)
        {
            int timesheetId;
            bool correctFormat = int.TryParse(id, out timesheetId);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }
            return new List<Audit>();
        }

        public List<Timesheet> GetTimesheets()
        {
            throw new NotImplementedException();
        }

        public List<Timesheet> GetTimesheetsNeedAction(string id)
        {
            int employeeId;
            bool correctFormat = int.TryParse(id, out employeeId);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }
            return new List<Timesheet>();
        }

        public List<Project> QueryForProjects(string query)
        {
            return businessService.FindProjects(query);
        }

        public List<Task> QueryForTaks(string query)
        {
            return businessService.FindTasks(query);
        }

        public Timesheet RejectTimesheet(string id, CreateAudit createAudit)
        {
            int timesheetId;
            bool correctFormat = int.TryParse(id, out timesheetId);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }

            return new Timesheet();
        }

        public void SetProjectManager(string projectId, string employeeId)
        {
            int projectID;
            bool correctFormat = int.TryParse(projectId, out projectID);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return;
            }
            int employeeID;
            correctFormat = int.TryParse(employeeId, out employeeID);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return;
            }
            businessService.SetProjectManager(projectID, employeeID);

        }

        public Employee UpdateEmployee(string id, Employee employee)
        {
            int employeeId;
            bool correctFormat = int.TryParse(id, out employeeId);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }
            return businessService.UpdateEmployee(employeeId, employee);
        }

        public Project UpdateProject(string id, Project project)
        {
            int projectId;
            bool correctFormat = int.TryParse(id, out projectId);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }
            return businessService.UpdateProject(projectId, project);
        }

        public Task UpdateTask(string id, Task task)
        {
            int taskId;
            bool correctFormat = int.TryParse(id, out taskId);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }
            return businessService.UpdateTask(taskId, task);
        }
    }
}
