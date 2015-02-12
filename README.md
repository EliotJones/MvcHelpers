# MVC Radio Buttons

## Introduction ##

This project provides classes and Editor templates for Mutually Exclusive Radio Buttons in MVC5. It adds a class which can be used with:

```@Html.EditorFor()```

![example of radio buttons](https://github.com/EliotJones/MvcHelpers/blob/master/example.png)

## Installation ##

The NuGet package can be installed using the NuGet GUI or Package Manager Console:

```Install-Package EliotJones.RadioButtons```

To uninstall simply remove the NuGet or:

```Uninstall-Package EliotJones.RadioButtons```

## Usage ##

You need a ViewModel/Model that implements one of the two non-abstract classes:

+ ```StringGuidRadioButtons```
+ ```StringIntRadioButtons```

Such as the ViewModel below:

    public class PepperStuff
    {
        public StringIntRadioButtons Peppers { get; set; }
    
        public int Quantity { get; set; }
    }

You can then map your collection to the class, you only need to provide the possible values as shown below:

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

You can also provide the SelectedValue if the radio buttons are on an edit view.

Once you have your ViewModel you can get the radio button view by simply calling:

    @Html.EditorFor(m => m.Peppers)

## Roll your Own ##

Classes should inherit from ```RadioButtonCollection<TKey, TValue>```. Once you have a named class, **create an EditorTemplate with a
corresponding name**. You should be able to copy the existing EditorTemplates and rename the view and change the model to the correct type.
