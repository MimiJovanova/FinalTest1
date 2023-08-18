using FinalTest.Category;
using FinalTest.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace FinalTest.Tests
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver;
        HomePage homePageObject;
        ProductCategory prductCategoryObject;


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://woodmart.xtemos.com/home");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            homePageObject = new HomePage(driver);
            prductCategoryObject = new ProductCategory(driver);
        }


        [Test]
        public void LoginAndRegister()
        {
            homePageObject.LoginForm();
            homePageObject.RegisterForm();
            homePageObject.VerifyEmailAddresst();
            homePageObject.backToHomePage();

        }
        [Test]
        public void productCategoryElectronics()
        {

            homePageObject.LoginForm();
            homePageObject.RegisterForm();
            homePageObject.VerifyEmailAddresst();
            homePageObject.backToHomePage();

            prductCategoryObject.electronicCategory();
            prductCategoryObject.checkout();
            prductCategoryObject.LogOut();
        }


        [TearDown]
       public void TearDown()
        {
            driver.Quit();
        }
    }
}