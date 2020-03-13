using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Models;
using TCC.Repositories.Auth;
using System.Security.Cryptography;
using System.Text;

namespace TCC.Services.Auth
{
    public class AuthServices : IAuthServices
    {
        private IAuthRepository _authRepository;

        public AuthServices(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public string generateSessionId()
        {
            byte[] buffer = new byte[32];
            new RNGCryptoServiceProvider().GetBytes(buffer);

            StringBuilder token= new StringBuilder();
            foreach (byte b in buffer)
                token.AppendFormat("{0:X2}",b);

            _authRepository.generateSessionId(token.ToString());
            return token.ToString();
        }
    }
}
