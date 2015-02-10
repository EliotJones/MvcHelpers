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
                    PossibleValues = new List<KeyValuePair<string, int>>
                    {
                        new KeyValuePair<string, int>("red", 1),
                        new KeyValuePair<string, int>("green", 2),
                        new KeyValuePair<string, int>("yellow", 3)
                    }
                }
            };

            return View(capsicums);
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