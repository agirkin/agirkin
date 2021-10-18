using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using Microsoft.Office;
using Microsoft.Office.Interop.Excel;

namespace DCC
{
    public class ActivityCompaniesListProfileExportLogList
    {
        private void TakeScreenshot()
        {
            string SaveLocation = @"C:\Temp\" + "failshot_" +
            TestContext.CurrentContext.Test.FullName + ".png";
            ITakesScreenshot ScreenshotDriver = (ITakesScreenshot)PC.driver;           
            ScreenshotDriver.GetScreenshot().SaveAsFile(SaveLocation, ScreenshotImageFormat.Png);
        }
        //IWebPC.driver PC.driver = new ChromePC.driver();
        // IWebPC.driver PC.driver = new FirefoxPC.driver();
        //static void Main(string[] args)
        //{
        //}
        [SetUp]
        public void Initialize()
        {
            var ActivityCompaniesInitialize = new Initialize(PC.driver);
            ActivityCompaniesInitialize.ActivityCompaniesInitialize();

        }

        [Test]
        public void ActivityCompaniesListProfileExportLog_List()
        {
            WebDriverWait wait = new WebDriverWait(PC.driver, TimeSpan.FromSeconds(120));
            wait.Until(d => d.Title.StartsWith("PRISM DCC", StringComparison.OrdinalIgnoreCase));
            var PageObject = new PageObject(PC.driver);

            Assert.AreEqual("Companies", PC.driver.FindElement(By.XPath("//h2[contains(text(), 'Companies')]")).Text);

            Assert.AreEqual("PRISM DCC", PC.driver.Title);

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));


            var FindBasic = new Find(PC.driver);
            FindBasic.FindBasic();
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));
            System.Threading.Thread.Sleep(4000);

            var AgencyContains = new Find(PC.driver);
            AgencyContains.BasicFind("", "", "Automation Tool Company Do Not");

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            var ClickSearch = new Find(PC.driver);
            ClickSearch.ClickSearch();

            //Highlight Row
            IWebElement HighlightRow1 = PC.driver.FindElement(By.XPath("//div[contains(text(), 'Automation Tool Company Do Not')]"));
            HighlightRow1.Clicks();

            System.Threading.Thread.Sleep(2000);

            //Click Profile Button
            PageObject.ButtonProfile.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));


            //Click View Button
            PageObject.ButtonView.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            System.Threading.Thread.Sleep(2000);

            //Click Export Log Button
            PageObject.ButtonExportLog.Clicks();


            System.Threading.Thread.Sleep(2000);
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));


            Assert.AreEqual("Company: Export Log", PC.driver.FindElement(By.XPath("//h2[contains(text(), 'Company: Export Log')]")).Text);

            //Verify Open Screen
            Assert.AreEqual("Export Log: Automation Tool Company Do Not", PC.driver.FindElement(By.XPath("//a[contains(@ng-href, '/Companies/Profile;')][contains(text(), 'Export Log: Automation Tool Company Do Not')]")).Text);

            System.Threading.Thread.Sleep(2000);
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            //Select List Refresh     
            var ListDropDownObjects = new ListDropDownObjects(PC.driver);
            ListDropDownObjects.ListRefresh();

            //Select List Reset Grid           
            ListDropDownObjects.ListResetGrid();




            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            System.Threading.Thread.Sleep(2000);

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnDataSource.GetAttribute("Sort Ascending");

            PageObject.ColumnDataSource.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnClient.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnExportDate.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnDataAvailableFrom.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnDataAvailableTo.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            PageObject.ColumnTicketsExported.Clicks();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            //Select Columns Button
            PageObject.ButtonColumn.Clicks();


            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));

            //Verify Data Source Button
            Assert.AreEqual("  Data Source", PC.driver.FindElement(By.XPath("//button[contains(text(), 'Data Source')]")).Text);

            //Verify Client Button
            Assert.AreEqual("  Client", PC.driver.FindElement(By.XPath("//button[contains(text(), 'Client')]")).Text);

            //Verify Date Processed Button
            Assert.AreEqual("  Export Date", PC.driver.FindElement(By.XPath("//button[contains(text(), 'Export Date')]")).Text);

            //Verify Data Available From Button
            Assert.AreEqual("  Data Available From", PC.driver.FindElement(By.XPath("//button[contains(text(), 'Data Available From')]")).Text);

            //Verify Data Available To Button
            Assert.AreEqual("  Data Available To", PC.driver.FindElement(By.XPath("//button[contains(text(), 'Data Available To')]")).Text);

            //Verify Count Button
            Assert.AreEqual("  Tickets Exported", PC.driver.FindElement(By.XPath("//button[contains(text(), 'Tickets Exported')]")).Text);

            //Select List Refresh          
            ListDropDownObjects.ListRefresh();

            //Select List Reset Grid
            ListDropDownObjects.ListResetGrid();

            //Select List Reset Sorting
            var ResetSorting = new ListDropDownObjects(PC.driver);
            ListDropDownObjects.ListResetSorting();
            System.Threading.Thread.Sleep(8000);

            //Select Refresh
            var RefreshIcon = new ListDropDownObjects(PC.driver);
            ListDropDownObjects.RefreshIcon();

            //////Select Export All Rows Icon
            ////var ExportAllRowsIcon = new ListDropDownObjects(PC.driver);
            ////ListDropDownObjects.ExportAllRowsIcon();

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));


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


