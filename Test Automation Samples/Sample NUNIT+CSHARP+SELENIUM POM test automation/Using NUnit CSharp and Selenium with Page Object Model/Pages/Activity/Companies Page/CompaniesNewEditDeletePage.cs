using OpenQA.Selenium;
using NUnit.Framework;
using System;
using System.Configuration;

namespace DCC
{
    class CompaniesNewEditDeletePage : TestBase
    {
        public string LegalName = ConfigurationManager.AppSettings["LegalName"];
        public string BusinessName = ConfigurationManager.AppSettings["BusinessName"];
        public string CompanyTypeAgency = ConfigurationManager.AppSettings["CompanyTypeAgency"];
        public string CompanyGroup = ConfigurationManager.AppSettings["CompanyGroup"];
        public string AKAKnownAs = ConfigurationManager.AppSettings["AKAKnownAs"];
        public string Country = ConfigurationManager.AppSettings["Country"];
        public string Address1 = ConfigurationManager.AppSettings["Address1"];
        public string Address2 = ConfigurationManager.AppSettings["Address2"];
        public string City = ConfigurationManager.AppSettings["City"];
        public string State = ConfigurationManager.AppSettings["State"];
        public string PostalCode = ConfigurationManager.AppSettings["PostalCode"];
        public string WebSite = ConfigurationManager.AppSettings["WebSite"];

        public CompaniesNewEditDeletePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void CompaniesVerifyTitles()
        {         
            //Verify Identification Displays
            Assert.AreEqual("Identification", FindElement(By.XPath("//h4[contains(text(), 'Identification')]")).Text);

            //Verify Legal Name Field Title Displays
            Assert.AreEqual("Legal Name", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Legal Name')]")).Text);

            //Verify Business Name Field Title Displays
            Assert.AreEqual("Business Name", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Business Name')]")).Text);

            //Verify Company Type Title Displays
            Assert.AreEqual("Company Type", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Company Type')]")).Text);

            //Verify Company Group Title Displays
            Assert.AreEqual("Company Group", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Company Group')]")).Text);

            //Verify Also Known As Title Displays
            Assert.AreEqual("Also Known As", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Also Known As')]")).Text);

            //Verify Data Source Title Displays
            Assert.AreEqual("Data Source", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Data Source')]")).Text);

            //Verify Customer Field Title Displays
            Assert.AreEqual("Customer", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Customer')]")).Text);

            //Verify Data Title Displays
            Assert.AreEqual("Data", FindElement(By.XPath("//h4[contains(text(), 'Data')]")).Text);

            //Verify Inactive Title Displays
            Assert.AreEqual("Inactive", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Inactive')]")).Text);

            //Verify Data Agreement Title Displays
            Assert.AreEqual("Data Agreement", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Data Agreement')]")).Text);

            //Verify Data UnMasked Title Displays
            Assert.AreEqual("Data UnMasked", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Data UnMasked')]")).Text);

            //Verify Passenger Masked Title Displays
            Assert.AreEqual("Passenger Masked", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Passenger Masked')]")).Text);

            //Verify Country/Region Field Title Displays
            Assert.AreEqual("Country/Region", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Country/Region')]")).Text);

            //Verify Address 1 Field Title Displays
            Assert.AreEqual("Address 1", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Address 1')]")).Text);

            //Verify Address 2 Field Title Displays
            Assert.AreEqual("Address 2", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Address 2')]")).Text);

            //Verify City Field Title Displays
            Assert.AreEqual("City", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'City')]")).Text);

            //Verify State/Province Field Title Displays
            Assert.AreEqual("State/Province", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'State/Province')]")).Text);

            //Verify Postal Code Field Title Displays
            Assert.AreEqual("Postal Code", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Postal Code')]")).Text);

            //Verify Web Site Field Title Displays
            Assert.AreEqual("Web Site", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Web Site')]")).Text);
        }
        public void EnterLegalName()
        {
            //Enter Legal Name
            IWebElement LegalNames = FindElement(By.Name("LegalName"));
            LegalNames.Clear();
            LegalNames.SendKeys(LegalName);
            //Verify Max length
            String actualLimit = LegalNames.GetAttribute("maxlength");
            Assert.AreEqual(actualLimit, "50");
            WaitUntilLoaded();

            // Verify Testing Legal Name
            FindElement(By.Name("LegalName")).GetAttribute(LegalName);

            //Verify Legal Name Label
            Assert.AreEqual("Legal Name", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Legal Name')]")).Text);
        }
        public void EnterBusinesslName()
        {
            //Enter Business Name
            IWebElement BusinessNames = FindElement(By.Name("CompanyName"));
            BusinessNames.Clear();
            BusinessNames.SendKeys(BusinessName);
            String actualLimitBusinessNames = BusinessNames.GetAttribute("maxlength");
            Assert.AreEqual(actualLimitBusinessNames, "50");
            WaitUntilLoaded();

            // Verify Testing Business Name
            FindElement(By.Name("CompanyName")).GetAttribute(BusinessName);

            //Verify Business Name Label
            Assert.AreEqual("Business Name", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Business Name')]")).Text);
        }
        public void SelectCompanyType()
        {
            //Select Company Type
            FindElement(By.Name("CompanyTypeId")).ComboBox().SelectByText(CompanyTypeAgency);
            WaitUntilLoaded();

            // Verify Company Type Label
            Assert.AreEqual("Company Type", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Company Type')]")).Text);
        }
        public void SelectCompanyGroup()
        {
            //Select Company Group
            FindElement(By.Name("CompanyGroupId")).ComboBox().SelectByIndex(1);
            WaitUntilLoaded();

            // Verify Company Group Label
            Assert.AreEqual("Company Group", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Company Group')]")).Text);
        }
        public void EnteralsoKnownAs()
        {
            //Enter Also Known As
            FindElement(By.Name("text")).SendKeys(AKAKnownAs);
            WaitUntilLoaded();

            //Select +
            FindElement(By.XPath("//*[@id='content']/div/div[1]/div/include-js/div/controller-data/div/div/ng-form/div/div[1]/div[3]/div[1]/div[2]/a")).Click();

            //Verify Also Known As Label
            Assert.AreEqual("Also Known As", FindElement(By.XPath("//span[text()='Also Known As']")).Text);
        }
        public void EnterCountry()
        {
            //Enter Country           
            FindElement(By.Name("CountryCode")).ComboBox().SelectByText(Country);

            //Verify Country/Region Label
            Assert.AreEqual("Country/Region", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Country/Region')]")).Text);
        }
        public void EnterAddress1()
        {
            //Enter Address 1
            IWebElement ElementAddress1 = FindElement(By.Name("AddressLine1"));
            ElementAddress1.Clear();
            ElementAddress1.SendKeys(Address1);

            Assert.AreEqual(Address1, ElementAddress1.GetAttribute("value"));
            WaitUntilCurtain();

            //Verify Address 1 Label
            Assert.AreEqual("Address 1", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Address 1')]")).Text);
        }
        public void EnterAddress2()
        {
            //Enter Address 2
            IWebElement ElementAddress2 = FindElement(By.Name("AddressLine2"));
            ElementAddress2.Clear();
            ElementAddress2.SendKeys(Address2);

            Assert.AreEqual(Address2, ElementAddress2.GetAttribute("value"));
            WaitUntilCurtain();

            //Verify Address 2 Label
            Assert.AreEqual("Address 2", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Address 2')]")).Text);
        }
        public void EnterCity()
        {
            //Enter City
            IWebElement ElementCity = FindElement(By.Name("City"));
            ElementCity.Clear();
            ElementCity.SendKeys(City);

            //Verify City
            Assert.AreEqual(City, FindElement(By.Name("City")).GetAttribute("value"));

            //Verify City Label
            Assert.AreEqual("City", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'City')]")).Text);
        }
        public void EnterStateProvince()
        {
            //Select State/Province
            FindElement(By.Name("StateCountryCode")).ComboBox().SelectByIndex(5);
            WaitUntilLoaded();

            //Verify State/Province
            FindElement(By.Name("StateCountryCode")).GetAttribute(State);

            //Verify State/Province Label
            Assert.AreEqual("State/Province", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'State/Province')]")).Text);
        }
        public void EnterPostalCode()
        {
            //Enter Postal Code
            IWebElement ElementPostalCode = FindElement(By.Name("PostalCode"));
            ElementPostalCode.Clear();
            ElementPostalCode.SendKeys(PostalCode);

            //Verify Postal Code
            Assert.AreEqual(PostalCode, FindElement(By.Name("PostalCode")).GetAttribute("value"));

            //Verify Postal Code Label
            Assert.AreEqual("Postal Code", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Postal Code')]")).Text);
        }
        public void EnterWebSite()
        {
            //Enter Web Site
            IWebElement ElementWebSite = FindElement(By.Name("WebSite"));
            ElementWebSite.Clear();
            ElementWebSite.SendKeys(WebSite);

            //Verify Web Site Label
            Assert.AreEqual("Web Site", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Web Site')]")).Text);
        }
        public void VerifyCheckMarks()
        {
            //Verify Check Mark Data Source Unchecked      
            IWebElement CheckMarkDataSource = FindElement(By.XPath("//input[contains(@ng-model, 'companiesNewEdit.company.IsDataSource')]"));
            Assert.IsFalse(CheckMarkDataSource.Selected);

            //Verify Data Source Label
            Assert.AreEqual("Data Source", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Data Source')]")).Text);

            //Verify Customer Unchecked      
            IWebElement CheckMarkCustomer = FindElement(By.XPath("//input[contains(@ng-model, 'companiesNewEdit.company.IsCustomer')]"));
            //            Assert.IsFalse(CheckMarkCustomer.Selected);

            //Verify Customer Label
            Assert.AreEqual("Customer", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Customer')]")).Text);

            //Verify Inactive Unchecked      
            IWebElement CheckMarkInactive = FindElement(By.XPath("//input[contains(@ng-model, 'companiesNewEdit.company.IsActive')]"));
            Assert.IsFalse(CheckMarkInactive.Selected);

            //Verify Inactive Label
            Assert.AreEqual("Inactive", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Inactive')]")).Text);

            //Verify Data Agreement Unchecked      
            IWebElement CheckMarkDataAgreement = FindElement(By.XPath("//input[contains(@ng-model, 'companiesNewEdit.company.HasDataAgreement')]"));
            Assert.IsFalse(CheckMarkDataAgreement.Selected);

            //Verify Data Agreement Label
            Assert.AreEqual("Data Agreement", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Data Agreement')]")).Text);

            //Verify Data Unmasked Is Checked
            Assert.IsTrue(FindElement(By.XPath("//input[contains(@class, 'spark-checkbox__input')][contains(@ng-model, 'companiesNewEdit.company.IsDataUnmasked')]")).Selected);

            //Verify Data UnMasked Label
            Assert.AreEqual("Data UnMasked", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Data UnMasked')]")).Text);

            //Verify Passenger Masked Unchecked      
            IWebElement CheckMarkPassengerMasked = FindElement(By.XPath("//input[contains(@ng-model, 'companiesNewEdit.company.IsPassengerNameMasked')]"));
            Assert.IsFalse(CheckMarkPassengerMasked.Selected);

            //Verify Passenger Masked Label
            Assert.AreEqual("Passenger Masked", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Passenger Masked')]")).Text);            
        }
    }
}