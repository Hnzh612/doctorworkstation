using highblood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.IServices
{
    public interface IAppointmentServices
    {
        public List<Appointment> GetAppointment();
       
    }
}
