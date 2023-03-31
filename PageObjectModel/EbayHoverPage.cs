using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject.PageObjectModel
{
    internal class EbayHoverPage
    {
        public string Url = "https://www.ebay.com/";

        string stringHoverXpath = "//*[@id=\"mainContent\"]/div[1]/ul/li[4]/a";
        public By StringHover => By.XPath(stringHoverXpath);

        string afterHoverXpath = "//a[@class='hl-cat-nav__js-link'][normalize-space()='Computers, Tablets & Network Hardware']";
        public By AfterHover => By.XPath(afterHoverXpath);

    }
}
