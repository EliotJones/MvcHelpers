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
            PepperStuff capsicums = new PepperStuff
            {
                Peppers = new StringGuidRadioButtons(
                    new Dictionary<string, Guid>
                    {
                        {"Red", Guid.NewGuid()},
                        {"Yellow", Guid.NewGuid()},
                        {"Green", Guid.NewGuid()}
                    }
                    )
            };

            List<string> a = new List<string>
            {
                "Billy",
                "Jean",
                "Soup"
            };

            capsicums.Chefs = new StringRadioButtons(a);

            capsicums.NationalBodies = StringIntRadioButtons.FromEnum(Abbreviations.UNHCR);
            capsicums.Bees = StringRadioButtons.FromEnum<Bees>();

            return View(capsicums);
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