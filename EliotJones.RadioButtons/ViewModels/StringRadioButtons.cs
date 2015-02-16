namespace EliotJones.RadioButtons.ViewModels
{
    using System.Collections.Generic;
    using System.Linq;

    public class StringRadioButtons : KeyValueRadioButtons<string, string>
    {
        public StringRadioButtons() { }

        public StringRadioButtons(IEnumerable<string> strings)
        {
            var possibleValues = strings.Select(s => new RadioButtonPair<string, string>(s, s));

            this.PossibleValues = possibleValues.ToList();
        }

        public static implicit operator StringRadioButtons(List<string> strings)
        {
            return new StringRadioButtons(strings);
        }
    }
}