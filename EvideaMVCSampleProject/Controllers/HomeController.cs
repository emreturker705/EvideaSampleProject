using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlugInContract;

namespace EvideaMVCSampleProject.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            List<IMenuCreator> cmdList = PlugInStarter.PlugInStarter.Start();
            return View(cmdList);
        }

    }
}
