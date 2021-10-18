using OpenQA.Selenium;
using NUnit.Framework;
using System;

namespace DCC
{
    public class ActivitySourcesListProfileSourceDetailsListEditPage : TestBase
    {
        public ActivitySourcesListProfileSourceDetailsListEditPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ActivitySourcesListProfileSourceDetails_Edit()
        {
            PageObject pageObject = new PageObject(driver);
            Initialize ActivitySourcesInitialize = new Initialize(driver);
            

            //Highlight Row
            FindElement(By.XPath("(//div[@class='ui-grid-cell-contents ng-binding ng-scope'])[1]")).Click();
            WaitUntilCurtain();

            //Click Edit
            pageObject.ClickButtonEdit();

            Assert.AreEqual("Data Source", FindElement(By.XPath("//h4[contains(text(), 'Data Source')]")).Text);

            //Verify Edit Source Details Displays
            Assert.AreEqual("Edit Source Details", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Edit Source Details')]")).Text);

            //Verify Testing Source Details Displays
            Assert.AreEqual("Testing Source Details", FindElement(By.XPath("//div[contains(text(), 'Testing Source Details')][@class='col-xs-12 ng-binding']")).Text);
            
            // Verify Answer Displays
            Assert.AreEqual("Answer", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Answer')]")).Text);

            FindElement(By.Name("ProfileQuestion")).EnterText("New Question");

            IWebElement Activescheckbox = FindElement(By.Name("IsActive"));
            if (Activescheckbox.Selected)
            {
                Activescheckbox.Click();
            }

            // Verify Active Displays
            Assert.AreEqual("Active", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Active')]")).Text);

            //Click Save
            pageObject.ClickButtonSave();
        }
    }
}


