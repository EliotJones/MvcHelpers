namespace EliotJones.RadioButtons.NuGetCheckSite.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using System;
    using EliotJones.RadioButtons.ViewModels;
    using EliotJones.RadioButtons.NuGetCheckSite.ViewModels;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult StringGuid()
        {
            var values = new KeyValuePair<string, Guid>[]
            {
                new KeyValuePair<string, Guid>("Aesop Rock", Guid.NewGuid()),
                new KeyValuePair<string, Guid>("Cubbiebear", Guid.NewGuid()),
                new KeyValuePair<string, Guid>("Eyedea & Abilities", Guid.NewGuid()),
                new KeyValuePair<string, Guid>("Evidence", Guid.NewGuid()),
                new KeyValuePair<string, Guid>("Micranots", Guid.NewGuid())
            };

            var rapperRating = new RapperRating
            {
                Rating = -1,
                Rappers = new StringGuidRadioButtons(values)
            };

            return View(rapperRating);
        }

        [HttpPost]
        public ActionResult StringGuid(RapperRating rapperRating)
        {
            if (!ModelState.IsValid)
            {
                return View(rapperRating);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult StringInt()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult StringString()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult String()
        {
            throw new NotImplementedException();
        }
    }
}