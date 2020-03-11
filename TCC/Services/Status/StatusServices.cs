using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Models;
using TCC.Repositories.Status;

namespace TCC.Services.Status
{
    public class StatusServices : IStatusServices
    {
        private IStatusRepository _statusRepository;

        public StatusServices(IStatusRepository statusRepository)
        {
            _statusRepository = statusRepository;
        }


        public List<StatusModel> getTodosStatus()
        {
            return _statusRepository.getAll();
        }

    }
}
