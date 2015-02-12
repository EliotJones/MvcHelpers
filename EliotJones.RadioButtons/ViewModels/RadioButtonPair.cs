namespace EliotJones.RadioButtons.ViewModels
{
    using System.Collections.Generic;

    public class RadioButtonPair<TKey, TValue>
    {
        public RadioButtonPair()
        {

        }

        public RadioButtonPair(TKey key, TValue value)
        {
            this.Key = key;
            this.Value = value;
        }

        public RadioButtonPair(KeyValuePair<TKey, TValue> keyValuePair)
        {
            this.Key = keyValuePair.Key;
            this.Value = keyValuePair.Value;
        }

        public virtual TKey Key { get; set; }

        public virtual TValue Value { get; set; }

    }
}