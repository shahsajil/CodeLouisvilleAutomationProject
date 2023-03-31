using AutomationProject.PageObjectModel;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace AutomationProject.TestClasses
{
    public sealed class PracticeComponentsTest : BaseTest
    {
        PracticeComponentsPage _practiceComponentsPage;

        public PracticeComponentsTest()
        {
            _practiceComponentsPage = new PracticeComponentsPage();
            Driver.Navigate().GoToUrl(_practiceComponentsPage.Url);
           
        }

        [Fact]
        public void DoubleClickMETest()
        {
            //Arrange
            string expectedDoubleClickMessage = "Button double clicked";
          

            //Act 
            Actions actions = new Actions(Driver);
            actions.DoubleClick(Driver.FindElement(_practiceComponentsPage.DoubleClickMe)).Build().Perform();
            string actualDoubleCLickMessage = Driver.FindElement(_practiceComponentsPage.ButtonDoubleClicked).Text;

            //Assert
            actualDoubleCLickMessage.Should().Be(expectedDoubleClickMessage);
        }

        [Fact]
        public void RadioButtonClickTest()
        {
            //Arrange
            string expectedRadioBtnMessage = "option1 clicked";


            //Act
           
            Driver.FindElement(_practiceComponentsPage.RadioButton).Click();
            string actualRadioBtnMessage = Driver.FindElement(_practiceComponentsPage.Option1Click).Text;

            //Assert
            actualRadioBtnMessage.Should().Be(expectedRadioBtnMessage);
        }

        [Fact]
        public void DropDownOption3SelectTest()
        {
            //Arrange
            string expectedOption = "option3";
            //Act
            Actions actions = new Actions(Driver);
            actions.MoveToElement(Driver.FindElement(By.TagName("body"))).SendKeys(Keys.PageDown).Build().Perform();
            IWebElement dropDrown = Driver.FindElement(_practiceComponentsPage.SelectAnOption);
            Thread.Sleep(2000);
            IList<IWebElement> options = dropDrown.FindElements(_practiceComponentsPage.SelectOption);
            foreach(IWebElement option in options)
            {
                if(option.Text == "Option 3")
                {
                    option.Click();
                    break;
                }
            }

            //Assert
            string selectedOption = dropDrown.GetAttribute("value");
            selectedOption.Should().Be(expectedOption);
        }
    }
}
