using highblood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Services
{
    public interface IUserServices
    {
        public List<user> GetAllUser();
        public user GetIdUser(string id);
        public int AddUser(user u1);
        public int DelUser(string id);
        public int UpdateUser(user u1);

    }
}
