namespace EliotJones.MvcHelpers.ViewModels.RadioButtons
{
    using System.Collections.Generic;

    public class StringIntRadioButtons : RadioButtonCollection<string, int>
    {
        public StringIntRadioButtons()
        {
            this.SelectedValue = int.MaxValue;
        }

        public StringIntRadioButtons(IEnumerable<KeyValuePair<string, int>> keysAndValues) : base(keysAndValues)
        {
        }
    }
}