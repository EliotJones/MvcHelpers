namespace EliotJones.RadioButtons.ViewModels
{
    using System;
    using System.Collections.Generic;

    public class RadioButtonPair<TKey, TValue>
    {
        public RadioButtonPair() { }

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

        public static explicit operator KeyValuePair<TKey, TValue>(RadioButtonPair<TKey, TValue> rbp)
        {
            if (rbp.Key == null || rbp.Value == null)
            {
                throw new InvalidOperationException("Attempted to cast from an empty RadioButtonPair.");   
            }
            return new KeyValuePair<TKey, TValue>(rbp.Key, rbp.Value);
        }

        public static implicit operator RadioButtonPair<TKey, TValue>(KeyValuePair<TKey, TValue> kvp)
        {
            return new RadioButtonPair<TKey, TValue>(kvp);
        }
    }
}