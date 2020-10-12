using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ChangePassword
    {
        #region Initialize Web Elements
        //Main Profile Elements
        private static IWebElement oldPassword => Driver.driver.FindElement(By.XPath("//input[@name='oldPassword']"));
        private static IWebElement newPassword => Driver.driver.FindElement(By.XPath("//input[@name='newPassword']"));
        private static IWebElement confirmPassword => Driver.driver.FindElement(By.XPath("//input[@name='confirmPassword']"));
        private static IWebElement save => Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[4]/button"));

        #endregion

        public static void FillForm(int DataRow)
        {
            //Prepares de ExcelSheet for reading
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ChangePassword");

            oldPassword.SendKeys(ExcelLibHelper.ReadData(DataRow, "OldPassword"));
            newPassword.SendKeys(ExcelLibHelper.ReadData(DataRow, "NewPassword"));
            confirmPassword.SendKeys(ExcelLibHelper.ReadData(DataRow, "ConfirmationPassword"));

            save.Click();
        }

    }
}
