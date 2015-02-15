namespace EliotJones.RadioButtons.ViewModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public abstract class KeyValueRadioButtons<TKey, TValue>
    {
        public KeyValueRadioButtons() { }

        public KeyValueRadioButtons(IEnumerable<KeyValuePair<TKey, TValue>> keysAndValues)
        {
            var possibleValues = new List<RadioButtonPair<TKey, TValue>>();

            foreach (var kvp in keysAndValues)
            {
                possibleValues.Add(new RadioButtonPair<TKey, TValue>(kvp));
            }

            PossibleValues = possibleValues;
        }

        public virtual IList<RadioButtonPair<TKey, TValue>> PossibleValues { get; set; }

        [Required(ErrorMessage = "This answer is required")]
        public virtual RadioButtonPair<TKey, TValue> Selected
        {
            get
            {
                if (SelectedValue == null)
                {
                    return null;
                }
                else
                {
                    return PossibleValues.FirstOrDefault(pv => pv.Value.Equals(SelectedValue));
                }
            }
            set { SelectedValue = value.Value; }
        }

        public virtual TValue SelectedValue { get; set; }
    }
}