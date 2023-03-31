using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject.PageObjectModel
{
    internal class PracticeComponentsPage
    {
        public string Url = "https://commitquality.com/practice-general-components";

        string doubleClickMeXpath = "//button[normalize-space()='Double click me']";
        public By DoubleClickMe => By.XPath(doubleClickMeXpath);

        string buttonDoubleClickedXpath = "//p[normalize-space()='Button double clicked']";
        public By ButtonDoubleClicked => By.XPath(buttonDoubleClickedXpath);

        string radioButtonXpath = "//input[@value='option1']";
        public By RadioButton => By.XPath(radioButtonXpath);

        string option1ClickedXpath = "//p[normalize-space()='option1 clicked']";
        public By Option1Click => By.XPath(option1ClickedXpath);

        string selectAnOptionXpath = "//div[@class='dropdowns']//select";
        public By SelectAnOption => By.XPath(selectAnOptionXpath);

        string selectOptionTagName = "option";
        public By SelectOption => By.XPath(selectOptionTagName);

        string selectOption3Xpath = "//option[@value='option3']";
        public By SelectOption3 => By.XPath(selectOption3Xpath);


    }
}
