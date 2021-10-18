using OpenQA.Selenium;
using NUnit.Framework;

namespace DCC
{
    public class ActivitySourceListsProfileContactsListEmailPage : TestBase
    {
        public ActivitySourceListsProfileContactsListEmailPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ActivitySourcesListProfileContactsList_Email()
        {
            //Select Refresh
            PageObject pageObject = new PageObject(driver);
            pageObject.RefreshIcon();

            //Agency Contains Testing
            Find find = new Find(driver);
            find.FindBasicTwoPlus();
            find.BasicFind("Agency", "contains", "A Way To Go Travel");
            find.ClickSearch();
            WaitUntilCurtain();

            //Highlight Row
            FindElement(By.XPath("(//div[@class='ui-grid-cell-contents ng-binding ng-scope'])[1]")).Click();
            WaitUntilCurtainninety();

            //Click Profile Button
            pageObject.ClickProfile();
            WaitUntilCurtainninety();

            //Click View Button 
            WaitUntilCurtain();
            pageObject.ClickButtonView();
            WaitUntilCurtainninety();

            //Click Contact Button
            WaitUntilCurtain();
            FindElement(By.XPath("//a[contains(@menu-command, 'cmdContacts')]")).Click();
            WaitUntilCurtain120();

            //Verify Page Title
            Assert.AreEqual("Data Source: Contacts", WaitForDisplayedElement(By.XPath("//h2[contains(text(), 'Data Source: Contacts')]")).Text);

            //Highlight Row
            WaitForDisplayedElement(By.XPath("(//div[@class='ui-grid-cell-contents ng-binding ng-scope'])[1]")).Click();
            WaitUntilCurtain();

            //Click Edit Button;
            IWebElement Edit = FindElement(By.XPath("//*[contains(@menu-application-content-area-id, '99')][contains(@menu-command, 'cmdEdit')]"));
            Edit.Click();
            WaitUntilCurtain();

            //Verify Edit Contact Displays
            Assert.AreEqual("Edit Contact", FindElement(By.XPath("//h2[contains(text(), 'Edit Contact')]")).Text);
            WaitUntilCurtain();

            //Enter Email
            IWebElement Email = FindElement(By.Name("WorkEmailAddress"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView()", Email);
            Email.Clear();
            Email.SendKeys("yvonne.gates@sabre.com");

            //Verify Email
            Assert.AreEqual("yvonne.gates@sabre.com", FindElement(By.Name("WorkEmailAddress")).GetAttribute("value"));

            //Click Save
            pageObject.ClickButtonTitleSave();

            //Highlight row
            //            FindElement(By.XPath("//div[@class='ui-grid-row ng-scope'][1]")).Click();
            WaitUntilCurtain();

            pageObject.ClickButtonEmail();
            WaitUntilCurtain();

            pageObject.ClickButtonTitleCancel();
            WaitUntilCurtain();

            //Verify Page Title
            Assert.AreEqual("Data Source: Contacts", FindElement(By.XPath("//h2[contains(text(), 'Data Source: Contacts')]")).Text);
            WaitUntilCurtain();

            pageObject.ClickButtonEmail();
            WaitUntilCurtain();

            //Verify Page Title Send Email
            Assert.AreEqual("Send Email", FindElement(By.XPath("//h2[contains(text(), 'Send Email')]")).Text);
                   
            //Verify From
            Assert.AreEqual("From", FindElement(By.XPath("//span[@class='spark-label spark']")).Text);

            // Verify To
            Assert.AreEqual("To", FindElement(By.XPath("//label[contains(@class, 'spark-label')]")).Text);

            // Verify CC
            Assert.AreEqual("Cc", FindElement(By.XPath("//label[contains(text(), 'Cc')]")).Text);

            // Verify Subject
            Assert.AreEqual("Subject", FindElement(By.XPath("//span[contains(text(), 'Subject')]")).Text);

            // Verify Attachments
            Assert.AreEqual("Attachments (Size must not exceed 8MB)", FindElement(By.XPath("//span[contains(text(), 'Attachment')]")).Text);

            // Verify Body
            Assert.AreEqual("Body", FindElement(By.XPath("//span[contains(text(), 'Body')]")).Text);
            WaitUntilCurtain();

            //Enter Subject
            IWebElement Subject = FindElement(By.Name("Subject"));
            Subject.SendKeys("Subject");

            //Click Upload
            IWebElement Upload = FindElement(By.XPath("//button[contains(@class, 'spark-btn spark-btn--xs')][contains(@ngf-select, 'fileUpload.uploadFiles($files)')]"));
            Upload.Click();

            System.Windows.Forms.SendKeys.SendWait("Testing");

            System.Windows.Forms.SendKeys.SendWait("{ENTER}");

            //Enter Body
            pageObject.FindElement(By.Name("Body")).SendKeys("This is a test of the Body of the Email");

            pageObject.ClickButtoncmdSend();
        }
    }
}


