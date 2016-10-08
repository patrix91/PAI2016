using Ftims.Pai.Service.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ftims.Pai.Service.DAL
{
    public class EfUnitOfWork : DbContext, IUnitOfWork
    {
        private readonly EfGenericRepository<Timesheet> _TimesheetRepo;
        private readonly EfGenericRepository<Day> _DayRepo;
        private readonly EfGenericRepository<TimeEntry> _TimeEntryRepo;
        private readonly EfGenericRepository<Entity.Project> _ProjectRepo;
        private readonly EfGenericRepository<ProjectTask> _TaskRepo;
        private readonly EfGenericRepository<Audit> _AuditRepo;
        private readonly EfGenericRepository<Employee> _EmployeeRepo;

        public DbSet<Timesheet> Timesheets { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<TimeEntry> TimeEntries { get; set; }
        public DbSet<Entity.Project> Projects { get; set; }
        public DbSet<ProjectTask> Tasks { get; set; }
        public DbSet<Audit> Audits { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public IGenericRepository<Timesheet> TimesheetRepository
        {
            get
            {
                return _TimesheetRepo;
            }
        }

        public IGenericRepository<Day> DayRepository
        {
            get
            {
                return _DayRepo;
            }
        }

        public IGenericRepository<TimeEntry> TimeEntryRepository
        {
            get
            {
                return _TimeEntryRepo;
            }
        }

        public IGenericRepository<Entity.Project> ProjectRepository
        {
            get
            {
                return _ProjectRepo;
            }
        }

        public IGenericRepository<ProjectTask> TaskRepository
        {
            get
            {
                return _TaskRepo;
            }
        }

        public IGenericRepository<Employee> EmployeeRepository
        {
            get
            {
                return _EmployeeRepo;
            }
        }

        public IGenericRepository<Audit> AuditRepository
        {
            get
            {
                return _AuditRepo;
            }
        }

        public EfUnitOfWork()
        {
            _TimesheetRepo = new EfGenericRepository<Timesheet>(Timesheets);
            _DayRepo = new EfGenericRepository<Day>(Days);
            _TimeEntryRepo = new EfGenericRepository<TimeEntry>(TimeEntries);
            _ProjectRepo = new EfGenericRepository<Entity.Project>(Projects);
            _TaskRepo = new EfGenericRepository<ProjectTask>(Tasks);
            _AuditRepo = new EfGenericRepository<Audit>(Audits);
            _EmployeeRepo = new EfGenericRepository<Employee>(Employees);
        }

        public void Commit()
        {
            this.SaveChanges();
        }
    }
}