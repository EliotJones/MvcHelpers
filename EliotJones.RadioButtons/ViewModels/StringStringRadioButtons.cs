namespace EliotJones.RadioButtons.ViewModels
{
    using System.Collections.Generic;

    public class StringStringRadioButtons : KeyValueRadioButtons<string, string>
    {
        public StringStringRadioButtons()
        {
            this.SelectedValue = null;
        }

        public StringStringRadioButtons(IEnumerable<KeyValuePair<string, string>> keysAndValues) : base(keysAndValues) { }
    }
}