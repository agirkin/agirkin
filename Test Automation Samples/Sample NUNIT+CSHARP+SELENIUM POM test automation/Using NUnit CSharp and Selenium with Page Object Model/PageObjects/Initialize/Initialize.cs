using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;

namespace DCC
{
    public class Initialize : TestBase
    {
        public string Agency = ConfigurationManager.AppSettings["Agency"];
        public string Carrier = ConfigurationManager.AppSettings["Carrier"];
        public string Company = ConfigurationManager.AppSettings["Company"];
        public string CompanyTypeAgency = ConfigurationManager.AppSettings["CompanyTypeAgency"];
        public string DataSource = ConfigurationManager.AppSettings["DataSource"];
        public Initialize(IWebDriver driver)
        {
            this.driver = driver;
        }
       
        public void CloseOpenScreenCloseInitialize()
        {

            PageObject pageObject = new PageObject(driver);

            //Verify Open Screen Label
            Assert.AreEqual("OPEN SCREENS", FindElement(By.XPath("//li[@class='spark-menu__list-title open-screens-title']")).Text);

            //Select > to close open tab
            IWebElement OpenTabArrow = WaitbyXPathVisible(driver, "//li[@class='spark-menu__list-title open-screens-title']/a/i");
            OpenTabArrow.Click();

        }
        public void OpenOpenScreenCloseInitialize()
        {

            PageObject pageObject = new PageObject(driver);

            //Verify Open Screen Label
            Assert.AreEqual("OPEN SCREENS", FindElement(By.XPath("//span[@class='spark-menu__list-title open-screens-title']")).Text);

            //Select > to open open tab
            IWebElement OpenTabArrow = WaitbyXPathVisible(driver, "//div[contains(@class, 'spark-margin-top--lg spark-margin-bottom--lg open-screens ')]/a/i");
            OpenTabArrow.Click();

        }
        [SetUp]
        public void ActivityArchiveFindInitialize()
        {
            Find find = new Find(driver);
            PageObject pageObject = new PageObject(driver);            

            //Navigate to Activty>Archive          
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Activity')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(), 'Archive')]")));
            WaitUntilCurtain();

            //Agency Contains Testing  
            find.ClickPlus();
            find.BasicFindClear("Agency", "Contains", Agency);
            find.ClickSearch();
            WaitUntilCurtain();
            Assert.IsTrue(driver.PageSource.Contains(Agency));

            //Verify Page Title
            Assert.AreEqual("Archive", FindElement(By.XPath("//h2[contains(text(), 'Archive')]")).Text);

            //Verify Open Tab
            IWebElement OpenTab = WaitbyXPathVisible(driver, "//a[contains(@href, '/ArchiveDocuments')][contains(@class, 'spark-menu__list-link ng-binding')]");
            Assert.AreEqual("ARCHIVE", OpenTab.Text);
            WaitUntilCurtain();

            //Close Open Tab Area
            Initialize initialize = new Initialize(driver);
            initialize.CloseOpenScreenCloseInitialize();

            //Verify OpenTab not displaying
            Assert.AreEqual(false, OpenTab.Displayed);

            //Open Open Tab Area
            initialize.OpenOpenScreenCloseInitialize();

          
        }
        [SetUp]
        public void ActivityCompaniesInitialize()
        {
            PageObject pageObject = new PageObject(driver);

            //Activity>Companies
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Activity')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Companies')]")));
            WaitUntilCurtain();

            //Verify Page Title
            Assert.AreEqual("Companies", FindElement(By.XPath("//h2[contains(text(), 'Companies')]")).Text);

            //Click Button Close
            pageObject.ClickButtonClose();

