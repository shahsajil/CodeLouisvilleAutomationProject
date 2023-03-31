using AutomationProject.PageObjectModel;
using FluentAssertions;
using OpenQA.Selenium;
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
    public sealed class LoginTest : BaseTest
    {
        LoginPage _loginPage;

        public LoginTest()
        {
            _loginPage = new LoginPage();
        }

        [Fact]
        public void InvalidLoginTest()
        {
            //Arrange
            String expectedinvalidMessage = "Invalid username or password";
            Driver.Navigate().GoToUrl(_loginPage.Url);

            //act
            Driver.FindElement(_loginPage.UserNameXpath).SendKeys("abcde");
            //Thread.Sleep(1000);
            Driver.FindElement(_loginPage.PasswordXpath).SendKeys("xyz123");
            //Thread.Sleep(1000);
            Driver.FindElement(_loginPage.ClickLoginBtn).Click();
            //Thread.Sleep(1000);

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(c => Driver.FindElement(_loginPage.InvalidMessage).Displayed);

            string actualMessage = Driver.FindElement(_loginPage.InvalidMessage).Text;
            //(Thread.Sleep(5000);

            //assert
            actualMessage.Should().Be(expectedinvalidMessage);

        }
    }
}
