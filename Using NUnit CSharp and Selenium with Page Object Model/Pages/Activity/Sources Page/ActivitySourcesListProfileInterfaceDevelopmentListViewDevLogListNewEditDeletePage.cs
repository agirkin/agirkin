using OpenQA.Selenium;
using NUnit.Framework;
using System;

namespace DCC
{
    public class ViewDevLogListNewEditDeletePage : TestBase
    {
        public ViewDevLogListNewEditDeletePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement ActivityType => FindElement(By.Name("ActivityTypeId"));
        public IWebElement ActivityItem => FindElement(By.Name("ActivityItemId"));
        public IWebElement DescriptionTextField => FindElement(By.Name("Description"));
        public void VerifyFieldTitles()
        {
            //Verify Activity Type Field Title
            Assert.AreEqual("Activity Type", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Activity Type')]")).Text);

            //Verify Activity Item Field Title
            Assert.AreEqual("Activity Item", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Activity Item')]")).Text);

            //Verify Description Field Title
            Assert.AreEqual("Description", FindElement(By.XPath("//span[contains(@class, 'spark-labe')][contains(text(), 'Description')]")).Text);
        }
        public void SelectActivityType()
        {
            //Select Activity Type Drop Down
            ActivityType.Click();
            WaitUntilCurtain();
            ActivityType.SendKeys("UnknownCo");
            ActivityType.Click();
            WaitUntilCurtain();

            string actualvalueActivityType = ActivityType.Text;
            Assert.IsTrue(actualvalueActivityType.Contains("UnknownCo"), actualvalueActivityType + " doesn't contain 'Activity Type'");
        }
        public void SelectActivityItem()
        {
            //Select Activity Item Drop Down
            ActivityItem.Click();
            WaitUntilCurtain();
            ActivityItem.SendKeys("Assistance");
            ActivityItem.Click();
            WaitUntilCurtain();

            string actualvalueActivityItem = ActivityItem.Text;
            Assert.IsTrue(actualvalueActivityItem.Contains("Assistance"), actualvalueActivityItem + " doesn't contain 'Activity Item'");
        }    
        public void EnterDescirption()
        {
            //Enter Description
            DescriptionTextField.Clear();
            DescriptionTextField.SendKeys("Testing Description");
            String DescriptionMaxlength = DescriptionTextField.GetAttribute("maxlength");
            Assert.AreEqual(DescriptionMaxlength, "4000");
            //string longText = new string('*', 4000);
            //IWebElement textArea = DescriptionTextField;
            //textArea.SendKeys(longText);       
        }
    }
}

