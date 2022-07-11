using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace technical_tracker.demo
{
    public class Tecnico : Empleado, IFactory
    {
        public string Especialidad { get; set; }

        public string getName()
        {
            return this.Nombre;
        }

        public void getProfile(string key)
        {
            this.Nombre = "Joshua";
            this.Apellido = "Valey";
            this.Especialidad = "Swtiching and routing";
        }

        public void saveProfile(string nombre, string apellido, string correo, string telefono, string puesto, string departamento)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Correo = correo;
            this.Telefono = telefono;
            this.Puesto = puesto;
            this.Departamento = departamento;

            Singleton.Storage.Instance.tecnicos.Add(this);
        }
    }
}
