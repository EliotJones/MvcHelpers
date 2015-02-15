namespace EliotJones.RadioButtons.Web.Controllers
{
    using EliotJones.RadioButtons.Web.ViewModels;
    using EliotJones.RadioButtons.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using System.Diagnostics;

    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            PepperStuff capsicumes = new PepperStuff
            {
                Peppers = new StringGuidRadioButtons(
                    new Dictionary<string, Guid>
                    {
                        {"gromlp", Guid.NewGuid()},
                        {"thhhtr", Guid.NewGuid()},
                        {"htrh", Guid.NewGuid()}
                    }
                    )
            };

            List<string> a = new List<string>
            {
                "Billy",
                "Snoppin",
                "Rapper"
            };

            capsicumes.Chefs = new StringRadioButtons(a);

            return View(capsicumes);
        }

        [HttpPost]
        public ActionResult Index(PepperStuff capsicums)
        {
            if (!ModelState.IsValid)
            {
                return View(capsicums);
            }

            if (Debugger.IsAttached)
            {
                KeyValuePair<string, Guid> kvp = (KeyValuePair<string, Guid>)capsicums.Peppers.PossibleValues.First();
                RadioButtonPair<string, Guid> rbp = kvp;
                Debugger.Break();
            }

            return RedirectToAction("Index");
        }
    }
}