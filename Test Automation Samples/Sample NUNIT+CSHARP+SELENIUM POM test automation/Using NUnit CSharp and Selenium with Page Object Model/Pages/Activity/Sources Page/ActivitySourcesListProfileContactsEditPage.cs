using System;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace DCC
{

    public class ActivitySourcesListProfileContactsEditPage : TestBase
    {
        public ActivitySourcesListProfileContactsEditPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ActivitySourcesListProfileContacts_Edit()
        {         
            PageObject pageObject = new PageObject(driver);
            Initialize ActivitySourcesInitialize = new Initialize(driver);         

            //Enter First Name
            IWebElement FirstName = FindElement(By.Name("FirstName"));
            FirstName.Clear();
            FirstName.SendKeys("OTesting First");
            //Verify Max length
            String FirstNameactualLimit = FirstName.GetAttribute("maxlength");
            Assert.AreEqual(FirstNameactualLimit, "15");          

            //Enter Last Name
            IWebElement LastName = FindElement(By.Name("LastName"));
            LastName.Clear();
            LastName.SendKeys("OTesting Last Name");
            //Verify Max length
            String LastNameactualLimit = LastName.GetAttribute("maxlength");
            Assert.AreEqual(LastNameactualLimit, "20");    

            //Select Mr/Mrs
            FindElement(By.Name("NameTitle")).Click();
            WaitUntilCurtain();
            FindElement(By.Name("NameTitle")).SendKeys("Mr.");

            //Enter Title
            FindElement(By.Name("JobTitle")).Clear();
            FindElement(By.Name("JobTitle")).SendKeys("Testing Title");

            //Select Company
            //FindElement(By.Name("CompanyId")).Click();
            //wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));
            //FindElement(By.XPath("//span[contains(text(), '1-800-Flowers')][contains(@ng-class, '!item.IsActive')]")).Click();

            WaitUntilCurtain();


            //Select Role
            FindElement(By.Name("RoleId")).Click();
            WaitUntilCurtain();
            FindElement(By.Name("RoleId")).SendKeys("MIS Director");


            //Enter Department
            FindElement(By.Name("Department")).Clear();
            FindElement(By.Name("Department")).SendKeys("Testing Department");

        
            //Select Reports To
            //FindElement(By.Name("ReportsToId")).Click();
            //WaitUntilCurtain();
            //FindElement(By.XPath("//span[contains(text(), 'tiedemann, julie')][contains(@ng-class, '!item.IsActive')]")).Click();


         
            //Select Assistant
            //pageObject.MGAssistant.Click();
            //WaitUntilCurtain();
            //FindElement(By.XPath("//span[contains(text(), 'tiedemann, julie')][contains(@ng-class, '!item.IsActive')]")).Click();

       
            //Select Country
             FindElement(By.Name("CountryCode")).Click();
            WaitUntilCurtain();
             FindElement(By.Name("CountryCode")).SendKeys("Australia (AU)");

            //Enter Address 1
            IWebElement Address1 = FindElement(By.Name("AddressLine1"));
            Address1.Clear();
            Address1.SendKeys("Testing Address 1");
            //Verify Max length
            String Address1actualLimit = Address1.GetAttribute("maxlength");
            Assert.AreEqual(Address1actualLimit, "75");

            //Enter Address 2
            IWebElement Address2 = FindElement(By.Name("AddressLine2"));
            Address2.Clear();
            Address2.SendKeys("Testing Address 2");
            //Verify Max length
            String Address2actualLimit = Address2.GetAttribute("maxlength");
            Assert.AreEqual(Address2actualLimit, "75");

          
            //Enter City
            FindElement(By.Name("City")).Clear();
            FindElement(By.Name("City")).SendKeys("Testing City");

            new SelectElement(driver.FindElement(By.Name("StateCountryCode"))).SelectByText("British Columbia");
            //FindElement(By.Name("StateCountryCode")).ComboBox().SelectByIndex(4);

          
            //Enter Postal Code
            FindElement(By.Name("PostalCode")).Clear();
            FindElement(By.Name("PostalCode")).SendKeys("123454");

          
            //Enter Phone
            FindElement(By.Name("WorkPhoneNumber")).Clear();
            FindElement(By.Name("WorkPhoneNumber")).SendKeys("1-800callme");

            //Enter Phone Ext
            FindElement(By.Name("WorkPhoneNumberExtension")).Clear();
            FindElement(By.Name("WorkPhoneNumberExtension")).SendKeys("1-800callme");

            //Enter Toll Free
            FindElement(By.Name("TollFreePhoneNumber")).Clear();
            FindElement(By.Name("TollFreePhoneNumber")).SendKeys("1-800callme");

           
            //Enter Toll Free Ext
            FindElement(By.Name("TollFreePhoneNumberExtension")).Clear();
            FindElement(By.Name("TollFreePhoneNumberExtension")).SendKeys("1-800callme");

            //Enter Fax
            FindElement(By.Name("FaxPhoneNumber")).Clear();
            FindElement(By.Name("FaxPhoneNumber")).SendKeys("1-800callme");

            //Enter Cell Phone
            FindElement(By.Name("CellPhoneNumber")).Clear();
            FindElement(By.Name("CellPhoneNumber")).SendKeys("1-800callme");

            //Enter Email
            FindElement(By.Name("WorkEmailAddress")).Clear();
            FindElement(By.Name("WorkEmailAddress")).SendKeys("yvonne.gates@sabre.com");

            //Enter Alternate Phone
            FindElement(By.Name("AlternatePhoneNumber")).Clear();
            FindElement(By.Name("AlternatePhoneNumber")).SendKeys("1-800callme");

            //Enter Notes
            FindElement(By.Name("Notes")).Clear();
            FindElement(By.Name("Notes")).SendKeys("Testing Notes");

            //Verify State/Province Field Title Displays
            Assert.AreEqual("State/Province", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'State/Province')]")).Text);

            // Verify Testing First Name
            Assert.AreEqual("OTesting First", FindElement(By.Name("FirstName")).GetAttribute("value"));

            // Verify Testing Last Name            
            Assert.AreEqual("OTesting Last Name", FindElement(By.Name("LastName")).GetAttribute("value"));

            //Verify MrMrs
            Assert.AreEqual("string:Mr.", FindElement(By.Name("NameTitle")).GetAttribute("value"));

            // Verify Title
            Assert.AreEqual("Testing Title", FindElement(By.Name("JobTitle")).GetAttribute("value"));

            //Verify Company
            Assert.AreEqual("Otrar Travel", FindElement(By.XPath("//span[contains(@ng-bind, 'contactsNewEdit.contact.CompanyName')]")).Text);

            //Verify Role
            Assert.AreEqual("number:6", FindElement(By.Name("RoleId")).GetAttribute("value"));

            //Verify Department
            Assert.AreEqual("Testing Department", FindElement(By.Name("Department")).GetAttribute("value"));

            //Verify Reports To
            //Assert.AreEqual("test, test", FindElement(By.XPath("//span[contains(@ng-bind, 'contactsNewEdit.contact.ReportsToFullName')]")).GetAttribute("value"));

            //Verify Assistant
            //Assert.AreEqual("test, test", FindElement(By.XPath("//span[contains(@ng-bind, 'contactsNewEdit.contact.AssistantFullName')]")).GetAttribute("value"));

            //Verify Country
            Assert.AreEqual("string:AU",  FindElement(By.Name("CountryCode")).GetAttribute("value"));

            //Verify Address 1
            Assert.AreEqual("Testing Address 1", FindElement(By.Name("AddressLine1")).GetAttribute("value"));

            //Verify Address 2
            Assert.AreEqual("Testing Address 2", FindElement(By.Name("AddressLine2")).GetAttribute("value"));

            //Verify City
            Assert.AreEqual("Testing City", FindElement(By.Name("City")).GetAttribute("value"));

            //Verify State/Province
            //Assert.AreEqual("string:AU,VIC", FindElement(By.Name("StateCountryCode")).GetAttribute("value"));

            //Verify Postal Code
            Assert.AreEqual("123454", FindElement(By.Name("PostalCode")).GetAttribute("value"));

            //Verify Phone
            Assert.AreEqual("1-800callme", FindElement(By.Name("WorkPhoneNumber")).GetAttribute("value"));

            //Verify Phone Ext
            Assert.AreEqual("1-800ca", FindElement(By.Name("WorkPhoneNumberExtension")).GetAttribute("value"));

            //Verify Toll Free
            Assert.AreEqual("1-800callme", FindElement(By.Name("TollFreePhoneNumber")).GetAttribute("value"));

            //Verify Toll Free Ext
            Assert.AreEqual("1-800ca", FindElement(By.Name("TollFreePhoneNumberExtension")).GetAttribute("value"));

            //Verify Fax
            Assert.AreEqual("1-800callme", FindElement(By.Name("FaxPhoneNumber")).GetAttribute("value"));

            //Verify Cell Phone
            Assert.AreEqual("1-800callme", FindElement(By.Name("CellPhoneNumber")).GetAttribute("value"));

            //Verify Email
            Assert.AreEqual("yvonne.gates@sabre.com", FindElement(By.Name("WorkEmailAddress")).GetAttribute("value"));     

            //Verify Alternate Phone
            Assert.AreEqual("1-800callme", FindElement(By.Name("AlternatePhoneNumber")).GetAttribute("value"));         

            //Verify Notes
            Assert.AreEqual("Testing Notes", FindElement(By.Name("Notes")).GetAttribute("value"));

            //Click Cancel
            pageObject.ClickButtonTitleCancel();
            WaitUntilCurtain();

            //Verify Taken Back to Contacts list Page
            Assert.AreEqual("Data Source: Contacts", FindElement(By.XPath("//h2[contains(text(), 'Data Source: Contacts')]")).Text);
            WaitUntilCurtain();

            //Highlight Contact
            //pageObject.HighlightLastNameRow.Click();
            WaitUntilCurtain();
        }      
    }
}


