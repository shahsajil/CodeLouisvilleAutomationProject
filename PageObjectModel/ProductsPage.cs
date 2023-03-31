using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject.PageObjectModel
{
    internal class ProductsPage
    {
        public string Url = "https://commitquality.com/";

        string resetTabXpath = "//button[normalize-space()='Reset']";
        public By ResetTabXpath => By.XPath(resetTabXpath);

        string addAProductXpath = "//a[@class='add-product-button']";
        public By AddAProductXpath => By.XPath(addAProductXpath);

        string invalidProductNameXpath = "//input[@placeholder='Filter by product name']";
        public By InvalidProductName => By.XPath(invalidProductNameXpath);

        string filterTabXpath = "//button[normalize-space()='Filter']";
        public By FilterTab => By.XPath(filterTabXpath);

        string invalidProductMessageXpath = "//p[@class='add-product-message']";
        public By InvalidProductMessage => By.XPath(invalidProductMessageXpath);

        string addProductXpath = "//a[normalize-space()='Add Product']";
        public By AddProduct => By.XPath(addProductXpath);

        string productNameXpath = "//input[@id='name']";
        public By ProductName => By.XPath(productNameXpath);

        string productPriceXpath = "//input[@id='price']";
        public By ProductPrice => By.XPath(productPriceXpath);

        string productDateStockedXpath = "//input[@id='dateStocked']";
        public By productDateStocked => By.XPath(productDateStockedXpath);

        string submitButtonXpath = "//button[@type='submit']";
        public By SubmitButton => By.XPath(submitButtonXpath);

        string productAddedXpath = "//td[normalize-space()='Pants']";
        public By ProductAdded => By.XPath(productAddedXpath);

        string priceWarningMessageXpath = "//div[normalize-space()='Price must not be empty and within 10 digits']";
        public By PriceWarningMessage => By.XPath(priceWarningMessageXpath);    

    }
}
