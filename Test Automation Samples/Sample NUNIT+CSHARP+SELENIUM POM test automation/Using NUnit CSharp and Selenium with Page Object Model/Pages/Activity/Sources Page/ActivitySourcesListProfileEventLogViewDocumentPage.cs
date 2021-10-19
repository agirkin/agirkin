using OpenQA.Selenium;
using NUnit.Framework;

namespace DCC
{
    public class ActivitySourcesListProfileEventLogViewDocumentsPage : TestBase
    {
        public ActivitySourcesListProfileEventLogViewDocumentsPage(IWebDriver driver)
        {
            this.driver = driver;
        }       
        public void ActivitySourcesListProfileEventLogList_ViewDocument()
        {
            PageObject pageObject = new PageObject(driver);
            Initialize initialize = new Initialize(driver);            

            //Highlight Row
            WaitForDisplayedElement(By.XPath("(//div[@class='ui-grid-cell-contents ng-binding ng-scope'])[1]")).Click();

            //Click Edit
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("(//a[@menu-command='cmdEdit'])[2]")));
            WaitUntilCurtain();

            pageObject.Upload();

            //Click Save
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdSave']")));
            WaitUntilCurtain();
               
            //Select View Document Button
            IWebElement ViewDocumentsButton = FindElement(By.XPath("//a[@menu-command='cmdActivityLogViewDocuments']"));
            ViewDocumentsButton.Click();
            driver.SwitchTo().ActiveElement();
            WaitUntilCurtainninety();

            //Verify View Documents Title
            Assert.AreEqual("View Documents", WaitForDisplayedElement(By.XPath("//h4[text()='View Documents']")).Text);

            //Verify Open Disabled
            pageObject.OpenDisabled();

            //Verify List Enabled
            pageObject.ListEnabled();

            //Highlight Row
            WaitForDisplayedElement(By.XPath("(//div[contains(text(), '.docx')][@class='ui-grid-cell-contents ng-binding ng-scope'])[1]")).Click();

            //Verify File Name Column
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'File Name')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();          
        }     
      
    }
}


