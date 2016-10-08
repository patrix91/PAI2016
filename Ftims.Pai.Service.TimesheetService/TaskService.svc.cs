using System;
using Ftims.Pai.Service.DTO;
using Ftims.Pai.Service.BLL;

namespace Ftims.Pai.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ITaskService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ITaskService.svc or ITaskService.svc.cs at the Solution Explorer and start debugging.
    public class TaskService : ITaskService
    {
        private ITaskBLL _taskBll;

        public TaskService(ITaskBLL taskBLL)
        {
            _taskBll = taskBLL;
        }

        public Task Create(CreateTask task)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task[] Find(string expression)
        {
            throw new NotImplementedException();
        }

        public Task Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task[] GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(string id, Task task)
        {
            throw new NotImplementedException();
        }
    }
}
