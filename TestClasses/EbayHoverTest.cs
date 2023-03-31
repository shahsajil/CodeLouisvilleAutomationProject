using AutomationProject.PageObjectModel;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace AutomationProject.TestClasses
{
    public sealed class EbayHoverTest : BaseTest
    {
        EbayHoverPage _ebayhoverPage;

        public EbayHoverTest()
        {
            _ebayhoverPage = new EbayHoverPage();
        }

        [Fact]
        public void ElectronicshoverTest()
        {
            //Arrange
            Driver.Navigate().GoToUrl(_ebayhoverPage.Url);
            string expectedHoverMessage = "Computers, Tablets & Network Hardware";

            //Act
            IWebElement elementToHover = Driver.FindElement(_ebayhoverPage.StringHover);
            Actions actions = new Actions(Driver);
            actions.MoveToElement(elementToHover).Build().Perform();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(c => Driver.FindElement(_ebayhoverPage.AfterHover).Displayed);

            string actualHoverMessage = Driver.FindElement(_ebayhoverPage.AfterHover).Text;

            //Assert
            actualHoverMessage.Should().Contain(expectedHoverMessage);

        }
    }
}
