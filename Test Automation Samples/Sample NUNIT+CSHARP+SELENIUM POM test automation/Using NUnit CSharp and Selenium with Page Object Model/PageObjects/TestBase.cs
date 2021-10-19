using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Text;
using DCC.RegressionTests;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Diagnostics;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace DCC
{
    public class TestBase
    {
        static void Main(string[] args)
        {
        }
        protected IWebDriver driver;
        class SaveScreenShotclass
        {
            public static string SaveScreenshot(IWebDriver driver, string FileName)
            {
                var folderLocation = (@"C:\Temp\");

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }
                string filename = TestContext.CurrentContext.Test.MethodName;
                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);
                //fileName.Append(DateTime.Now.ToString("hhmm" + filename));
                fileName.Append(filename);
                fileName.Append(".jpeg");
                screenShot.SaveAsFile(fileName.ToString(),
                ScreenshotImageFormat.Jpeg);
                return fileName.ToString();
            }
        }
        public void Setup(String browserName)
        {
            InternetExplorerOptions options = new InternetExplorerOptions
            {
                IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                EnsureCleanSession = true,
                UnhandledPromptBehavior = UnhandledPromptBehavior.Ignore
            };
            if (browserName.Equals("ie"))
                driver = new InternetExplorerDriver(options);

            else if (browserName.Equals("chrome"))
                driver = new ChromeDriver();
            //else
            //    driver = new FirefoxDriver();
        }       
        public void LogIn()
        {
            //Cert1
            //driver.Navigate().GoToUrl("https://pmcdcc1.sgdccert.sabre.com");
            //Cert2
            driver.Navigate().GoToUrl("https://pmcdcc2.sgdccert.sabre.com");           
            //Dev2
            //driver.Navigate().GoToUrl("https://pmddcc2.sgdcelab.sabre.com/");
            //Dev1
            //driver.Navigate().GoToUrl("https://pmddcc1.sgdcelab.sabre.com/");
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();
            WaitUntilCurtain120();          
            
            //Click Close on Security Window
            IWebElement ClickClose = WaitForDisplayedElement(By.XPath("//button[text()='Close']"));
            ClickClose.Click();
            WaitUntilLoaded();
            WaitUntilCurtain();
        }
        
        public void WaitUntilLoaded()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until((x) =>
            {
                return ((IJavaScriptExecutor)this.driver)
                    .ExecuteScript("return document.readyState").Equals("complete");
            });
        }
        public void SISWaitUntilCurtain()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@class='blockUI blockOverlay']")));

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@id='QuickLaunchUpdateProgress']")));

            wait.Until((x) =>
            {
                return ((IJavaScriptExecutor)this.driver)
                    .ExecuteScript("return document.readyState").Equals("complete");
            });
        }
        public void WaitUntilCurtain()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            //            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//span[@class='spark-progress__meter']")));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@ng-controller='loadingCurtainController']")));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@id='loadingCurtain']")));

            wait.Until((x) =>
            {
                return ((IJavaScriptExecutor)this.driver)
                    .ExecuteScript("return document.readyState").Equals("complete");
            });
            try
            {
                //Verify Application Error Not Received
                var error = driver.FindElements(By.XPath("//*[text()='A system error has occurred']"));
                Assert.IsFalse(error.Count > 0 && error[0].Displayed);
            } catch (Exception e)
            {
                Console.WriteLine("A System Error Occurred" + e.Message);
            } 
        }
        public void WaitUntilCurtainsixty()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//span[@class='spark-progress__meter']")));

            wait.Until((x) =>
            {
                return ((IJavaScriptExecutor)this.driver)
                    .ExecuteScript("return document.readyState").Equals("complete");
            });
        }
        public void WaitUntilCurtainninety()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//span[@class='spark-progress__meter']")));

            wait.Until((x) =>
            {
                return ((IJavaScriptExecutor)this.driver)
                    .ExecuteScript("return document.readyState").Equals("complete");
            });
        }
        public void WaitUntilCurtain120()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//span[@class='spark-progress__meter']")));

            wait.Until((x) =>
            {
                return ((IJavaScriptExecutor)this.driver)
                    .ExecuteScript("return document.readyState").Equals("complete");
            });
        }
        public void WaitUntilCurtain240()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(240));

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//span[@class='spark-progress__meter']")));

            wait.Until((x) =>
            {
                return ((IJavaScriptExecutor)this.driver)
                    .ExecuteScript("return document.readyState").Equals("complete");
            });
        }

        [TearDown]
        protected void Cleanup()
        {     
            if
               (TestContext.CurrentContext.Result.Outcome.Status.Equals
               (TestStatus.Failed))
                SaveScreenShotclass.SaveScreenshot(driver, "FileName");

            try
            {
                //Verify Application Error Not Received
                var error1 = driver.FindElements(By.XPath("//*[text()='A system error has occurred']"));
                Assert.IsFalse(error1.Count > 0 && error1[0].Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("A System Error Occurred" + e.Message);
            }
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//*[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);

            driver.Manage().Cookies.DeleteAllCookies();
            driver.Quit();
            driver.Dispose();
        }
        public class SeleniumHandler
        {
            //private string webDriverParams = "{\"Driver\":\"Chrome\"}";
            public string WebDriverParams { get; set; }

            private IWebDriver webDriver = null;

            public IWebDriver WebDriver
            {
                get
                {
                    if (webDriver == null)
                    {
                        webDriver = SetWebDriver();
                    }
                    return webDriver;
                }
            }
            private IWebDriver SetWebDriver()
            {
                try
                {
                    var driverParams = JObject.Parse(WebDriverParams);
                    if (driverParams["Driver"].ToString() == "Chrome")
                    {
                        return SetChromeDriver();
                    }
                    else if (driverParams["Driver"].ToString() == "IE")
                    {
                        return SetInternetExplorerDriver();
                    }
                    return SetChromeDriver();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            private IWebDriver SetFireFoxDriver()
            {
                throw new NotImplementedException();
            }
            private IWebDriver SetChromeDriver()
            {
                try
                {
                    return new ChromeDriver();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            private IWebDriver SetInternetExplorerDriver()
            {
                try
                {
                    InternetExplorerOptions options = new InternetExplorerOptions
                    {
                        EnsureCleanSession = true,
                        IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                        EnablePersistentHover = true,
                        UnhandledPromptBehavior = UnhandledPromptBehavior.Dismiss
                    };
                    //options.PageLoadStrategy = InternetExplorerPageLoadStrategy.Normal;

                    return new InternetExplorerDriver(options);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public static IEnumerable<String> BrowserToRunWith()
        {
            String[] browsers = AutomationSettings.browsersToRunWith.Split(',');
            foreach (String b in browsers)
            {
                yield return b;
            }
        }
        public IWebElement FindElement(By by, int interval = 500, int timeout = 60000)
        {
            IWebElement webElement = null;
            var tick = 0;
            try
            {
                do
                {
                    try
                    {
                        webElement = driver.FindElement(by);
                    }
                    catch
                    {
                        Thread.Sleep(interval);
                        tick += interval;
                    }
                } while (webElement == null && tick < timeout);
                if (webElement == null)
                {
                    throw new TimeoutException(
                        string.Format("Element(s) were not found within {0}sec.", (timeout / 1000).ToString()));
                }
                return webElement;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<IWebElement> FindElements(By by, int interval = 500, int timeout = 30000)
        {
            var elements = new List<IWebElement>();
            var tick = 0;
            try
            {
                do
                {
                    try
                    {
                        elements = driver.FindElements(by).ToList();
                        if (elements.Count == 0)
                        {
                            Thread.Sleep(interval);
                            tick += interval;
                        }
                    }
                    catch
                    {

                    }
                } while (elements.Count == 0 && tick < timeout);
                return elements;
            }
            catch (Exception)
            {
                throw;
            }
        }       
        public IWebElement WaitForDisplayedElement(By by, int interval = 500, int timeout = 60000)
        {
            IWebElement webElement = null;
            var tick = 0;
            try
            {
                do
                {
                    try
                    {
                        webElement = driver.FindElement(by);
                    }
                    catch
                    {
                        Thread.Sleep(interval);
                        tick += interval;
                    }
                } while (webElement == null && tick < timeout);
                if (webElement == null)
                {
                    throw new TimeoutException(
                        string.Format("Element(s) were not found within {0}sec.", (timeout / 1000).ToString()));
                }
                return webElement;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IWebElement GetDisplayedElement(By by, int interval = 500, int timeout = 30000)
        {
            try
            {
                var elements = FindElements(by, interval, timeout);

                foreach (IWebElement element in elements)
                {
                    if (element.Displayed)
                    {
                        return element;
                    }
                }
                throw new ElementNotVisibleException();
            }
            catch (Exception)
            {
                throw;
            }
        }
     protected bool IsDisplyed(By locator, int maxWaitTime)
        {
            try {
                WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(maxWaitTime));
                wait.Until(driver => driver.FindElement(locator).Displayed);
                return true;
            }
            catch (OpenQA.Selenium.WebDriverTimeoutException)
            {
                return false;
            }
        }
        public void WaitForAjaxComplete(int maxSeconds)
        {
            bool is_ajax_compete = false;
            for (int i = 1; i <= maxSeconds; i++)
            {
                is_ajax_compete = (bool)((IJavaScriptExecutor)driver).
                ExecuteScript("return window.jQuery != undefined && jQuery.active == 0");
            if (is_ajax_compete)
                {
                    return;
                }
                System.Threading.Thread.Sleep(1000);
            }
            throw new Exception("Timed out after " + maxSeconds + " seconds");    
        }

        public static IWebElement WaitbyNameClickable(IWebDriver driver, string NameLocator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60))
                {
                    PollingInterval = TimeSpan.FromMilliseconds(500)
                };
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                IWebElement searchElement = wait.Until(ExpectedConditions.ElementExists(By.Name(NameLocator)));
                return searchElement;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Timed Out: " + e.Message);
                return null;
            }
        }
        public static IWebElement WaitbyXPathClickable(IWebDriver driver, string XPathLocator)
        {
            try
            {
                Stopwatch _stopwatch = new Stopwatch();
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(45));
                _stopwatch.Start();
                wait.PollingInterval = TimeSpan.FromMilliseconds(500);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                IWebElement searchElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(XPathLocator)));
                _stopwatch.Stop();
                return searchElement;
              
            }
            catch (Exception e)
            {
                Debug.WriteLine("Some Error: " + e.Message);
                return null;
                
            }
        }

        public static IWebElement WaitbyXPathVisible(IWebDriver driver, string XPathLocator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30))
                {
                    PollingInterval = TimeSpan.FromMilliseconds(500)
                };
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                IWebElement searchElement = wait.Until(ExpectedConditions.ElementExists(By.XPath(XPathLocator)));
                return searchElement;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Some Error: " + e.Message);
                return null;
            }
        }
    }    
}

   

