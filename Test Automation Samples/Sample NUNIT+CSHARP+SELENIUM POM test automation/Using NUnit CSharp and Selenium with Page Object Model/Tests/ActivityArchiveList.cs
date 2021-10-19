using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;

namespace DCC
{
    public class ActivityArchiveList
    {
        private void TakeScreenshot()
        {
            string SaveLocation = @"C:\Temp\" + "failshot_" +
            TestContext.CurrentContext.Test.FullName + ".png";
            ITakesScreenshot ScreenshotDriver = (ITakesScreenshot)PC.driver;
            ScreenshotDriver.GetScreenshot().SaveAsFile(SaveLocation, ScreenshotImageFormat.Png);

        }
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {

            var ActivityArchive = new Initialize(PC.driver);
            ActivityArchive.ActivityArchiveInitialize();

        //PC.driver = new ChromeDriver();
        //WebDriverWait wait = new WebDriverWait(PC.driver, TimeSpan.FromSeconds(60));

            //PC.driver.Navigate().GoToUrl("http://pmtdcc.sgdcelab.sabre.com/");
            //PC.driver.Manage().Window.Maximize();

            //wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            //Click Close on Security Window
            //IWebElement close = PC.driver.FindElement(By.XPath("//button[contains(text(), 'Close')]"));
            //close.Click();

            //wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));
            //System.Threading.Thread.Sleep(2000);

            //Clicks Activity
            //IWebElement Activity = PC.driver.FindElement(By.XPath("//*[contains(text(), 'Activity')]"));
            //Activity.Clicks();

            //System.Threading.Thread.Sleep(2000);
            //wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            //Click Archive
            //IWebElement Archive = PC.driver.FindElement(By.XPath("//*[contains(text(), 'Archive')]"));
            //Archive.Clicks();

            //System.Threading.Thread.Sleep(2000);
            //wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            //Verify Open Tab
            //Assert.AreEqual("ARCHIVE", PC.driver.FindElement(By.XPath("//a[contains(@href, '/ArchiveDocuments')][contains(@class, 'spark-menu__list-link ng-binding')]")).Text);

            //wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

        }
        [Test]
        public void ActivityArchive_List()
        {         
            var PageObject = new PageObject(PC.driver);
                   
            WebDriverWait wait = new WebDriverWait(PC.driver, TimeSpan.FromSeconds(120));

            //Select Refresh
            var ListDropDownObjects = new ListDropDownObjects(PC.driver);
            ListDropDownObjects.RefreshIcon();

            //Select List Refresh  
            ListDropDownObjects.ListRefresh();

            //Select List Reset Grid
            ListDropDownObjects.ListResetGrid();

            //Select List Reset Filters
            ListDropDownObjects.ListResetFilters();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));
           
            //Verify Edit Disabled       
            Assert.AreEqual("true", PC.driver.FindElement(By.XPath("//a[contains(@menu-command, 'cmdEdit')]")).GetAttribute("disabled"));

            //Verify Delete Disabled       
            Assert.AreEqual("true", PC.driver.FindElement(By.XPath("//a[contains(@menu-command, 'cmdDelete')]")).GetAttribute("disabled"));

            //Verify Clone Disabled       
            Assert.AreEqual("true", PC.driver.FindElement(By.XPath("//a[contains(@menu-command, 'cmdClone')]")).GetAttribute("disabled"));

            //Verify Check In Disabled       
            Assert.AreEqual("true", PC.driver.FindElement(By.XPath("//a[contains(@menu-command, 'cmdCheckIn')]")).GetAttribute("disabled"));

            //Verify Distribute Disabled       
            Assert.AreEqual("true", PC.driver.FindElement(By.XPath("//a[contains(@menu-command, 'cmdDistribute')]")).GetAttribute("disabled"));

            //Verify Open Disabled       
            Assert.AreEqual("true", PC.driver.FindElement(By.XPath("//a[contains(@menu-command, 'cmdOpen')]")).GetAttribute("disabled"));

            //Assert.AreEqual("true", PC.driver.FindElement(By.XPath("//span[.='Stored Date']")).GetAttribute("Sort Ascending"));

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnStoredDate.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnStoredDate.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnAirlineClient.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnAirlineClient.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnCompany.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnCompany.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnContact.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnContact.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnAgency.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnAgency.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnStoredBy.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnStoredBy.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnDocument.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnDocument.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnDocumentType.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnDocumentType.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnModified.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnModified.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            //Select Columns Button
            PageObject.ButtonColumn.Clicks();

            //Verify Stored Date Button
            Assert.AreEqual("  Stored Date", PC.driver.FindElement(By.XPath("//button[contains(text(), 'Stored Date')]")).Text);

