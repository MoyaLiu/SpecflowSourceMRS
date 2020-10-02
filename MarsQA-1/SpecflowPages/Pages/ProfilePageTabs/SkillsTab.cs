using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages.ProfilePage
{
    class SkillsTab
    {
        #region Web Elements
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

        #endregion

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

        public static void DeleteSkill()
        {
            //Delete Skill after changing tab and waiting for elements to be interactable
            tabSkill.Click();
            WaitHelper.WaitClickble(Driver.driver, buttonDeleteSkill);
            buttonDeleteSkill.Click();
        }

        public static void CheckSkill(int DataRow)
        {
            //Checks Skill after changing tab and waiting for elements to be interactable
            tabSkill.Click();
            WaitHelper.WaitClickble(Driver.driver, buttonDeleteSkill);
            if (checkSkill.Text != ExcelLibHelper.ReadData(DataRow, "skill")) { Assert.Fail(); }
        }

    }
}
