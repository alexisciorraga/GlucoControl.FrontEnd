using GlucoControl.FrontEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace GlucoControl.FrontEnd.Controllers
{
    public class RegistroController : Controller
    {
        public IActionResult Index(string usuario)
        {
            ViewBag.Usuario = usuario;
            return View();
        }

        public ActionResult AddControl(ControlModel control)
        {
            return RedirectToAction("Index");
        }
    }
}
