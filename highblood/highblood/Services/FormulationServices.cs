using highblood.IServices;
using highblood.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Services
{
    public class FormulationServices : Dbservice, IFormulationServices
    {
        public FormulationServices() : base()
        {

        }
        public List<Formulation> GetFormulation()
        {
            return db.Queryable<Formulation>().ToList();
        }
        public List<Formulation> GetIdFormulation(int id)
        {
            return db.Queryable<Formulation>().Where(u => u.UId == id).ToList();
        }
    }
}
