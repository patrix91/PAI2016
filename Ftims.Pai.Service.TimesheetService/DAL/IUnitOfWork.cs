using Ftims.Pai.Service.Entity;
using System;

namespace Ftims.Pai.Service.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Timesheet> TimesheetRepository { get; }
        IGenericRepository<Day> DayRepository { get; }
        IGenericRepository<TimeEntry> TimeEntryRepository { get; }
        IGenericRepository<Entity.Project> ProjectRepository { get; }
        IGenericRepository<ProjectTask> TaskRepository { get; }
        IGenericRepository<Employee> EmployeeRepository { get; }
        IGenericRepository<Audit> AuditRepository { get; }

        void Commit();
    }
}