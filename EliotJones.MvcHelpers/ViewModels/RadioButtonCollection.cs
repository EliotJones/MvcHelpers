namespace EliotJones.MvcHelpers.ViewModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class RadioButtonCollection<TKey, TValue, TKeyNullable, TValueNullable>
    {
        public virtual IList<RadioButtonPair<TKey, TValue>> PossibleValues { get; set; }

        public virtual RadioButtonPair<TKey, TValue> SelectedValue { get; set; }
    }

    public struct RadioButtonPair<TKey, TValue>
    {
        public RadioButtonPair(TKey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }

        private TKey key;
        public TKey Key { get { return key; } set { key = value;} }

        private TValue value;
        public TValue Value { get { return value; } set { this.value = value;} }
    }

    public class StringIntCollection : RadioButtonCollection<string, int, string, int?>
    {
    }

    public class StringIntCollectionRequired : StringIntCollection
    {
        [Required]
        public override RadioButtonPair<string, int> SelectedValue { get; set; }
    }
}