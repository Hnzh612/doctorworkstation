using highblood.IServices;
using highblood.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace highblood.Services
{
    public class AppointmentServices :Dbservice, IAppointmentServices
    {
        public AppointmentServices() : base()
        {

        }
        public List<Appointment> GetAppointment()
        {
            return db.Queryable<Appointment>().ToList();
        }
    }
}
