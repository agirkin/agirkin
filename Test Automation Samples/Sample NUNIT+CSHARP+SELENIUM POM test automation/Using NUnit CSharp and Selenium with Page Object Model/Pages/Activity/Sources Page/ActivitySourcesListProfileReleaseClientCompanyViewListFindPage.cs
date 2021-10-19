using OpenQA.Selenium;
using NUnit.Framework;
using System.Configuration;
using System;

namespace DCC
{
    public class ActivitySourcesListProfileReleaseClientCompanyViewListFindPage : TestBase
    {
        public ActivitySourcesListProfileReleaseClientCompanyViewListFindPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string Agency = ConfigurationManager.AppSettings["Agency"];
        public string ClientCompany = ConfigurationManager.AppSettings["ClientCompany"];
        public string DCCCompany = ConfigurationManager.AppSettings["DCCCompany"];
        public void ActivitySourcesListProfileReleaseClientCompanyViewList_Find()
        {
            //Select List Refresh        
            PageObject pageObject = new PageObject(driver);
            pageObject.RefreshIcon();
            WaitUntilCurtain();

            Assert.AreEqual("Data Source", FindElement(By.XPath("//h2[contains(text(), 'Data Source')]")).Text);

            //Select List Reset Sorting
            pageObject.ListResetSorting();

            //Company Contains Testing 
            Find find = new Find(driver);
            find.FindBasicTwoPlus();
            find.BasicFind("Agency", "contains", Agency);
            find.ClickSearch();

            //Highlight Row
            FindElement(By.XPath("(//div[contains(text(), '" + Agency + "')][@class='ui-grid-cell-contents ng-binding ng-scope'])[1]")).Click();

            //Click Profile Button
            pageObject.ClickProfile();
            WaitUntilCurtain();

            //Click View Button
            pageObject.ClickButtonView();
            WaitUntilCurtain();

            //Click Release Button
            pageObject.ClickButtonRelease();
            WaitUntilCurtain();

            Assert.AreEqual("Data Source: Release", FindElement(By.XPath("//h2[contains(text(), 'Data Source: Release')]")).Text);
            WaitUntilCurtain();

            //Client Company Contains 
            find.FindBasic();
            find.BasicFindClear("Client Company", "Contains", ClientCompany);
            find.ClickSearch();
            WaitUntilCurtain();

            //Client Company Does Not Contain 
            find.FindBasic();
            find.BasicFindClear("Client Company", "Does Not Contains", ClientCompany);
            find.ClickSearch();
            WaitUntilCurtain();

            Assert.IsFalse(driver.PageSource.Contains(ClientCompany));

            //Client Company Equals 
            find.FindBasic();
            find.BasicFindClear("Client Company", "Equals", ClientCompany);
            find.ClickSearch();
            WaitUntilCurtain();

            //Assert.IsTrue(driver.PageSource.Contains("Chevron Inc."));

            //Client Company Not Equals 
            find.FindBasic();
            find.BasicFindClear("Client Company", "Not Equals", ClientCompany);
            find.ClickSearch();
            WaitUntilCurtain();

            Assert.IsFalse(driver.PageSource.Contains(ClientCompany));

            //Client Company Starts With 
            find.FindBasic();
            find.BasicFindClear("Client Company", "Starts With", ClientCompany);
            find.ClickSearch();
            WaitUntilCurtain();

            Assert.IsTrue(driver.PageSource.Contains(ClientCompany));

            //Client Company Does Not Start With 
            find.FindBasic();
            find.BasicFindClear("Client Company", "Does Not Start With", ClientCompany);
            find.ClickSearch();
            WaitUntilCurtain();

            Assert.IsFalse(driver.PageSource.Contains(ClientCompany));

            //Client Company Ends With 
            find.FindBasic();
            find.BasicFindClear("Client Company", "Ends With", ClientCompany);
            find.ClickSearch();
            WaitUntilCurtain();

            //Assert.IsTrue(driver.PageSource.Contains("Chevron Inc."));

            //Client Company Does Not End With 
            find.FindBasic();
            find.BasicFindClear("Client Company", "Does not end with", ClientCompany);
            find.ClickSearch();
            WaitUntilCurtain();

            //Assert.IsFalse(driver.PageSource.Contains("Global"));

            //DCC Company Contains;
            find.FindBasic();
            find.BasicFindClear("DCC Company", "Contains", DCCCompany);
            find.ClickSearch();
            WaitUntilCurtain();
            find.FindContains("DCC Company", "Contains", DCCCompany);

            //DCC Company Does Not Contain                                 
            find.FindBasic();
            find.BasicFindClear("DCC Company", "Does Not Contain", DCCCompany);
            find.ClickSearch();
            WaitUntilCurtain();

            //Assert.IsFalse(driver.PageSource.Contains("Chevron"));

            //DCC Company Equals 
            find.FindBasic();
            find.BasicFindClear("DCC Company", "Equals", DCCCompany);
            find.ClickSearch();
            WaitUntilCurtain();

            //Assert.IsTrue(driver.PageSource.Contains("Chevron"));

            //DCC Company Not Equals 
            find.FindBasic();
            find.BasicFindClear("DCC Company", "Not Equals", DCCCompany);
            find.ClickSearch();
            WaitUntilCurtain();

            //DCC Company Starts With 
            find.FindBasic();
            find.BasicFindClear("DCC Company", "Starts with", DCCCompany);
            find.ClickSearch();
            WaitUntilCurtain();
            //Assert.IsTrue(driver.PageSource.Contains("AChevron Inc."));

            //DCC Company Does Not Start With           
            find.FindBasic();
            find.BasicFindClear("DCC Company", "Does Not Starts with", DCCCompany);
            find.ClickSearch();
            WaitUntilCurtain();
            Assert.IsFalse(driver.PageSource.Contains(DCCCompany));

            //DCC Company Ends With            
            find.FindBasic();
            find.BasicFindClear("DCC Company", "Ends with", DCCCompany);
            find.ClickSearch();
            WaitUntilCurtain();
            //Assert.IsTrue(driver.PageSource.Contains("Chevron"));

            //DCC Company Does Not End With 
            find.FindBasic();
            find.BasicFindClear("DCC Company", "Does Not End with", DCCCompany);
            find.ClickSearch();
            WaitUntilCurtain();
            //Assert.IsFalse(driver.PageSource.Contains("Chevron"));

            //Client Equals
            find.FindBasic();
            find.BasicFindwdropdown("Client", "Equals", "Chevron");
            find.ClickSearch();
            WaitUntilCurtain();

            //Client Not Equals
            find.FindBasic();
            find.BasicFindwdropdown("Client", "Not equals", "Chevron");
            find.ClickSearch();
            WaitUntilCurtain();

            //Carriers Contains           
            find.FindBasic();
            find.BasicFindClear("Carriers", "Contains", "DL");
            find.ClickSearch();
            WaitUntilCurtain();

            //Assert.IsTrue(driver.PageSource.Contains("DL"));

            //Lead Carrier Equals 
            find.FindBasic();
            find.BasicFindwdropdown("Lead Carrier", "Equals", "DL");
            find.ClickSearch();
            WaitUntilCurtain();

            find.FindContains("Lead Carrier", "Equals", "DL");

            //Lead Carrier Not Equals             
            find.FindBasic();
            find.BasicFindwdropdown("Lead Carrier", "Not equals", "DL");
            find.ClickSearch();
            WaitUntilCurtain();

            //Assert.IsFalse(driver.PageSource.Contains("DL"));

            ////Request Date Equals
            //find.FindBasic();();

            //var RequestDateEquals = new Find(driver);
            //RequestDateEquals.BasicFind("Request Date", "Equals", "11012015");

            //ClickSearch.ClickSearch();

            ////Request Date Greater than
            //find.FindBasic();();

            //var RequestDateGreaterThan = new Find(driver);
            //RequestDateGreaterThan.BasicFind("Request Date", "Greater than", "11012015");

            //ClickSearch.ClickSearch();

            ////Request Date Greater than or equal
            //find.FindBasic();();

            //var RequestDateGreaterThanorequal = new Find(driver);
            //RequestDateGreaterThanorequal.BasicFind("Request Date", "Greater than or equal", "11012015");

            //ClickSearch.ClickSearch();


            ////Request Date Less than
            //find.FindBasic();();

            //var RequestDateLessThan = new Find(driver);
            //RequestDateLessThan.BasicFind("Request Date", "Less than", "11012015");

            //ClickSearch.ClickSearch();

            ////Request Date Less than or equal
            //find.FindBasic();();

            //var RequestDateLessThanorequal = new Find(driver);
            //RequestDateLessThanorequal.BasicFind("Request Date", "Less than or equal", "11012015");

            //ClickSearch.ClickSearch();

            //Data Status Equals
            find.FindBasic();
            find.BasicFindwdropdown("Data Status", "Equals", "9. New");
            find.ClickSearch();
            WaitUntilCurtain();

            //Data Status Not Equals
            find.FindBasic();
            find.BasicFindwdropdown("Data Status", "Not equals", "9. New");
            find.ClickSearch();
            WaitUntilCurtain();

            //Release Type Equals             
            find.FindBasic();
            find.BasicFindwdropdown("Release Type", "Equals", "Agency");
            find.ClickSearch();
            WaitUntilCurtain();

            Assert.IsTrue(driver.PageSource.Contains("Agency"));

            //Release Type Not Equals 
            find.FindBasic();
            find.BasicFindwdropdown("Release Type", "Not equals", "Agency");
            find.ClickSearch();
            WaitUntilCurtain();

            Assert.IsTrue(driver.PageSource.Contains("Corporate"));

            

            //Suspended Equals No Find
            find.FindBasic();
            find.BasicFindwdropdown("Suspended", "Equals", "No");
            find.ClickSearch();
            WaitUntilCurtain();

            //Suspended Equals yes Find
            find.FindBasic();
            find.BasicFindwdropdown("Suspended", "Equals", "Yes");
            find.ClickSearch();
            WaitUntilCurtain();

            //Suspended Not Equals No Find
            find.FindBasic();
            find.BasicFindwdropdown("Suspended", "Not Equals", "No");
            find.ClickSearch();
            WaitUntilCurtain();

            //Suspended Not Equals Yes 
            find.FindBasic();
            find.BasicFindwdropdown("Suspended", "Not Equals", "Yes");
            find.ClickSearch();
            WaitUntilCurtain();

            //Changed By Contains 
            find.FindBasic();
            find.BasicFindClear("Changed By", "Contains", "Gates");
            find.ClickSearch();
            WaitUntilCurtain();
            driver.PageSource.Contains("Gates");

            //Changed By Does Not Contain 
            find.FindBasic();
            find.BasicFindClear("Changed By", "Does Not Contain", "Gates");
            find.ClickSearch();
            WaitUntilCurtain();

            //Assert.IsFalse(driver.PageSource.Contains("Gates"));

            //Changed By Equals 
            find.FindBasic();
            find.BasicFindClear("Changed By", "Equals", "Gates");
            find.ClickSearch();
            WaitUntilCurtain();
            driver.PageSource.Contains("Gates");

            //Changed By Not Equals 
            find.FindBasic();
            find.BasicFindClear("Changed By", "Not Equals Contains", "Gates");
            find.ClickSearch();
            WaitUntilCurtain();
            driver.PageSource.Contains("Gates");

            //Changed By Starts With 
            find.FindBasic();
            find.BasicFindClear("Changed By", "Starts With", "Gates");
            find.ClickSearch();
            WaitUntilCurtain();
            driver.PageSource.Contains("Gates");

            //Changed By Does Not Start With 
            find.FindBasic();
            find.BasicFind("Changed By", "Does Not Starts With", "Gates");
            find.ClickSearch();
            WaitUntilCurtain();
            driver.PageSource.Contains("Gates");

            //Changed By Ends With 
            find.FindBasic();
            find.BasicFindClear("Changed By", "Does Not Starts With", "Gates");
            find.ClickSearch();
            WaitUntilCurtain();
            driver.PageSource.Contains("Gates");

            //Changed By Does Not End With 
            find.FindBasic();
            find.BasicFind("Changed By", "Does Not End With", "Gates");
            find.ClickSearch();
            WaitUntilCurtain();
            driver.PageSource.Contains("Gates");

            //Expired Equals No Find
            find.FindBasic();
            find.BasicFindwdropdown("Expired", "Equals", "No");
            find.ClickSearch();
            WaitUntilCurtain();

            //Expired Equals yes Find
            find.FindBasic();
            find.BasicFindwdropdown("Expired", "Equals", "No");
            find.ClickSearch();
            WaitUntilCurtain();

            //Expired Not Equals No Find
            find.FindBasic();
            find.BasicFindwdropdown("Expired", "Not Equals", "No");
            find.ClickSearch();
            WaitUntilCurtain();

            //Expired Not Equals Yes Find          
            find.FindBasic();
            find.BasicFindwdropdown("Expired", "Not Equals", "No");
            find.ClickSearch();
            WaitUntilCurtain();
        }
    }
}


