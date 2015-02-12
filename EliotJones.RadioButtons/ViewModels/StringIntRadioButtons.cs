namespace EliotJones.RadioButtons.ViewModels
{
    using System.Collections.Generic;

    public class StringIntRadioButtons : KeyValueRadioButtons<string, int>
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