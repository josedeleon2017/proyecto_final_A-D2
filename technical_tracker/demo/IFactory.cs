using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace technical_tracker.demo
{
    public interface IFactory
    {
        void getProfile(string key);
        void saveProfile(string nombre, string apellido, string correo, string telefono, string puesto, string departamento);
        string getName();
    }
}
