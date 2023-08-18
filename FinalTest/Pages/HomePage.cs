using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;


namespace FinalTest.Pages
{
    public class HomePage
    {
        IWebDriver driver;
        string mail = ("mimikmk23@gmail.com");
        

        By loginLocator = By.CssSelector("span.wd-tools-text");
        By createAnAccountLocator = By.CssSelector("a.btn.btn-style-link.btn-color-primary.create-account-button");
        By userNameFieldLocator = By.Id("reg_username");
        By emailFieldLocator = By.Id("reg_email");
        By passwordFieldLocator = By.Id("reg_password");
        By registerButtonLocator = By.Name("register");
        By accountDetailsLocator = By.XPath("//*[@id=\"post-9\"]/div/div/div/div[1]/nav/ul/li[5]");
        By emailLocator = By.Name("account_email");
        By homePageButtonLocator = By.ClassName("nav-link-text");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void LoginForm()
        {

            IWebElement Login = driver.FindElement(loginLocator);
            Login.Click();

            IWebElement createAnAccount = driver.FindElement(createAnAccountLocator);
            createAnAccount.Click();

        }
        public void RegisterForm()
        {

            
            IWebElement userNameField = driver.FindElement(userNameFieldLocator);
            userNameField.Clear();
            userNameField.SendKeys("mimikmk23");

            IWebElement emailField = driver.FindElement(emailFieldLocator);
            emailField.Click();
            emailField.SendKeys(mail);

            IWebElement passwordField = driver.FindElement(passwordFieldLocator);
            passwordField.Clear();
            passwordField.SendKeys("*123456***");

            IWebElement registerButton = driver.FindElement(registerButtonLocator);
            registerButton.Click();

            IWebElement accountDetails = driver.FindElement(accountDetailsLocator);
            accountDetails.Click();
   
        }

        public void VerifyEmailAddresst()
        {
            IWebElement email = driver.FindElement(emailLocator);
            string emailFieldValue = email.GetAttribute("value");
            Assert.AreEqual(mail, emailFieldValue);
            Console.WriteLine(" The Email is validated");
        }
        public void backToHomePage()
        {
            IWebElement homePage = driver.FindElement(homePageButtonLocator);
            homePage.Click();
        }
    }
}

