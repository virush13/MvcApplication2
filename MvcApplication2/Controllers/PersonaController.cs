using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class PersonaController : Controller
    {
        //
        // GET: /Persona/

        public ActionResult Index()
        {
            List<Persona> lista= new List<Persona>();
            Persona per1 = new Persona();
            per1.codigo = 1;
            per1.nombre = "luis";
            lista.Add(per1);
            Persona per2 = new Persona();
            per2.codigo = 2;
            per2.nombre = "luis2";
            lista.Add(per2);
            Persona per3 = new Persona();
            per3.codigo = 3;
            per3.nombre = "luis3";
            lista.Add(per3);
            return View(lista);
        }

    }
}
