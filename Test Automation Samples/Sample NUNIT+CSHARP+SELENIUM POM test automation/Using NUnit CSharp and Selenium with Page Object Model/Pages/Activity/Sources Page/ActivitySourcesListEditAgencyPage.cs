using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;

namespace DCC
{  
    public class ActivitySourcesListEditAgencyPage : TestBase
    {
        public ActivitySourcesListEditAgencyPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement Address1 => FindElement(By.Name("AddressLine1"));
        public IWebElement Address2 => FindElement(By.Name("AddressLine2"));
        public void ActivitySourcesList_EditAgency()
        {                  
            //Highlight Agency
            Actions Highlight = new Actions(driver);
            Highlight.MoveToElement(FindElement(By.XPath("(//div[@class='ui-grid-cell-contents ng-binding ng-scope'])[1]"))).Click().Build().Perform();       
            WaitUntilCurtain();

            //Click Edit Agency Button
            PageObject pageObject = new PageObject(driver);
            pageObject.ClickButtonEditAgency();
            WaitUntilCurtain();

            //Verify Edit Company Displays
            Assert.AreEqual("Edit Company", FindElement(By.XPath("//h2[contains(text(), 'Edit Company')]")).Text);

            //Click Cancel
            pageObject.ClickButtonTitleCancel();
            WaitUntilCurtain();

            //Verify Taken Back to Data Source list Page
            Assert.AreEqual("Data Source", FindElement(By.XPath("//h2[contains(text(), 'Data Source')]")).Text);
            WaitUntilCurtain();
            
            //Click Edit Button
            WaitUntilCurtain();
            pageObject.ClickButtonEditAgency();
            WaitUntilCurtain();            

            //Verify Edit Company Displays
            Assert.AreEqual("Edit Company", FindElement(By.XPath("//h2[contains(text(), 'Edit Company')]")).Text);
            WaitUntilCurtain();           

            //Clear Legal Name field
            FindElement(By.Name("LegalName")).Clear();
            Assert.AreEqual("Required", FindElement(By.XPath("//span[contains(@class, 'spark-select__message ng-scope')][contains(@ng-if, 'companiesNewEdit.companyForm.LegalName.$error.dccrequired && (!companiesNewEdit.companyForm.LegalName.$pristine || companiesNewEdit.submitted')]")).Text);
            WaitUntilCurtain();

            FindElement(By.Name("CompanyName")).Clear();
            // Verify Business Name Required
            Assert.AreEqual("Required", FindElement(By.XPath("//span[contains(@class, 'spark-select__message ng-scope')][contains(@ng-if, 'companiesNewEdit.companyForm.CompanyName.$error.dccrequired && (!companiesNewEdit.companyForm.CompanyName.$pristine || companiesNewEdit.submitted)')]")).Text);
            WaitUntilCurtain();

            Address1.Clear();
            // Verify Address 1 Required
            Assert.AreEqual("Required", FindElement(By.XPath("//span[contains(@class, 'spark-select__message')][contains(@ng-if, 'companiesNewEdit.CompanyAddressForm.AddressLine1.$error.dccrequired && (!companiesNewEdit.CompanyAddressForm.AddressLine1.$pristine || companiesNewEdit.submitted)')]")).Text);
            WaitUntilCurtain();

            FindElement(By.Name("City")).Clear();
            // Verify City Required
            Assert.AreEqual("Required", FindElement(By.XPath("//span[contains(@class, 'spark-select__message')][contains(@ng-if, 'companiesNewEdit.CompanyAddressForm.City.$error.dccrequired && (!companiesNewEdit.CompanyAddressForm.City.$pristine || companiesNewEdit.submitted)')]")).Text);
            WaitUntilCurtain();

            //Enter Legal Name
            FindElement(By.Name("LegalName")).SendKeys("Automation");

            //Enter Business Name
            FindElement(By.Name("CompanyName")).SendKeys("Automation");

            //Select Company Type
            Actions SelectCompanyType = new Actions(driver);
            SelectCompanyType.MoveToElement(FindElement(By.Name("CompanyTypeId"))).Click().Build().Perform();         
            WaitUntilCurtain();
            FindElement(By.Name("CompanyTypeId")).SendKeys("Agency");

            //Select Country
            Actions SelectCountry = new Actions(driver);
            SelectCountry.MoveToElement(FindElement(By.Name("CountryCode"))).Click().Build().Perform();
            WaitUntilCurtain();
             FindElement(By.Name("CountryCode")).SendKeys("S. Georgia / S. Sandwich Isls.");

            //Enter Address 1
            Address1.SendKeys("Testing Address 1");

            //Enter Address 2
            Address2.Clear();
            Address2.SendKeys("Testing Address 2");

            //Enter City
            FindElement(By.Name("City")).Clear();
            FindElement(By.Name("City")).SendKeys("Testing City");

            //Enter Postal Code
            FindElement(By.Name("PostalCode")).Clear();
            FindElement(By.Name("PostalCode")).SendKeys("PostalCode");

            //EnterWeb Site
            FindElement(By.Name("WebSite")).Clear();
            FindElement(By.Name("WebSite")).SendKeys("http://www.anything.com");

            //Verify Data Unmasked Is Checked
            Assert.IsTrue(driver.FindElement(By.XPath("//input[contains(@class, 'spark-checkbox__input')][contains(@ng-model, 'companiesNewEdit.company.IsDataUnmasked')]")).Selected);
            
            // Verify Testing Legal Name
            Assert.AreEqual("Automation", FindElement(By.Name("LegalName")).GetAttribute("value"));

            // Verify Testing Business Name
            Assert.AreEqual("Automation", FindElement(By.Name("CompanyName")).GetAttribute("value"));

            //Verify Agency           
            //Assert.AreEqual("1", pageObject.DDLCompanyType.GetAttribute("value"));

            //Verify Address 
            Assert.AreEqual("Testing Address 1", Address1.GetAttribute("value"));

            //Verify Address 2
            Assert.AreEqual("Testing Address 2", Address2.GetAttribute("value"));

            //Verify City
            Assert.AreEqual("Testing City", FindElement(By.Name("City")).GetAttribute("value"));

            //Verify Postal Code
            Assert.AreEqual("PostalCode", FindElement(By.Name("PostalCode")).GetAttribute("value"));

            //Verify Web Site           
            Assert.AreEqual("http://www.anything.com", FindElement(By.Name("WebSite")).GetAttribute("value"));

            //Click Save
            WaitUntilCurtain();
            pageObject.ClickButtonTitleSave();
            WaitUntilCurtainninety();

            IList<IWebElement> Aduplicate = driver.FindElements(By.XPath("//div[text()='Business Name already exists.']"));
            if (Aduplicate.Count > 0 && Aduplicate[0].Displayed)
            {
                pageObject.ClickButtonTitleCancel();

                WaitUntilCurtain();
            }
            else { }
           

            //Verify Taken Back to Data Source list Page
            Assert.AreEqual("Data Source", FindElement(By.XPath("//h2[contains(text(), 'Data Source')]")).Text);

            //Company Contains Testing   
            Find find = new Find(driver);
            find.FindBasicTwoPlus();
            find.BasicFind("Agency", "Equals", "Automation");
            find.ClickSearch();
            WaitUntilCurtain();

            //Highlight Agency
            Actions HighlightAgency = new Actions(driver);
            HighlightAgency.MoveToElement(FindElement(By.XPath("//div[@class='ui-grid-row ng-scope'][1]"))).Click().Build().Perform();
            WaitUntilCurtain();

            //Click Edit Agency Button
            WaitUntilCurtain();
            pageObject.ClickButtonEditAgency();
            WaitUntilCurtainsixty();            

            //Verify Edit Company Displays
            Assert.AreEqual("Edit Company", WaitbyXPathVisible(driver, "//h2[contains(text(), 'Edit Company')]").Text);
            WaitUntilCurtain();

            // Verify Testing Legal Name
            Assert.AreEqual("Automation", FindElement(By.Name("LegalName")).GetAttribute("value"));

            // Verify Testing Business Name
            Assert.AreEqual("Automation", FindElement(By.Name("CompanyName")).GetAttribute("value"));

            //Verify Agency           
            //Assert.AreEqual("1", pageObject.DDLCompanyType.GetAttribute("value"));

            //Verify Address 
            Assert.AreEqual("Testing Address 1", Address1.GetAttribute("value"));

            //Verify Address 2
            Assert.AreEqual("Testing Address 2", Address2.GetAttribute("value"));

            //Verify City
            Assert.AreEqual("Testing City", FindElement(By.Name("City")).GetAttribute("value"));

            //Verify Postal Code
            Assert.AreEqual("PostalCode", FindElement(By.Name("PostalCode")).GetAttribute("value"));

            //Click Save
            //pageObject.ClickButtonTitleSave();
            WaitUntilCurtain();

            //Clear Legal Name field
            FindElement(By.Name("LegalName")).Clear();
            Assert.AreEqual("Required", driver.FindElement(By.XPath("//span[contains(@class, 'spark-select__message ng-scope')][contains(@ng-if, 'companiesNewEdit.companyForm.LegalName.$error.dccrequired && (!companiesNewEdit.companyForm.LegalName.$pristine || companiesNewEdit.submitted')]")).Text);
            WaitUntilCurtain();

            // Verify Business Name Required
            FindElement(By.Name("CompanyName")).Clear();
            Assert.AreEqual("Required", driver.FindElement(By.XPath("//span[contains(@class, 'spark-select__message ng-scope')][contains(@ng-if, 'companiesNewEdit.companyForm.CompanyName.$error.dccrequired && (!companiesNewEdit.companyForm.CompanyName.$pristine || companiesNewEdit.submitted)')]")).Text);
            WaitUntilCurtain();

            FindElement(By.Name("AddressLine1")).Clear();
            // Verify Address 1 Required
            Assert.AreEqual("Required", driver.FindElement(By.XPath("//span[contains(@class, 'spark-select__message')][contains(@ng-if, 'companiesNewEdit.CompanyAddressForm.AddressLine1.$error.dccrequired && (!companiesNewEdit.CompanyAddressForm.AddressLine1.$pristine || companiesNewEdit.submitted)')]")).Text);
            WaitUntilCurtain();

            FindElement(By.Name("City")).Clear();
            // Verify City Required
            Assert.AreEqual("Required", driver.FindElement(By.XPath("//span[contains(@class, 'spark-select__message')][contains(@ng-if, 'companiesNewEdit.CompanyAddressForm.City.$error.dccrequired && (!companiesNewEdit.CompanyAddressForm.City.$pristine || companiesNewEdit.submitted)')]")).Text);
            WaitUntilCurtain();

            //Enter Legal Name
            FindElement(By.Name("LegalName")).SendKeys("Obriy Inc American Express");

            //Enter Business Name
            FindElement(By.Name("CompanyName")).SendKeys("Obriy Inc American Express");

            //Select Company Type
            Actions SelectCompanyType1 = new Actions(driver);
            SelectCompanyType1.MoveToElement(FindElement(By.Name("CompanyTypeId"))).Click().Build().Perform();
            WaitUntilCurtain();
            FindElement(By.Name("CompanyTypeId")).SendKeys("Agency");

            //Select Country
            Actions SelectCountry1 = new Actions(driver);
            SelectCountry1.MoveToElement(FindElement(By.Name("CountryCode"))).Click().Build().Perform();
            WaitUntilCurtain();
             FindElement(By.Name("CountryCode")).SendKeys("Croatia");

            //Enter Address 1
            Address1.Clear();
            Address1.SendKeys("Trg N. Š. Zrinskog 1");

            //Enter Address 2
            Address2.Clear();
            Address2.SendKeys("");

            //Enter City
            FindElement(By.Name("City")).Clear();
            FindElement(By.Name("City")).SendKeys("Zagreb");

            //Enter Postal Code
            FindElement(By.Name("PostalCode")).Clear();
            FindElement(By.Name("PostalCode")).SendKeys("");

            //EnterWeb Site
            FindElement(By.Name("WebSite")).Clear();
            FindElement(By.Name("WebSite")).SendKeys("www.globtour.hr");

            //Verify Data Unmasked Is Checked
            Assert.IsTrue(driver.FindElement(By.XPath("//input[contains(@class, 'spark-checkbox__input')][contains(@ng-model, 'companiesNewEdit.company.IsDataUnmasked')]")).Selected);
            
            // Verify Testing Legal Name
            Assert.AreEqual("Obriy Inc American Express", FindElement(By.Name("LegalName")).GetAttribute("value"));

            // Verify Testing Business Name
            Assert.AreEqual("Obriy Inc American Express", FindElement(By.Name("CompanyName")).GetAttribute("value"));

            //Verify Agency           
            //Assert.AreEqual("1", pageObject.DDLCompanyType.GetAttribute("value"));

            //Verify Address 1
            Assert.AreEqual("Trg N. Š. Zrinskog 1", Address1.GetAttribute("value"));

            //Verify Address 2
            Assert.AreEqual("", Address2.GetAttribute("value"));

            //Verify City
            Assert.AreEqual("Zagreb", FindElement(By.Name("City")).GetAttribute("value"));

            //Verify Postal Code
            Assert.AreEqual("", FindElement(By.Name("PostalCode")).GetAttribute("value"));

            //Verify Web Site
            Assert.AreEqual("www.globtour.hr", FindElement(By.Name("WebSite")).GetAttribute("value"));

            //Click Save
            pageObject.ClickButtonTitleSave();
            WaitUntilCurtain();


            IList<IWebElement> Aduplicate1 = driver.FindElements(By.XPath("//div[text()='Business Name already exists.']"));
            if (Aduplicate1.Count > 0 && Aduplicate1[0].Displayed)
            {
                pageObject.ClickButtonTitleCancel();

                WaitUntilCurtain();
            }
            else { }

            //Verify Taken Back to Data Source list Page
            Assert.AreEqual("Data Source", driver.FindElement(By.XPath("//h2[contains(text(), 'Data Source')]")).Text);
        }
    }
}

