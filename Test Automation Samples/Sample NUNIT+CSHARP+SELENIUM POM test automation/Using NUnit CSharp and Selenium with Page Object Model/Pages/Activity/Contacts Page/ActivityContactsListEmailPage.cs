using OpenQA.Selenium;
using NUnit.Framework;
using System.Configuration;

namespace DCC
{
    public class ActivityContactsListEmailPage : TestBase
    {
        public ActivityContactsListEmailPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string LastName = ConfigurationManager.AppSettings["LastName"];
        public void ActivityContactsList_Email()
        {          
            PageObject pageObject = new PageObject(driver);
            Distribute distribute = new Distribute(driver);

            //Last Name Contains Gates
            Find find = new Find(driver);
            find.FindBasicTwoPlus();
            find.BasicFind("Last Name", "Contains", LastName);
            find.ClickSearch();
            WaitUntilCurtain();

            //Highlight Row
            pageObject.HighlightFirstRow();
           
            //Click Email Button            
            pageObject.ClickButtonEmail();
            WaitUntilCurtain120();

            Assert.AreEqual("Send Email", FindElement(By.XPath("//h2[contains(text(), 'Send Email')]")).Text);
            WaitUntilCurtain();

            //Click Cancel           
            pageObject.ClickButtonTitleCancel();
            WaitUntilCurtain();

            //Click Email Button           
            pageObject.ClickButtonEmail();
            WaitUntilCurtain();

            //Verify Page Title Send Email
            Assert.AreEqual("Send Email", FindElement(By.XPath("//h2[contains(text(), 'Send Email')]")).Text);

            Assert.AreEqual("Gates, Yvonne", FindElement(By.XPath("//span[@class='spark-input__field ng-binding']")).Text);

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

            pageObject.ClickButtonX();
            WaitUntilCurtain();

            // Verify Required
            Assert.AreEqual("Required", FindElement(By.XPath("//span[@ng-show='contactsEmail.emailItemForm.ToAddresses.$error.dccrequired && (!contactsEmail.emailItemForm.ToAddresses.$pristine || contactsEmail.submitted)']")).Text);

            //Enter To
            distribute.EnterTo();

            // Verify Name
            WaitUntilCurtain();
            Assert.AreEqual("Gates, Yvonne <Yvonne.Gates@sabre.com>", FindElement(By.XPath("//span[@uis-transclude-append='']")).Text);
        } 
    }
}

