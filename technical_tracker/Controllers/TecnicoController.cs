using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using technical_tracker.demo;

namespace technical_tracker.Controllers
{
    public class TecnicoController : Controller
    {
        // GET: TecnicoController
        public ActionResult Index()
        {
            return View(Singleton.Storage.Instance.tecnicos);
        }

        // GET: TecnicoController/Create
        public ActionResult Create()
        {         
            return View();
        }

        // POST: TecnicoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                EmpleadoFactory factory = new ConcreteEmpleadoFactory();

                IFactory t = factory.GetEmpleado("Tecnico");
                t.saveProfile(collection["Nombre"], collection["Apellido"], collection["Correo"], collection["Telefono"], collection["Puesto"], collection["Departamento"], "", collection["Especialidad"]);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
       
    }
}
