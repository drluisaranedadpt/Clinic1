using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Clinic.Controllers
{
    public class UserService
    {
        internal bool TryValidateUser(string username, string password, out List<Claim> claims)
        {
            throw new NotImplementedException();
        }
    }
}