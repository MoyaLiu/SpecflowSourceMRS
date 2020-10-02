using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ProfilePages
    {
        #region Initialize Web Elements
        //Main Profile Elements
        private static IWebElement labelGreeting => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
        private static IWebElement buttonEditDescription => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
        private static IWebElement textboxDescription => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
        private static IWebElement buttonSaveDescription => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
        //Language Tab Elements
        //Skills Tab Elements
        //Education Tab Elements
        //Certificate Tab Elements
        #endregion

        public static void GoToProfilePage()
        {

        }

        public static void CheckProfilePage()
        {
            //Check that we are log-in in the Profile Page by looking for the greeting message
            WaitHelper.WaitClickble(Driver.driver,labelGreeting);
        }

        #region Test Methods
        public static void FillDetails(int DataRow)
        {
            
            //Wait for the Profile details to be interactable
            WaitHelper.WaitClickble(Driver.driver, buttonEditDescription);

            //Fill description
            AddDescription(DataRow);

            //Fill Language Information
            //AddLanguage(DataRow);

            //Fill Skills after Information
            //AddSkill(DataRow);

            //Fill Education Information
            //AddEducation(DataRow);

            //Fill Certificate Information
            AddCertificate(DataRow);
        }
        #endregion

        #region Page Methods
        public static void AddDescription(int DataRow)
        {
            buttonEditDescription.Click();
            textboxDescription.Clear();
            textboxDescription.SendKeys((ExcelLibHelper.ReadData(DataRow, "description")));
            buttonSaveDescription.Click();
        }

        

        

        

        

        public static void DeleteDetails()
        {

            

            
        }

        public static void CheckDetails(int DataRow)
        {
            //Creates the Variable to return
            bool CheckResult = true;
            Driver.driver.Navigate().Refresh();

            

            

            if (CheckResult != true)
            {
                Assert.Fail("Details don't match the expected results!");
            }
        }

        public static void CheckIfEmpty()
        {
            //Looks for Language delete button after changing tab expecting not finding it
            //try
            //{ 
            //    //tabLanguage.Click();
            //    Assert.Fail();
            //}
            //catch
            //{
            //    Assert.Pass();
            //}
        }
        #endregion
    }
}
