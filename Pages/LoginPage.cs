using OpenQA.Selenium;

public class LoginPage
{
    private readonly IWebDriver _driver;

    // Locators
    private readonly By emailInput = By.Id("input-email");
    private readonly By passwordInput = By.Id("input-password");
    private readonly By loginButton = By.CssSelector("input[type='submit']");

    // Constructor
    public LoginPage(IWebDriver driver)
    {
        _driver = driver;
    }

    // Actions
    public void EnterEmail(string email)
    {
        _driver.FindElement(emailInput).SendKeys(email);
    }

    public void EnterPassword(string password)
    {
        _driver.FindElement(passwordInput).SendKeys(password);
    }

    public void ClickLogin()
    {
        _driver.FindElement(loginButton).Click();
    }

    public void LoginAs(string email, string password)
    {
        EnterEmail(email);
        EnterPassword(password);
        ClickLogin();
    }
}
