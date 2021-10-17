using LABII.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LABII.Servicio
{
    public interface IPersona
    {
        void Save(persona p);
        List<persona> Listar();
    }
}
