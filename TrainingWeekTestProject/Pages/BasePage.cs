using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace TrainingWeekTestProject.Pages
{
    public class BasePage
    {
        private ChromeDriver driver;
        private WebDriverWait wait;

        public BasePage(ChromeDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
        }

        protected void SendKeys(By locator, string textToType)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            driver.FindElement(locator).SendKeys(textToType);
        }

        protected void Click(By locator)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            driver.FindElement(locator).Click();
        }

        protected void SelectFromDropdown(By locator, string valueToSelect)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            IWebElement dropdownElement = driver.FindElement(locator);
            SelectElement dropdownSelect = new SelectElement(dropdownElement);
            dropdownSelect.SelectByValue(valueToSelect);
        }

        protected string GetElementText(By locator)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
            return driver.FindElement(locator).Text;
        }
    }
}
