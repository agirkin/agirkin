using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace DCC
{

    public class ActivityContactsListExportContactPage : TestBase
    {
        public ActivityContactsListExportContactPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ActivityContactsList_ExportContact()
        {
            //Last Name Contains Gates  
            Find find = new Find(driver);
            find.FindBasicTwoPlus();
            find.BasicFind("Last Name", "Contains", "Gates");
            find.ClickSearch();

            //Highlight Row
            Actions Highlight = new Actions(driver);
            Highlight.MoveToElement(FindElement(By.XPath("(//div[contains(text(), 'Gates')][@class='ui-grid-cell-contents ng-binding ng-scope'])[1]"))).Click().Build().Perform();

            //Click Export Contact            
            Assert.AreEqual(true, FindElement(By.XPath("//a[text()='Export Contact']")).Displayed);
            Assert.AreEqual(true, FindElement(By.XPath("//a[text()='Export Contact']")).Enabled);
        }
    }
}

