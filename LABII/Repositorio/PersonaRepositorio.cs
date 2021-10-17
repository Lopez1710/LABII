using LABII.Data;
using LABII.Dominio;
using LABII.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LABII.Repositorio
{
    public class PersonaRepositorio : IPersona
    {
        private ApplicationDBContext DB;
        public PersonaRepositorio(ApplicationDBContext DB)
        {
            this.DB = DB;
        }
        public List<persona> Listar()
        {
            return DB.personas.ToList();
        }

        public void Save(persona p)
        {
            DB.Add(p);
            DB.SaveChanges();
        }
    }
}
