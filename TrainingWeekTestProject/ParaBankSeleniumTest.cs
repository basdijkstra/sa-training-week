using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TrainingWeekTestProject.Pages;

namespace TrainingWeekTestProject
{
    public class ParaBankSeleniumTest
    {
        private ChromeDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://parabank.parasoft.com");
        }

        [TestCase("10000", "100", "Denied", TestName = $"A loan request for 10000 with down payment 100 should be denied")]
        [TestCase("9000", "1000", "Approved", TestName = $"A loan request for 9000 with down payment 1000 should be approved")]
        public void MyFirstParaBankTest(string amount, string downPayment, string expectedResult)
        {
            new LoginPage(driver)
                .LoginAs("john", "demo");

            new AccountsOverviewPage(driver)
                .SelectMenuItem("Request Loan");

            new RequestLoanPage(driver)
                .SubmitLoanApplication(amount: amount, downPayment: downPayment, fromAccountId: "12345");

            string result = new RequestLoanResultPage(driver)
                .GetLoanApplicationResult();

            // Loan Request Result page
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TearDown]
        public void StopBrowser()
        {
            driver.Quit();
        }
    }
}
