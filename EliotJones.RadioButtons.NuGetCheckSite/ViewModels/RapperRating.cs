namespace EliotJones.RadioButtons.NuGetCheckSite.ViewModels
{
    using EliotJones.RadioButtons.ViewModels;
    using System.ComponentModel.DataAnnotations;

    public class RapperRating
    {
        [Required]
        public int Rating { get; set; }

        public StringGuidRadioButtons Rappers { get; set; }
    }
}