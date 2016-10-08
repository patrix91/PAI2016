using System;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Ftims.Pai.Service.DAL;
using Ftims.Pai.Service.BLL;

namespace Ftims.Pai.Service.Infrastructure
{
    public class WindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IProjectService,ProjectService>(),
                Component.For<ITimesheetService,TimesheetService>(),
                Component.For<IEmployeeService,EmployeeService>(),
                Component.For<ITaskService,TaskService>(),
                Component.For<IProjectBLL>(),
                Component.For<ITaskBLL>(),
                Component.For<IEmployeeBLL>(),
                Component.For<IUnitOfWork,EfUnitOfWork>()
                );
        }
    }
}