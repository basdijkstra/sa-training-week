using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TrainingWeekTestProject.Pages
{
    public class RequestLoanPage : BasePage
    {
        private readonly By TextFieldAmount = By.Id("amount");
        private readonly By TextFieldDownPayment = By.Id("downPayment");
        private readonly By DropdownFromAccountId = By.Id("fromAccountId");
        private readonly By ButtonSubmitLoanApplication = By.XPath("//input[@value='Apply Now']");

        public RequestLoanPage(ChromeDriver driver) : base(driver)
        {
        }

        public void SubmitLoanApplication(string amount, string downPayment, string fromAccountId)
        {
            SendKeys(TextFieldAmount, amount);
            SendKeys(TextFieldDownPayment, downPayment);
            SelectFromDropdown(DropdownFromAccountId, fromAccountId);
            Click(ButtonSubmitLoanApplication);
        }
    }
}
