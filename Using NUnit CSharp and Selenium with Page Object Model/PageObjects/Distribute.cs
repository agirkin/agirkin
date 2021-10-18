//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.UI;
//using NUnit.Framework;
//using OpenQA.Selenium.Interactions;

//namespace DCC
//{
//    public class Distribute
//    {
//        private IWebDriver driver;

//        public Distribute(IWebDriver driver)
//        {
//            this.driver = driver;
//        }

//        public void EmailForm()
//        {
//            var PageObject = new PageObject(driver);

//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
//            wait.Until(d => d.Title.StartsWith("PRISM DCC", StringComparison.OrdinalIgnoreCase));

//            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));


//            //Verify From
//            Assert.AreEqual("From", driver.FindElement(By.XPath("//span[@class='spark-label spark']")).Text);

//            // Verify To
//            Assert.AreEqual("To", driver.FindElement(By.XPath("//label[contains(@class, 'spark-label')]")).Text);

//            // Verify CC
//            Assert.AreEqual("Cc", driver.FindElement(By.XPath("//label[contains(text(), 'Cc')]")).Text);

//            // Verify Subject
//            Assert.AreEqual("Subject", driver.FindElement(By.XPath("//span[contains(text(), 'Subject')]")).Text);

//            // Verify Attachments
//            Assert.AreEqual("Attachments (Size must not exceed 8MB)", driver.FindElement(By.XPath("//span[contains(text(), 'Attachment')]")).Text);

//            // Verify Body
//            Assert.AreEqual("Body", driver.FindElement(By.XPath("//span[contains(text(), 'Body')]")).Text);

//            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@id='loadingCurtain']")));
//            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//span[@class='spark-progress__meter']")));

//            //Click Save
//            IWebElement ButtonX1 = wait.Until(ExpectedConditions.ElementToBeClickable(pageObject.ButtonX));          
//            pageObject.ButtonX.Click();

//            wait.Until(ExpectedConditions.ElementToBeClickable(pageObject.ButtoncmdSend));

//            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@id='loadingCurtain']")));
//            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//span[@class='spark-progress__meter']")));

//            // Verify Required
//            Assert.AreEqual("Required", driver.FindElement(By.XPath("//span[contains(@ng-show, 'dccrequired && (!archiveDocumentsEmail.emailItemForm.ToAddresses.$pristine')]")).Text);

//            wait.Until(ExpectedConditions.ElementToBeClickable(pageObject.ButtoncmdSend));

//            //Enter Email Name         
//            Actions actions = new Actions(driver);
//            actions.MoveToElement(driver.FindElement(By.Name("ToAddresses")));
//            actions.Click();
//            actions.SendKeys("Gates, Yvonne");            
//            actions.Build().Perform();
//            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(), 'Gates, Yvonne')][contains(@ng-if, '!emailAddress.isTag')]")));
//            IWebElement EmailNameSelect = driver.FindElement(By.XPath("//span[contains(text(), 'Gates, Yvonne')][contains(@ng-if, '!emailAddress.isTag')]"));
//            EmailNameSelect.Click();



//            wait.Until(ExpectedConditions.ElementToBeClickable(pageObject.ButtoncmdSend));

//            // Verify Name
//            Assert.AreEqual("Gates, Yvonne <Yvonne.Gates@sabre.com>", driver.FindElement(By.XPath("//span[@uis-transclude-append='']")).Text);
//            wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("CCAddresses")));

//            IWebElement CcEmailName = wait.Until(driver => driver.FindElement(By.Name("CCAddresses")));
//            CcEmailName.Click();

//            wait.Until(ExpectedConditions.ElementToBeClickable(pageObject.ButtoncmdSend));

//            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//span[@class='spark-progress__meter']")));

//            ////Enter Email Name
//            //IWebElement CcEmailNameEnter = driver.FindElement(By.XPath("//input[contains(@class, 'ui-select-search input-xs ng-pristine ng-valid')]"));
//            //CcEmailNameEnter.SendKeys("Gates");

//            //wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));
//            //wait.Until(ExpectedConditions.ElementToBeClickable(pageObject.ButtoncmdSend));

//            //wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(), 'Gates, Yvonne')][contains(@ng-if, '!emailAddress.isTag')]")));
//            //IWebElement CcEmailNameSelect = driver.FindElement(By.XPath("//span[contains(text(), 'Gates, Yvonne')][contains(@ng-if, '!emailAddress.isTag')]"));
//            //CcEmailNameSelect.Click();


//            //wait.Until(ExpectedConditions.ElementToBeClickable(pageObject.ButtoncmdSend));

//            //// Verify Name
//            //Assert.AreEqual("Gates, Yvonne <Yvonne.Gates@sabre.com>", driver.FindElement(By.XPath("//span[@uis-transclude-append='']")).Text);

//            //wait.Until(ExpectedConditions.ElementToBeClickable(pageObject.TextSubject));

//            //Enter Subject
//            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@id='loadingCurtain']")));
//            pageObject.TextSubject.Clear();
//            pageObject.TextSubject.SendKeys("Subject");

//            //Click Upload
//            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@id='loadingCurtain']")));
//            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@id='loadingCurtain'][@class='ng-scope']")));
//            //IWebElement Upload = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(@class, 'spark-btn spark-btn--xs')][contains(@ngf-select, 'fileUpload.uploadFiles($files)')]")));
//            IWebElement Upload = driver.FindElement(By.XPath("//button[contains(@class, 'spark-btn spark-btn--xs')][contains(@ngf-select, 'fileUpload.uploadFiles($files)')]"));
//            Upload.Click();

//            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@id='loadingCurtain']")));
//            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@id='loadingCurtain'][@class='ng-scope']")));
//            wait.Until(ExpectedConditions.ElementToBeClickable(pageObject.ButtoncmdSend));

//            System.Threading.Thread.Sleep(4000);
//            System.Windows.Forms.SendKeys.SendWait("Testing document afkjsdklajfd.docx");
            
//            System.Windows.Forms.SendKeys.SendWait("{ENTER}");
//            wait.Until(ExpectedConditions.ElementToBeClickable(pageObject.TextBody));

//            //Enter Body
//            pageObject.TextBody.Clear();
//            pageObject.TextBody.EnterText("This is a test of the Body of the Email");

//            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@id='loadingCurtain']")));
//            wait.Until(ExpectedConditions.ElementToBeClickable(pageObject.ButtoncmdSend));

//            pageObject.ButtoncmdSend.Click();

//            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='loadingCurtain']/div/span")));


//        }

//    }
//}
