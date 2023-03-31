using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject.PageObjectModel
{
    internal class FileUploadPage
    {
        public string Url = "https://commitquality.com/practice-file-upload";

        string chooseFileXpath = "//input[@id='file-input']";
        public By ChooseFile => By.XPath(chooseFileXpath);

        string fileUploadSubmitBtn = "//button[@type='submit']";
        public By FileUploadSubmitBtn => By.XPath(fileUploadSubmitBtn);

        string fileUploadWarningMessageXpath = "//div[@class='error-message']";
        public By FileUploadWarningMessage => By.XPath(fileUploadWarningMessageXpath);

        string backToPracticeXpath = "//a[@class='back-link']";
        public By BackToPractice => By.XPath(backToPracticeXpath);

        string noteToUserXpath = "//body/div[@id='root']/div[@class='App']/div[@class='container']/div/p[1]";
        public By NoteToUser => By.XPath(noteToUserXpath);

        string suggestionToUserXpath = "//label[@for='file-input']";
        public By SuggestionToUser => By.XPath(suggestionToUserXpath);

        string learnTabXpath = "//a[normalize-space()='Learn']";
        public By LearnTab => By.XPath(learnTabXpath);

        string commitQualityTextXpath = "//div[@id='inner-header-container']//yt-formatted-string[@id='text']";
        public By CommitQualityText => By.XPath(commitQualityTextXpath);
    }
}
