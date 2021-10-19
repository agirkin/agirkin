using OpenQA.Selenium;
using NUnit.Framework;

namespace DCC
{
    internal class ActivityCompaniesListProfileEventLogPage : TestBase
    {        
        public IWebElement EditButton => FindElement(By.XPath("(//a[@menu-command='cmdEdit'])[2]"));

        public IWebElement ViewDocumentButton => FindElement(By.XPath("//a[@menu-command='cmdActivityLogViewDocuments']"));

        public IWebElement ViewDocumentTitle => FindElement(By.XPath("//h4[text()='View Documents']"));

        public IWebElement OpenLink => FindElement(By.XPath("//a[contains(@menu-command, 'cmdOpen')]"));

        public ActivityCompaniesListProfileEventLogPage(IWebDriver driver)
        {
            this.driver = driver;
        }           
        public void ActivityCompaniesListProfileEventLog_ViewDocument_Open()
        {
            PageObject pageObject = new PageObject(driver);

            //Highlight Row
            pageObject.HighlightFirstRow();

            //Click Edit
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            js.ExecuteScript("arguments[0].click();", EditButton);
            WaitUntilCurtain();

            //Upload Document
            pageObject.Upload();
            WaitUntilCurtain();

            //Click Save
            pageObject.ClickLinkTextSave();
            WaitUntilCurtain();

            //Select View Document Button           
            ViewDocumentButton.Click();
            driver.SwitchTo().ActiveElement();
            WaitUntilCurtain();
            WaitForAjaxComplete(30);

            //Verify View Documents Title
            Assert.AreEqual("View Documents", ViewDocumentTitle.Text);

            //Highlight Row
            pageObject.HighlightFirstRow();

            //Click Open
            Assert.IsTrue(OpenLink.Enabled);
            Assert.AreEqual(true, OpenLink.Displayed);
            WaitUntilCurtain();
        }
    }
}


