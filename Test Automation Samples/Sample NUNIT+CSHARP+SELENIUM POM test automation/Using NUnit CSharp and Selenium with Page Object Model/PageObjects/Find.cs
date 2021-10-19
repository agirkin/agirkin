using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System;

namespace DCC
{
    public class Find : TestBase
    {
        public Find(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void FindBasic()
        {
            WaitUntilCurtain120();
            WaitUntilLoaded();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdFind']")));
            WaitUntilCurtain();
            WaitUntilLoaded();

            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[text()='Reset']")));
            WaitUntilCurtain();
            WaitUntilLoaded();

            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdFind']")));
            WaitUntilCurtain();
            WaitUntilLoaded();

            js.ExecuteScript("arguments[0].click();", FindElement(By.LinkText("+")));
        }
        public void FindBasicTwoPlus()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtainninety();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdFind']")));
            WaitUntilCurtainninety();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[text()='Reset']")));
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdFind']")));
            WaitUntilCurtain();
        }
        public void FindBasicRemoveTwoRows()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdFind']")));
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[text()='Reset']")));
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdFind']")));
            WaitUntilCurtain();
            js.ExecuteScript("arguments[0].click();", FindElement(By.LinkText("-")));
            WaitUntilCurtain();
            js.ExecuteScript("arguments[0].click();", FindElement(By.LinkText("-")));
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.LinkText("+")));
            WaitUntilCurtain();
        }
        public void FindBasicRemoveOneRows()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();

            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdFind']")));
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//button[text()='Reset']")));
            WaitUntilCurtain();
            WaitUntilLoaded();

            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdFind']")));
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.LinkText("-")));
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.LinkText("+")));
        }
        public void FindBasicwithFindButton() //Companies Find
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //Wait
            WaitUntilCurtain();
            WaitUntilLoaded();

            //Click Find
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdFind']")));
            WaitUntilCurtain();
            WaitUntilLoaded();

            //Click Reset
            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//button[text()='Reset']")));
            WaitUntilCurtain();
            WaitUntilLoaded();

            //Click Find
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdFind']")));
            WaitUntilCurtain();
            WaitUntilLoaded();

            //Click Plus
            js.ExecuteScript("arguments[0].click();", FindElement(By.LinkText("+")));
            WaitUntilCurtain();
            WaitUntilLoaded();
        }
        public void FindBasicNoFindButton() //Companies Find
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //Wait
            WaitUntilCurtain();
            WaitUntilLoaded();

            //Click Reset
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[text()='Reset']")));
            WaitUntilCurtain();
            WaitUntilLoaded();

            //Click Find
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdFind']")));
            WaitUntilCurtain();
            WaitUntilLoaded();

            //Click Plus
            js.ExecuteScript("arguments[0].click();", FindElement(By.LinkText("+")));
            WaitUntilCurtain();
            WaitUntilLoaded();
        }

        public void AdvancedFind()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //Click Find
            WaitUntilLoaded();
            WaitUntilCurtain();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdFind']")));

            //Click Reset
            WaitUntilLoaded();
            WaitUntilCurtain();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//button[text()='Reset']")));

            //Click Find
            WaitUntilLoaded();
            WaitUntilCurtain();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdFind']")));

            //Click New
            WaitUntilLoaded();
            WaitUntilCurtain();
            FindElement(By.XPath("//span[contains(text(), 'New')]")).Click();
        }
        public void ClickPlus()
        {
            //Click +
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.LinkText("+")));
        }
        public void ClickFindAdvanced()
        {
            //Click Find Advanced
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            js.ExecuteScript("arguments[0].click();", FindElement(By.XPath("//a[@menu-command='cmdFindAdvanced']")));
        }
        public void ClickTicketLedgerPlus()
        {
            //Click +
            WaitUntilCurtainsixty();
            WaitUntilLoaded();
            FindElement(By.XPath("//a[contains(@class, 'spark-btn--sm spark-btn')][contains(@ng-click, 'queryFormMultiValueSelect.add()')]")).Click();
        }
        public void ReportsFind()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            FindElement(By.XPath("//*[contains(@menu-command, 'cmdFind')]")).Click();
            WaitUntilCurtain();
            WaitUntilLoaded();
            //Click Reset
            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//button[text()='Reset']")));
            WaitUntilCurtain();
            WaitUntilLoaded();
            FindElement(By.XPath("//*[contains(@menu-command, 'cmdFind')]")).Click();
            WaitUntilCurtain();
            WaitUntilLoaded();
            FindElement(By.LinkText("+")).Click();
        }

        public void ClickSearch()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//button[text()='Search']")));
            WaitUntilCurtain120();
            //Verify Application Error Not Received
            var error = driver.FindElements(By.XPath("//*[text()='A system error has occurred']"));
            Assert.IsFalse(error.Count > 0 && error[0].Displayed);
        }
        public void DoubleFindClear(string columnName, string operators, string value)
        {
            WaitUntilCurtain();
            WaitUntilLoaded();
            FindElement(By.XPath("(//select[@name='ColumnId'])[2]")).SendKeys(columnName);
            WaitUntilCurtain();
            WaitUntilLoaded();
            FindElement(By.XPath("(//select[@name='OperatorId'])[2]")).SendKeys(operators);
            WaitUntilCurtain();
            WaitUntilCurtainsixty();
            IWebElement Value = FindElement(By.XPath("(//input[@name='Value'])[2]"));
            Value.Clear();
            Value.SendKeys(value);
            WaitUntilCurtain();
            WaitUntilLoaded();
        }
        public void DoubleFind(string columnName, string operators, string value)
        {
            WaitUntilCurtain();
            WaitUntilLoaded();
            FindElement(By.XPath("//select[contains(@class, 'spark-select__input ng-pristine ng-untouched ng-valid ng-not-empty ng-valid-dccrequired')][@name='ColumnId']")).SendKeys(columnName);
            WaitUntilCurtain();
            WaitUntilLoaded();
            FindElement(By.Name("OperatorId")).SendKeys(operators);
            WaitUntilCurtain();
            WaitUntilLoaded();
            FindElement(By.XPath("(//input[@name='Value'])[2]")).SendKeys(value);
            WaitUntilCurtain();
            WaitUntilLoaded();
        }
        public void DoubleFindwodropdownClear(string columnName, string operators, string value)
        {
            WaitUntilCurtain();
            WaitUntilLoaded();
            System.Threading.Thread.Sleep(1000);
            FindElement(By.XPath("(//select[@name='ColumnId'])[2]")).SendKeys(columnName);
            WaitUntilCurtain();
            WaitUntilLoaded();
            System.Threading.Thread.Sleep(1000);
            FindElement(By.XPath("(//select[@name='OperatorId'])[2]")).SendKeys(operators);
            WaitUntilCurtainsixty();
            IWebElement Value = FindElement(By.XPath("//input[@name='Value']"));
            Value.Clear();
            Value.SendKeys(value);
            WaitUntilCurtain();
            WaitUntilLoaded();
        }
        public void DoubleFindwdropdown(string columnName, string operators, string value)
        {
            WaitUntilCurtain();
            WaitUntilLoaded();
            FindElement(By.XPath("(//select[@name='ColumnId'])[2]")).SendKeys(columnName);
            WaitUntilCurtain();
            WaitUntilLoaded();
            FindElement(By.XPath("(//select[@name='OperatorId'])[2]")).SendKeys(operators);
            WaitUntilCurtain();
            WaitUntilLoaded();
            new SelectElement(FindElement(By.XPath("(//Select[@name='Value'])[2]"))).SelectByText(value);
            WaitUntilCurtain();
            WaitUntilLoaded();
        }
        public void DoubleFindDD(string columnName, string operators, string value)
        {
            WaitUntilCurtain();
            WaitUntilLoaded();
            System.Threading.Thread.Sleep(1000);
            FindElement(By.XPath("(//select[@name='ColumnId'])[2]")).SendKeys(columnName);
            WaitUntilCurtain();
            WaitUntilLoaded();
            System.Threading.Thread.Sleep(1000);
            FindElement(By.XPath("(//select[@name='OperatorId'])[2]")).SendKeys(operators);
            WaitUntilCurtain();
            WaitUntilLoaded();
            System.Threading.Thread.Sleep(1000);
            new SelectElement(FindElement(By.XPath("//Select[@name='Value']"))).SelectByText(value);
            WaitUntilCurtain();
            WaitUntilLoaded();
        }
        public void DoubleFindDropDown(string columnName, string operators, string value)
        {
            WaitUntilCurtain();
            WaitUntilLoaded();
            System.Threading.Thread.Sleep(1000);
            FindElement(By.XPath("//select[contains(@class, 'spark-select__input ng-pristine ng-untouched ng-valid ng-not-empty ng-valid-dccrequired')][@name='ColumnId']")).SendKeys(columnName);
            WaitUntilCurtain();
            WaitUntilLoaded();
            System.Threading.Thread.Sleep(1000);
            FindElement(By.Name("OperatorId")).SendKeys(operators);
            WaitUntilCurtain();
            WaitUntilLoaded();
            FindElement(By.XPath("(//input[@name='Value'])[2]")).SendKeys(value);
            WaitUntilCurtain();
            WaitUntilLoaded();
        }
        public void BasicFindClear(string columnName, string operators, string value)
        {
            WaitUntilCurtain();
            WaitUntilLoaded();
            FindElement(By.Name("ColumnId")).SendKeys(columnName);
            WaitUntilCurtain();
            WaitUntilLoaded();
            FindElement(By.Name("OperatorId")).SendKeys(operators);
            WaitUntilCurtainninety();
            WaitUntilLoaded();
            FindElement(By.Name("Value")).Clear();
            FindElement(By.Name("Value")).SendKeys(value);
            WaitUntilCurtain();
            WaitUntilLoaded();
        }
        public void BasicFindwdropdown(string columnName, string operators, string value)
        {           
            System.Threading.Thread.Sleep(2000);
            FindElement(By.XPath("//select[@name='ColumnId']")).SendKeys(columnName);
            WaitUntilCurtain();
            WaitUntilLoaded();
            System.Threading.Thread.Sleep(1000);
            FindElement(By.XPath("//select[@name='OperatorId']")).SendKeys(operators);
            WaitUntilCurtain();
            WaitUntilLoaded();
            System.Threading.Thread.Sleep(1000);
            new SelectElement(FindElement(By.XPath("//Select[@name='Value']"))).SelectByText(value);
            System.Threading.Thread.Sleep(1000);
            WaitUntilCurtain();
            WaitUntilLoaded();
        }
        public void CalendarFind(string columnName, string operators, string year, string month)
        {
            new SelectElement(driver.FindElement(By.Name("ColumnId"))).SelectByText(columnName);
            WaitUntilCurtain();
            new SelectElement(driver.FindElement(By.Name("OperatorId"))).SelectByText(operators);
            WaitUntilCurtain();

            //Select Calendar  
            driver.FindElement(By.XPath("//a[@title='Show Calendar']/i")).Click();
            System.Threading.Thread.Sleep(1000);

            new SelectElement(driver.FindElement(By.Name("year"))).SelectByText(year);
            WaitUntilCurtain();

            new SelectElement(driver.FindElement(By.Name("month"))).SelectByText(month);
            WaitUntilCurtain();

            driver.FindElement(By.XPath("//span[text()='8']")).Click();
            WaitUntilCurtain();
        }
        public void BasicFindClearWithPlus(string columnName, string operators, string value)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WaitUntilCurtain();
            WaitUntilLoaded();
            System.Threading.Thread.Sleep(10000);
            //Click Plus
            js.ExecuteScript("arguments[0].click();", FindElement(By.LinkText("+")));
            WaitUntilCurtain();
            WaitUntilLoaded();
            FindElement(By.Name("ColumnId")).SendKeys(columnName);
            WaitUntilCurtain();
            WaitUntilLoaded();
            FindElement(By.Name("OperatorId")).SendKeys(operators);
            WaitUntilCurtain();
            WaitUntilLoaded();
            FindElement(By.Name("Value")).Clear();
            System.Threading.Thread.Sleep(1000);
            FindElement(By.Name("Value")).SendKeys(value);
            WaitUntilCurtain();
            WaitUntilLoaded();
        }
        public void BasicFind(string ColumnName, string Operators, string value)
        {
            WaitUntilCurtain();
            WaitUntilLoaded();
            FindElement(By.Name("ColumnId")).SendKeys(ColumnName);
            WaitUntilCurtain();
            WaitUntilLoaded();
            FindElement(By.Name("OperatorId")).SendKeys(Operators);
            WaitUntilCurtain();
            WaitUntilLoaded();
            FindElement(By.Name("Value")).SendKeys(value);
            WaitUntilCurtainsixty();
            WaitUntilLoaded();
        }
        public void TicketLedgerMagnifyingGlassFind(string ColumnName, string operators, string value)
        {
            WaitUntilCurtain();
            WaitUntilLoaded();
            new SelectElement(FindElement(By.Name("CriterionTypeId"))).SelectByText(ColumnName);
            WaitUntilCurtain();
            System.Threading.Thread.Sleep(5000);
            FindElement(By.Name("OperatorId")).SendKeys(operators);
            WaitUntilCurtain();
            System.Threading.Thread.Sleep(5000);
            FindElement(By.Name("item[$index].Name")).Click();
            WaitUntilCurtain();
            System.Threading.Thread.Sleep(5000);
            WaitUntilCurtain();
            FindElement(By.XPath("html/body/div[4]/input[1]")).SendKeys(value);
            WaitUntilCurtain();
            System.Threading.Thread.Sleep(4000);
            FindElement(By.XPath("//span[@class='ui-select-highlight']")).Click();
            WaitUntilCurtain();
        }
        public void TextOtherReportCurrency(string ColumnName, string operators, string value)
        {
            WaitUntilCurtain();
            WaitForDisplayedElement(By.Name("CriterionTypeId")).SendKeys(ColumnName);

            WaitUntilCurtain();
            FindElement(By.Name("OperatorId")).SendKeys(operators);

            FindElement(By.Name("textCurrency")).SendKeys(value);
            WaitUntilCurtain();
        }
        public void DueDate()
        {
            PageObject pageObject = new PageObject(driver);
            
            Find find = new Find(driver);

            //Due Date Equals
            find.FindBasicwithFindButton();
            WaitUntilCurtain();
            find.CalendarFind("Due Date", "Equals", "2016", "January");
            WaitUntilCurtain();
            find.ClickSearch();
            WaitUntilCurtain();

            //Due Date Greater Than
            find.FindBasicwithFindButton();
            WaitUntilCurtain();
            find.CalendarFind("Due Date", "Greater than", "2016", "January");
            WaitUntilCurtain();
            find.ClickSearch();
            WaitUntilCurtain();

            //Due Date Greater Than or equal
            find.FindBasicwithFindButton();
            WaitUntilCurtain();
            find.CalendarFind("Due Date", "Greater than or equal", "2016", "January");
            WaitUntilCurtain();
            find.ClickSearch();
            WaitUntilCurtain();

            //Due Date Less Than 
            find.FindBasicwithFindButton();
            WaitUntilCurtain();
            find.CalendarFind("Due Date", "Less than", "2016", "January");
            WaitUntilCurtain();
            find.ClickSearch();
            WaitUntilCurtain();

            //Due Date Less Than or equal
            find.FindBasicwithFindButton();
            WaitUntilCurtain();
            find.CalendarFind("Due Date", "Less than or equal", "2016", "January");
            WaitUntilCurtain();
            find.ClickSearch();
            WaitUntilCurtain();

            //Completed Date Equals
            find.FindBasicwithFindButton();
            WaitUntilCurtain();
            find.CalendarFind("Completed Date", "Equals", "2016", "January");
            WaitUntilCurtain();
            find.ClickSearch();
            WaitUntilCurtain();

            //Completed Date Greater Than
            find.FindBasicwithFindButton();
            WaitUntilCurtain();
            find.CalendarFind("Completed Date", "Greater than", "2016", "January");
            WaitUntilCurtain();
            find.ClickSearch();
            WaitUntilCurtain();

            //Completed Date Greater Than or equal
            find.FindBasicwithFindButton();
            WaitUntilCurtain();
            find.CalendarFind("Completed Date", "Greater than or equal", "2016", "January");
            WaitUntilCurtain();
            find.ClickSearch();
            WaitUntilCurtain();

            //Completed Date Less Than 
            find.FindBasicwithFindButton();
            WaitUntilCurtain();
            find.CalendarFind("Completed Date", "Less than", "2016", "January");
            WaitUntilCurtain();
            find.ClickSearch();
            WaitUntilCurtain();

            //Completed Date Less Than or equal
            find.FindBasicwithFindButton();
            WaitUntilCurtain();
            find.CalendarFind("Completed Date", "Less than or equal", "2016", "January");
            WaitUntilCurtain();
            find.ClickSearch();
            WaitUntilCurtain();
        }

        public void FindContains(string ColumnName, string operators, string value)
        {
            try
            {
                if (driver.PageSource.Contains(value))
                {
                    Console.WriteLine(ColumnName + operators + value);
                }

                else if ("No records to view".Equals(driver.FindElement(By.XPath("//span[text()='No records to view']"))))
                {
                    Console.WriteLine("No records to view");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void FindDoesnotContains(string ColumnName, string operators, string value)
        {
            try
            {
                if (!driver.PageSource.Contains(value))
                {
                    Console.WriteLine(ColumnName + operators + value);
                }

                else if ("No records to view".Equals(driver.FindElement(By.XPath("//span[text()='No records to view']"))))
                {
                    Console.WriteLine("No records to view");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}


