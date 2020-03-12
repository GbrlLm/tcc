using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Models;

namespace TCC.Services.Status
{
    public interface IStatusServices
    {
        List<StatusModel> getTodosStatus();
        List<StatusModel> getStatusEntity();
    }
}
