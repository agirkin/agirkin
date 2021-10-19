using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;

namespace DCC
{

    public class CompaniesProfileListTopSections : TestBase
    {
            public CompaniesProfileListTopSections(IWebDriver driver)
            {
                this.driver = driver;
            }
            public void CompaniesProfileList_TopSections()
            {          
            Assert.AreEqual("Identification", FindElement(By.XPath("//strong[contains(text(), 'Identification')]")).Text);

            Assert.AreEqual("Company", FindElement(By.XPath("//strong[contains(text(), 'Company')]")).Text);

            Assert.AreEqual("Type", FindElement(By.XPath("//strong[contains(text(), 'Type')]")).Text);

            Assert.AreEqual("Address", FindElement(By.XPath("//strong[contains(text(), 'Address')]")).Text);

            Assert.AreEqual("Address 1", FindElement(By.XPath("//strong[contains(text(), 'Address 1')]")).Text);

            Assert.AreEqual("Address 2", FindElement(By.XPath("//strong[contains(text(), 'Address 2')]")).Text);

            Assert.AreEqual("City", FindElement(By.XPath("//strong[contains(text(), 'City')]")).Text);

            Assert.AreEqual("State/Province", FindElement(By.XPath("//strong[contains(text(), 'State/Province')]")).Text);

            Assert.AreEqual("Postal Code", FindElement(By.XPath("//strong[contains(text(), 'Postal Code')]")).Text);

            Assert.AreEqual("Country", FindElement(By.XPath("//strong[contains(text(), 'Country')]")).Text);

            WaitUntilCurtain();        

        }
    }
}


