using OpenQA.Selenium.Chrome;

[TestFixture]
public class LoginTests
{
    private ChromeDriver _driver;
    private HomePage _homePage;
    private LoginPage _loginPage;

    [SetUp]
    public void SetUp()
    {
        _driver = new ChromeDriver();
        _driver.Navigate().GoToUrl("http://opencart.abstracta.us/");
        _driver.Manage().Window.Maximize();

        _homePage = new HomePage(_driver);
        _loginPage = new LoginPage(_driver);
    }

    [Test]
    public void Login_WithValidCredentials_ShouldRedirectToMyAccount()
    {
        _homePage.GoToLoginPage();
        _loginPage.LoginAs("test@automation.com", "Test1234");

        // Simple assertion to verify redirection to My Account page
        Assert.That(_driver.Title, Is.EqualTo("My Account"));
    }

    [TearDown]
    public void TearDown()
    {
        _driver.Quit();
        _driver.Dispose();
    }
}
