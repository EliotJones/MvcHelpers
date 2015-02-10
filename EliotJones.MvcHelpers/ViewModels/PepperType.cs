namespace EliotJones.MvcHelpers.ViewModels
{
    public class PepperStuff
    {
        public RadioButtonCollection<string, int, int?> Peppers { get; set; }

        public int Quantity { get; set; }
    }
}