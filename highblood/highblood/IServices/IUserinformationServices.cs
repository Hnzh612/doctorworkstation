using highblood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.IServices
{
    public interface IUserinformationServices
    {
        public CallBack GetAllUserinforamtion(int page, string name, int age, string sex);
        public userinformation GetIdUserinforamtion(string id);
        public int AddUserinforamtion(userinformation u1);
        public int DelUserinforamtion(string id);
        public int UpdateUserinforamtion(userinformation u1);

    }
}
