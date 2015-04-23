namespace EliotJones.RadioButtons.Web.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public enum Abbreviations : int
    {
        GB,
        [Display(Name = "World Bank")]
        WB,
        [Display(Name = "United Kingdom")]
        UK,
        [Display(Name = "United Nations")]
        UN = 7,
        UNHCR
    }

    public enum Bees
    {
        [Display(Name = "The Bee Called Buzz")]
        Buzz = 1,
        [Display(Name = "Sting, not to be confused with The Police")]
        Sting = 2,
        Honey = 3
    }
}