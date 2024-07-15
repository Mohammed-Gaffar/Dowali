using Core.Enums;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class StaticRepository
    {
        private readonly DowaliContext _StaticContext;

        public StaticRepository()
        {
            _StaticContext = new DowaliContext();
        }

        public string GetUserRole(string Username)
        {

            var user = _StaticContext.Users.FirstOrDefault(m => m.UserName == Username);

            Roles roleName = Roles.User;


            if (user != null)
            {
               roleName = _StaticContext.Users.FirstOrDefault(m => m.UserName == Username).Role;
            }


            if (roleName != null)
            {
                return Roles.GetName(roleName);
            }
            else
            {
                return null;
            }

        }

    }
}
