namespace EliotJones.MvcHelpers.ViewModels.RadioButtons
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public abstract class RadioButtonCollection<TKey, TValue>
    {
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