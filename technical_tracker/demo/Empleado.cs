using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace technical_tracker.demo
{
    public class Empleado : Persona
    {
        public string Departamento { get; set; }
        public string Puesto { get; set; }
        public double Salario { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set; }

    }
}
