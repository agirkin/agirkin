using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace DCC
{
    public class ActivityContactsListDataSourcePage : TestBase
    {
        public ActivityContactsListDataSourcePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ActivityContactsList_DataSources()
        {

            PageObject pageObject = new PageObject(driver);
            Find find = new Find(driver);
            ContactsPage Contacts = new ContactsPage(driver);

            //Company Contains          
            find.FindBasicTwoPlus();
            find.BasicFind("Company", "Contains", "ABC Test");
            find.ClickSearch();
            WaitUntilCurtain();

            //Highlight Row
            FindElement(By.XPath("(//div[@class='ui-grid-row ng-scope'])[4]")).Click();
            WaitUntilCurtain();

            //Select Data Sources
            pageObject.ClickButtonDataSources();
            System.Threading.Thread.Sleep(5000);

            //Select Data Source Drop Down    
            IWebElement DataSource = FindElement(By.Name("dynamiclist"));
            DataSource.Click();
            WaitUntilCurtain();
            FindElement(By.XPath("html/body/div[3]/input[1]")).SendKeys("ABC Test Datasource");
            System.Threading.Thread.Sleep(2000);
            Actions builder = new Actions(driver);
            builder.SendKeys(Keys.Enter);
            //FindElement(By.XPath("//span[@class='ng-binding ng-scope']")).Click();
            WaitUntilCurtain();

            //Click Plus
            FindElement(By.XPath("//ng-form[@name='contactDataSources.contactDataSourcesForm']/div/div/div/div/div[2]/a")).Click();
            WaitUntilCurtain();
            //Contacts.Contacts_DataSource();

            //Click Save
            pageObject.ClickButtonSave();
        }
    }
}

