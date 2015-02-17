namespace EliotJones.RadioButtons.ViewModels
{
    using System.Collections.Generic;

    /// <summary>
    /// An implementation of the KeyValueRadioButtons where the key is a string and the value is an int.
    /// </summary>
    public class StringIntRadioButtons : KeyValueRadioButtons<string, int>
    {
        /// <summary>
        /// Default constructor sets the selected value to int.MaxValue.
        /// </summary>
        public StringIntRadioButtons()
        {
            this.SelectedValue = int.MaxValue;
        }

        /// <summary>
        /// Construct radio buttons from an IEnumerable of KeyValue pairs.
        /// </summary>
        /// <param name="keysAndValues"></param>
        public StringIntRadioButtons(IEnumerable<KeyValuePair<string, int>> keysAndValues) : base(keysAndValues)
        {
        }
    }
}