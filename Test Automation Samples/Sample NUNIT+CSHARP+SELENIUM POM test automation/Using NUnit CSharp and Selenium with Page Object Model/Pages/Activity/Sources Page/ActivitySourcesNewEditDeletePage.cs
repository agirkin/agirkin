using OpenQA.Selenium;
using NUnit.Framework;
using System;
using OpenQA.Selenium.Support.UI;
using System.Configuration;

namespace DCC
{
    public class ActivitySourceNewEditDelete : TestBase
    {
        public ActivitySourceNewEditDelete(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string Agency = ConfigurationManager.AppSettings["Agency"];
        public string DataSource = ConfigurationManager.AppSettings["DataSource"];
        public IWebElement SourceTypeDD => FindElement(By.Name("SourceTypeId"));
        public void ActivitySourceVerifyTitles()
        {
            PageObject pageObject = new PageObject(driver);
            WaitUntilCurtain();

            //Verify Identification Title
            Assert.AreEqual("Identification", FindElement(By.XPath("//h4[contains(text(), 'Identification')]")).Text);

            // Verify Agency Field Title Displays
            Assert.AreEqual("Agency", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Agency')]")).Text);

            //Verify Data Sources Field Title Displays
            Assert.AreEqual("Data Sources", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Data Sources')]")).Text);

            //Verify Masked Datasource Name Field Title Displays
            Assert.AreEqual("Masked Datasource Name", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Masked Datasource Name')]")).Text);

            //Verify Primary Contact Field Title Displays
            Assert.AreEqual("Primary Contact", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Primary Contact')]")).Text);

            //Verify Data Chase Contact Field Title Displays
            Assert.AreEqual("Data Chase Contact", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Data Chase Contact')]")).Text);

            //Verify Interface Name Field Title Displays
            Assert.AreEqual("Interface Name", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Interface Name')]")).Text);

            //Verify Source Type Field Title Displays
            Assert.AreEqual("Source Type", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Source Type')]")).Text);

            //Verify Location Title
            Assert.AreEqual("Location", FindElement(By.XPath("//h4[contains(text(), 'Location')]")).Text);

            //Verify Single Ticketing Country Field Title Displays
            Assert.AreEqual("Single Ticketing Country", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Single Ticketing Country')]")).Text);

            //Verify Country Field Title Displays
            Assert.AreEqual("Country", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Country')]")).Text);

            //Verify Currency Field Title Displays
            Assert.AreEqual("Currency", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Currency')]")).Text);

            //Verify Language Title Displays
            Assert.AreEqual("Language", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Language')]")).Text);

            //Verify Source Status Field Title Displays
            Assert.AreEqual("Source Status", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Source Status')]")).Text);

            //Verify Suspect Title Displays
            Assert.AreEqual("Suspect", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Suspect')]")).Text);

            //Verify Inactive Title Displays
            Assert.AreEqual("Inactive", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Inactive')]")).Text);

            //Verify Data Source Title
            Assert.AreEqual("Data Source", FindElement(By.XPath("//h4[contains(text(), 'Data Source')]")).Text);

            //Verify Frequency Field Title Displays
            Assert.AreEqual("Frequency", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Frequency')]")).Text);

            //Verify Autoload Title Displays
            Assert.AreEqual("Autoload", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Autoload')]")).Text);

            //Verify Local Source Title Displays
            Assert.AreEqual("Local Source", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Local Source')]")).Text);

            //Verify Combine Source Status Title Displays
            Assert.AreEqual("Combine Source Status", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Combine Source Status')]")).Text);

            //Verify Track Status Title Displays
            Assert.AreEqual("Track Status", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Track Status')]")).Text);

            //Verify Track Alternate Source Title Displays
            Assert.AreEqual("Track Alternate Source", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Track Alternate Source')]")).Text);

            //Verify Data Late Notice Title Displays
            Assert.AreEqual("Data Late Notice", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Data Late Notice')]")).Text);

            //Verify SFTP Input Title
            Assert.AreEqual("SFTP Input", FindElement(By.XPath("//h4[contains(text(), 'SFTP Input')]")).Text);

            //Verify Production Account Title
            Assert.AreEqual("Production Account", FindElement(By.XPath("//h6[text()='Production Account']")).Text);

            ////Verify File Location: Title
            //Assert.AreEqual("File Location:", FindElement(By.XPath("//div/div/ng-form/div[2]/div[1]/text()[3]")).Text);

            //Verify User ID Title Displays
            Assert.AreEqual("User ID", FindElement(By.XPath("//input[@name='InFtpUserId']/following-sibling::span[text()='User ID']")).Text);

            //Verify Password Field Title Displays
            Assert.AreEqual("Password", FindElement(By.XPath("//input[@name='InFtpPassword']/following-sibling::span[text()='Password']")).Text);

            //Verify Test Account Title
            Assert.AreEqual("Test Account", FindElement(By.XPath("//h6[text()='Test Account']")).Text);

            ////Verify File Location: Title
            //Assert.AreEqual("File Location:", FindElement(By.XPath("//div/div/ng-form/div[2]/div[1]/text()[4]")).Text);

            //Verify User ID Title Displays
            Assert.AreEqual("User ID", FindElement(By.XPath("//input[@name='TestUserId']/following-sibling::span[text()='User ID']")).Text);

            //Verify Password Field Title Displays
            Assert.AreEqual("Password", FindElement(By.XPath("//input[@name='TestPassword']/following-sibling::span[text()='Password']")).Text);
        }
        public void EnterAgency()
        {
            // Enter Agency
            IWebElement AgencyDropDown = FindElement(By.Name("SourceCompanyId"));
            AgencyDropDown.Click();
            WaitUntilCurtain();
            FindElement(By.XPath("//div[@name='SourceCompanyId']/input[1]")).SendKeys(Agency);
            System.Threading.Thread.Sleep(5000);
            FindElement(By.XPath("//*[contains(@id, 'ui-select-choices-row')]")).Click();
            WaitUntilCurtain();
        }
        public void EnterDataSource()
        {
            //Enter Data Sources
            IWebElement DataSources = FindElement(By.Name("DataSourceName"));
            DataSources.Clear();
            DataSources.SendKeys(DataSource);
            //Verify Max length
            String DataSourcesactualLimit = DataSources.GetAttribute("maxlength");
            Assert.AreEqual(DataSourcesactualLimit, "30");
        }
        public void EnterMaskedDataSourceName()
        {
            //Enter Masked Datasource Name
            IWebElement MaskedDataSourceName = FindElement(By.Name("MaskedDataSourceName"));
            MaskedDataSourceName.Clear();
            MaskedDataSourceName.SendKeys("ABC Test Travel Agency Data Source Name");
            //Verify Max length
            String MaskedDataSourceNameactualLimit = MaskedDataSourceName.GetAttribute("maxlength");
            Assert.AreEqual(MaskedDataSourceNameactualLimit, "30");
            WaitUntilCurtainsixty();
        }
        public void EnterPrimaryContact()
        {
            //Enter Primary Contact
            FindElement(By.Name("PrimaryContactId")).Click();
            WaitUntilCurtain();
            FindElement(By.XPath("//span[contains(text(), 'Oautomation Last Nam, OAutomation Fir <yvonne.gates@sabre.com>')][contains(@ng-class, '!item.IsActive')]")).Click();
            WaitUntilCurtain();
        }
        public void SelectDataChaseContact()
        {
            //Select Data Chase Contact
            SelectElement DataChase = new SelectElement(FindElement(By.Name("DataChaseContactId")));
            DataChase.SelectByIndex(1);
        }
        public void SelectInterfaceName()
        {
            //Select Interface Name
            System.Threading.Thread.Sleep(5000);
            FindElement(By.Name("DataInterfaceId")).Click();
            WaitUntilCurtain();
            FindElement(By.XPath("//span[contains(text(), 'AAirPass')][contains(@ng-class, '!item.IsActive')]")).Click();
            System.Threading.Thread.Sleep(5000);
        }
        public void SelectSourceType()
        {
            //Select Source Type           
            WaitbyNameClickable(driver, "SourceTypeId").Click();
            WaitUntilCurtain();
            SourceTypeDD.SendKeys("Airline");
        }
        public void VerifyDataLateNoticeChecked()
        {
            //Verify Data Late Notice Checked
            Assert.IsTrue(FindElement(By.XPath("//input[contains(@ng-model, 'dataSourcesNewEdit.dataSource.SendDataLateNotice')]")).Selected);
        }
        public void SelectCountry()
        {
            //Select Country
            WaitbyNameClickable(driver, "CountryCode").Click();
            WaitUntilCurtain();
            FindElement(By.Name("CountryCode")).SendKeys("Australia (AU)");
        }
        public void SelectCurrency()
        {
            //Select Currency
            FindElement(By.Name("CurrencyCode")).Click();
            WaitUntilCurtain();
            FindElement(By.Name("CurrencyCode")).SendKeys("Australian Dollar");
        }
        public void SelectLanguage()
        {
            //Select Language
            FindElement(By.Name("LanguageId")).Click();
            WaitUntilCurtain();
            FindElement(By.Name("LanguageId")).SendKeys("Chinese");
        }
        public void SelectSourceStatus()
        {
            //Select Source Status
            FindElement(By.Name("DataSourceLateReasonId")).Click();
            WaitUntilCurtain();
            FindElement(By.Name("DataSourceLateReasonId")).SendKeys("Source Provided Instructions");
        }
        public void VerifySuspectUnChecked()
        {
            //Verify Suspect UnChecked
            Assert.IsFalse(FindElement(By.XPath("//input[contains(@class, 'spark-checkbox__input')][contains(@ng-model, 'dataSourcesNewEdit.dataSource.IsSuspect')]")).Selected);
        }
        public void VerifyInactiveUnChecked()
        {
            //Verify Inactive UnChecked
            Assert.IsFalse(FindElement(By.XPath("//input[contains(@class, 'spark-checkbox__input')][contains(@ng-model, 'dataSourcesNewEdit.dataSource.IsActive')]")).Selected);
        }
        public void SelectFrequency()
        {
            //Select Frequency
            FindElement(By.Name("FrequencyId")).Click();
            WaitUntilCurtain();
            FindElement(By.Name("FrequencyId")).SendKeys("Daily");
        }
        public void CheckMarkCombineSourceStatus()
        {
            IWebElement CombineSourceStatus = FindElement(By.XPath("//span[@class='spark-label'][text()='Track Status']"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView()", CombineSourceStatus);
        }    
        public void EnterUserID()
        {
            //Enter User ID
            IWebElement ProductionAccountUserID = FindElement(By.Name("InFtpUserId"));
            ProductionAccountUserID.Clear();
            ProductionAccountUserID.SendKeys("Testing User ID");
            //Verify Max length
            String actualLimit = ProductionAccountUserID.GetAttribute("maxlength");
            Assert.AreEqual(actualLimit, "255");
            WaitUntilLoaded();
        }
        public void EnterPassword()
        {

            //Enter Password
            IWebElement ProductionAccountPassword = FindElement(By.Name("InFtpPassword"));
            ProductionAccountPassword.Clear();
            ProductionAccountPassword.SendKeys("Testing Password");
            String ProductionAccountPasswordactualLimit = ProductionAccountPassword.GetAttribute("maxlength");
            Assert.AreEqual(ProductionAccountPasswordactualLimit, "30");
            WaitUntilLoaded();
        }
        public void EnterTestAccountUserID()
        {

            //Enter Test Account User ID
            IWebElement TestAccountUserID = FindElement(By.Name("TestUserId"));
            TestAccountUserID.Clear();
            TestAccountUserID.SendKeys("Test Account User ID");
            //Verify Max length
            String TestAccountUserIDactualLimit = TestAccountUserID.GetAttribute("maxlength");
            Assert.AreEqual(TestAccountUserIDactualLimit, "255");
            WaitUntilLoaded();
        }
        public void EnterTestAccountPassword()
        {

            //Enter Test Account Password
            IWebElement TestAccountPassword = FindElement(By.Name("TestPassword"));
            TestAccountPassword.Clear();
            TestAccountPassword.SendKeys("Test Account Password");
            String TestAccountPasswordactualLimit = TestAccountPassword.GetAttribute("maxlength");
            Assert.AreEqual(TestAccountPasswordactualLimit, "30");
            WaitUntilLoaded();
        }
        public void VerifyAutoLoadChecked()
        {
            //Verify Auto Load Checked
            Assert.IsTrue(FindElement(By.XPath("//input[contains(@class, 'spark-checkbox__input')][contains(@ng-model, 'dataSourcesNewEdit.dataSource.Autoload')]")).Selected);
        }
        public void VerifyTrackStatusChecked()
        {
            //Verify Track Status Checked
            Assert.IsTrue(FindElement(By.XPath("//input[contains(@class, 'spark-checkbox__input')][contains(@ng-model, 'dataSourcesNewEdit.dataSource.IsTracked')]")).Selected);
        }
        public void VerifyTrackAlternateSourceUnChecked()
        {
            //Verify Alternate Source UnChecked
            Assert.IsFalse(FindElement(By.XPath("//input[contains(@ng-model, 'dataSourcesNewEdit.dataSource.TrackAlternateSource')]")).Selected);
        }
        public void VerifyLocalSourceUnChecked()
        {
            //Verify Local Source UnChecked
            Assert.IsFalse(FindElement(By.XPath("//input[contains(@ng-model, 'dataSourcesNewEdit.dataSource.IsLocalSource')]")).Selected);
        }
        public void VerifyCombineSourceStatusUnChecked()
        {
            //Verify Source Status UnChecked
            Assert.IsFalse(FindElement(By.XPath("//input[contains(@ng-model, 'dataSourcesNewEdit.dataSource.CombineSourceStatus')]")).Selected);
        }

    }
}
