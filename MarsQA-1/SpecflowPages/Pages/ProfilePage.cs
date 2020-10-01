using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ProfilePage
    {
        #region Initialize Web Elements
        //Main Profile Elements
        private static IWebElement labelGreeting => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
        private static IWebElement buttonEditDescription => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
        private static IWebElement textboxDescription => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
        private static IWebElement buttonSaveDescription => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
        //Language Tab Elements
        private static IWebElement tabLanguage => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        private static IWebElement buttonAddLanguage => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement textboxAddLanguage => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
        private static IWebElement dropdownLanguageLV => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
        private static IWebElement dropdownLanguageOption => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
        private static IWebElement buttonLanguageSave => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        private static IWebElement buttonEditLanguage => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]"));
        private static IWebElement textboxEditLanguage => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        private static IWebElement dropdownEditLanguageLV => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
        private static IWebElement dropdownEditLanguageOption => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[2]"));
        private static IWebElement buttonEditLanguageSave => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
        private static IWebElement buttonDeleteLanguage => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
        private static IWebElement checkLanguage => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
        //Skills Tab Elements
        private static IWebElement tabSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        private static IWebElement buttonAddSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement textboxAddSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
        private static IWebElement dropdownSkillLV => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
        private static IWebElement dropdownSkillOption => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
        private static IWebElement buttonAddSkillSave => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        private static IWebElement buttonEditSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]"));
        private static IWebElement textboxEditSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        private static IWebElement dropdownEditSkillLV => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
        private static IWebElement dropdownEditSkillOption => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[2]"));
        private static IWebElement buttonEditSkillSave => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
        private static IWebElement buttonDeleteSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
        private static IWebElement checkSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
        //Education Tab Elements
        private static IWebElement tabEducation => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
        private static IWebElement buttonAddEducation => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        private static IWebElement textboxCollege => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
        private static IWebElement dropdownCollege => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
        private static IWebElement dropdownCollegeOption => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[92]"));
        private static IWebElement dropdownTitle => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
        private static IWebElement dropdownTitleOption => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[3]"));
        private static IWebElement textboxDegree => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
        private static IWebElement dropdownGraduation => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
        private static IWebElement dropdownGraduationOption => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[3]"));
        private static IWebElement buttonAddEducationSave => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
        private static IWebElement buttonEditEducation => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));
        private static IWebElement textboxEditEducation => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input"));
        private static IWebElement buttonEditEducationSave => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));
        private static IWebElement buttonDeleteEducation => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));
        private static IWebElement checkEducation => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
        //Certificate Tab Elements
        private static IWebElement tabCertificates => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
        private static IWebElement buttonAddCertificates => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private static IWebElement textboxCertificates => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
        private static IWebElement textboxCertificator => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
        private static IWebElement dropdownCertificateYear => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
        private static IWebElement dropdownCertificateYearOption => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[2]"));
        private static IWebElement buttonCertificateSave => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
        private static IWebElement buttonDeleteCertificate => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));
        private static IWebElement buttonEditCertificate => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i"));
        private static IWebElement textboxEditCertificate => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input"));
        private static IWebElement buttonEditCertificateSave => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
        private static IWebElement checkCertificate => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
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
            AddLanguage(DataRow);

            //Fill Skills after Information
            AddSkill(DataRow);

            //Fill Education Information
            AddEducation(DataRow);

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
        public static void AddLanguage(int DataRow)
        {
            //Fill Language after changing tab and waiting for elements to be interactable
            tabLanguage.Click();
            WaitHelper.WaitClickble(Driver.driver, buttonAddLanguage);
            buttonAddLanguage.Click();
            textboxAddLanguage.SendKeys((ExcelLibHelper.ReadData(DataRow, "language")));
            dropdownLanguageLV.Click();
            dropdownLanguageOption.Click();
            buttonLanguageSave.Click();
        }

        public static void AddSkill(int DataRow)
        {
            //Fill Skills after changing tab and waiting for elements to be interactable
            tabSkill.Click();
            WaitHelper.WaitClickble(Driver.driver, buttonAddSkill);
            buttonAddSkill.Click();
            textboxAddSkill.SendKeys((ExcelLibHelper.ReadData(DataRow, "skill")));
            dropdownSkillLV.Click();
            dropdownSkillOption.Click();
            buttonAddSkillSave.Click();
        }

        public static void AddEducation(int DataRow)
        {
            //Fill Education after changing tab and waiting for elements to be interactable
            tabEducation.Click();
            WaitHelper.WaitClickble(Driver.driver, buttonAddEducation);
            buttonAddEducation.Click();
            textboxCollege.SendKeys("CETI");
            dropdownCollege.Click();
            dropdownCollegeOption.Click();
            dropdownTitle.Click();
            dropdownTitleOption.Click();
            textboxDegree.SendKeys((ExcelLibHelper.ReadData(DataRow, "education")));
            dropdownGraduation.Click();
            dropdownGraduationOption.Click();
            buttonAddEducationSave.Click();
        }

        public static void AddCertificate(int DataRow)
        {
            //Fill Certifications after changing tab and waiting for elements to be interactable
            tabCertificates.Click();
            WaitHelper.WaitClickble(Driver.driver, buttonAddCertificates);
            buttonAddCertificates.Click();
            textboxCertificates.SendKeys((ExcelLibHelper.ReadData(DataRow, "certificates")));
            textboxCertificator.SendKeys("RH Consulting");
            dropdownCertificateYear.Click();
            dropdownCertificateYearOption.Click();
            buttonCertificateSave.Click();
        }

        public static void EditDetails(int DataRow)
        {
            //Edit Language after changing tab and waiting for elements to be interactable
            tabLanguage.Click();
            WaitHelper.WaitClickble(Driver.driver, buttonEditLanguage);
            buttonEditLanguage.Click();
            dropdownEditLanguageLV.Click();
            dropdownEditLanguageOption.Click();
            buttonEditLanguageSave.Click();

            //Edit Skills after changing tab and waiting for elements to be interactable
            tabSkill.Click();
            WaitHelper.WaitClickble(Driver.driver, buttonEditSkill);
            buttonEditSkill.Click();
            textboxEditSkill.Clear();
            textboxEditSkill.SendKeys(ExcelLibHelper.ReadData(DataRow, "skill"));
            dropdownEditSkillLV.Click();
            dropdownEditSkillOption.Click();
            buttonEditSkillSave.Click();

        }

        public static void EditLanguage(int DataRow)
        {
            EditLanguage(3);
            EditSkill(3);
            EditEducation(3);
            EditCertificate(3);
        }

        public static void EditSkill(int DataRow)
        {
            //Edit Skills after changing tab and waiting for elements to be interactable
            tabSkill.Click();
            WaitHelper.WaitClickble(Driver.driver, buttonEditSkill);
            buttonEditSkill.Click();
            textboxEditSkill.Clear();
            textboxEditSkill.SendKeys(ExcelLibHelper.ReadData(DataRow, "skill"));
            dropdownEditSkillLV.Click();
            dropdownEditSkillOption.Click();
            buttonEditSkillSave.Click();
        }

        public static void EditEducation(int DataRow)
        {
            //Edit Skills after changing tab and waiting for elements to be interactable
            tabEducation.Click();
            WaitHelper.WaitClickble(Driver.driver, buttonEditEducation);
            buttonEditSkill.Click();
            textboxEditEducation.Clear();
            textboxEditEducation.SendKeys(ExcelLibHelper.ReadData(DataRow, "education"));
            buttonEditEducationSave.Click();
        }

        public static void EditCertificate(int DataRow)
        {
            //Edit Skills after changing tab and waiting for elements to be interactable
            tabCertificates.Click();
            WaitHelper.WaitClickble(Driver.driver, buttonEditCertificate);
            buttonEditCertificate.Click();
            textboxEditCertificate.Clear();
            textboxEditCertificate.SendKeys(ExcelLibHelper.ReadData(DataRow, "certificates"));
            buttonEditCertificateSave.Click();
        }

        public static void DeleteDetails()
        {
            //Delete Language after changing tab and waiting for elements to be interactable
            tabLanguage.Click();
            WaitHelper.WaitClickble(Driver.driver, buttonDeleteLanguage);
            buttonDeleteLanguage.Click();

            //Delete Skill after changing tab and waiting for elements to be interactable
            tabSkill.Click();
            WaitHelper.WaitClickble(Driver.driver, buttonDeleteSkill);
            buttonDeleteSkill.Click();

            //Delete Education after changing tab and waiting for elements to be interactable
            tabEducation.Click();
            WaitHelper.WaitClickble(Driver.driver, buttonDeleteEducation);
            buttonDeleteEducation.Click();

            //Delete Certificate after changing tab and waiting for elements to be interactable
            tabCertificates.Click();
            WaitHelper.WaitClickble(Driver.driver, buttonDeleteCertificate);
            buttonDeleteCertificate.Click();
        }

        public static void CheckDetails(int DataRow)
        {
            //Creates the Variable to return
            bool CheckResult = true;
            Driver.driver.Navigate().Refresh();

            //Checks Language after changing tab and waiting for elements to be interactable
            tabLanguage.Click();
            WaitHelper.WaitClickble(Driver.driver, buttonDeleteLanguage);
            if (checkLanguage.Text!= ExcelLibHelper.ReadData(DataRow, "language")) { CheckResult = false; }

            //Checks Skill after changing tab and waiting for elements to be interactable
            tabSkill.Click();
            WaitHelper.WaitClickble(Driver.driver, buttonDeleteSkill);
            if (checkSkill.Text != ExcelLibHelper.ReadData(DataRow, "skill")) { CheckResult = false; }

            //Checks Education after changing tab and waiting for elements to be interactable
            tabEducation.Click();
            WaitHelper.WaitClickble(Driver.driver, buttonDeleteEducation);
            if (checkEducation.Text != ExcelLibHelper.ReadData(DataRow, "education")) { CheckResult = false; }

            //Checks Certificates after changing tab and waiting for elements to be interactable
            tabCertificates.Click();
            WaitHelper.WaitClickble(Driver.driver, buttonDeleteCertificate);
            if (checkCertificate.Text != ExcelLibHelper.ReadData(DataRow, "certificates")) { CheckResult = false; }

            if (CheckResult != true)
            {
                Assert.Fail("Details don't match the expected results!");
            }
        }

        public static void CheckIfEmpty()
        {
            //Looks for Language delete button after changing tab expecting not finding it
            try
            { 
                tabLanguage.Click();
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }
        #endregion
    }
}
