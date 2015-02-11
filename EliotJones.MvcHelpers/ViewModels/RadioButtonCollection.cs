namespace EliotJones.MvcHelpers.ViewModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class RadioButtonCollection<TKey, TValue, TValueNullable>
    {
        public virtual IList<RadioButtonPair<TKey, TValue>> PossibleValues { get; set; }

        public virtual TValueNullable SelectedValue { get; set; }

        public TKey SelectedKey { get; set; }
    }

    public class RadioButtonPair<TKey, TValue>
    {
        public TKey Key { get; set; }

        public TValue Value { get; set; }
    }

    public class StringIntCollection : RadioButtonCollection<string, int, int?>
    {
    }

    public class StringIntCollectionRequired : StringIntCollection
    {
        [Required]
        public override int? SelectedValue { get; set; }
    }
}