using OpenQA.Selenium;
using System;
using System.Linq;

namespace DCC
{
    //public class Helper
    //{
    ////public static void highlightElement(IWebDriver driver, IWebElement element)
    ////{
    ////    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

    //    //    try
    //    //    {
    //    //        Thread.Sleep(500);
    //    //    }
    //    //    catch (ThreadInterruptedException e)
    //    //    {
    //    //        Debug.WriteLine(e.Message);
    //    //        js.ExecuteScript("arguments[0].setattribute('style'.'border: solid 2px white')", element);
    //    //    }
    //    public static String GetDate(String format, int dateDiff)
    //{
    //    if (format == null)
    //    {
    //        format = "MM/dd/yyyy";
    //    }
    //    else if (format.Equals("AUS") || format.Equals("UK"))
    //    {
    //        format = "dd/MM/yyyy";
    //    }
    //    else if (format.Equals("ISO"))
    //    {
    //        format = "yyyy-MM-dd";
    //    }
    //    DateTime today = DateTime.Today;
    //    return today.AddDays(dateDiff).ToString(format);
    //}
    //public static String Today(String format)
    //{
    //    return GetDate(format, 0);
    //}
    //public static String Tomorrow(String format)
    //{
    //    return GetDate(format, 1);
    //}
    //public static String Yesterday(String format)
    //{
    //    return GetDate(format, -1);
    //}
    class Helper
    {
        public static String ScriptDir()
        {
            return @"C:\SRC\PRISM\QA\DCC\Main\DCC.RegressionTests";
        }
    }
}


   

    

