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
        public user GetIdUser(int id);
        public int AddUser(user u1);
        public int DelUser(int id);
        public int UpdateUser(user u1);

    }
}
