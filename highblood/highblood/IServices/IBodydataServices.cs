using highblood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.IServices
{
    public interface IBodydataServices
    {
        public List<Bodydata> GetBodydata();
        public Bodydata GetIdBodydata(int id);
    }
}
