using highblood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.IServices
{
    public interface IAdminServices
    {
        public List<admin> GetAllAdmin();
        public CallBack Login(string username,string password);
        public int AddAdmin(admin al);
        public int DelAdmin(int id);
        public int UpdateAdmin(admin al);

    }
}
