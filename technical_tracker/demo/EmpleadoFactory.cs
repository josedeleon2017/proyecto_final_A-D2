using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace technical_tracker.demo
{
    public abstract class EmpleadoFactory
    {
        public abstract IFactory GetEmpleado(string Empleado);
    }
}
