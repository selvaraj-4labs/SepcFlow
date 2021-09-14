using OpenQA.Selenium;
using System.Collections.Generic;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions
{
    public class RadioButton
    {
        public List<RadioButtonElement> radioButtonOptions { get; set; } = new List<RadioButtonElement>();
        public RadioButton AddRadioButtonElement(string value, By locator)
        {
            radioButtonOptions.Add(new RadioButtonElement(value, locator));

            return this;
        }
    }


    public class RadioButtonElement
    {
        public RadioButtonElement(string value, By locator)
        {
            this.value = value;
            this.locator = locator;
        }

        public string value { set;get; }
        public By locator { set; get; }
    }

}
