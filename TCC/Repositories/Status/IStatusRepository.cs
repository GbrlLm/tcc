using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Models;

namespace TCC.Repositories.Status
{
    public interface IStatusRepository
    {
        List<StatusModel> getAll();
        List<StatusModel> getAllEntity();
    }
}
