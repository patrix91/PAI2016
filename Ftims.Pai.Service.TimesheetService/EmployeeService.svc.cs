using System;
using Ftims.Pai.Service.DTO;
using Ftims.Pai.Service.BLL;

namespace Ftims.Pai.Service{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeBLL _employeeBll;

        public EmployeeService(IEmployeeBLL employeeBll)
        {
            _employeeBll = employeeBll;
        }

        public Employee Create(CreateEmployee task)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Employee Get(string id)
        {
            throw new NotImplementedException();
        }

        public Employee[] GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetDetails(string id)
        {
            throw new NotImplementedException();
        }

        public Project[] GetProjects(string id)
        {
            throw new NotImplementedException();
        }

        public Employee[] GetSubordinates(string id)
        {
            throw new NotImplementedException();
        }

        public Timesheet[] GetTimesheets(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, Employee task)
        {
            throw new NotImplementedException();
        }
    }
}
