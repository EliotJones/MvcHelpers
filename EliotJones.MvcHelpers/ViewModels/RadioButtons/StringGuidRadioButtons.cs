namespace EliotJones.MvcHelpers.ViewModels.RadioButtons
{
    using System;
    using System.Collections.Generic;

    public class StringGuidRadioButtons : RadioButtonCollection<string, Guid>
    {
        public StringGuidRadioButtons()
        {
            this.SelectedValue = Guid.Empty;
        }

        public StringGuidRadioButtons(IEnumerable<KeyValuePair<string, Guid>> keysAndValues) : base(keysAndValues)
        {
        }
    }
}