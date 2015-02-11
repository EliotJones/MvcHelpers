# EliotJones.MvcHelpers

## Introduction ##

This sample MVC project provides classes and Editor templates for Mutually Exclusive Radio Buttons in MVC5.

![example of radio buttons](https://github.com/EliotJones/MvcHelpers/blob/master/example.png)

## Installation ##

The aim is to provide a NuGet package to add the required files to an MVC project. In the meantime please follow the steps to install:

1. Get the ```EliotJones.MvcHelpers\ViewModels\RadioButtons\``` view model classes and put them in your own project.
2. Get the ```EliotJones.MvcHelpers\Views\Shared\EditorTemplates\``` views and put them in the corresponding folder in your project. **It is important the views are in** ```\Views\Shared\EditorTemplates```!
3. Resolve namespace issues in both the ViewModels and the Views.

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

You can also provide the SelectedValue if the radio buttons are on a edit view.

Once you have your ViewModel you can get the radio button view by simply calling:

    @Html.EditorFor(m => m.Peppers)

## Roll your Own ##

Classes should inherit from ```RadioButtonCollection<TKey, TValue>```. Once you have a named class, **create an EditorTemplate with a
corresponding name**. You should be able to copy the existing EditorTemplates and rename the view and change the model to the correct type.
