using System;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Ftims.Pai.Service.DAL;
using Ftims.Pai.Service.Services;

namespace Ftims.Pai.Service.Infrastructure
{
    public class WindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                           Component.For<IUnitOfWork,EfUnitOfWork>(),
                           Component.For<ITimeManagement, TimeManagement>(),
                           Component.For<ITimeManagementService, TimeManagementService>()
                );
        }
    }
}