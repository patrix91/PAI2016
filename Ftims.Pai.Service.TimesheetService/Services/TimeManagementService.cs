using Ftims.Pai.Service.DAL;

namespace Ftims.Pai.Service.Services
{
    public class TimeManagementService : ITimeManagementService
    {
        private IUnitOfWork unitOfWork;

        public TimeManagementService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}