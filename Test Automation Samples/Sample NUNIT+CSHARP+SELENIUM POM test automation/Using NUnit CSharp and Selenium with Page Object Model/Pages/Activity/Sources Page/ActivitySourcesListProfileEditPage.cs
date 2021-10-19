using System;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace DCC
{
    internal class ActivitySourcesListProfileEditPage : TestBase
    {
        public ActivitySourcesListProfileEditPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement Country => FindElement(By.Name("CountryCode"));
        public IWebElement DataChaseContactDropDown => FindElement(By.Name("DataChaseContactId"));
        public IWebElement DataSourcesField => FindElement(By.Name("DataSourceName"));
        public IWebElement MaskedDataSourceNameField => FindElement(By.Name("MaskedDataSourceName"));
        public IWebElement CurrenyDropDown => FindElement(By.Name("CurrencyCode"));
        public IWebElement AgencyTrashCan => FindElement(By.XPath("//div[contains(@ng-show, 'dataSourcesNewEdit.dataSource.SourceCompanyId')][contains(@class, 'spark-icon-trash')]"));

        public void ActivitySourcesListProfile_Edit()
        {
            //Clear Agency field           
            AgencyTrashCan.Click();
            WaitUntilCurtain();

            //Clear Data Sources field
            FindElement(By.Name("DataSourceName")).Clear();

            //Click Save
            PageObject pageObject = new PageObject(driver);
            pageObject.ClickButtonTitleSave();

            //Clear Masked Datasource Name field
            FindElement(By.Name("MaskedDataSourceName")).Clear();
            WaitUntilCurtain();

            //Enter Agency     
            Actions EnterAgency = new Actions(driver);
            EnterAgency.MoveToElement(FindElement(By.Name("SourceCompanyId"))).Click().Build().Perform();
            WaitUntilCurtain();
            FindElement(By.XPath("//span[contains(text(), 'ABC Test Travel Agency')][contains(@ng-class, '!item.IsActive')]")).Click();
            WaitUntilCurtainninety();

            //Enter Data Sources    
            DataSourcesField.SendKeys("ABC Test Travel Agency");

            //Enter Masked Datasource Name
            MaskedDataSourceNameField.SendKeys("Testing Masked Data Source");
            WaitUntilCurtainninety();

            //Enter Primary Contact 
            IWebElement EnterPrimaryContact = FindElement(By.Name("PrimaryContactId"));
            EnterPrimaryContact.Click();
            WaitUntilCurtainninety();
            FindElement(By.XPath("html/body/div[2]/input[1]")).SendKeys("tiedemann, julie");
            System.Threading.Thread.Sleep(5000);
            FindElement(By.XPath("html/body/div[2]/ul/li/div[3]/span")).Click();
            WaitUntilCurtain();
            string actualvaluePrimaryContact = EnterPrimaryContact.Text;
            Assert.IsTrue(actualvaluePrimaryContact.Contains("tiedemann, julie"), actualvaluePrimaryContact + " doesn't contains 'Contact'");

            //Select Data Chase Contact
            new SelectElement(DataChaseContactDropDown).SelectByIndex(1);
            WaitUntilCurtain120();

            //Select Country
            Country.Click();
            WaitUntilCurtain();
            Country.SendKeys("United States");
            WaitUntilCurtainsixty();

            //Enter Currency
            new SelectElement(CurrenyDropDown).SelectByText("US Dollar (USD)");
            WaitUntilCurtain();

            //Enter Language
            new SelectElement(driver.FindElement(By.Name("LanguageId"))).SelectByText("English (US)");
            WaitUntilCurtain240();

            //Enter Source Status
            IWebElement SourceState = WaitbyNameClickable(driver, ("DataSourceLateReasonId"));
            SourceState.Click();
            WaitUntilCurtainsixty();
            SourceState.SendKeys("Source Objection");
            WaitUntilCurtain();

            //Enter Frequency
            FindElement(By.Name("FrequencyId")).Click();
            WaitUntilCurtain();
            FindElement(By.Name("FrequencyId")).SendKeys("Weekly");

            //Enter User ID
            FindElement(By.Name("InFtpUserId")).Clear();
            FindElement(By.Name("InFtpUserId")).SendKeys("Testing User ID");

            //Enter Password
            FindElement(By.Name("InFtpPassword")).Clear();
            FindElement(By.Name("InFtpPassword")).SendKeys("Testing Password");
            WaitUntilCurtainsixty();

            // Verify Agency 
            Assert.AreEqual("ABC Test Travel Agency", FindElement(By.Name("DataSourceName")).GetAttribute("value"));

            // Verify Data Sources
            Assert.AreEqual("ABC Test Travel Agency", FindElement(By.Name("DataSourceName")).GetAttribute("value"));

            //Verify Masked Datasource Name
            Assert.AreEqual("Testing Masked Data Source", FindElement(By.Name("MaskedDataSourceName")).GetAttribute("value"));

            //Verify Country
            Assert.AreEqual("string:US", FindElement(By.Name("CountryCode")).GetAttribute("value"));

            //Verify Curreny
            Assert.AreEqual("string:USD", FindElement(By.Name("CurrencyCode")).GetAttribute("value"));

            //Verify Source Status
            Assert.AreEqual("number:3", FindElement(By.Name("DataSourceLateReasonId")).GetAttribute("value"));

            //Verify Frequency
            Assert.AreEqual("number:2", FindElement(By.Name("FrequencyId")).GetAttribute("value"));

            //Verify User ID
            Assert.AreEqual("Testing User ID", FindElement(By.Name("InFtpUserId")).GetAttribute("value"));

            //Verify Password
            Assert.AreEqual("Testing Password", FindElement(By.Name("InFtpPassword")).GetAttribute("value"));

            //Verify Data Late Notice Unchecked                  
            Assert.IsTrue(FindElement(By.XPath("//input[contains(@ng-model, 'dataSourcesNewEdit.dataSource.SendDataLateNotice')]")).Selected);

            //Verify Single Ticketing Country Unchecked                  
            Assert.IsTrue(FindElement(By.XPath("//input[contains(@ng-model, 'dataSourcesNewEdit.dataSource.HasSingleTicketingCountry')]")).Selected);

            //Verify Suspect Unchecked                  
            Assert.IsFalse(FindElement(By.XPath("//input[contains(@ng-model, 'dataSourcesNewEdit.dataSource.IsSuspect')]")).Selected);

            //Verify Inactive Unchecked                  
            Assert.IsFalse(FindElement(By.XPath("//input[contains(@ng-model, 'dataSourcesNewEdit.dataSource.IsActive')]")).Selected);

            //Verify Autoload Is Checked
            Assert.IsTrue(FindElement(By.XPath("//input[contains(@class, 'spark-checkbox__input')][contains(@ng-model, 'dataSourcesNewEdit.dataSource.Autoload')]")).Selected);

            //Verify Track Status Is Checked
            Assert.IsTrue(FindElement(By.XPath("//input[contains(@class, 'spark-checkbox__input')][contains(@ng-model, 'dataSourcesNewEdit.dataSource.IsTracked')]")).Selected);

            //Verify Local Source Unchecked
            Assert.IsTrue(FindElement(By.XPath("//input[contains(@class, 'spark-checkbox__input')][contains(@ng-model, 'dataSourcesNewEdit.dataSource.IsLocalSource')]")).Selected);

            //Verify Track Alternate Source Unchecked
            Assert.IsFalse(FindElement(By.XPath("//input[contains(@class, 'spark-checkbox__input')][contains(@ng-model, 'dataSourcesNewEdit.dataSource.TrackAlternateSource')]")).Selected);

            //Verify Combine Source Status Checked
            Assert.IsFalse(FindElement(By.XPath("//input[contains(@class, 'spark-checkbox__input')][contains(@ng-model, 'dataSourcesNewEdit.dataSource.CombineSourceStatus')]")).Selected);

        }
    }
}


