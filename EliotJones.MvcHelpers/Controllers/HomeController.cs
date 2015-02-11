namespace EliotJones.MvcHelpers.Controllers
{
    using EliotJones.MvcHelpers.ViewModels;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            PepperStuff capsicums = new PepperStuff
            {
                Quantity = 0,
                Peppers = new StringIntCollection
                {
                    PossibleValues = new List<RadioButtonPair<string, int>>
                    {
                        new RadioButtonPair<string, int>
                        {
                            Key = "red", 
                            Value = 1
                        },
                        new RadioButtonPair<string, int>
                        {
                            Key = "green", 
                            Value = 2
                        }
                    }
                }
            };

            return View(capsicums);
        }

        [HttpPost]
        public ActionResult Index(PepperStuff capsicums)
        {
            IList<RadioButtonPair<string, int>> longNameSoHoveringIsEasy = capsicums.Peppers.PossibleValues;

            if (!ModelState.IsValid)
            {
                return View(capsicums);
            }

            return RedirectToAction("Index");
        }
    }
}