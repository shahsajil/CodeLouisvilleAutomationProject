using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject.PageObjectModel
{
    internal class LoginPage
    {
        public string Url = "https://commitquality.com/login";

        string userNameXpath = "//input[@placeholder='Enter Username']";
        public By UserNameXpath => By.XPath(userNameXpath);

        string passwordXpath = "//input[@placeholder='Enter Password']";
        public By PasswordXpath => By.XPath(passwordXpath);

        string clickLoginBtn = "//button[@type='submit']";
        public By ClickLoginBtn => By.XPath(clickLoginBtn);

        string invalidMessage = "//div[@class='error']";
        public By InvalidMessage => By.XPath(invalidMessage);
    }
}
