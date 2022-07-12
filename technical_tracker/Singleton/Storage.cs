using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using technical_tracker.demo;

namespace technical_tracker.Singleton
{
    public class Storage
    {
        private static Storage _instance = null;

        public static Storage Instance
        {
            get
            {
                if (_instance == null) _instance = new Storage();
                return _instance;
            }
        }

        public List<Tecnico> tecnicos = new List<Tecnico>() { new Tecnico() { Nombre = "José", Apellido = "De León", Correo = "jdeleon@redDragon.com", Telefono = "12345678", Puesto = "Técnico I", Departamento = "Internet", Especialidad = "Cableado" },
                                                        new Tecnico() { Nombre = "Kevin", Apellido = "Romero", Correo = "kromero@redDragon.com", Telefono= "87654321", Puesto = "Técnico I", Departamento = "Telefonía", Especialidad = "Cableado" }};
        public List<Supervisor> supervisores = new List<Supervisor>() { new Supervisor() { Nombre = "Javier", Apellido = "Morales", Correo = "jmorales@redDragon.com", Telefono = "12345678", Puesto = "Supervisor I", Departamento = "Internet" , AreaTecnica = "Internet Residencial"},
                                                        new Supervisor() { Nombre = "Joshua", Apellido = "Valey", Correo = "jvaley@redDragon.com", Telefono= "87654321", Puesto = "Supervisor I", Departamento = "Telefonía", AreaTecnica = "Redes móviles" }};

    }
}
