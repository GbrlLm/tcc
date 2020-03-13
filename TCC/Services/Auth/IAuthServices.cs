using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Models;

namespace TCC.Services.Auth
{
    public interface IAuthServices
    {
        string generateSessionId();
    }
}
