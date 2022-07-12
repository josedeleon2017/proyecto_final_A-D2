using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace technical_tracker.demo
{
    public class Supervisor : Empleado, IFactory
    {
        public string AreaTecnica { get; set; }

        public string getName()
        {
            return this.Nombre;
        }

        public void getProfile(string key)
        {
            this.Nombre = "José";
            this.Apellido = "De León";
            this.AreaTecnica = "Internet";
        }

        public void saveProfile(string nombre, string apellido, string correo, string telefono, string puesto, string departamento, string area, string especialidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Correo = correo;
            this.Telefono = telefono;
            this.Puesto = puesto;
            this.Departamento = departamento;
            this.AreaTecnica = area;

            Singleton.Storage.Instance.supervisores.Add(this);
        }
    }
}
