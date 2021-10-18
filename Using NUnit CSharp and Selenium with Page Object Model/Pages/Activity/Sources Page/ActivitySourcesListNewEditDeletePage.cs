using OpenQA.Selenium;
using NUnit.Framework;
using System.Collections.Generic;

namespace DCC
{
    public class ActivitySourcesListNewEditDeletePage : TestBase
    {
        public ActivitySourcesListNewEditDeletePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ActivitySourcesList_New_Edit_Delete()
        {

            PageObject pageObject = new PageObject(driver);
            Initialize ActivitySourcesInitialize = new Initialize(driver);
            ActivitySourceNewEditDelete ActivitySourceNewEditDelete = new ActivitySourceNewEditDelete(driver);

            // Click New Button
            pageObject.ClickButtoncmdNew();
            WaitUntilCurtain();

            //Verify New Data Source Displays
            Assert.AreEqual("New Data Source", FindElement(By.XPath("//h2[contains(text(), 'New Data Source')]")).Text);
            WaitUntilCurtain();

            //Click Save
            pageObject.ClickButtonTitleSave();

            //Verify Agency Required
            Assert.AreEqual("Required", FindElement(By.XPath("//span[contains(@class, 'spark-select__message')][contains(@ng-show, 'dataSourcesNewEdit.dataSourceForm.SourceCompanyId.$error.dccrequired && dataSourcesNewEdit.submitted')]")).Text);

            //Verify Data Sources Required
            Assert.AreEqual("Required", FindElement(By.XPath("//span[contains(@class, 'spark-select__message')][contains(@ng-if, 'dataSourcesNewEdit.dataSourceForm.DataSourceName.$error.dccrequired && (!dataSourcesNewEdit.dataSourceForm.DataSourceName.$pristine || dataSourcesNewEdit.submitted)')]")).Text);

            //Verify Source Type Required
            Assert.AreEqual("Required", FindElement(By.XPath("//span[contains(@class, 'spark-select__message')][contains(@ng-show, 'dataSourcesNewEdit.dataSourceForm.SourceTypeId.$error.dccrequired && (!dataSourcesNewEdit.dataSourceForm.SourceTypeId.$pristine || dataSourcesNewEdit.submitted)')]")).Text);

            //Click Cancel
            pageObject.ClickButtonTitleCancel();
            WaitUntilCurtain();

            // Click New Button
            pageObject.ClickButtoncmdNew();

            //Verify New Data Source Displays
            Assert.AreEqual("New Data Source", FindElement(By.XPath("//h2[contains(text(), 'New Data Source')]")).Text);
            WaitUntilCurtain();

            ActivitySourceNewEditDelete.ActivitySourceVerifyTitles();
            ActivitySourceNewEditDelete.EnterAgency();
            ActivitySourceNewEditDelete.EnterDataSource();
            ActivitySourceNewEditDelete.EnterMaskedDataSourceName();
            ActivitySourceNewEditDelete.EnterPrimaryContact();
            ActivitySourceNewEditDelete.SelectDataChaseContact();
            ActivitySourceNewEditDelete.SelectInterfaceName();
            ActivitySourceNewEditDelete.SelectSourceType();
            ActivitySourceNewEditDelete.SelectCountry();
            ActivitySourceNewEditDelete.SelectCurrency();
            ActivitySourceNewEditDelete.SelectLanguage();
            ActivitySourceNewEditDelete.SelectSourceStatus();
            ActivitySourceNewEditDelete.SelectFrequency();
            ActivitySourceNewEditDelete.VerifyTrackStatusChecked();
            ActivitySourceNewEditDelete.EnterUserID();
            ActivitySourceNewEditDelete.EnterPassword();
            ActivitySourceNewEditDelete.EnterTestAccountUserID();
            ActivitySourceNewEditDelete.EnterTestAccountPassword();


            //Click Save
            pageObject.ClickButtonTitleSave();

            IList<IWebElement> Aduplicate = driver.FindElements(By.XPath("//div[contains(text(), 'A duplicate Data Source Name already exists')]"));
            if (Aduplicate.Count > 0 && Aduplicate[0].Displayed)
            {
                pageObject.ClickButtonTitleCancel();
            }
            else { }
            WaitUntilCurtainninety();

            // Verify Taken Back to Data Source list Page
            //            Assert.AreEqual("Data Source", FindElement(By.XPath("//h2[contains(text(), 'Data Source')]")).Text);

            //Agency Contains Testing
            Find find = new Find(driver);
            find.FindBasicTwoPlus();
            find.BasicFindClear("Data Source", "Contains", "ABC Test Travel Agency");
            find.ClickSearch();
            WaitUntilCurtain();

            //Highlight Row
            FindElement(By.XPath("(//div[@class='ui-grid-cell-contents ng-binding ng-scope'])[1]")).Click();
            WaitUntilCurtain();

            //Click Edit Button          
            pageObject.ClickButtonEdit();
            WaitUntilCurtain();

            //Verify Edit Data Source Displays
            Assert.AreEqual("Edit Data Source", FindElement(By.XPath("//h2[contains(text(), 'Data Source')]")).Text);

            //Click Cancel
            pageObject.ClickButtonTitleCancel();
            WaitUntilCurtain();

            //Verify Taken Back to Companies list Page
            Assert.AreEqual("Data Source", FindElement(By.XPath("//h2[contains(text(), 'Data Source')]")).Text);

            //Click Edit Button           
            pageObject.ClickButtonEdit();
            WaitUntilCurtain();

            //Verify Edit Data Source Displays
            Assert.AreEqual("Edit Data Source", FindElement(By.XPath("//h2[contains(text(), 'Edit Data Source')]")).Text);


            WaitUntilCurtain();
            ActivitySourceNewEditDelete.ActivitySourceVerifyTitles();
            ActivitySourceNewEditDelete.EnterAgency();
            ActivitySourceNewEditDelete.EnterDataSource();
            ActivitySourceNewEditDelete.EnterMaskedDataSourceName();
            ActivitySourceNewEditDelete.EnterPrimaryContact();
            ActivitySourceNewEditDelete.SelectDataChaseContact();
            ActivitySourceNewEditDelete.SelectInterfaceName();
            ActivitySourceNewEditDelete.SelectSourceType();
            ActivitySourceNewEditDelete.SelectCountry();
            ActivitySourceNewEditDelete.SelectCurrency();
            ActivitySourceNewEditDelete.SelectLanguage();
            ActivitySourceNewEditDelete.SelectSourceStatus();
            ActivitySourceNewEditDelete.SelectFrequency();
            ActivitySourceNewEditDelete.VerifyTrackStatusChecked();
            ActivitySourceNewEditDelete.EnterUserID();
            ActivitySourceNewEditDelete.EnterPassword();
            ActivitySourceNewEditDelete.EnterTestAccountUserID();
            ActivitySourceNewEditDelete.EnterTestAccountPassword();

            //Click Save
            pageObject.ClickButtonTitleSave();

            IList<IWebElement> AduplicateEdit = driver.FindElements(By.XPath("//div[contains(text(), 'A duplicate Data Source Name already exists')]"));
            if (AduplicateEdit.Count > 0 && AduplicateEdit[0].Displayed)
            {
                pageObject.ClickButtonTitleCancel();
            }
            else { }
            WaitUntilCurtain();

            //Click Delete
            pageObject.ClickButtonDelete();
            WaitUntilCurtain();

            //Click Yes
            pageObject.ClickButtonYes();
            WaitUntilCurtain();
        }
    }
}

