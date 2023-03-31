using AutomationProject.PageObjectModel;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V109.HeapProfiler;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace AutomationProject.TestClasses
{
    public sealed class FileUploadTest : BaseTest
    {
        FileUploadPage _fileUploadPage;
        private string textFilePath;

        public FileUploadTest()
        {
            _fileUploadPage = new FileUploadPage();
            Driver.Navigate().GoToUrl(_fileUploadPage.Url);
        }

        [Fact]
        public void TextFileUploadTest()
        {
            //Arrange
            string expectedAlertText = "File successfully uploaded!";
            textFilePath = Directory.GetCurrentDirectory();


            //Act
            IWebElement fileUploadElement = Driver.FindElement(_fileUploadPage.ChooseFile);
            //string filePath = Path.Combine(textFilePath, "Fileupload.txt");
            fileUploadElement.SendKeys(textFilePath);
            Driver.FindElement(_fileUploadPage.FileUploadSubmitBtn).Click();

            IAlert alert = Driver.SwitchTo().Alert();
            string actualAlertText = alert.Text;
            Thread.Sleep(3000);

            //Assert
            actualAlertText.Should().Be(expectedAlertText);
        }

        [Fact]
        public void ClickingSubmitBtnWithoutUploadingFileTest()
        {
            //Arrange
            string expectedFileUploadWarningMessage = "Please select a file to upload.";

            //Act
            Driver.FindElement(_fileUploadPage.FileUploadSubmitBtn).Click();
            String actualFileUploadWarningMessaage = Driver.FindElement(_fileUploadPage.FileUploadWarningMessage).Text;

            //Assert
            actualFileUploadWarningMessaage.Should().Be(expectedFileUploadWarningMessage);

        }

        [Fact]
        public void BackToPracticePageTest()
        {
            //Arrange

            //Act
            Driver.FindElement(_fileUploadPage.BackToPractice).Click();
            string text = Driver.FindElement(_fileUploadPage.NoteToUser).Text;

            //Assert
            text.Should().Contain("This page is likely to be updated");
        }

        [Fact]
        public void ChooseAFileTextTest()
        {
            //Arrange
            string expectedSuggestion = "Choose a file:";

            //Act
            string actualSuggestion = Driver.FindElement(_fileUploadPage.SuggestionToUser).Text;

            //Assert
            actualSuggestion.Should().Be(expectedSuggestion);
        }

        [Fact]
        public void SwitchTabTest()
        {
            //Arrange
            String expectedMessage = "CommitQuality";
            Driver.Navigate().GoToUrl(_fileUploadPage.Url);

            //Act
            Driver.FindElement(_fileUploadPage.LearnTab).Click();
            //Swicth to the new tab
            string currenWindowHandle = Driver.CurrentWindowHandle;
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            var element = wait.Until(C=>Driver.FindElement(_fileUploadPage.CommitQualityText));
           string actualMessage = element.Text;

            //Assert
            actualMessage.Should().Be(expectedMessage);
        }
    }
}
