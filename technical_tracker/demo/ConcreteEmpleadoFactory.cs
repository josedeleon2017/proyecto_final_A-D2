using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace technical_tracker.demo
{
    public class ConcreteEmpleadoFactory : EmpleadoFactory
    {
        public override IFactory GetEmpleado(string Empleado)
        {
            switch (Empleado)
            {
                case "Tecnico":
                    return new Tecnico();
                case "Supervisor":
                    return new Supervisor();
                default:
                    throw new ApplicationException(string.Format("Empleado'{0}' cannot be created", Empleado));
            }
        }
    }
}
