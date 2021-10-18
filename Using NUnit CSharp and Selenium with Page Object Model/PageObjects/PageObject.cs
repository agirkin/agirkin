using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;
using System.Configuration;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace DCC
{
    public class PageObject : TestBase
    {
        public PageObject(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string Company = ConfigurationManager.AppSettings["Company"];
        public string LastName = ConfigurationManager.AppSettings["LastName"];
        public IWebElement ClientCompanyDD => FindElement(By.Name("SSCustomerCompanyId"));
        public IWebElement CustomerNumber => FindElement(By.Name("CustomerNo"));

        public void AssertResolvePageTitle()
        {
            Assert.AreEqual("Resolve", FindElement(By.XPath("//h4[contains(text(), 'Resolve')]")).Text);
            WaitUntilCurtain();
        }
        //Button Acknowledgements      
        public void ClickButtonAcknowledgements()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(), 'Acknowledgements')]")));
            WaitUntilCurtain();
        }
        //Button All
        public void ClickButtoncmdAll()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdAll']")));
            WaitUntilCurtain();
        }
        //Button Archive
        public void ClickButtoncmdArchive()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[@menu-command='cmdArchive']")));
            WaitUntilCurtain();
        }
        //Button Audit Log
        public void ClickButtonAuditLog()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[(@menu-command='cmdAuditLog')]")));
            WaitUntilCurtain();
        }
        //Button Cancel
        public void ClickButtonCancel()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[contains(text(), 'Cancel')]")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        public void ClickButtonPageCancel()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(), 'Cancel')]")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        public void ClickButtonTitleCancel()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(@menu-command, 'cmdCancel')]")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        //Button Carrier Detail       
        public void ClickButtonCarrierDetail()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(@menu-command, 'cmdCarrierDetail')]")));
            WaitUntilCurtain();
        }
        public void ClickButtonContinue()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[contains(text(), 'Continue')]")));
            WaitUntilCurtain();
        }
        //Button Reports Clog
        public void ClickButtonReportsClog()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@class, 'spark-icon spark-icon--lg spark-icon-cog')]")));
            WaitUntilCurtain();
        }
        //Button CheckIn     
        public void ClickButtoncmdCheckIn()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[(@menu-command='cmdCheckIn')]")));
            WaitUntilCurtain();
        }
        //Button Client Company View    
        public void ClickButtonClientCompanyView()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(@menu-command, 'cmdDccClientView')]")));
            WaitUntilCurtain();
        }
        //Button Clone       
        public void ClickButtoncmdClone()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(@menu-command, 'cmdClone')]")));
            WaitUntilCurtain();
        }
        //Button Close     
        public void ClickButtonClose()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(@menu-command, 'cmdClose')]")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        //Button Copy To       
        public void ClickButtonCopyTo()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@menu-command, 'cmdCopyTo')]")));
            WaitUntilCurtain();
        }
        public void ClickButtonDataSources()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@menu-command, 'cmdDataSource')]")));
            WaitUntilCurtain();
        }
        //Button Data Status     
        public void ClickButtonDataStatus()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@menu-command, 'cmdDataStatus')]")));
            WaitUntilCurtain();
        }
        //Button Data Status Detail      
        public void ClickButtonDataStatusDetail()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@menu-command, 'cmdDataStatusDetail')]")));
            WaitUntilCurtain();
        }
        //Button Data Status Detail      
        public void ClickButtonDelete()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@menu-command, 'cmdDelete')]")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        //Button Distribute       
        public void ClickButtonDistribute()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(@menu-command, 'cmdDistribute')]")));
            WaitUntilCurtain();
        }
        //Button Edit
        public void ClickButtonEdit()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdEdit']")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        //Button Edit Agency      
        public void ClickButtonEditAgency()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(@menu-command, 'cmdEditAgency')]")));
            WaitUntilCurtain();
        }
        //Button Email
        public void ClickButtonEmail()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[(@menu-command='cmdEmail')]")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        //Button History       
        public void ClickButtonHistory()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[(@menu-command='cmdHistory')]")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        //Button Event Log
        public void ClickButtonEventLog()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[(@menu-command='cmdActivityLog')]")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        //Button Export Log       
        public void ClickButtonExportLog()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[(@menu-command='cmdExportLog')]")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        //Button IATA Detail     
        public void ClickButtonIATADetail()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[@menu-command='cmdIATADetail']")));
            WaitUntilCurtain();
        }
        public void ClickButtonCarrierSummary()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[@menu-command='cmdDataImportLogCarrierSummary']")));
            WaitUntilCurtain();
        }
        //Button Import Log       
        public void ClickButtonImportLog()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[(@menu-command='cmdImportLog')]")));
            WaitUntilCurtain();
        }
        //Button Keywords        
        public void ClickButtonKeywords()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(@class, 'spark-icon filter-icon spark-popover__toggle spark-tooltip')]")));
            WaitUntilCurtain();
        }
        public void ClickButtonNew()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[text()='New']")));
            WaitUntilCurtain();
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        public void ClickNew()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[text()='New']")));
            WaitUntilCurtain();
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        //Button cmdNew       
        public void ClickButtoncmdNew()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtainsixty();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[@menu-command='cmdNew']")));
            WaitUntilCurtainninety();
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        public void ClickButtonNo()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[contains(@class, 'spark-btn--secondary') and text()='No']")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        public void ClickButtonOK()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[contains(text(), 'OK')]")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        public void ClickButtoncmdOpen()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(@menu-command, 'cmdOpen')]")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        //Button Process       
        public void ClickButtonProcess()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(@menu-command, 'cmdProcess')]")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        //Button Arrow
        public void ClickButtonArrow()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[@class='spark-icon--fill spark-icon-arrow-triangle-down ng-scope']")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        //Button Release      
        public void ClickButtonRelease()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(@menu-command, 'cmdRelease')]")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        //Button Remove Data
        public void ClickButtonRemoveData()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[@menu-command='cmdRemoveClientData']")));
            WaitUntilCurtain();
        }
        //Button Rename      
        public void ClickButtonRename()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Rename')]")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        public void ClickButtonReset()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[text()='Reset']")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        public void ClickButtonRun()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[text()='Run']")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        public void ClickButtonRunGroup()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[text()='Run Group']")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        public void ClickLinkTextContinue()
        {
            Actions ClickLinkTextResolve = new Actions(driver);
            ClickLinkTextResolve.MoveToElement(FindElement(By.XPath("//*[text()='Continue']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        public void ClickLinkTextResolve()
        {
            Actions ClickLinkTextResolve = new Actions(driver);
            ClickLinkTextResolve.MoveToElement(FindElement(By.XPath("//a[text()='Resolve']"))).Click().Build().Perform();
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        public void ClickLinkTextSave()
        {
            Actions ClickLinkTextSave = new Actions(driver);
            ClickLinkTextSave.MoveToElement(FindElement(By.XPath("//a[text()='Save']"))).Click().Build().Perform();
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed, "A system error has occurred");
        }

        //Button Save       
        public void ClickButtonSave()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[contains(text(), 'Save')]")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed, "A system error has occurred");
        }
        //Button Save and Send Spec 
        public void ClickButtonSaveandSendSpec()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(), 'Save and Send Spec')]")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }

        //Button Title Save
        public void ClickButtonTitleSave()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(@menu-command, 'cmdSave')]")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        public void ClickButtonSaveandClone()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdSaveAndClone']")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed, "A system error has occurred");
        }
        public void ClickButtonSaveandRun()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[text()='Save and Run']")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed, "A system error has occurred");
        }
        //Button cmdSend
        public void ClickButtoncmdSend()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(@menu-command, 'cmdSend')]")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        public void ClickButtonSourceDetails()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[(@menu-command='cmdSourceDetails')]")));
            WaitUntilCurtain();
        }

        //Button Ticketing Detail
        public void ClickButtonTicketingDetail()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('View')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Ticketing Detail')]")));
            WaitUntilCurtain120();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed, "A system error has occurred");
        }
        //Button View
        public void ClickButtonView()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(@menu-command, 'cmdView')]")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        //Button X      
        public void ClickButtonX()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[@class='close ui-select-match-close']")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        //Button Yes
        public void ClickButtonYes()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[contains(text(), 'Yes')]")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed, "A system error has occurred");
        }
        //Button Add Selected Reports 
        public void ClickButtonAddSelectedReports()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[contains(@ng-disabled, 'reportSetsNewEdit.reportsTabArrowButton_Disabled(reportSetsNewEdit, 0)')]")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        //CheckMark Allow others to run this set      
        public void ClickCheckMarkAllowotherstorunthisset()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(@class, 'spark-label') and text()='Allow others to run this set']")));
            WaitUntilCurtain();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed, "A system error has occurred");
        }
        public void ClientCompanyDisabled()
        {
            //Verify Client Company Disabled       
            Assert.AreEqual("Client Company", driver.FindElement(By.XPath("//span[@class='spark-label'][text()='Client Company']")).Text);
            Assert.AreEqual("true", FindElement(By.Name("SSCustomerCompanyId")).GetAttribute("disabled"));
            Assert.AreEqual(true, FindElement(By.Name("SSCustomerCompanyId")).Displayed);
        }
        public void CustomerNumberDisabled()
        {

            //Verify Customer Number Disabled       
            Assert.AreEqual("Customer Number", driver.FindElement(By.XPath("//span[@class='spark-label'][text()='Customer Number']")).Text);
            Assert.AreEqual("true", CustomerNumber.GetAttribute("disabled"));
            Assert.AreEqual(true, CustomerNumber.Displayed);
        }

            public void Dashboard()
        {
            //Verify Page Closed
            Assert.AreEqual("Welcome to DCC", FindElement(By.XPath("//div[contains(text(), 'Welcome to DCC')]")).Text);
            WaitUntilCurtain();
        }
        public void Delete()
        {
            PageObject pageObject = new PageObject(driver);

            //Click Delete
            pageObject.ClickButtonDelete();
            System.Threading.Thread.Sleep(3000);

            //Click Yes
            pageObject.ClickButtonYes();
            WaitUntilCurtain();

            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//h4[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed, "A system error has occurred");
        }
        public void SelectCustCompanyID()
        {
            //Select Company Drop Down 
            driver.FindElement(By.Name("CustomerCompanyId")).Click();
            WaitUntilCurtain();
            driver.FindElement(By.XPath("html/body/div[2]/input[1]")).SendKeys(Company);
            driver.FindElement(By.XPath("//span[@class='ui-select-highlight']")).Click();
            WaitUntilCurtain();
        }
        public void SelectDataSourceID(string DataSource)
        {
            //Select Data Source Drop Down 
            System.Threading.Thread.Sleep(5000);
            FindElement(By.Name("DataSourceId")).Click();
            WaitUntilCurtain();
            FindElement(By.XPath("html/body/div[3]/input[1]")).SendKeys(DataSource);
            WaitUntilCurtain();
            FindElement(By.XPath("//span[@class='ui-select-highlight']")).Click();
            WaitUntilCurtain();
        }
        public void EnterIATANumber(string IATANumber)
        {
            // Verify IATA Number
            Assert.AreEqual("IATA Number", FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'IATA Number')]")).Text);

            //Enter IATA Number
            FindElement(By.Name("IataNo")).SendKeys(IATANumber);
        }
        public void HighlightFirstRow()
        {
            //Highlight Row
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", WaitbyXPathClickable(driver, "//div[@class='ui-grid-cell-contents ng-binding ng-scope']"));
        }
        public void SelectDropDownAgency(string Agency)
        {
            IWebElement AgencyDropDown = FindElement(By.Name("AgencyId"));
            AgencyDropDown.Click();
            WaitUntilCurtainninety();
            FindElement(By.XPath("//div[@name='AgencyId']/input[1]")).SendKeys(Agency);
            Thread.Sleep(3000);
            FindElement(By.XPath("//span[@class='ui-select-highlight']")).Click();
            WaitUntilCurtain();
            string actualvalueAgency = AgencyDropDown.Text;
            Assert.IsTrue(actualvalueAgency.Contains(Agency), actualvalueAgency + " doesn't contains 'Agency'");
        }
        //Drow Down Carrier    
        public void SelectDropDownCarrier(string Carrier)
        {
            //Select Carrier Drop Down (Client)
            IWebElement SelectCarrier = WaitbyNameClickable(driver, "CarrierCode");
            SelectCarrier.Click();
            WaitUntilCurtain();
            FindElement(By.XPath("html/body/div[3]/input[1]")).SendKeys(Carrier);
            FindElement(By.XPath("//span[@class='ui-select-highlight']")).Click();
            WaitUntilCurtain();
        }
        //Column Account Type        
        public void SortColumnAccountType()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Account Type')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Accounting System  
        public void SortColumnAccountingSystem()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Interface Name')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }

        //Sort Column Action Date       
        public void SortColumnActionDate()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Action Date'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Sort Column Active       
        public void SortColumnActive()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Active'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Sort Column Active       
        public void SortColumnActivityItem()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Activity Item'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Sort Column Active       
        public void SortColumnActivityType()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Activity Type'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Sources Agency            
        public void SortColumnSourceAgency()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Agency'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Aircraft Code 
        public void SortColumnAircraftCode()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Aircraft Code'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        public void SortColumnAirlineClient()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Airline/Client'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();

            //Verify Sort Order        
            //            Assert.IsTrue(FindElement(By.XPath("//*[text()='Airline/Client']/following-sibling::span[@aria-label='Sort Ascending']")).Displayed);
        }
        //Column Airport
        public void SortColumnAirport()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Airport'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column All Carriers     
        public void SortColumnAllCarriers()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='All Carriers'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column All Customers     
        public void SortColumnAllCustomers()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='All Customers'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column All Dates
        public void SortColumnAllDates()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='All Dates'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Allow Others       
        public void SortColumnAllowothers()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Allow Others'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Amount
        public void SortColumnAmount()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Amount'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Application Debug Log ID
        public void SortColumnApplicationDebugLogID()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Application Debug Log ID'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Archive Doc ID       
        public void SortColumnColumnArchiveDocID()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Archive Doc ID'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Archived
        public void SortColumnArchived()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Archived'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Assigned To
        public void SortColumnAssignedTo()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Assigned To'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Audits
        public void SortColumnAudits()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Audits'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Audit Name       
        public void SortColumnAuditName()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Audit Name'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Begin Date
        public void SortColumnBeginDate()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Begin Date'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Button String
        public void SortColumnButtonString()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Button String'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Cabin
        public void SortColumnCabin()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Cabin'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Canceled
        public void SortColumnCanceled()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Cancelled'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }

        //Column Carrier 
        public void SortColumnCarrier()
        {
            Actions Carrier = new Actions(driver);
            Carrier.MoveToElement(FindElement(By.XPath("//span[text()='Carrier'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Carriers
        public void SortColumnCarriers()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Carriers')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Carrier Code 
        public void SortColumnCarrierCode()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Carrier Code')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Carrier in File
        public void SortColumnCarrierInFile()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Carrier in File')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Carrier Number 
        public void SortColumnCarrierNumber()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Carrier Number')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Changed By
        public void SortColumnChangedBy()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Changed By')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Chase Status
        public void SortColumnChaseStatus()
        {
            Actions ChaseStatus = new Actions(driver);
            ChaseStatus.MoveToElement(FindElement(By.XPath("//span[text()='Chase Status'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
        }
        //Column Client
        public void SortColumnClient()
        {
            Actions Client = new Actions(driver);
            Client.MoveToElement(FindElement(By.XPath("//span[contains(text(), 'Client')][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
        }
        //Column Client Code
        public void SortColumnClientCode()
        {
            Actions ClientCode = new Actions(driver);
            ClientCode.MoveToElement(FindElement(By.XPath("//span[contains(text(), 'Client Code')][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
        }
        //Column Client Company
        public void SortColumnClientCompany()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            IWebElement ClientCompany = FindElement(By.XPath("//span[text()='Client Company'][@class='ui-grid-header-cell-label ng-binding']"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView()",
            ClientCompany);
            js.ExecuteScript("arguments[0].click();", ClientCompany);
            WaitUntilCurtain();
        }
        //Column Code        
        public void SortColumnCode()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Code'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Combine Source Status
        public void SortColumnCombineSourceStatus()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Source Status')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Comments
        public void SortColumnComments()
        {
            Actions Comments = new Actions(driver);
            Comments.MoveToElement(FindElement(By.XPath("//span[text()='Comments'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Company    
        public void SortColumnCompany()
        {
            Actions Company = new Actions(driver);
            Company.MoveToElement(FindElement(By.XPath("//span[contains(text(), 'Company')][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Company ID
        public void SortColumnCompanyID()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Company ID')]")));
            WaitUntilCurtain();
        }
        //Column Company Type
        public void SortColumnCompanyType()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Company Type')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Completed Date
        public void SortColumnCompletedDate()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Completed Date'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        public void SortColumnContactID()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Contact ID')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Continent
        public void SortColumnContinent()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Continent'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Corrected Carrier

        //Column Continent
        public void SortColumnCorrectedCarrier()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Corrected Carrier'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Corrective Action
        public void SortColumnCorrectiveAction()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Corrective Action'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Country
        public void SortColumnCountry()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Country'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Create Date
        public void SortColumnCreateDate()
        {
            Actions CreateDate = new Actions(driver);
            CreateDate.MoveToElement(FindElement(By.XPath("//span[contains(text(), 'Create Date')][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
        }
        public void SortColumnCreatedBy()
        {
            Actions CreatedBy = new Actions(driver);
            CreatedBy.MoveToElement(FindElement(By.XPath("//span[contains(text(), 'Created By')][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
        }
        //Column Created On
        public void SortColumnCreatedOn()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Created On'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column custCompanyID Hover
        public void SortColumnCustCompanyID()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'CustCompanyID')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Customer Number
        public void SortColumnCustomerNumber()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Customer Number'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Data Available From
        public void SortColumnDataAvailableFrom()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Data Available From'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Data Available To
        public void SortColumnDataAvailableTo()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Data Available To'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Data Agreement       
        public void SortColumnDataAgreement()
        {
            FindElement(By.XPath("//span[text()='Data Agreement']")).Click();
            WaitUntilCurtain();
        }
        //Column Data Source
        public void SortColumnDataSource()
        {
            Actions DataSource = new Actions(driver);
            DataSource.MoveToElement(FindElement(By.XPath("//span[text()='Data Source'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtainsixty();
        }
        //Column DataSourceID
        public void SortColumnDataSourceIDOneWord()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'DataSourceID')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Data Source ID
        public void SortColumndataSourceID()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'dataSourceID')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Data Source ID
        public void SortColumnDataSourceID()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//*[contains(text(), 'Data Source ID')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Data Sources
        public void SortColumnDataSources()
        {
            Actions DataStatus = new Actions(driver);
            DataStatus.MoveToElement(FindElement(By.XPath("//span[text()='Data Source'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
        }
        //Column Data Status
        public void SortColumnDataStatus()
        {
            Actions DataStatus = new Actions(driver);
            DataStatus.MoveToElement(FindElement(By.XPath("//span[text()='Data Status'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Date
        public void SortColumnDate()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Date')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Date Processed
        public void SortColumnDateProcessed()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Date Processed')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column DCC Company
        public void SortColumnDCCCompany()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            IWebElement DCCCompany = FindElement(By.XPath("//span[contains(text(), 'DCC Company')][contains(@id, 'header-text')]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView()",
            DCCCompany);
            js.ExecuteScript("arguments[0].click();", DCCCompany);
            WaitUntilCurtain();
        }
        //Column Debug Message
        public void SortColumnDebugMessage()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Debug Message')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Defined Value
        public void SortColumnDefinedValue()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Defined Value')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Description
        public void SortColumnDescription()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Description')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Document
        public void SortColumnDocument()
        {
            FindElement(By.XPath("//span[contains(text(), 'Document')]")).Click();
            WaitUntilCurtainninety();

            //Verify Sort Order        
            Assert.IsTrue(FindElement(By.XPath("//*[text()='Document']/following-sibling::span[@aria-label='Sort Ascending']")).Displayed);
        }
        //Column Document Name
        public void SortColumnDocumentName()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Document Name')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Document Type
        public void SortColumnDocumentType()
        {
            FindElement(By.XPath("//span[contains(text(), 'Document Type')]")).Click();
            WaitUntilCurtainninety();
        }
        //Column DRAID
        public void SortColumnDRAID()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'DRAID')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column DRA #       
        public void SortColumnDRA()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'DRA #')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        public void SortColumnDRARequired()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'DRA Required')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Due Date
        public void SortColumnDueDate()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Due Date'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column End Date
        public void SortColumnEndDate()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='End Date'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Event
        public void SortColumnEvent()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Event'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Expired
        public void SortColumnExpired()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Expired'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Export Date
        public void SortColumnExportDate()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Export Date'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtainninety();
        }
        //Column Export ID
        public void SortColumnExportID()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Export ID'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Failed
        public void SortColumnFailed()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Failed'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column % Failed
        public void SortColumnPercentFailed()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='% Failed'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column File Location
        public void SortColumnFileLocation()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='File Location'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column File Name
        public void SortColumnFileName()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='File Name'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column File Name and Path
        public void SortColumnFileNameandPath()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='File Name and Path'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column File Path
        public void SortColumnFilePath()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='File Path'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Finished
        public void SortColumnFinished()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Finished'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column First Ticket Date
        public void SortColumnFirstTicketDate()
        {
            Actions FirstTicketDate = new Actions(driver);
            FirstTicketDate.MoveToElement(FindElement(By.XPath("//span[contains(text(), 'First Ticket Date')][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtainsixty();
        }
        //Column Frequency
        public void SortColumnFrequency()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Frequency'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column From Company
        public void SortColumnFromCompany()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='From Company'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column FTP Site
        public void SortColumnFTPSite()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='FTP Site'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column FTP Folder
        public void SortColumnFTPFolder()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='FTP Folder'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Home IATA Number
        public void SortColumnHomeIATANumber()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Home IATA Number'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Host IATA Number
        public void SortColumnHostIATANumber()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Host IATA Number'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column IATA Number
        public void SortColumnIATANumber()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='IATA Number'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column ICAO Code 
        public void SortColumnICAOCode()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='ICAO Code'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Import Date
        public void SortColumnImportDate()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Import Date'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Import ID
        public void SortColumnImportID()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Import ID'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Industry
        public void SortColumnIndustry()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Industry'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }

        //Column SortColumnInterfaceName
        public void SortColumnInterfaceName()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Interface Name'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }

        //Column Invoice
        public void SortColumnInvoice()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Invoice'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Is Current Version
        public void SortColumnIsCurrentVersion()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Is Current Version'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Is Deleted
        public void SortColumnIsDeleted()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Is Deleted'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Issue Date
        public void SortColumnIssueDate()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Issue Date'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Issue Month
        public void SortColumnIssueMonth()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Issue Month'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Issue Year 
        public void SortColumnIssueYear()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Issue Year'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Keyword
        public void SortColumnKeyword()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Keyword'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Last Action
        public void SortColumnLastAction()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Last Action'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Last Chased By
        public void SortColumnLastChasedBy()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Last Chased By'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Last Modified
        public void SortColumnLastModified()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Last Modified'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Last Run
        public void SortColumnLastRun()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Last Run'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Last Run Status
        public void SortColumnLastRunStatus()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Last Run Status'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtainsixty();
        }
        //Column Last Ticket Date
        public void SortColumnLastTicketDate()
        {
            Actions LastTicketDate = new Actions(driver);
            LastTicketDate.MoveToElement(driver.FindElement(By.XPath("//span[contains(text(), 'Last Ticket Date')][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtainsixty();
        }
        //Column Lead Carrier
        public void SortColumnLeadCarrier()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Lead Carrier'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtainsixty();
        }
        //Column Local Source
        public void SortColumnLocalSource()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Local SOurce'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Location
        public void SortColumnLocation()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Location'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Log Date/Time
        public void SortColumnLogDateTime()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Log Date/Time'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Log Level
        public void SortColumnLogLevel()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Log Level'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Message
        public void SortColumnMessage()
        {
            WaitbyXPathClickable(driver, "//span[text()='Message'][@class='ui-grid-header-cell-label ng-binding']").Click();
            WaitUntilCurtain();
        }
        //Column Modified Date
        public void SortColumnModifiedDate()
        {
            FindElement(By.XPath("//span[contains(text(), 'Modified Date')]")).Click();
            WaitUntilCurtainninety();

            //Verify Sort Order        
            Assert.IsTrue(FindElement(By.XPath("//*[text()='Modified Date']/following-sibling::span[@aria-label='Sort Ascending']")).Displayed);
        }
        //Column Month
        public void SortColumnMonth()
        {
            Actions DataStatus = new Actions(driver);
            DataStatus.MoveToElement(FindElement(By.XPath("//span[text()='Month'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Multiple Sources 
        public void SortColumnMultipleSources()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Multiple Sources'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Name
        public void SortColumnName()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Name'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Net Tickets Loaded
        public void SortColumnNetTicketsLoaded()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Net Tickets Loaded'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Next Run
        public void SortColumnNextRun()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Next Run'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Notified
        public void SortColumnNotified()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Notified'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtainninety();
        }
        //Column Number of Companies
        public void SortColumnNumberofCompanies()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Number of Companies'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Office Type
        public void SortColumnOfficeType()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Office Type'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Operator
        public void SortColumnOperator()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Operator'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        public void SortColumnOrder()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Order')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }

        public void SortColumnOwnedBy()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Owned By'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Pending
        public void SortColumnPending()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Pending'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Privilege
        public void SortColumnPrivilege()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Privilege'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Primary Contact
        public void SortColumnPrimaryContact()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Primary Contact'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Process
        public void SortColumnColumnProcess()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Process'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }

        //Column Production Date
        public void SortColumnProductionDate()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Production Date'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }

        //Column Process Status
        public void SortColumnProcessStatus()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Process Status'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        public void SortColumnQuestion()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Question'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Raw Carrier
        public void SortColumnRawCarrier()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Raw Carrier'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Reason
        public void SortColumnReason()
        {
            Actions Reason = new Actions(driver);
            Reason.MoveToElement(FindElement(By.XPath("//span[contains(text(), 'Reason')][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Received
        public void SortColumnReceived()
        {
            Actions Received = new Actions(driver);
            Received.MoveToElement(FindElement(By.XPath("//span[contains(text(), 'Received')][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Release Type
        public void SortColumnReleaseType()
        {
            Actions ReleaseType = new Actions(driver);
            ReleaseType.MoveToElement(FindElement(By.XPath("//span[contains(text(), 'Release Type')][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Request Date
        public void SortColumnRequestDate()
        {
            Actions RequestDate = new Actions(driver);
            RequestDate.MoveToElement(FindElement(By.XPath("//span[contains(text(), 'Request Date')][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column RequestTypeID
        public void SortColumnRequestTypeID()
        {
            Actions RequestTypeID = new Actions(driver);
            RequestTypeID.MoveToElement(FindElement(By.XPath("//span[contains(text(), 'Request Type ID')][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Requested By
        public void SortColumnRequestedBy()
        {
            Actions RequestedBy = new Actions(driver);
            RequestedBy.MoveToElement(FindElement(By.XPath("//span[contains(text(), 'Requested By')][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Requested From
        public void SortColumnRequestedFrom()
        {
            Actions RequestedFrom = new Actions(driver);
            RequestedFrom.MoveToElement(FindElement(By.XPath("//span[contains(text(), 'Requested From')][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Requested To      
        public void SortColumnRequestedTo()
        {
            Actions RequestedTo = new Actions(driver);
            RequestedTo.MoveToElement(FindElement(By.XPath("//span[contains(text(), 'Requested To')][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Security Role ID
        public void SortColumnSecurityRoleID()
        {
            Actions SecurityRoleID = new Actions(driver);
            SecurityRoleID.MoveToElement(FindElement(By.XPath("//span[contains(text(), 'Security Role ID')][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Segment Count
        public void SortColumnSegmentCount()
        {
            Actions SegmentCount = new Actions(driver);
            SegmentCount.MoveToElement(FindElement(By.XPath("//span[contains(text(), 'Segment Count')][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Set Name
        public void SortColumnSetName()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Set Name'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Source
        public void SortColumnSource()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Source'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Source Company ID
        public void SortColumnSourceCompanyID()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Source Company ID')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Source Status
        public void SortColumnSourceStatus()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Source Status'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Special Export
        public void SortColumnSpecialExport()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Special Export'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column SSCompanyID
        public void SortColumnSSCompanyID()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'SSCompanyID')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column SSCustCompanyID
        public void SortColumnSSCustCompanyID()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'SSCustCompanyID')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Stack Trace
        public void SortColumnStackTrace()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Stack Trace')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Start Date
        public void SortColumnStartDate()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Start Date')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Started 
        public void SortColumnStarted()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Started'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Status 
        public void SortColumnStatus()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Status'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column State Province
        public void SortColumnStateProvince()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='State/Province'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Step Failed
        public void SortColumnStepFailed()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Step Failed'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Step Id
        public void SortColumnStepID()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Step ID'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Step Name
        public void SortColumnStepName()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Step Name'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        public void SortColumnStepStatus()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Step Status'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Stored By Contact ID
        public void SortColumnStoredByContactID()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Stored By Contact ID')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Stored By User Name
        public void SortColumnStoredByUserName()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'StoredByUserName')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Subtitle
        public void SortColumnSubtitle()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Subtitle'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Support ID
        public void SortColumnSupportID()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Support ID'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Suspect
        public void SortColumnSuspect()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Suspect'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        public void SortColumnSuspended()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Suspended'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column System Source
        public void SortColumnSystemSource()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='System Source'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Tickets
        public void SortColumnTickets()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Tickets'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Ticket Number
        public void SortColumnTicketNumber()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Ticket Number'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Tickets Exported
        public void SortColumnTicketsExported()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Tickets Exported'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Tickets In File
        public void SortColumnTicketsInFile()
        {
            Actions DataStatus = new Actions(driver);
            DataStatus.MoveToElement(FindElement(By.XPath("//span[text()='Tickets In File'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
        }
        //Column Ticketing Country
        public void SortColumnTicketingCountry()
        {
            Actions DataStatus = new Actions(driver);
            DataStatus.MoveToElement(FindElement(By.XPath("//span[text()='Ticketing Country/Region'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
        }
        //Column Tickets Deleted
        public void SortColumnTicketsDeleted()
        {
            Actions DataStatus = new Actions(driver);
            DataStatus.MoveToElement(FindElement(By.XPath("//span[text()='Tickets Deleted'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
        }
        //Column Ticket Loaded
        public void SortColumnTicketLoaded()
        {
            Actions DataStatus = new Actions(driver);
            DataStatus.MoveToElement(FindElement(By.XPath("//span[text()='Ticket Loaded'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
        }
        //Column Tickets Loaded
        public void SortColumnTicketsLoaded()
        {
            Actions DataStatus = new Actions(driver);
            DataStatus.MoveToElement(FindElement(By.XPath("//span[text()='Tickets Loaded'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
        }
        //Column Tickets Received
        public void SortColumnTicketsReceived()
        {
            Actions DataStatus = new Actions(driver);
            DataStatus.MoveToElement(FindElement(By.XPath("//span[text()='Tickets Received'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
        }
        //Column Total
        public void SortColumnTotal()
        {
            Actions DataStatus = new Actions(driver);
            DataStatus.MoveToElement(FindElement(By.XPath("//span[text()='Total'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
        }
        //Column Total Segment

        public void SortColumnTotalSegment()
        {
            Actions DataStatus = new Actions(driver);
            DataStatus.MoveToElement(FindElement(By.XPath("//span[text()='Total Segments'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
        }
        //Column Total Transactions
        public void SortColumnTotalTransactions()
        {
            Actions DataStatus = new Actions(driver);
            DataStatus.MoveToElement(FindElement(By.XPath("//span[text()='Total Transactions'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
        }
        //Column Trans No 
        public void SortColumnTransNo()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//span[contains(text(), 'Trans No')][contains(@id, 'header-text')]")));
            WaitUntilCurtain();
        }
        //Column Type 
        public void SortColumnType()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Type'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column User ID
        public void SortColumnUserId()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='User ID'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column User Name
        public void SortColumnUserName()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='User Name'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Column Web Server
        public void SortColumnWebServer()
        {
            Actions SortColumn = new Actions(driver);
            SortColumn.MoveToElement(FindElement(By.XPath("//span[text()='Web Server'][@class='ui-grid-header-cell-label ng-binding']"))).Click().Build().Perform();
            WaitUntilCurtain();
        }
        //Drop Down List Accounting Sysytem

        public void DDLInterfaceName(string InterfaceName)
        {
            //Actions DDLInterfaceName = new Actions(driver);
            //driver.FindElement(By.Name("DataInterfaceId")).ComboBox().SelectByText(InterfaceName);
            //DDLAccountingSystem.MoveToElement(FindElement(By.Name("AccountingSystemId"))).Click().Build().Perform();
            //WaitUntilCurtain();
            //WaitUntilCurtain();
            //FindElement(By.Name("AccountingSystemId")).SendKeys(AccountingSystem);
            WaitUntilCurtain();
        }
        ////Label Requested By
        //[FindsBy(How = How.XPath, Using = "//span[contains(@class, 'spark-label')][contains(text(), 'Requested By')]")]
        //public IWebElement LabelRequestedBy { get; set; }






        //Highlight Process Row     
        public void HighlightProcessRow()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("(//div[contains(text(), 'Successful')][@class='ui-grid-cell-contents ng-binding ng-scope'])[1]")));
            WaitUntilCurtain();
        }
        public void ClickColumnButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//div[contains(@class, 'ui-grid-icon-container')]")));
            WaitUntilCurtain();
        }
        public void ClickProfile()
        {
            IJavaScriptExecutor Profile = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            Profile.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//a[@menu-command='cmdProfile']")));
        }
        public void SortColumnAgency()
        {
            FindElement(By.XPath("//span[contains(text(), 'Agency')]")).Click();
            WaitUntilCurtainninety();
        }
        public void SortColumnCity()
        {
            FindElement(By.XPath("//span[text()='City']")).Click();
            WaitUntilCurtain120();
        }
        public void SortColumnContact()
        {
            FindElement(By.XPath("//span[contains(text(), 'Contact')]")).Click();
            WaitUntilCurtainninety();

            //Verify Sort Order        
            Assert.IsTrue(FindElement(By.XPath("//*[text()='Contact']/following-sibling::span[@aria-label='Sort Ascending']")).Displayed);
        }

        public void SortColumnEmail()
        {
            FindElement(By.XPath("//span[contains(text(), 'Email')]")).Click();
            WaitUntilCurtainninety();
        }
        public void SortColumnFirstName()
        {
            FindElement(By.XPath("//span[contains(text(), 'First Name')]")).Click();
            WaitUntilCurtainninety();
        }
        public void SortColumnLastName()
        {
            FindElement(By.XPath("//span[contains(text(), 'Last Name')]")).Click();
            WaitUntilCurtainninety();
        }
        public void SortColumnPhone()
        {
            FindElement(By.XPath("//span[contains(text(), 'Phone')]")).Click();
            WaitUntilCurtainninety();
        }
        public void SortColumnRole()
        {
            FindElement(By.XPath("//span[contains(text(), 'Role')]")).Click();
            WaitUntilCurtainninety();
        }
        public void SortColumnStoredBy()
        {
            FindElement(By.XPath("//span[contains(text(), 'Stored By')]")).Click();
            WaitUntilCurtainninety();

            //Verify Sort Order        
            Assert.IsTrue(FindElement(By.XPath("//*[text()='Stored By']/following-sibling::span[@aria-label='Sort Ascending']")).Displayed);
        }
        public void SortColumnStoredDate()
        {
            FindElement(By.XPath("//span[contains(text(), 'Stored Date')]")).Click();
            WaitUntilCurtainninety();
        }

        public void SortColumnTitle()
        {
            FindElement(By.XPath("//span[contains(text(), 'Title')]")).Click();
            WaitUntilCurtainninety();
        }
        //Column Year
        public void SortColumnYear()
        {
            FindElement(By.XPath("//span[contains(text(), 'Year')]")).Click();
            WaitUntilCurtainninety();
        }
        public void VerifyFieldTitle()
        {
            //Verify Document Field Title
            IWebElement PageTitle = FindElement(By.XPath("//span[contains(@class, 'spark-label')][contains(text(), 'Document')]"));
            Assert.AreEqual("Document", PageTitle.Text);
            WaitUntilCurtain();
        }
        //Upload
        public void Upload()
        {
            //string File = "Testing document afkjsdklajfd.docx";
            //string FilePath = Environment.CurrentDirectory + $"C:/SRC/PRISM/QA/DCC/Main/DCC.RegressionTests/ExcelData/";

            //Thread.Sleep(4000);
            IWebElement UploadButton = WaitbyXPathClickable(driver, "(//button[contains(@class, 'spark-btn spark-btn--xs')][contains(@ngf-select, 'fileUpload.uploadFiles($files)')])[1]");
            UploadButton.Click();
            //driver.FindElement(By.Id("file-upload")).SendKeys(FilePath);
            //driver.FindElement(By.Id("file-submit")).Click();
            //IWebElement FileUploaded = driver.FindElement(By.Id("uploaded-files"));

            //Assert.IsTrue(FileUploaded.Text == File, "Document Did not Upload Correctly");
            //Thread.Sleep(4000);
            Actions action = new Actions(driver);
            action.SendKeys(OpenQA.Selenium.Keys.Escape);
            Thread.Sleep(4000);
            SendKeys.SendWait(@"C:\SRC\PRISM\QA\DCC\Main\DCC.RegressionTests\ExcelData\");
            //Thread.Sleep(4000);
            SendKeys.SendWait("Testing document afkjsdklajfd.docx");
            //Thread.Sleep(4000);
            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(4000);

            //verify Document
            IWebElement Document = WaitbyXPathVisible(driver, "//span[contains(text(), 'Testing document')]");
            Assert.AreEqual(true, Document.Displayed, "Document Did not Upload Correctly");
        }
        //Enter Comments
        public void EnterComments()
        {
            string Comments = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            FindElement(By.Name("Comments")).SendKeys(Comments);
            WaitUntilCurtain();
        }
        public void AmendDisabled()
        {
            //Verify Amend Disabled       
            IWebElement Amend = FindElement(By.LinkText("AMEND"));
            Assert.AreEqual("true", Amend.GetAttribute("disabled"));
            Assert.AreEqual(true, Amend.Displayed);
        }
        public void ApproveDisabled()
        {
            //Verify Approve Disabled       
            IWebElement Approve = FindElement(By.LinkText("APPROVE"));
            Assert.AreEqual("true", Approve.GetAttribute("disabled"));
            Assert.AreEqual(true, Approve.Displayed);
        }
        public void ArchiveDisabled()
        {
            //Verify Archive Disabled       
            IWebElement Archive = FindElement(By.LinkText("ARCHIVE"));
            Assert.AreEqual("true", Archive.GetAttribute("disabled"));
            Assert.AreEqual(true, Archive.Displayed);
        }
        public void AssignDisabled()
        {
            //Verify Assign Disabled       
            IWebElement Assign = FindElement(By.LinkText("ASSIGN"));
            Assert.AreEqual("true", Assign.GetAttribute("disabled"));
            Assert.AreEqual(true, Assign.Displayed);
        }
        public void AssignEnabled()
        {
            //Verify Assign Enabled       
            IWebElement Assign = FindElement(By.LinkText("ASSIGN"));
            Assert.IsTrue(Assign.Enabled);
            Assert.AreEqual(true, Assign.Displayed);
        }
        public void AuditLogDisabled()
        {
            //Verify Audit Log Disabled       
            IWebElement AuditLog = FindElement(By.LinkText("AUDIT LOG"));
            Assert.AreEqual("true", AuditLog.GetAttribute("disabled"));
            Assert.AreEqual(true, AuditLog.Displayed);
        }
        public void CancelDisabled()
        {
            //Verify Cancel Disabled       
            IWebElement Cancel = FindElement(By.LinkText("CANCEL"));
            Assert.AreEqual("true", Cancel.GetAttribute("disabled"));
            Assert.AreEqual(true, Cancel.Displayed);
        }
        public void CarrierDetailDisabled()
        {
            //Verify Carrier Detail Disabled       
            IWebElement CarrierDetail = FindElement(By.LinkText("CARRIER DETAIL"));
            Assert.AreEqual("true", CarrierDetail.GetAttribute("disabled"));
            Assert.AreEqual(true, CarrierDetail.Displayed);
        }
        public void CheckInDisabled()
        {
            //Verify CheckIn Disabled       
            IWebElement CheckIn = FindElement(By.LinkText("CHECK IN"));
            Assert.AreEqual("true", CheckIn.GetAttribute("disabled"));
            Assert.AreEqual(true, CheckIn.Displayed);
        }
        public void CloneDisabled()
        {
            //Verify Clone Disabled       
            IWebElement Clone = FindElement(By.LinkText("CLONE"));
            Assert.AreEqual("true", Clone.GetAttribute("disabled"));
            Assert.AreEqual(true, Clone.Displayed);
        }
        public void CommentDisabled()
        {
            //Verify Comment Disabled       
            IWebElement Comment = FindElement(By.LinkText("COMMENT"));
            Assert.AreEqual("true", Comment.GetAttribute("disabled"));
            Assert.AreEqual(true, Comment.Displayed);
        }
        public void CommentEnabled()
        {
            IWebElement Comment = FindElement(By.LinkText("COMMENT"));
            Assert.IsTrue(Comment.Enabled);
            Assert.AreEqual(true, Comment.Displayed);
        }
        public void CopyToDisabled()
        {
            //Verify Copy To Disabled          
            IWebElement CopyTo = FindElement(By.LinkText("COPY TO"));
            Assert.AreEqual("true", CopyTo.GetAttribute("disabled"));
            Assert.AreEqual(true, CopyTo.Displayed);
        }
        public void CreateEventDisabled()
        {
            //Verify Create Event Disabled          
            IWebElement CreateEvent = FindElement(By.LinkText("CREATE EVENT"));
            Assert.AreEqual("true", CreateEvent.GetAttribute("disabled"));
            Assert.AreEqual(true, CreateEvent.Displayed);
        }
        public void CreateEventEnabled()
        {
            IWebElement CreateEvent = FindElement(By.LinkText("CREATE EVENT"));
            Assert.IsTrue(CreateEvent.Enabled, "Create Event not Enabled");
            Assert.AreEqual(true, CreateEvent.Displayed);
        }
        public void DataSourcesDisabled()
        {
            //Verify Data Sources Disabled       
            IWebElement DataSources = FindElement(By.LinkText("DATA SOURCES"));
            Assert.AreEqual("true", DataSources.GetAttribute("disabled"));
            Assert.AreEqual(true, DataSources.Displayed);
        }
        public void DeleteDisabled()
        {
            //Verify Delete Disabled       
            IWebElement Delete = FindElement(By.LinkText("DELETE"));
            Assert.AreEqual("true", Delete.GetAttribute("disabled"));
            Assert.AreEqual(true, Delete.Displayed);
        }
        public void DeleteEnabled()
        {
            IWebElement Delete = FindElement(By.LinkText("DELETE"));
            Assert.IsTrue(Delete.Enabled);
            Assert.AreEqual(true, Delete.Displayed);
        }
        public void DetailDisabled()
        {
            //Verify Detail Disabled       
            IWebElement Detail = FindElement(By.LinkText("DETAIL"));
            Assert.AreEqual("true", Detail.GetAttribute("disabled"));
            Assert.AreEqual(true, Detail.Displayed);
        }
        public void DetailEnabled()
        {
            IWebElement Detail = FindElement(By.LinkText("DETAIL"));
            Assert.IsTrue(Detail.Enabled);
            Assert.AreEqual(true, Detail.Displayed);
        }
        public void DistributeDisabled()
        {
            //Verify Distribute Disabled       
            IWebElement Distribute = FindElement(By.LinkText("DISTRIBUTE"));
            Assert.AreEqual("true", Distribute.GetAttribute("disabled"));
            Assert.AreEqual(true, Distribute.Displayed);
        }
        public void DownDisabled()
        {
            //Verify Down Disabled       
            IWebElement Down = FindElement(By.LinkText("DOWN"));
            Assert.AreEqual("true", Down.GetAttribute("disabled"));
            Assert.AreEqual(true, Down.Displayed);
        }
        public void EditDisabled()
        {
            //Verify Edit Disabled       
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
            IWebElement Edit = wait.Until(d => d.FindElement(By.LinkText("EDIT")));
            Assert.AreEqual("true", Edit.GetAttribute("disabled"));
            Assert.AreEqual(true, Edit.Displayed);
        }
        public void EditEnabled()
        {
            IWebElement Edit = FindElement(By.LinkText("EDIT"));
            Assert.IsTrue(Edit.Enabled);
            Assert.AreEqual(true, Edit.Displayed);
        }
        public void EditSecondDisabled()
        {
            //Verify Edit Disabled 
            IWebElement Edit = WaitForDisplayedElement(By.XPath("(//a[@menu-command='cmdEdit'])[2]"));
            Assert.AreEqual("true", Edit.GetAttribute("disabled"));
            Assert.AreEqual(true, Edit.Displayed);
        }
        public void EmailDisabled()
        {
            //Verify Email Disabled       
            IWebElement Email = FindElement(By.LinkText("EMAIL"));
            Assert.AreEqual("true", Email.GetAttribute("disabled"));
            Assert.AreEqual(true, Email.Displayed);
        }
        public void ExportContactDisabled()
        {
            //Verify Export Contact Disabled       
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            IWebElement ExportContact = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("EXPORT CONTACT")));
            Assert.AreEqual("true", ExportContact.GetAttribute("disabled"));
            Assert.AreEqual(true, ExportContact.Displayed);
        }
        public void FindEnabled()
        {
            IWebElement Find = FindElement(By.LinkText("FIND"));
            Assert.IsTrue(Find.Enabled);
            Assert.AreEqual(true, Find.Displayed);
        }
        public void HistoryDisabled()
        {
            //Verify History Disabled       
            IWebElement History = FindElement(By.LinkText("HISTORY"));
            Assert.AreEqual("true", History.GetAttribute("disabled"));
            Assert.AreEqual(true, History.Displayed);
        }
        public void IATADetailDisabled()
        {
            //Verify IATA Detail Disabled       
            IWebElement IATADetail = FindElement(By.LinkText("IATA DETAIL"));
            Assert.AreEqual("true", IATADetail.GetAttribute("disabled"));
            Assert.AreEqual(true, IATADetail.Displayed);
        }
        public void ListEnabled()
        {
            IWebElement List = FindElement(By.LinkText("LIST"));
            Assert.IsTrue(List.Enabled);
            Assert.AreEqual(true, List.Displayed);
        }
        public void NewDisabled()
        {
            //Verify New Disabled       
            IWebElement NewDisabled = FindElement(By.LinkText("NEW"));
            Assert.AreEqual("true", NewDisabled.GetAttribute("disabled"));
            Assert.AreEqual(true, NewDisabled.Displayed);
        }
        public void NewEnabled()
        {
            //Verify New Enabled   
            IWebElement New = FindElement(By.LinkText("NEW"));
            Assert.IsTrue(New.Enabled);
            Assert.AreEqual(true, New.Displayed);
        }
        public void OpenDisabled()
        {
            //Verify Open Disabled       
            IWebElement Open = FindElement(By.LinkText("OPEN"));
            Assert.AreEqual("true", Open.GetAttribute("disabled"));
            Assert.AreEqual(true, Open.Displayed);
        }
        public void OpenEnabled()
        {
            //Verify Open Enabled
            IWebElement Open = FindElement(By.LinkText("OPEN"));
            Assert.IsTrue(Open.Enabled);
            Assert.AreEqual(true, Open.Displayed);
        }
        public void ProcessDisabled()
        {
            //Verify Process Disabled       
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
            IWebElement Process = wait.Until(d => d.FindElement(By.LinkText("PROCESS")));
            Assert.AreEqual("true", Process.GetAttribute("disabled"));
            Assert.AreEqual(true, Process.Displayed);
        }
        public void ProfileDisabled()
        {
            //Verify Profile Disabled       
            IWebElement Profile = FindElement(By.LinkText("PROFILE"));
            Assert.AreEqual("true", Profile.GetAttribute("disabled"));
            Assert.AreEqual(true, Profile.Displayed);
        }
        public void ReassignDisabled()
        {
            //Verify Reassign Disabled       
            IWebElement Reassign = FindElement(By.LinkText("REASSIGN"));
            Assert.AreEqual("true", Reassign.GetAttribute("disabled"));
            Assert.AreEqual(true, Reassign.Displayed);
        }
        public void ReExportDisabled()
        {
            //Verify ReExport Disabled       
            IWebElement ReExport = FindElement(By.LinkText("RE-EXPORT"));
            Assert.AreEqual("true", ReExport.GetAttribute("disabled"));
            Assert.AreEqual(true, ReExport.Displayed);
        }
        public void RefreshEnabled()
        {
            //Verify Refresh Enabled       
            IWebElement Refresh = FindElement(By.LinkText("REFRESH"));
            Assert.IsTrue(Refresh.Enabled);
            Assert.AreEqual(true, Refresh.Displayed);
        }
        public void RemoveDataDisabled()
        {
            //Verify RemoveData Disabled       
            IWebElement RemoveData = FindElement(By.LinkText("REMOVE DATA"));
            Assert.AreEqual("true", RemoveData.GetAttribute("disabled"));
            Assert.AreEqual(true, RemoveData.Displayed);
        }
        public void RenameDisabled()
        {
            //Verify Rename Disabled       
            IWebElement Rename = FindElement(By.LinkText("RENAME"));
            Assert.AreEqual("true", Rename.GetAttribute("disabled"));
            Assert.AreEqual(true, Rename.Displayed);
        }

        public void ResolveDisabled()
        {
            //Verify Resolve Disabled       
            IWebElement Resolve = FindElement(By.LinkText("RESOLVE"));
            Assert.AreEqual("true", Resolve.GetAttribute("disabled"));
            Assert.AreEqual(true, Resolve.Displayed);
        }
        public void ResolveEnabled()
        {
            IWebElement Resolve = FindElement(By.LinkText("RESOLVE"));
            Assert.IsTrue(Resolve.Enabled);
            Assert.AreEqual(true, Resolve.Displayed);
        }
        public void RunDisabled()
        {
            //Verify Run Disabled       
            IWebElement Run = FindElement(By.LinkText("RUN"));
            Assert.AreEqual("true", Run.GetAttribute("disabled"));
            Assert.AreEqual(true, Run.Displayed);
        }
        public void RunGroupDisabled()
        {
            //Verify Run Group Disabled       
            IWebElement RunGroup = FindElement(By.LinkText("RUN GROUP"));
            Assert.AreEqual("true", RunGroup.GetAttribute("disabled"));
            Assert.AreEqual(true, RunGroup.Displayed);
        }
        public void SendDisabled()
        {
            //Verify Send Disabled       
            IWebElement Send = FindElement(By.XPath("//a[@menu-command='cmdSend']"));
            Assert.AreEqual("true", Send.GetAttribute("disabled"));
            Assert.AreEqual(true, Send.Displayed);
        }
        public void SendProgrammingNotesDisabled()
        {
            //Verify Send Programming Notes Disabled       
            IWebElement SendProgrammingNotes = FindElement(By.LinkText("SEND PROGRAMMING NOTES"));
            Assert.AreEqual("true", SendProgrammingNotes.GetAttribute("disabled"));
            Assert.AreEqual(true, SendProgrammingNotes.Displayed);
        }
        public void SendProgrammingNotesEnabled()
        {
            IWebElement SendProgrammingNotes = FindElement(By.LinkText("SEND PROGRAMMING NOTES"));
            Assert.IsTrue(SendProgrammingNotes.Enabled);
            Assert.AreEqual(true, SendProgrammingNotes.Displayed);
        }
        public void StatisticsDisabled()
        {
            //Verify Statistics Disabled       
            IWebElement Statistics = FindElement(By.LinkText("STATISTICS"));
            Assert.AreEqual("true", Statistics.GetAttribute("disabled"));
            Assert.AreEqual(true, Statistics.Displayed);
        }
        public void StepsDisabled()
        {
            //Verify Steps Disabled       
            IWebElement Steps = FindElement(By.LinkText("STEPS"));
            Assert.AreEqual("true", Steps.GetAttribute("disabled"));
            Assert.AreEqual(true, Steps.Displayed);
        }
        public void TicketingDetailDisabled()
        {
            //Verify IATA Detail Disabled       
            IWebElement TicketingDetail = FindElement(By.LinkText("TICKETING DETAIL"));
            Assert.AreEqual("true", TicketingDetail.GetAttribute("disabled"));
            Assert.AreEqual(true, TicketingDetail.Displayed);
        }
        public void UnassignDisabled()
        {
            //Verify Unassign Disabled       
            IWebElement Unassign = FindElement(By.LinkText("UNASSIGN"));
            Assert.AreEqual("true", Unassign.GetAttribute("disabled"));
            Assert.AreEqual(true, Unassign.Displayed);
        }
        public void UpDisabled()
        {
            //Verify Up Disabled       
            IWebElement Up = FindElement(By.LinkText("UP"));
            Assert.AreEqual("true", Up.GetAttribute("disabled"));
            Assert.AreEqual(true, Up.Displayed);
        }
        public void UpdateProfilesEnabled()
        {
            IWebElement UpdateProfiles = FindElement(By.LinkText("UPDATE PROFILES"));
            Assert.IsTrue(UpdateProfiles.Enabled);
            Assert.AreEqual(true, UpdateProfiles.Displayed);
        }

        public void ViewDevLogDisabled()
        {
            //Verify View Dev Log Disabled       
            IWebElement ViewDevlog = FindElement(By.LinkText("VIEW DEV LOG"));
            Assert.AreEqual("true", ViewDevlog.GetAttribute("disabled"));
            Assert.AreEqual(true, ViewDevlog.Displayed);
        }
        public void ViewDevLogEnabled()
        {
            IWebElement ViewDevLog = FindElement(By.LinkText("VIEW DEV LOG"));
            Assert.IsTrue(ViewDevLog.Enabled);
            Assert.AreEqual(true, ViewDevLog.Displayed);
        }

        public void ViewDisabled()
        {
            //Verify View Disabled       
            IWebElement View = FindElement(By.LinkText("VIEW"));
            Assert.AreEqual("true", View.GetAttribute("disabled"));
            Assert.AreEqual(true, View.Displayed);
        }
        public void ViewDocumentsDisabled()
        {
            //Verify View Documents Disabled       
            IWebElement ViewDocuments = FindElement(By.LinkText("VIEW DOCUMENTS"));
            Assert.AreEqual("true", ViewDocuments.GetAttribute("disabled"));
            Assert.AreEqual(true, ViewDocuments.Displayed);
        }

        public void ViewProgrammingNotesDisabled()
        {
            //Verify View Documents Disabled       
            IWebElement ViewProgrammingNotes = FindElement(By.LinkText("VIEW PROGRAMMING NOTES"));
            Assert.AreEqual("true", ViewProgrammingNotes.GetAttribute("disabled"));
            Assert.AreEqual(true, ViewProgrammingNotes.Displayed);
        }

        public void ColumnInterfaceNameButton()
        {
            //Verify Interface Name Button
            Assert.AreEqual("  Interface Name", FindElement(By.XPath("//button[contains(text(), 'Interface Name')]")).Text);
        }
        public void ColumnAgencyButton()
        {
            //Verify Agency Button
            Assert.AreEqual("  Agency", FindElement(By.XPath("//button[contains(text(), 'Agency')]")).Text);
        }
        public void ColumnAirlineClientButton()
        {
            //Verify  Airline/Client Button
            Assert.AreEqual("  Airline/Client", FindElement(By.XPath("//button[contains(text(), 'Airline/Client')]")).Text);
        }
        public void ColumnAssignedToButton()
        {
            //Verify  Assigned To Button
            Assert.AreEqual("  Assigned To", FindElement(By.XPath("//button[contains(text(), 'Assigned To')]")).Text);
        }
        public void ColumnClientCompanyButton()
        {
            //Verify Comments Button
            Assert.AreEqual("  Client Company", FindElement(By.XPath("//button[contains(text(), 'Client Company')]")).Text);
        }
        public void ColumnCommentsButton()
        {
            //Verify Comments Button
            Assert.AreEqual("  Comments", FindElement(By.XPath("//button[contains(text(), 'Comments')]")).Text);
        }
        public void ColumnContactButton()
        {
            //Verify Contact Button
            Assert.AreEqual("  Contact", FindElement(By.XPath("//button[contains(text(), 'Contact')]")).Text);
        }
        public void ColumnDataSourceButton()
        {
            //Verify Data Source Button
            Assert.AreEqual("  Data Source", FindElement(By.XPath("//button[contains(text(), 'Data Source')]")).Text);
        }
        public void ColumnDocumentButton()
        {
            //Verify Document Button
            Assert.AreEqual("  Document", FindElement(By.XPath("//button[contains(text(), 'Document')]")).Text);
        }
        public void ColumnDocumentTypeButton()
        {
            //Verify Document Type Button
            Assert.AreEqual("  Document Type", FindElement(By.XPath("//button[contains(text(), 'Document Type')]")).Text);
        }
        public void ColumnFileLocationButton()
        {
            //Verify File Location Button
            Assert.AreEqual("  File Location", FindElement(By.XPath("//button[contains(text(), 'File Location')]")).Text);
        }
        public void ColumnFileNameButton()
        {
            //Verify File Name Button
            Assert.AreEqual("  File Name", FindElement(By.XPath("//button[contains(text(), 'File Name')]")).Text);
        }
        public void ColumnFinishedButton()
        {
            //Verify Finished Button
            Assert.AreEqual("  Finished", FindElement(By.XPath("//button[contains(text(), 'Finished')]")).Text);
        }
        public void ColumnMessageButton()
        {
            //Verify Message Button
            Assert.AreEqual("  Message", FindElement(By.XPath("//button[contains(text(), 'Message')]")).Text);
        }
        public void ColumnModifiedButton()
        {
            //Verify Modified Button
            Assert.AreEqual("  Modified Date", FindElement(By.XPath("//button[contains(text(), 'Modified Date')]")).Text);
        }
        public void ColumnResolveStatusButton()
        {
            //Verify Resolve Status Button
            Assert.AreEqual("  Resolve Status", FindElement(By.XPath("//button[contains(text(), 'Resolve Status')]")).Text);
        }
        public void ColumnStartedButton()
        {
            //Verify Started Button
            Assert.AreEqual("  Started", FindElement(By.XPath("//button[contains(text(), 'Started')]")).Text);
        }
        public void ColumnStatusButton()
        {
            //Verify Status Button
            Assert.AreEqual("  Status", FindElement(By.XPath("//button[contains(text(), 'Status')]")).Text);
        }
        public void ColumnStepButton()
        {
            //Verify Step Button
            Assert.AreEqual("  Step", FindElement(By.XPath("//button[contains(text(), 'Step')]")).Text);
        }
        public void ColumnStoredByButton()
        {
            //Verify Stored By Button
            Assert.AreEqual("  Stored By", FindElement(By.XPath("//button[contains(text(), 'Stored By')]")).Text);
        }
        public void ColumnStoredDateButton()
        {
            //Verify Stored Date Button
            Assert.AreEqual("  Stored Date", FindElement(By.XPath("//button[contains(text(), 'Stored Date')]")).Text);
        }
        public void VerifyCreatedOn()
        {
            //Verify Created On
            Assert.IsTrue(driver.PageSource.Contains("Created On:"));
            Assert.IsTrue(driver.PageSource.Contains("By:"));
        }
        public void VerifyLastUpdate()
        {
            //Verify Last Update
            Assert.IsTrue(driver.PageSource.Contains("Last Update:"));
        }
        public void VerifyPageObjects()
        {
            //Navigate to List>Refresh                    
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('List')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(), 'Refresh')]")));
            WaitUntilCurtainsixty();

            js.ExecuteScript("return $(\"a:contains('List')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(), 'Reset Grid')]")));
            WaitUntilCurtainninety();

            js.ExecuteScript("return $(\"a:contains('List')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(), 'Reset Filters')]")));
            WaitUntilCurtainsixty();

            js.ExecuteScript("return $(\"a:contains('List')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdResetSorting']")));
            WaitUntilCurtainsixty();


            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[@title='Find']")));
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[text()='Reset']")));

            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[@ng-click='grid.options.refresh_Clicked()']")));
            WaitUntilCurtain120();

            Assert.IsTrue(FindElement(By.XPath("//button[@title='Export all rows']")).Enabled);
            Assert.AreEqual(true, FindElement(By.XPath("//button[@title='Export all rows']")).Displayed);
        }
        public void VerifyPageObjectswofilters()
        {
            //Navigate to List>Refresh                    
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('List')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", WaitForDisplayedElement(By.XPath("//a[contains(text(), 'Refresh')]")));
            WaitUntilCurtainsixty();

            js.ExecuteScript("return $(\"a:contains('List')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(), 'Reset Grid')]")));
            WaitUntilCurtainsixty();

            js.ExecuteScript("return $(\"a:contains('List')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdResetSorting']")));
            WaitUntilCurtain();


            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[@title='Find']")));
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[text()='Reset']")));

            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[@ng-click='grid.options.refresh_Clicked()']")));
            WaitUntilCurtainninety();

            Assert.IsTrue(FindElement(By.XPath("//button[@title='Export all rows']")).Enabled);
            Assert.AreEqual(true, FindElement(By.XPath("//button[@title='Export all rows']")).Displayed);
        }
        public void VerifyPageObjectswosorting()
        {
            //Navigate to List>Refresh                    
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('List')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//a[contains(text(), 'Refresh')]")));

            js.ExecuteScript("return $(\"a:contains('List')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//a[contains(text(), 'Reset Grid')]")));

            js.ExecuteScript("return $(\"a:contains('List')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//a[contains(text(), 'Reset Filters')]")));
             
            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//button[@ng-click='grid.options.refresh_Clicked()']")));
            System.Threading.Thread.Sleep(5000);

            Assert.IsTrue(driver.FindElement(By.XPath("//button[@title='Export all rows']")).Enabled);
            Assert.AreEqual(true, driver.FindElement(By.XPath("//button[@title='Export all rows']")).Displayed);
        }
        public void ListRefresh()
        {
            //Navigate to List>Refresh                    
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('List')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(), 'Refresh')]")));
            WaitUntilCurtain();
        }
        public void ListResetGrid()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('List')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(), 'Reset Grid')]")));
            WaitUntilCurtain();
        }
        public void ListResetFilters()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('List')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[contains(text(), 'Reset Filters')]")));
            WaitUntilCurtain();
        }
        public void ListResetSorting()
        {
            //Select List>Reset Sorting
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return $(\"a:contains('List')\").mouseover();");
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdResetSorting']")));
            WaitUntilCurtain();
        }
        public void FindIcon()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[@title='Find']")));

            //Click Reset            
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[text()='Reset']")));
            WaitUntilCurtain();
        }
        public void RefreshIcon()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", WaitForDisplayedElement(By.XPath("//button[@ng-click='grid.options.refresh_Clicked()']")));
            WaitUntilCurtain();
        }
        public void ExportAllRowsIcon()
        {
            // WaitUntilCurtain();
            Assert.IsTrue(FindElement(By.XPath("//button[@title='Export all rows']")).Enabled);
            Assert.AreEqual(true, FindElement(By.XPath("//button[@title='Export all rows']")).Displayed);
            //WaitUntilCurtain();
            System.Threading.Thread.Sleep(4000);
        }
        public void UIGridPagerControlDisabled()
        {
            WaitUntilCurtain();
            //Verify Page First Disabled       
            Assert.AreEqual("true", FindElement(By.XPath("//button[contains(@class, 'ui-grid-pager-first')]")).GetAttribute("disabled"));
            WaitUntilCurtain();
        }
        public void UIGridPagerControl()
        {
            //Verify Page First Displays                
            Assert.AreEqual(true, FindElement(By.XPath("//button[contains(@aria-label, 'Page to first')]")).Displayed);
            WaitUntilCurtain();
            Assert.AreEqual(true, FindElement(By.XPath("//button[contains(@aria-label, 'Page back')]")).Displayed);
            WaitUntilCurtain();
            Assert.AreEqual(true, FindElement(By.XPath("//input[@aria-label='Selected page']")).Displayed);
            WaitUntilCurtain();
            Assert.AreEqual(true, FindElement(By.XPath("//span[@class='ui-grid-pager-max-pages-number ng-binding']")).Displayed);
            WaitUntilCurtain();
            Assert.AreEqual(true, FindElement(By.XPath("//button[contains(@aria-label, 'Page forward')]")).Displayed);
            WaitUntilCurtain();
            Assert.AreEqual(true, FindElement(By.XPath("//button[contains(@aria-label, 'Page to last')]")).Displayed);
            WaitUntilCurtain();
            Assert.IsTrue(driver.PageSource.Contains("items per page"));
            WaitUntilCurtain();

            SelectElement soc = new SelectElement(FindElement(By.XPath("//select[@ng-model='grid.options.paginationPageSize']")));
            string[] drop = { "10", "15", "20", "30", "50", "75", "100", };
            IEnumerable<string> actual = soc.Options.Select(i => i.Text);
            Assert.IsTrue(drop.All(d => actual.Contains(d)));

            SelectElement Dropdown = new SelectElement(FindElement(By.XPath("//select[@ng-model='grid.options.paginationPageSize']")));
            Dropdown.SelectByText("75");
            Assert.That(Dropdown.SelectedOption.Text.Equals("75"));

            WaitUntilCurtainninety();
        }
        public void ReleaseProfileTopSectionAlbemarleCatalysts()
        {
            //Verify Page Title
            Assert.AreEqual("Release: Data Status Detail", FindElement(By.XPath("//h2[contains(text(), 'Release: Data Status Detail')]")).Text);

            Assert.AreEqual("Client", FindElement(By.XPath("//strong[text()='Client']")).Text);

            Assert.AreEqual("CO", FindElement(By.XPath("//label[contains(@class, 'ng-binding')][contains(text(), 'CO')]")).Text);

            Assert.AreEqual("Release Type", FindElement(By.XPath("//*[text()='Release Type']")).Text);

            Assert.AreEqual("Corporate", FindElement(By.XPath("//label[contains(@class, 'ng-binding')][contains(text(), 'Corporate')]")).Text);

            Assert.AreEqual("DRA #", FindElement(By.XPath("//*[text()='DRA #']")).Text);

            Assert.AreEqual("0", FindElement(By.XPath("//label[contains(@class, 'ng-binding')][contains(text(), '0')]")).Text);

            Assert.AreEqual("Client Company", FindElement(By.XPath("//*[text()='Client Company']")).Text);

            Assert.AreEqual("Albemarle Catalysts", FindElement(By.XPath("//label[contains(@class, 'ng-binding')][contains(text(), 'Albemarle Catalysts')]")).Text);

            Assert.AreEqual("Agency", FindElement(By.XPath("//*[text()='Agency']")).Text);

            Assert.AreEqual("BCD Travel", FindElement(By.XPath("//label[contains(@class, 'ng-binding')][contains(text(), 'BCD Travel')]")).Text);

            Assert.AreEqual("Data Status", FindElement(By.XPath("//strong[text()='Data Status']")).Text);

            Assert.AreEqual("8. Expired", FindElement(By.XPath("//label[contains(@class, 'ng-binding')][contains(text(), '8. Expired')]")).Text);

            Assert.AreEqual("Request Date", FindElement(By.XPath("//strong[text()='Request Date']")).Text);

            Assert.AreEqual("Feb 2, 2004", FindElement(By.XPath("//label[contains(@class, 'ng-binding')][contains(text(), 'Feb 2, 2004')]")).Text);

            Assert.AreEqual("Begin Date", FindElement(By.XPath("//strong[text()='Begin Date']")).Text);

            Assert.AreEqual("Jul 1, 2004", FindElement(By.XPath("//label[contains(@class, 'ng-binding')][contains(text(), 'Jul 1, 2004')]")).Text);

            Assert.AreEqual("End Date", FindElement(By.XPath("//strong[text()='End Date']")).Text);

            Assert.AreEqual("Jan 21, 2005", FindElement(By.XPath("//label[contains(@class, 'ng-binding')][contains(text(), 'Jan 21, 2005')]")).Text);

            Assert.AreEqual("Archive Date", FindElement(By.XPath("//strong[text()='Archive Date']")).Text);
        }
        public void VerifySaveCancelButtons()
        {
            WaitUntilCurtain();
            //Verify Buttons, in order  
            Assert.AreEqual("SAVE", FindElement(By.XPath("//nav[@class='spark-modal__nav spark-margin-top']/button[1]")).Text);
            Assert.AreEqual("CANCEL", FindElement(By.XPath("//nav[@class='spark-modal__nav spark-margin-top']/button[2]")).Text);
        }
        public void VerifyYesNoButtons()
        {
            WaitUntilCurtain();
            //Verify Buttons, in order  
            Assert.AreEqual("YES", FindElement(By.XPath("//nav[@class='spark-modal__nav spark-margin-top']/button[1]")).Text);
            Assert.AreEqual("NO", FindElement(By.XPath("//nav[@class='spark-modal__nav spark-margin-top']/button[2]")).Text);
        }
    }
}







