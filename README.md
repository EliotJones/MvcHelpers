# MVC Radio Buttons

## Installation ##

The NuGet package can be installed using the NuGet GUI or Package Manager Console:

```Install-Package EliotJones.RadioButtons```

To uninstall simply remove the NuGet or use the Package Manager Console:

```Uninstall-Package EliotJones.RadioButtons```

## Usage ##

You need a ViewModel/Model with a property with one of the following types:

+ ```StringGuidRadioButtons```
+ ```StringIntRadioButtons```
+ ```StringStringRadioButtons```
+ ```StringRadioButtons```

The naming follows the ```[Key][Value]RadioButtons``` pattern where Key is the type of the data used to label the button and value is the value of the button when selected.

For instance if you have a status table you want to bind to radio buttons with the structure:

1. New
2. Open
3. Closed

You would use a StringIntRadioButtons property.

The ViewModel below has the Peppers property which uses this type:

    public class PepperStuff
    {
        public StringIntRadioButtons Peppers { get; set; }
    
        public int Quantity { get; set; }
    }

You can then map your collection to the property, you only need to provide the possible values as shown below:

    PepperStuff capsicums = new PepperStuff
    {
        Quantity = 0,
        Peppers = new StringIntRadioButtons
        {
            PossibleValues = new List<RadioButtonPair<string, int>>
            {
                new RadioButtonPair<string, int>
                {
                    Key = "red", 
                    Value = 0
                },
                new RadioButtonPair<string, int>
                {
                    Key = "yellow",
                    Value = 1
                },
                new RadioButtonPair<string, int>
                {
                    Key = "green", 
                    Value = 2
                }
            }
        }
    };

There is an overloaded constructor allowing you to map a ```IEnumerable<KeyValuePair<TKey, TValue>>``` to the PossibleValues field.

You can also provide the SelectedValue if the radio buttons are on an edit view.

Once you have your ViewModel you can get the radio button view by simply putting this in your View:

    @Html.EditorFor(m => m.Peppers)

## Edit The View Layout ##

This NuGet package gives you complete control over the generated HTML for your radio button list. The views are stored in Views > Shared > EditorTemplates. You can edit the HTML though be careful what you change as it may break everything!

## Roll your Own ##

Classes should inherit from ```RadioButtonCollection<TKey, TValue>```. Once you have a named class, **create an EditorTemplate with a
corresponding name**. You should be able to copy the existing EditorTemplates and rename the view and change the model to the correct type.
