namespace EliotJones.MvcHelpers.Controllers
{
    using EliotJones.MvcHelpers.ViewModels;
    using EliotJones.RadioButtons.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            //PepperStuff capsicums = new PepperStuff
            //{
            //    Quantity = 0,
            //    Peppers = new StringIntRadioButtons
            //    {
            //        PossibleValues = new List<RadioButtonPair<string, int>>
            //        {
            //            new RadioButtonPair<string, int>
            //            {
            //                Key = "red", 
            //                Value = 0
            //            },
            //            new RadioButtonPair<string, int>
            //            {
            //                Key = "yellow",
            //                Value = 1
            //            },
            //            new RadioButtonPair<string, int>
            //            {
            //                Key = "green", 
            //                Value = 2
            //            }
            //        }
            //    }
            //};

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

            return RedirectToAction("Index");
        }
    }
}