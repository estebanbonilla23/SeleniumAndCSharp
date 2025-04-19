using OpenQA.Selenium;

public class HomePage
{
    private readonly IWebDriver _driver;

    private readonly By myAccountDropdown = By.CssSelector(".dropdown-toggle[title='My Account']");
    private readonly By loginLink = By.LinkText("Login");

    public HomePage(IWebDriver driver)
    {
        _driver = driver;
    }

    public void GoToLoginPage()
    {
        _driver.FindElement(myAccountDropdown).Click();
        _driver.FindElement(loginLink).Click();
    }
}
