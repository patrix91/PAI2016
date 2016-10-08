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
            int employeeId;
            bool correctFormat = int.TryParse(id, out employeeId);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return;
            }
          
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
            return new List<Employee>();
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
        }

        public Employee GetEmployee(string id)
        {
            int employeeId;
            bool correctFormat = int.TryParse(id,out employeeId);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }
            return new Employee(employeeId, "Name " + employeeId, "Lastname " + employeeId, "email");
        }

        public List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
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
            return new List<Employee>();
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
            return new List<Project>();
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
            return new Project(projectId, "Code" + projectId, "Nanme" + projectId);
        }

        public List<Project> GetProjects()
        {
            throw new NotImplementedException();
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
            return new Task(taskId, "Code" + taskId, "Nanme" + taskId);
        }

        public List<Task> GetTasks()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public List<Task> QueryForTaks(string query)
        {
            throw new NotImplementedException();
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
            return new Employee(employeeId, "Name " + employeeId, "Lastname " + employeeId, "email");
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
            return new Project(projectId, "Code" + projectId, "Name" + projectId);
        }

        public Task UpdateTask(string id, Task project)
        {
            int taskId;
            bool correctFormat = int.TryParse(id, out taskId);
            if (!correctFormat)
            {
                this.BadRequest("Incorrect format of id");
                return null;
            }
            return new Task(taskId, "Code" + taskId, "Name" + taskId);
        }
    }
}
