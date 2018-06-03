using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bitirme.Controllers
{
    public class MapController : Controller
    {
        // GET: Map
        public ActionResult Maps()
        {
            if (Session["login"] == "false" || Session["username"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                return View();
            }
        }
    }
}