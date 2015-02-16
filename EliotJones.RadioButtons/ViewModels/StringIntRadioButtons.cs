namespace EliotJones.RadioButtons.ViewModels
{
    using System.Collections.Generic;

    /// <summary>
    /// An implementation of the KeyValueRadioButtons where the key is a string and the value is an int.
    /// </summary>
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