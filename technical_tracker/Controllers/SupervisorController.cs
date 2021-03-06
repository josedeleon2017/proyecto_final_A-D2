using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using technical_tracker.demo;

namespace technical_tracker.Controllers
{
    public class SupervisorController : Controller
    {
        // GET: SupervisorController
        public ActionResult Index()
        {
            return View(Singleton.Storage.Instance.supervisores);
        }
  
        // GET: SupervisorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SupervisorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                EmpleadoFactory factory = new ConcreteEmpleadoFactory();

                IFactory s = factory.GetEmpleado("Supervisor");
                s.saveProfile(collection["Nombre"], collection["Apellido"], collection["Correo"], collection["Telefono"], collection["Puesto"], collection["Departamento"], collection["AreaTecnica"], "");
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
    }
}
