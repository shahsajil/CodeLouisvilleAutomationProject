using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject.TestClasses
{
    public class BaseTest : IDisposable
    {
        protected IWebDriver Driver;

        public BaseTest()
        {
            IWebDriver driver = new ChromeDriver();
            Driver = driver;
            Driver.Manage().Window.Maximize();
        }
        public void Dispose()
        {
            Driver.Quit();
        }
    }
}