            //Activity>Companies
            js.ExecuteScript("return $(\"a:contains('Activity')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Companies')]")));
            WaitUntilCurtain();

            //Verify Open Tab
            IWebElement OpenTab = WaitbyXPathVisible(driver, "//a[contains(@ng-href, '/Companies')][contains(@class, 'spark-menu__list-link ng-binding')]");
            Assert.AreEqual("COMPANIES", OpenTab.Text);
            WaitUntilCurtain();

            //Verify Page Title
            Assert.AreEqual("Companies", FindElement(By.XPath("//h2[contains(text(), 'Companies')]")).Text);
        }
        [SetUp]
        public void ActivityCompaniesProfileInitialize(string name, string Operator, string value)
        {
            //Activity>Companies
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Activity')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Companies')]")));
            WaitUntilCurtain120();

            //Verify Page Title
            Assert.AreEqual("Companies", FindElement(By.XPath("//h2[contains(text(), 'Companies')]")).Text);

            //Verify Open Tab
            IWebElement OpenTab = WaitbyXPathVisible(driver, "//a[contains(@ng-href, '/Companies')][contains(@class, 'spark-menu__list-link ng-binding')]");
            Assert.AreEqual("COMPANIES", OpenTab.Text);
            WaitUntilCurtain();

            Find find = new Find(driver);
            find.FindBasic();
            find.BasicFind(name, Operator, value);
            find.ClickSearch();
            WaitUntilCurtain();

            //Highlight Row
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//div[@class='ui-grid-cell-contents ng-binding ng-scope']")));

            //Click Edit
            PageObject pageObject = new PageObject(driver);
            pageObject.ClickButtonEdit();

            //Verify Page Title
            Assert.AreEqual("Edit Company", FindElement(By.XPath("//h2[contains(text(), 'Edit Company')]")).Text);

            //Address 1
            IWebElement Address1 = FindElement(By.Name("AddressLine1"));
            String attValueAddress1 = Address1.Text;

            //Address 2
            IWebElement Address2 = FindElement(By.Name("AddressLine2"));
            String attValueAddress2 = Address2.Text;

            //City
            IWebElement City = FindElement(By.Name("City"));
            String attValueCity = City.Text;

            //State Province
            IWebElement StateProvince = FindElement(By.Name("StateCountryCode"));
            String attValueStateProvince = StateProvince.Text;

            //Postal Code
            IWebElement PostalCode = FindElement(By.Name("PostalCode"));
            String attValuePostalCode = PostalCode.Text;

            IWebElement CountryRegion = FindElement(By.Name("LegalName"));
            String attValueCountryRegion = CountryRegion.Text;

            //Click Cancel to Close Edit 
            pageObject.ClickButtonPageCancel();

            //Click Profile Button
            pageObject.ClickProfile();
            WaitUntilCurtain120();

            Assert.AreEqual("Company: Contacts", WaitForDisplayedElement(By.XPath("//h2[contains(text(), 'Company: Contacts')]")).Text);

            CompaniesProfileListTopSections CompaniesProfileListTopSections = new CompaniesProfileListTopSections(driver);
            CompaniesProfileListTopSections.CompaniesProfileList_TopSections();

            //Verify Top Section Company
            Assert.AreEqual(Company, driver.FindElement(By.XPath("//label[text()= '" + Company + "']")).Text);

            //Verify Top Section Type
            Assert.AreEqual(CompanyTypeAgency, FindElement(By.XPath("//label[text()= '" + CompanyTypeAgency + "']")).Text);
            WaitUntilCurtain(); WaitUntilLoaded();

            //Address 1
            String TextAddress1 = FindElement(By.XPath("//div[@ng-controller='addressControlController as addressControl']/div[1]/div[2]")).Text;
            Assert.True(TextAddress1.Contains(attValueAddress1));

            //Address 2
            String TextAddress2 = FindElement(By.XPath("//div[@ng-controller='addressControlController as addressControl']/div[2]/div[2]")).Text;
            Assert.True(TextAddress2.Contains(attValueAddress2));

            //City
            String TextCity = FindElement(By.XPath("//div[@ng-controller='addressControlController as addressControl']/div[3]/div[2]")).Text;
            Assert.True(TextCity.Contains(attValueCity));

            //PostalCode
            String TextPostalCode = FindElement(By.XPath("//div[@ng-controller='addressControlController as addressControl']/div[3]/div[6]")).Text;
            Assert.True(TextPostalCode.Contains(attValuePostalCode));

            //Country Region
            String TextCountryRegion = FindElement(By.XPath("//div[@ng-controller='addressControlController as addressControl']/div[4]/div[2]")).Text;
            Assert.True(TextCountryRegion.Contains(attValueCountryRegion));

        }
        public void ActivityContactsInitialize()
        {
            //Activity>Contacts
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Activity')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Contacts')]")));
            WaitUntilCurtain();

            //Verify Open Tab
            IWebElement OpenTab = WaitbyXPathVisible(driver, "//a[contains(@ng-href, '/Contacts')][contains(@class, 'spark-menu__list-link ng-binding')]");
            Assert.AreEqual("CONTACTS", OpenTab.Text);
            WaitUntilCurtain();

            //Verify Page Title
            Assert.AreEqual("Contacts", WaitForDisplayedElement(By.XPath("//h2[contains(text(), 'Contacts')]")).Text);
        }
        public void ActivityEventLogInitialize(string name, string Operator, string value)
        {
            //Select Activity>Event Log
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Activity')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Event Log')]")));
            WaitUntilCurtain();

            //Data Source Contains 
            Find find = new Find(driver);
            find.FindBasic();
            find.BasicFindClear(name, Operator, value);
            find.ClickSearch();

            //Verify Page Title
            Assert.AreEqual("Event Log", FindElement(By.XPath("//h2[contains(text(), 'Event Log')]")).Text);
            Assert.AreEqual("EVENT LOG", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Event Log')]")).Text);
        }
        public void ActivityReportsInitialize()
        {
            //Select Activity>Report
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Activity')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Report')]")));
            WaitUntilCurtainninety();        

            Assert.AreEqual("PRISM DCC", driver.Title);
            Assert.AreEqual("REPORTS", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Reports')]")).Text);
            Assert.AreEqual("Reports", FindElement(By.XPath("//h2[@class='ng-scope']")).Text);
        }
        public void ActivitySourcesInitialize()
        {
            //Select Activity>Sources
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Activity')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Sources')]")));
            WaitUntilCurtain();

            //Select Refresh
            PageObject pageObject = new PageObject(driver);
            pageObject.RefreshIcon();

            Assert.AreEqual("Data Source", FindElement(By.XPath("//h2[contains(text(), 'Data Source')]")).Text);

            //Verify Sources Open Tab 
            Assert.AreEqual("SOURCES", FindElement(By.XPath("//a[contains(@href, '/DataSources')][contains(@class, 'spark-menu__list-link ng-binding')]")).Text);
        }
        public void ActivitySourcesProfileInitializeAgency(string ColumnName, string Operator, string Value)
        {
            //Select Activity>Sources
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Activity')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Sources')]")));
            WaitUntilCurtain();           

            Assert.AreEqual("Data Source", FindElement(By.XPath("//h2[contains(text(), 'Data Source')]")).Text);

            //Verify Sources Open Tab 
            Assert.AreEqual("SOURCES", FindElement(By.XPath("//a[contains(@href, '/DataSources')][contains(@class, 'spark-menu__list-link ng-binding')]")).Text);
            
            //Agency Contains 
            Find find = new Find(driver);
            find.FindBasicTwoPlus();
            find.BasicFind(ColumnName, Operator, Value);
            find.ClickSearch();
            WaitUntilCurtain();

            //Highlight Row         
            IWebElement Highlight = FindElement(By.XPath("(//div[@class='ui-grid-cell-contents ng-binding ng-scope'])[1]"));
            Highlight.Click();

            //Click Profile Button
            PageObject pageObject = new PageObject(driver);
            pageObject.ClickProfile();
            WaitUntilCurtain120();

           
        }
        public void ActivitySourcesProfileInitializeDataSource()
        {
            //Select Activity>Sources
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Activity')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Sources')]")));
            WaitUntilCurtain();

            Assert.AreEqual("Data Source", FindElement(By.XPath("//h2[contains(text(), 'Data Source')]")).Text);

            //Verify Sources Open Tab 
            Assert.AreEqual("SOURCES", FindElement(By.XPath("//a[contains(@href, '/DataSources')][contains(@class, 'spark-menu__list-link ng-binding')]")).Text);

            //Agency Contains 
            Find find = new Find(driver);
            find.FindBasicTwoPlus();
            find.BasicFindClear("Data Source", "Equals", DataSource);
            find.ClickSearch();
            WaitUntilCurtain();

            //Highlight Row         
            IWebElement Highlight = driver.FindElement(By.XPath("(//div[@class='ui-grid-cell-contents ng-binding ng-scope'])[1]"));
            Highlight.Click();

            //Click Profile Button
            PageObject pageObject = new PageObject(driver);
            pageObject.ClickProfile();
            WaitUntilCurtain120();

            ActivitySourcesListProfileTopSectionPage activitySourcesListProfileTopSection = new ActivitySourcesListProfileTopSectionPage(driver);
            activitySourcesListProfileTopSection.ActivitySourcesListProfile_TopSection();
        }
        public void ActivitySourcesListProfileInterfaceDevelopmentList()
        {
            //Log In
            Initialize initialize = new Initialize(driver);
            initialize.ActivitySourcesInitialize();

            //Verify Page Title
            Assert.AreEqual("Data Source", FindElement(By.XPath("//h2[contains(text(), 'Data Source')]")).Text);

            //Company Contains Testing
            Find find = new Find(driver);
            find.FindBasicTwoPlus();
            find.BasicFind("Agency", "contains", Agency);
            find.ClickSearch();
            WaitUntilCurtain();
            WaitUntilLoaded();

            //Highlight Row
            FindElement(By.XPath("(//div[contains(text(), '" + Agency + "')][@class='ui-grid-cell-contents ng-binding ng-scope'])[1]")).Click();

            //Click Profile Button
            PageObject pageObject = new PageObject(driver);
            pageObject.ClickProfile();
            WaitUntilCurtain();

            //Select View>Interface Development
            initialize.ViewInterfaceDevelopmentInitialize();

            //Verify Page Title
            Assert.AreEqual("Data Source: Interface Development", WaitForDisplayedElement(By.XPath("//h2[contains(text(), 'Data Source: Interface Development')]")).Text);
        }
        public void ActivitySourcesListProfileInterfaceDevelopmentListViewDevLog()
        {            
            //Log In
            Initialize initialize = new Initialize(driver);
            initialize.ActivitySourcesInitialize();

            //Verify Page Title
            Assert.AreEqual("Data Source", FindElement(By.XPath("//h2[contains(text(), 'Data Source')]")).Text);

            //Company Contains Testing
            Find find = new Find(driver);
            find.FindBasicTwoPlus();
            find.BasicFind("Agency", "contains", "Otrar");
            find.ClickSearch();
            WaitUntilCurtain();
            WaitUntilLoaded();

            //Highlight Row
            FindElement(By.XPath("(//div[contains(text(), 'Otrar Travel')][@class='ui-grid-cell-contents ng-binding ng-scope'])[1]")).Click();

            //Click Profile Button
            PageObject pageObject = new PageObject(driver);
            pageObject.ClickProfile();
            WaitUntilCurtain();

            //Select View>Interface Development
            initialize.ViewInterfaceDevelopmentInitialize();

            //Verify Page Title
            Assert.AreEqual("Data Source: Interface Development", WaitForDisplayedElement(By.XPath("//h2[contains(text(), 'Data Source: Interface Development')]")).Text);

            //Highlight a row
            pageObject.HighlightFirstRow();

            //Click View Dev Log Button
            IWebElement ViewDevLogButton = driver.FindElement(By.XPath("//a[@menu-command='cmdViewDevLog']"));
            ViewDevLogButton.Click();
            WaitUntilCurtain();

            //Verify Page Title
            Assert.AreEqual("Dev Log", FindElement(By.XPath("//h2[contains(text(), 'Dev Log')]")).Text);
            WaitUntilCurtain();
        }
        public void ActivityTicketLedgerInitialize()
        {
            //Select Activity>Ticket Ledger
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Activity')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Ticket Ledger')]")));
            WaitUntilCurtain();

            Assert.AreEqual("Ticket Ledger", driver.FindElement(By.XPath("//h2[contains(text(), 'Ticket Ledger')]")).Text);
            WaitUntilCurtainninety();
        }
        public void AdminCompanyUpdateInitialize()
        {
            //Select Admin>Company Update
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Admin')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Company Update')]")));
            WaitUntilCurtain();

            //Verify Open Tab 
            Assert.AreEqual("COMPANY UPDATE", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Company Update')]")).Text);
            //Verify Page Title
            Assert.AreEqual("Company Update", FindElement(By.XPath("//h2[contains(text(), 'Company Update')]")).Text);
        }
        public void AdminCustomerDefinitionInitialize()
        {
            WaitUntilCurtain();
            //Select Admin>Customer Definition
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Admin')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Customer Definition')]")));
            WaitUntilCurtain();

            //Verify Page Title
            Assert.AreEqual("Customer Definition", FindElement(By.XPath("//h2[contains(text(), 'Customer Definition')]")).Text);

            //Verify Open Tab            
            Assert.AreEqual("CUSTOMER DEFINITION", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Customer Definition')]")).Text);
        }
        public void AdminCustomerNumbersInitialize()
        {
            //Select Admin>Customer Numbers 
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Admin')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@href='/SystemData/CustomerNumbers']")));
            WaitUntilCurtain();

            //Verify Open Tab                  
            Assert.AreEqual("CUSTOMER NUMBERS", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Customer Numbers')]")).Text);
        }
        public void AdminDataStatusInitialize()
        {
            //Select Admin>Data Status
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Admin')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@href='/DataServices/ReleasesDataStatuses']")));
            WaitUntilCurtain();

            //Verify Open Tab
            Assert.AreEqual("DATA STATUS", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Data Status')]")).Text);
            WaitUntilCurtain();

            Assert.AreEqual("Data Status", FindElement(By.XPath("//h2[contains(text(), 'Data Status')]")).Text);
        }
        public void AdminDataStatusDetailInitialize()
        {
            //Select Admin>Data Status Detail
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Admin')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Data Status Detail')]")));
            WaitUntilCurtain();
            WaitUntilLoaded();

            //Verify Open Tab
            Assert.AreEqual("Data Status Detail", FindElement(By.XPath("//h2[contains(text(), 'Data Status Detail')]")).Text);
            var Data = WaitForDisplayedElement(By.XPath("//a[@href='/DataServices/ReleasesDataStatusesDetails'][@class='spark-menu__list-link ng-binding']")).Text;
            WaitUntilCurtain();
        }
        public void AdminMaskingDetailInitialize()
        {
            //Select Admin>Masking Detail 
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Admin')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Masking Detail')]")));
            WaitUntilCurtain();

            //Verify Open Tab            
            Assert.AreEqual("MASKING DETAIL", FindElement(By.XPath("//a[contains(@href, '/SystemData/MaskingDetails')]")).Text);
        }
        public void AdminNotificationsInitialize()
        {
            //Select Admin>Notification
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Admin')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@href, '/SystemData/Notifications')]")));
            WaitUntilCurtain();

            //Verify Open Tab        
            Assert.AreEqual("NOTIFICATIONS", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Notifications')]")).Text);
        }
        public void AdminPRISMAdminApplicationDebugLogInitialize()
        {
            //Admin>User>Application Debug Log       
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Admin')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(),'PRISM Admin')]//following-sibling::button")));
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Application Debug Log')]")));
            WaitUntilCurtain();

            //Verify Open Tab 
            Assert.AreEqual("APPLICATION DEBUG LOG", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Application Debug Log')]")).Text);
        }
        public void AdminPRISMAdminDebugLogInitialize()
        {
            //Admin>User>Application Debug Log       
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Admin')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(),'PRISM Admin')]//following-sibling::button")));
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[text()='Debug Log']")));
            WaitUntilCurtain();

            //Verify Open Tab 
            Assert.AreEqual("Debug Log", FindElement(By.XPath("//h2[contains(text(), 'Debug Log')]")).Text);
        }
        public void AdminPRISMAdminPRISMRuleInitialize()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Admin')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(),'PRISM Admin')]//following-sibling::button")));
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'PRISM Rule')]")));
            WaitUntilCurtain();

            //Verify Open Tab 
            Assert.AreEqual("PRISM RULE", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'PRISM Rule')]")).Text);
        }
        public void AdminTicketingCountryInitialize()
        {
            //Select Admin>Ticketing Country
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Admin')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Ticketing Country')]")));
            WaitUntilCurtain();

            Assert.AreEqual("Ticketing Country", FindElement(By.XPath("//h2[contains(text(), 'Ticketing Country')]")).Text);
        }
        public void AdminTicketLocationInitialize()
        {
            //Select Admin>Ticket Location
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Admin')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Ticket Location')]")));
            WaitUntilCurtain();

            Assert.AreEqual("Ticket Location", FindElement(By.XPath("//h2[contains(text(), 'Ticket Location')]")).Text);

            //Verify Open Tab        
            Assert.AreEqual("TICKET LOCATION", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Ticket Location')]")).Text);
        }
        public void AdminUnknownCompaniesInitialize()
        {
            //Select Admin>Unknown Companies
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Admin')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Unknown Companies')]")));
            WaitUntilCurtain();

            //Verify Page Title
            Assert.AreEqual("Unknown Companies", FindElement(By.XPath("//h2[contains(text(), 'Unknown Companies')]")).Text);

            //Verify Open Tab            
            Assert.AreEqual("UNKNOWN COMPANIES", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Unknown Companies')]")).Text);
        }
        public void AdminUnknownCompaniesListDetail()
        {
            //Select Admin>Unknown Companies
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Admin')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Unknown Companies')]")));
            WaitUntilCurtainninety();

            //Verify Open Tab            
            Assert.AreEqual("UNKNOWN COMPANIES", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Unknown Companies')]")).Text);
            WaitUntilCurtain();

            Assert.AreEqual("Unknown Companies", FindElement(By.XPath("//h2[contains(text(), 'Unknown Companies')]")).Text);

            //Highlight Row         
            IWebElement Highlight = WaitbyXPathClickable(driver, "(//div[@class='ui-grid-cell-contents ng-binding ng-scope'])[1]");
            Highlight.Click();

            //Select Detail Button
            FindElement(By.XPath("//a[@menu-command='cmdDetail']")).Click();
        }
        public void AdminUserAccessInitialize()
        {
            //Admin>User>Access
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Admin')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(),'Admin')]//following-sibling::button")));
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Access')]")));
            WaitUntilCurtain();

            //Verify Open Tab 
            Assert.AreEqual("USER ACCESS", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'User')]")).Text);
        }
        public void AdminUserAuditInitialize()
        {
            //Admin>User>Audit
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Admin')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(),'Admin')]//following-sibling::button")));
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Audit')]")));
            WaitUntilCurtain();

            //Verify Open Tab 
            Assert.AreEqual("USER AUDIT", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'User Audit')]")).Text);
            WaitUntilCurtain();
        }
        public void AdminUserMonitorInitialize()
        {
            //Admin>User>Monitor
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Admin')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(),'Admin')]//following-sibling::button")));
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Monitor')]")));
            WaitUntilCurtain();

            //Verify Open Tab 
            Assert.AreEqual("USER MONITOR", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'User')]")).Text);
        }
        public void DataDataFileLogInitialize()
        {
            //Navigate to Data>Data File Log
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Data')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Data File Log')]")));
            WaitUntilCurtainsixty();
            WaitUntilLoaded();

            //Resolve Status Equals
            Find find = new Find(driver);
            find.FindBasicTwoPlus();
            find.BasicFindwdropdown("Resolve Status", "Equals", "Completed");
            find.ClickSearch();
            WaitUntilCurtain();
            Assert.IsTrue(driver.PageSource.Contains("Failed"));

            //Verify Page Title
            Assert.AreEqual("Data File Log", FindElement(By.XPath("//h2[contains(text(), 'Data File Log')]")).Text);

            //Verify Open Tab            
            Assert.AreEqual("DATA FILE LOG", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Data File Log')]")).Text);
        }
        public void DataExportInitialize()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Data')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(),'Export')]//following-sibling::button")));
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@href, '/DataManagement/DataExports')]")));
            WaitUntilCurtain();

            //Verify Page Title
            Assert.AreEqual("Data Export", FindElement(By.XPath("//h2[contains(text(), 'Data Export')]")).Text);

            //Verify Open Tab    
            Assert.AreEqual("DATA EXPORT", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Data Export')]")).Text);
        }
        public void DataExportLogInitialize()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Data')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(),'Export')]//following-sibling::button")));
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@href, '/DataManagement/ExportLog')]")));
            WaitUntilCurtain();

            //Verify Page Title
            Assert.AreEqual("Export Log", FindElement(By.XPath("//h2[contains(text(), 'Export Log')]")).Text);

            //Verify Open Tab    
            Assert.AreEqual("EXPORT LOG", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Export Log')]")).Text);
        }
        public void DataExportNotExportedInitialize()
        {
            //Navigate to Admin > User > Preference
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Data')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(),'Export')]//following-sibling::button")));
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@href='/DataManagement/ExportNotExported']")));
            WaitUntilCurtain();
        }
        public void DataImportImportLogInitialize()
        {
            WaitUntilCurtain();
            System.Threading.Thread.Sleep(5000);

            //Navigate to Data>Data Import
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Data')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@href='/DataManagement/DataImports']")));
            WaitUntilCurtain();
            WaitUntilLoaded();

            //Verify Open Tab            
            Assert.AreEqual("IMPORT LOG", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Import Log')]")).Text);
        }
        public void DataImportNoDataLogLogInitialize()
        {           
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Data')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(),'Import')]//following-sibling::button")));
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@href, '/DataManagement/DataImports')][normalize-space(.) = 'No Data Log'][contains(@href, '/DataManagement/DataImports')]")));
            WaitUntilCurtain();

            //Verify Open Tab            
            Assert.AreEqual("NO DATA LOG", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'No Data Log')]")).Text);
        }
        public void DataImportPendingInitialize()
        {            
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Data')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(),'Import')]//following-sibling::button")));
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link')][contains(@ng-href, '/DataManagement/DataImportPendingImports ')][normalize-space(.) = 'Pending'][contains(@href, '/DataManagement/DataImportPendingImports')]")));
            WaitUntilCurtainsixty();

            //Verify Page Title
            Assert.AreEqual("Pending", FindElement(By.XPath("//h2[contains(text(), 'Pending')]")).Text);

            //Verify Open Tab            
            Assert.AreEqual("PENDING", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Pending')]")).Text);
        }
        public void DataInterfaceDevelopmentInitialize()
        {
            //Navigate to Data>Interface Development
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Data')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Interface Development')]")));
            WaitUntilCurtain();

            //Verify Open Tab            
            Assert.AreEqual("INTERFACE DEVELOPMENT", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Interface Development')]")).Text);
        }
        public void DataProcessLogInitialize()
        {
            //Select Data>Process Log
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Admin')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Process Log')]")));
            WaitUntilCurtainsixty();

            Assert.AreEqual("Process Log", FindElement(By.XPath("//h2[contains(text(), 'Process Log')]")).Text);

            //Verify Open Tab             
            Assert.AreEqual("PROCESS LOG", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Process Log')]")).Text);
        }
        public void DataWheelStatusInitialize()
        {
            //Select Data>Wheel Status
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Admin')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Wheel Status')]")));
            WaitUntilCurtainsixty();

            Assert.AreEqual("Wheel Status", FindElement(By.XPath("//h2[contains(text(), 'Wheel Status')]")).Text);

            //Verify Open Tab             
            Assert.AreEqual("WHEEL STATUS", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Wheel Status')]")).Text);
        }
        public void DataRemoveClientDataInitialize()
        {
            //Select Data>Remove Client Data
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Admin')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Remove Client Data')]")));
            WaitUntilCurtainsixty();

            Assert.AreEqual("Remove Client Data", FindElement(By.XPath("//h2[contains(text(), 'Remove Client Data')]")).Text);

            //Verify Open Tab             
            Assert.AreEqual("REMOVE CLIENT DATA", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Remove Client Data')]")).Text);
        }
        public void DRADataChaseInitialize()
        {
            //Navigate to DRA>Data Chase       
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('DRA')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Data Chase')]")));
            WaitUntilCurtain();

            //Verify Page Title
            Assert.AreEqual("Data Chase", FindElement(By.XPath("//h2[contains(text(), 'Data Chase')]")).Text);
            WaitUntilCurtain();

            //Verify Open Tab 
            Assert.AreEqual("DATA CHASE", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Data Chase')]")).Text);
        }
        public void DRAReleaseInitializewithFind(string ColumnName, string Operator, string Value)
        {
            //Navigate to DRA>Release 
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('DRA')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@href, '/DataServices/Releases/dccCompaniesGrid')][contains(@ng-href, '/DataServices/Releases/dccCompaniesGrid')][contains(text(), 'Release')]")));

            //DCC Company Contains
            Find find = new Find(driver);
            find.FindBasic();
            find.BasicFindClear(ColumnName, Operator, Value);
            find.ClickSearch();
            WaitUntilCurtainsixty();
            System.Threading.Thread.Sleep(5000);

            //Verify Page Title
            Assert.AreEqual("Release", FindElement(By.XPath("//h2[contains(text(), 'Release')]")).Text);

            //Verify Open Tab Release
            Assert.AreEqual("RELEASE", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][@href='/DataServices/Releases/dccCompaniesGrid']")).Text);
            WaitUntilCurtain();
        }
        public void DRAReleaseDCCCompanyInitialize(string ColumnName, string Operator, string Value)
        {           
            //Navigate to DRA>Release 
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('DRA')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@href, '/DataServices/Releases/dccCompaniesGrid')][contains(@ng-href, '/DataServices/Releases/dccCompaniesGrid')][contains(text(), 'Release')]")));

            //DCC Company Contains
            Find find = new Find(driver);
            find.FindBasic();
            find.BasicFindClear(ColumnName, Operator, Value);
            find.ClickSearch();
            WaitUntilCurtainsixty();
            System.Threading.Thread.Sleep(5000);

            //Verify Page Title
            Assert.AreEqual("Release", FindElement(By.XPath("//h2[contains(text(), 'Release')]")).Text);
        }
        public void DRAReleaseClientCompanyInitialize(string ColumnName, string Operator, string Value)
        {
            //Navigate to DRA>Release 
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('DRA')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@href, '/DataServices/Releases/dccCompaniesGrid')][contains(@ng-href, '/DataServices/Releases/dccCompaniesGrid')][contains(text(), 'Release')]")));

            //Client Company Contains
            Find find = new Find(driver);
            find.FindBasic();
            find.BasicFindClear(ColumnName, Operator, Value);
            find.ClickSearch();
            WaitUntilCurtainsixty();

            //Click Client Company View
            PageObject pageObject = new PageObject(driver);
            pageObject.ClickButtonClientCompanyView();
            WaitUntilCurtain();

            //Verify Page Title
            Assert.AreEqual("Release", FindElement(By.XPath("//h2[contains(text(), 'Release')]")).Text);
            WaitUntilCurtain();

            //Verify Button Displays Client Company View
            Assert.AreEqual("VIEW: CLIENT COMPANY", FindElement(By.XPath("//a[@menu-command='cmdViewClientCompany']")).Text);
        }
        public void DRAReleaseClientCompanyProfileInitialize(string ColumnName, string Operator, string Value, string ColumnName1, string Operator1, string Value1)
        {
            //Navigate to DRA>Release 
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('DRA')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@href, '/DataServices/Releases/dccCompaniesGrid')][contains(@ng-href, '/DataServices/Releases/dccCompaniesGrid')][contains(text(), 'Release')]")));
            WaitUntilCurtainsixty();

            //Verify Page Title
            Assert.AreEqual("Release", FindElement(By.XPath("//h2[contains(text(), 'Release')]")).Text);

            //Verify Open Tab Release
            Assert.AreEqual("RELEASE", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][@href='/DataServices/Releases/dccCompaniesGrid']")).Text);
            WaitUntilCurtain();

            //DCC Company Contains
            Find find = new Find(driver);
            find.FindBasic();
            find.BasicFindClear(ColumnName, Operator, Value);
            find.ClickPlus();
            find.DoubleFindClear(ColumnName1, Operator1, Value1);
            find.ClickSearch();
            WaitUntilCurtainninety();

            Assert.AreEqual("Release", FindElement(By.XPath("//h2[contains(text(), 'Release')]")).Text);

            //Verify Open Tab Release
            Assert.AreEqual("RELEASE", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][@href='/DataServices/Releases/dccCompaniesGrid']")).Text);
            WaitUntilCurtainsixty();

            //Select Client Company View
            PageObject pageObject = new PageObject(driver);
            pageObject.ClickButtonClientCompanyView();

            Assert.AreEqual("VIEW: CLIENT COMPANY", FindElement(By.XPath("//a[@menu-command='cmdViewClientCompany']")).Text);

            //Highlight Row         
            IWebElement Highlight = FindElement(By.XPath("(//div[@class='ui-grid-cell-contents ng-binding ng-scope'])[1]"));
            Highlight.Click();

            //Click Profile Button
            pageObject.ClickProfile();
            WaitUntilCurtainsixty();

            Assert.AreEqual("Release: Archive", FindElement(By.XPath("//h2[contains(text(), 'Release: Archive')]")).Text);
        }
        public void DRAReleaseDCCCompanyProfileInitialize(string ColumnName, string Operator, string Value)
        {
            //Navigate to DRA>Release 
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('DRA')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@href, '/DataServices/Releases/dccCompaniesGrid')][contains(@ng-href, '/DataServices/Releases/dccCompaniesGrid')][contains(text(), 'Release')]")));
            WaitUntilCurtainsixty();

            //Verify Page Title
            Assert.AreEqual("Release", FindElement(By.XPath("//h2[contains(text(), 'Release')]")).Text);

            //Verify Open Tab Release
            Assert.AreEqual("RELEASE", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][@href='/DataServices/Releases/dccCompaniesGrid']")).Text);
            WaitUntilCurtain();

            //DCC Company Contains
            Find find = new Find(driver);
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdFind']")));
            find.BasicFindClearWithPlus(ColumnName, Operator, Value);
            find.ClickSearch();
            WaitUntilCurtainsixty();

            //Highlight Row         
            IWebElement Highlight = WaitbyXPathClickable(driver, "(//div[@class='ui-grid-cell-contents ng-binding ng-scope'])[1]");
            Highlight.Click();

            //Click Profile Button
            PageObject pageObject = new PageObject(driver);
            pageObject.ClickProfile();
            WaitUntilCurtainninety();

            Assert.AreEqual("Release: Archive", FindElement(By.XPath("//h2[contains(text(), 'Release: Archive')]")).Text);
        }
        public void DRARequestInitialize()
        {
            WaitUntilCurtain();

            //Navigate to DRA>Request 
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('DRA')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@href, '/DataServices/Requests')][contains(@ng-href, '/DataServices/Requests')][contains(text(), 'Request')]")));
        }
        public void DRARequestProcessInitialize()
        {
            //Navigate to DRA>Request 
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('DRA')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@href, '/DataServices/Requests')][contains(@ng-href, '/DataServices/Requests')][contains(text(), 'Request')]")));
            WaitUntilCurtain();
            FindElement(By.Name("Value")).ComboBox().SelectByText("UA");

            Find find = new Find(driver);
            find.ClickSearch();
            WaitUntilCurtainninety();

            Assert.IsTrue(driver.PageSource.Contains("UA"));
            WaitUntilCurtain();

            //Highlight Agency
            PageObject pageObject = new PageObject(driver);
            pageObject.HighlightFirstRow();

            //Click Process Button
            pageObject.ClickButtonProcess();
            WaitUntilCurtain120();

            //Verify New Release Displays          
            Assert.AreEqual("New Release", FindElement(By.XPath("//h2[text()='New Release']")).Text);

            //Verify Open Tab
            Assert.AreEqual("New Release", FindElement(By.XPath("//a[contains(@href, '/DataServices/Releases/Process')]")).Text);
        }
        public void ListsAircraftTypesInitialize()
        {
            //Navigate to Lists>Aircraft Type 
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Lists')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@href, '/SystemData/AircraftTypes')][contains(@ng-href, '/SystemData/AircraftTypes')][contains(text(), 'Aircraft Type')]")));
            WaitUntilCurtain();

            //Verify Page Title
            Assert.AreEqual("Aircraft Type", FindElement(By.XPath("//h2[contains(text(), 'Aircraft Type')]")).Text);

            //Verify Open Tab            
            Assert.AreEqual("AIRCRAFT TYPE", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Aircraft Type')]")).Text);
        }
        public void ListsAirlinePartnersInitialize()
        {
            //Navigate to Lists>Airline Partners
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Lists')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@href, '/SystemData/AirlinePartners')][contains(@ng-href, '/SystemData/AirlinePartners')][contains(text(), 'Airline Partners')]")));
            WaitUntilCurtain();

            //Verify Page Title
            Assert.AreEqual("Airline Partners", FindElement(By.XPath("//h2[contains(text(), 'Airline Partners')]")).Text);

            //Verify Open Tab            
            Assert.AreEqual("AIRLINE PARTNERS", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Airline Partners')]")).Text);
        }
        public void ListsAirportInitialize()
        {
            //Navigate to Lists>Airport
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Lists')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@href, '/SystemData/Airports')][contains(@ng-href, '/SystemData/Airports')][contains(text(), 'Airport')]")));
            WaitUntilCurtain();
            
            //Verify Page Title
            Assert.AreEqual("Airport", FindElement(By.XPath("//h2[contains(text(), 'Airport')]")).Text);

            //Verify Airport Open Tab 
            Assert.AreEqual("AIRPORT", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(@ng-href, '/SystemData/Airports')]")).Text);
        }
        public void ListsCabinTranslationsInitialize()
        {
            //Navigate to Lists>Cabin
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Lists')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(),'Cabin')]//following-sibling::button")));
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@href, '/SystemData/CabinTranslations')]")));
            WaitUntilCurtainsixty();

            Find find = new Find(driver);
            new SelectElement(FindElement(By.XPath("//Select[@name='Value']"))).SelectByText(Carrier);
            System.Threading.Thread.Sleep(1000);
            find.ClickSearch();
            WaitUntilCurtain();

            //Verify Open Tab            
            Assert.AreEqual("CABIN", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Cabin')]")).Text);

            Assert.AreEqual("Cabin Translations", FindElement(By.XPath("//h2[contains(text(), 'Cabin Translations')]")).Text);
        }
        public void ListsCabinUpdateInitialize()
        {
            //Navigate to Lists>Cabin>Update
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Lists')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(),'Cabin')]//following-sibling::button")));
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@href, '/SystemData/CabinTranslationsAffectedTickets')]")));
            WaitUntilCurtain();

            Assert.AreEqual("Cabin Update", FindElement(By.XPath("//h2[contains(text(), 'Cabin Update')]")).Text);

            //Verify Open Tab            
            Assert.AreEqual("CABIN UPDATE", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Cabin Update')]")).Text);
        }
        public void ListsCarrierInitialize()
        {
            //Navigate to Lists>Carrier
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Lists')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@href, '/SystemData/Carriers')][contains(@ng-href, '/SystemData/Carriers')][contains(text(), 'Carrier')]")));
            WaitUntilCurtain();

            //Verify Page Title
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            IWebElement PageTitle = WaitbyXPathVisible(driver, "//h2[contains(text(), 'Carrier')]");
            Assert.AreEqual("Carrier", PageTitle.Text);

            //Verify Open Tab          
            Assert.AreEqual("CARRIER", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Carrier')]")).Text);
        }
        public void ListsCarrierDirectInitialize()
        {
            //Navigate to Lists>Carrier
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Lists')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@href, '/SystemData/CarrierDirects')]")));
            WaitUntilCurtain();

            //Verify Page Title
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            IWebElement PageTitle = WaitbyXPathVisible(driver, "//h2[contains(text(), 'Carrier Direct')]");
            Assert.AreEqual("Carrier Direct", PageTitle.Text);

            //Verify Open Tab          
            Assert.AreEqual("CARRIER DIRECT", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Carrier Direct')]")).Text);
        }
        public void ListsCompanyGroupsInitialize()
        {
            //Navigate to Lists>Company Groups
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Lists')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@href, '/CompanyGroups')][contains(text(), 'Company Groups')]")));
            WaitUntilCurtain();

            //Verify Page Title
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            IWebElement PageTitle = WaitbyXPathVisible(driver, "//h2[contains(text(), 'Company Groups')]");
            Assert.AreEqual("Company Groups", PageTitle.Text);

            //Verify Open Tab          
            Assert.AreEqual("COMPANY GROUPS", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Company Groups')]")).Text);
        }
        public void ListsIATAInitialize()
        {
            //Navigate to Lists>IATA
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Lists')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@href='/SystemData/IATALocations']")));
            WaitUntilCurtain();

            //Verify Page Title
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(200));
            IWebElement PageTitle = WaitbyXPathVisible(driver, "//h2[contains(text(), 'IATA')]");
            Assert.AreEqual("IATA", PageTitle.Text);

            //Verify Open Tab             
            Assert.AreEqual("IATA", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'IATA')]")).Text);
        }
        public void ListsSourceDetailsInitialize()
        {
            WaitUntilCurtain();

            //Navigate to Lists>Source Details
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('Lists')\").mouseover();");
            WaitUntilCurtain();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@href, '/SystemData/DataSourceProfileQuestions')][contains(text(), 'Source Details')][@class='spark-menu__list-link']")));
            WaitUntilCurtain();

            //Verify Page Title
            Assert.AreEqual("Source Details", FindElement(By.XPath("//h2[contains(text(), 'Source Details')]")).Text);

            //Verify Open Tab             
            Assert.AreEqual("SOURCE DETAILS", FindElement(By.XPath("//a[contains(@class, 'spark-menu__list-link ng-binding')][contains(text(), 'Source Details')]")).Text);
        }
        public void ViewArchiveInitialize()
        {
            //Select View>Archive
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('View')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//a[@menu-command='cmdArchive']")));
            WaitUntilCurtainninety();
        }
        public void ViewContactsInitialize()
        {
            //Select View>Contact
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('View')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdContacts']")));
            WaitUntilCurtain();
        }
        public void ViewDataStatusInitialize()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('View')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//a[@menu-command='cmdDataStatus']")));
            WaitUntilCurtain();
        }
        public void ViewDataStatusDetailInitialize()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('View')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//a[@menu-command='cmdDataStatusDetail']")));
            WaitUntilCurtain();
        }

        public void ViewEventLogInitialize()
        {
            //Select View>Event Log
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('View')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdActivityLog']")));
            WaitUntilCurtainsixty();
        }
        public void ViewExportLogInitialize()
        {
            //Select View>Export Log
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('View')\").mouseover();");
            WaitForAjaxComplete(20);
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdExportLog']")));
            WaitUntilCurtain();

            //Verify Page Title
            Assert.AreEqual("Data Source: Export Log", WaitForDisplayedElement(By.XPath("//h2[contains(text(), 'Data Source: Export Log')]")).Text);
        }
        public void ViewImportLogInitialize()
        {
            //Select View>Import Log
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('View')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdImportLog']")));
            WaitUntilCurtainsixty();

            //Verify Page Title
            Assert.AreEqual("Data Source: Import Log", WaitForDisplayedElement(By.XPath("//h2[contains(text(), 'Data Source: Import Log')]")).Text);
        }
        public void ViewInterfaceDevelopmentInitialize()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('View')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//a[@menu-command='cmdInterfaceDevelopment']")));
            WaitUntilCurtainsixty();
        }
        public void ViewInterfaceHistoryInitialize()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('View')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//a[@menu-command='cmdInterfaceHistory']")));
            WaitUntilCurtain120();
        }
        public void ViewSourceDetailsInitialize()
        {
            //Select View>Import Log
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('View')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdSourceDetails']")));
            WaitUntilCurtainsixty();
        }
        public void ViewTicketLocationInitialize()
        {
            //Select View>Import Log
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('View')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdTicketLocation']")));
            WaitUntilCurtainsixty();

        }
    }
}
