namespace EliotJones.MvcHelpers.ViewModels.RadioButtons
{
    using System;

    public class StringGuidRadioButtons : RadioButtonCollection<string, Guid>
    {
        public StringGuidRadioButtons()
        {
            this.SelectedValue = Guid.Empty;
        }
    }
}