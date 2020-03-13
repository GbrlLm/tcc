using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Models;

namespace TCC.Repositories.Auth
{
    public interface IAuthRepository
    {
        void generateSessionId(string token);
    }
}
