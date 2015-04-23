namespace EliotJones.RadioButtons.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Reflection;

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

        public static StringRadioButtons FromEnum<T>(string selectedValue = null)
        {
            if (!IsSubclassOfEnum<T>())
            {
                throw new InvalidOperationException("The type " + typeof(T).Name + " is not an enum");
            }

            var selectedValueHasBeenFound = false;

            var fieldInfos = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static);
            var values = new string[fieldInfos.Length];

            for (var i = 0; i < fieldInfos.Length; i++)
            {
                var isSelected = selectedValue != null &&
                                 selectedValue.Equals(fieldInfos[i].Name, StringComparison.InvariantCultureIgnoreCase);

                var displayAttribute = (DisplayAttribute)fieldInfos[i]
                    .GetCustomAttributes(typeof(DisplayAttribute)).SingleOrDefault();

                var name = (displayAttribute == null) ? fieldInfos[i].Name : displayAttribute.Name;

                if (isSelected || (selectedValue != null && name.Equals(selectedValue, StringComparison.InvariantCultureIgnoreCase)))
                {
                    selectedValue = name;
                    selectedValueHasBeenFound = true;
                }

                values[i] = name;
            }

            if (selectedValueHasBeenFound)
            {
                return new StringRadioButtons(values)
                {
                    SelectedValue = selectedValue
                };
            }
            return new StringRadioButtons(values);
        }

        private static bool IsSubclassOfEnum<T>()
        {
            return typeof(T).IsSubclassOf(typeof(Enum));
        }

        public static StringRadioButtons FromEnum<T>(T selectedValue)
        {
            if (!IsSubclassOfEnum<T>())
            {
                throw new InvalidOperationException("The type " + typeof(T).Name + " is not an enum");
            }

            var valueAsEnum = selectedValue as Enum;

            return FromEnum<T>(Enum.GetName(typeof(T), valueAsEnum));
        }
    }
}