            //Verify Airline/Client Button
            Assert.AreEqual("  Airline/Client", PC.driver.FindElement(By.XPath("//button[contains(text(), 'Airline/Client')]")).Text);

            //Verify Company Button
            Assert.AreEqual("  Company", PC.driver.FindElement(By.XPath("//button[contains(text(), 'Company')]")).Text);

            //Verify Contact Button
            Assert.AreEqual("  Contact", PC.driver.FindElement(By.XPath("//button[contains(text(), 'Contact')]")).Text);

            //Verify Agency Button
            Assert.AreEqual("  Agency", PC.driver.FindElement(By.XPath("//button[contains(text(), 'Agency')]")).Text);

            //Verify Stored By Button
            Assert.AreEqual("  Stored By", PC.driver.FindElement(By.XPath("//button[contains(text(), 'Stored By')]")).Text);

            //Verify Document Button
            Assert.AreEqual("  Document", PC.driver.FindElement(By.XPath("//button[contains(text(), 'Document')]")).Text);

            //Verify Document Type Button
            Assert.AreEqual("  Document Type", PC.driver.FindElement(By.XPath("//button[contains(text(), 'Document Type')]")).Text);

            //Verify Modified Button
            Assert.AreEqual("  Modified Date", PC.driver.FindElement(By.XPath("//button[contains(text(), 'Modified')]")).Text);

            //Check Mark Document Name
            IWebElement DocumentName = PC.driver.FindElement(By.Id("menuitem-27"));
            DocumentName.Click();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            //Verify Document Name
            Assert.AreEqual("  Document Name", PC.driver.FindElement(By.XPath("//button[contains(text(), 'Document Name')]")).Text);

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            //Sort Document Name Column
            PageObject.ColumnDocumentName.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            //UnCheckCheck Mark Document Name
            IWebElement UncheckDocumentName = PC.driver.FindElement(By.Id("menuitem-26"));
            UncheckDocumentName.Click();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            //Check Mark Comments
            IWebElement Comments = PC.driver.FindElement(By.Id("menuitem-29"));
            Comments.Click();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            //Verify Comments
            Assert.AreEqual("  Comments", PC.driver.FindElement(By.XPath("//button[contains(text(), 'Comments')]")).Text);

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            //Sort Comments Column
            PageObject.ColumnComments.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            //UnCheckCheck Mark Comments
            IWebElement UnCheckComments = PC.driver.FindElement(By.Id("menuitem-28"));
            UnCheckComments.Click();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            //Check Mark Archive Doc ID
            IWebElement ArchiveDocID = PC.driver.FindElement(By.Id("menuitem-31"));
            ArchiveDocID.Click();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            //Verify Archive Doc ID
            Assert.AreEqual("  Archive Doc ID", PC.driver.FindElement(By.XPath("//button[contains(text(), 'Archive Doc ID')]")).Text);

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            //Sort Archive Doc ID Column
            PageObject.ColumnArchiveDocID.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            //UnCheckCheck Mark Archive Doc ID
            IWebElement UnCheckArchiveDocID = PC.driver.FindElement(By.Id("menuitem-30"));
            UnCheckArchiveDocID.Click();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            //Select List Refresh          
            ListDropDownObjects.ListRefresh();

            //Select List Reset Grid
            var ResetGrid = new ListDropDownObjects(PC.driver);
            ListDropDownObjects.ListResetGrid();

            //Select List Reset Filters
            var ResetFilter = new ListDropDownObjects(PC.driver);
            ListDropDownObjects.ListResetFilters();

            //Select List Reset Sorting
            var ResetSorting = new ListDropDownObjects(PC.driver);
            ListDropDownObjects.ListResetSorting();
            System.Threading.Thread.Sleep(8000);

            //Select Find/Reset
            var FindIcon = new ListDropDownObjects(PC.driver);
            ListDropDownObjects.FindIcon();

            //Select Refresh
            var RefreshIcon = new ListDropDownObjects(PC.driver);
            ListDropDownObjects.RefreshIcon();

            ////Select Export All Rows Icon
            //var ExportAllRowsIcon = new ListDropDownObjects(PC.driver);
            //ListDropDownObjects.ExportAllRowsIcon();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            //Close Page
            PageObject.ButtonClose.Clicks();
        }
    

        [TearDown]
        public void TearDown()
        {
            if
                (TestContext.CurrentContext.Result.Outcome.Status.Equals
                (TestStatus.Failed))
                TakeScreenshot();

            
            PC.driver.Quit();
        }
    }
}

