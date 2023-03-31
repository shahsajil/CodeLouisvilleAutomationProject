using AutomationProject.PageObjectModel;
using FluentAssertions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace AutomationProject.TestClasses
{
    public sealed class ProductsTest : BaseTest
    {
        ProductsPage _ProductsPage;

        public ProductsTest()
        {
            _ProductsPage = new ProductsPage();
            Driver.Navigate().GoToUrl(_ProductsPage.Url);
        }

        [Fact]
        public void ResetTabPresentTest()
        {
            //Arrange 

            //Act 
            bool resetDisplayed = Driver.FindElement(_ProductsPage.ResetTabXpath).Displayed;

            //Assert
            resetDisplayed.Should().BeTrue();
        }

        [Fact]
        public void AddAProductTabPresetTest()
        {
            //Arrange
     
            //Act
            bool addAProductDisplayed = Driver.FindElement(_ProductsPage.AddAProductXpath).Displayed;

            //Assert
            addAProductDisplayed.Should().BeTrue();

        }

        [Fact]
        public void FilteringInvalidProduct()
        {
            //Arrange 
            String expectedText = "No products found";

            //Act
            Driver.FindElement(_ProductsPage.InvalidProductName).SendKeys("pants");
            Driver.FindElement(_ProductsPage.FilterTab).Click();
            string actualText = Driver.FindElement(_ProductsPage.InvalidProductMessage).Text;

            //Assert
            actualText.Should().Be(expectedText);

        }

        [Fact]
        public void AddingAProductPantsTestWithTodayDate()
        {
            //Arrange
            

            //Act
            Driver.FindElement(_ProductsPage.AddProduct).Click();
            Driver.FindElement( _ProductsPage.ProductName).SendKeys("Pants");
            Driver.FindElement(_ProductsPage.ProductPrice).SendKeys("49");
           
            string todaysDate = DateTime.Now.ToString("MM/dd/yyyy"); 
            IWebElement datePickerElement = Driver.FindElement(_ProductsPage.productDateStocked);
            datePickerElement.SendKeys(todaysDate);
          
            Driver.FindElement(_ProductsPage.SubmitButton).Click();
           
            //Assert
            Driver.FindElement(_ProductsPage.ProductAdded).Displayed.Should().BeTrue();

        }

        [Fact]
        public void EnteringMoreThen10NumberInPriceForNegativeTest()
        {

            //Arrange
            
            string expectedPriceWarningMessage = "Price must not be empty and within 10 digits";

            //Act
            Driver.FindElement(_ProductsPage.AddProduct).Click();
            Driver.FindElement(_ProductsPage.ProductName).SendKeys("Shirt");
            Driver.FindElement(_ProductsPage.ProductPrice).SendKeys("984176105155");
            string todaysDate = DateTime.Now.ToString("MM/dd/yyyy");
            IWebElement datePickerElement = Driver.FindElement(_ProductsPage.productDateStocked);
            datePickerElement.SendKeys(todaysDate);

            string actualPriceWarningMessage = Driver.FindElement(_ProductsPage.PriceWarningMessage).Text;

            //Assert
            actualPriceWarningMessage.Should().Be(expectedPriceWarningMessage);
           
        }
    }
}
