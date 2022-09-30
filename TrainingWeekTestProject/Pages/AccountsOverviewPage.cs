using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TrainingWeekTestProject.Pages
{
    public class AccountsOverviewPage : BasePage
    {
        public AccountsOverviewPage(ChromeDriver driver) : base(driver)
        {
        }

        public void SelectMenuItem(string menuItemName)
        {
            Click(By.LinkText(menuItemName));
        }
    }
}
