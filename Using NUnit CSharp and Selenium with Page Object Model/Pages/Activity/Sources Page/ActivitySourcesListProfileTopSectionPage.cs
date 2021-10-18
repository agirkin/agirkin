using System;
using OpenQA.Selenium;
using NUnit.Framework;
using System.Configuration;

namespace DCC
{  
    public class ActivitySourcesListProfileTopSectionPage : TestBase
    {
        public ActivitySourcesListProfileTopSectionPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string Agency = ConfigurationManager.AppSettings["Agency"];
        public void ActivitySourcesListProfile_TopSection()
        {              

            Assert.AreEqual("Data Source: Release", FindElement(By.XPath("//h2[contains(text(), 'Data Source: Release')]")).Text);

            Assert.AreEqual("Otrar Travel", FindElement(By.XPath("//label[contains(@class, 'ng-binding')][contains(text(), 'Otrar Travel')]")).Text);

            Assert.AreEqual("Identification", FindElement(By.XPath("//strong[contains(text(), 'Identification')]")).Text);

            Assert.AreEqual("Agency", FindElement(By.XPath("//strong[contains(text(), 'Agency')]")).Text);

            Assert.AreEqual("Address", FindElement(By.XPath("//strong[contains(text(), 'Address')]")).Text);

            Assert.AreEqual("Address 1", FindElement(By.XPath("//strong[contains(text(), 'Address 1')]")).Text);

            Assert.AreEqual("127/9 Makatayer Street", FindElement(By.XPath("//div[contains(@class, 'col-xs-9 ng-binding')][contains(text(), '127/9 Makatayer Street')]")).Text);

            Assert.AreEqual("Address 2", FindElement(By.XPath("//strong[contains(text(), 'Address 2')]")).Text);

            Assert.AreEqual("City", FindElement(By.XPath("//strong[contains(text(), 'City')]")).Text);

            Assert.AreEqual("Almaty, Kazakhstan", FindElement(By.XPath("//div[contains(@class, 'col-xs-offset-1 ng-binding')][contains(text(), 'Almaty, Kazakhstan')]")).Text);

            Assert.AreEqual("State/Province", FindElement(By.XPath("//strong[contains(text(), 'State/Province')]")).Text);

            Assert.AreEqual("Postal Code", FindElement(By.XPath("//strong[contains(text(), 'Postal Code')]")).Text);

            Assert.AreEqual("050000", FindElement(By.XPath("//div[contains(@class, 'col-xs-2 ng-binding')][contains(text(), '050000')]")).Text);

            Assert.AreEqual("Country", FindElement(By.XPath("//strong[contains(text(), 'Country')]")).Text);

            Assert.AreEqual("Kazakhstan", FindElement(By.XPath("//div[contains(@class, 'col-xs-9 ng-binding')][contains(text(), 'Kazakhstan')]")).Text);
            WaitUntilCurtain();
        }
    }
}


