using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace TrainingWeekTestProject.Pages
{
    public class LoginPage : BasePage
    {
        private readonly By TextFieldUsername = By.Name("username");
        private readonly By TextFieldPassword = By.Name("password");
        private readonly By ButtonDoLogin = By.XPath("//input[@value='Log In']");

        public LoginPage(ChromeDriver driver) : base(driver)
        {
        }

        public void LoginAs(string username, string password)
        {
            SendKeys(TextFieldUsername, username);
            SendKeys(TextFieldPassword, password);
            Click(ButtonDoLogin);
        }
    }
}
