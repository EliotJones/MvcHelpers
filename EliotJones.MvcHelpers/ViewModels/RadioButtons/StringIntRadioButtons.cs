namespace EliotJones.MvcHelpers.ViewModels.RadioButtons
{
    public class StringIntRadioButtons : RadioButtonCollection<string, int>
    {
        public StringIntRadioButtons()
        {
            this.SelectedValue = int.MaxValue;
        }
    }
}