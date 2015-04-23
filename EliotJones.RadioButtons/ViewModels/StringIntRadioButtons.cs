namespace EliotJones.RadioButtons.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    ///     An implementation of the KeyValueRadioButtons where the key is a string and the value is an int.
    /// </summary>
    public class StringIntRadioButtons : KeyValueRadioButtons<string, int>
    {
        /// <summary>
        ///     Default constructor sets the selected value to int.MaxValue.
        /// </summary>
        public StringIntRadioButtons()
        {
            this.SelectedValue = int.MaxValue;
        }

        /// <summary>
        ///     Construct radio buttons from an IEnumerable of KeyValue pairs.
        /// </summary>
        /// <param name="keysAndValues"></param>
        public StringIntRadioButtons(IEnumerable<KeyValuePair<string, int>> keysAndValues)
            : base(keysAndValues)
        {
            this.SelectedValue = int.MaxValue;
        }

        public static StringIntRadioButtons FromEnum<T>(string selectedValue = null)
        {
            if (!IsSubclassOfEnum<T>())
            {
                throw new InvalidOperationException("The type " + typeof (T).Name + " is not an enum");
            }

            var selectedEnum = int.MinValue;
            var selectedValueHasBeenFound = false;

            var fieldInfos = typeof (T).GetFields(BindingFlags.Public | BindingFlags.Static);
            var values = new KeyValuePair<string, int>[fieldInfos.Length];

            for (var i = 0; i < fieldInfos.Length; i++)
            {
                var isSelected = selectedValue != null &&
                                 selectedValue.Equals(fieldInfos[i].Name, StringComparison.InvariantCultureIgnoreCase);

                var displayAttribute = (DisplayAttribute) fieldInfos[i]
                    .GetCustomAttributes(typeof (DisplayAttribute)).SingleOrDefault();

                var name = (displayAttribute == null) ? fieldInfos[i].Name : displayAttribute.Name;

                var value = (int) Enum.Parse(typeof (T), fieldInfos[i].Name);

                if (isSelected || (selectedValue != null && name.Equals(selectedValue, StringComparison.InvariantCultureIgnoreCase)))
                {
                    selectedEnum = value;
                    selectedValueHasBeenFound = true;
                }

                values[i] = new KeyValuePair<string, int>(name, value);
            }

            if (selectedValueHasBeenFound)
            {
                return new StringIntRadioButtons(values)
                {
                    SelectedValue = selectedEnum
                };
            }
            return new StringIntRadioButtons(values);
        }

        private static bool IsSubclassOfEnum<T>()
        {
            return typeof (T).IsSubclassOf(typeof (Enum));
        }

        public static StringIntRadioButtons FromEnum<T>(T selectedValue)
        {
            if (!IsSubclassOfEnum<T>())
            {
                throw new InvalidOperationException("The type " + typeof (T).Name + " is not an enum");
            }

            var valueAsEnum = selectedValue as Enum;

            return FromEnum<T>(Enum.GetName(typeof (T), valueAsEnum));
        }
    }
}