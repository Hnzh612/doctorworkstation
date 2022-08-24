using highblood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.IServices
{
    public interface IFormulationServices
    {
        public List<Formulation> GetFormulation();
        public List<Formulation> GetIdFormulation(int id);
    }
}
