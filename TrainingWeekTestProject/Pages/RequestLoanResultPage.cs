using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TrainingWeekTestProject.Pages
{
    public class RequestLoanResultPage : BasePage
    {
        private readonly By TextLabelLoanApplicationResult = By.Id("loanStatus");

        public RequestLoanResultPage(ChromeDriver driver) : base(driver)
        {
        }

        public string GetLoanApplicationResult()
        {
            return GetElementText(TextLabelLoanApplicationResult);
        }
    }
}
