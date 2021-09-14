using OpenQA.Selenium;
using System.Collections.Generic;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions
{

    /// <summary>
    /// Define a group of mutually exclusive buttons.
    /// (Only one can be selected at any one point)
    /// </summary>
    public class ButtonGroup
    {
        public List<ButtonElement> buttonOptions { get; set; } = new List<ButtonElement>();

        public ButtonGroup AddButtonElement(string value, By locator)
        {
            buttonOptions.Add(new ButtonElement(value, locator));
            return this;
        }
    }

    /// <summary>
    /// Define an abstract button element.
    /// </summary>
    public class ButtonElement
    {
        public string value { get; set; }
        public By locator { get; set; }

        public ButtonElement(string value, By locator)
        {
            this.value = value;
            this.locator = locator;
        }
    }
}
