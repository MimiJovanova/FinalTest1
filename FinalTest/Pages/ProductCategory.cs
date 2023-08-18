using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;


namespace FinalTest.Category
{
    public class ProductCategory
    {
        IWebDriver driver;

        By electronicLocator = By.XPath("//*[@id=\"menu-item-8010\"]");
        By iPhoneRedLocator = By.LinkText("iPhone Red 128GB");
        By addRoCartLocator = By.Name("add-to-cart");
        By checkoutLocator = By.XPath("/html/body/div[4]/div[2]/div/div[2]/p[2]/a[2]");
        By firstNameLocator = By.Id("billing_first_name");
        By lastNameLocator = By.Id("billing_last_name");
        By countryLocator = By.Id("select2-billing_country-container");
        By countryFieldLocator = By.ClassName("select2-search__field");
        By streetAddressLocator = By.Id("billing_address_1");
        By postcodeLocator = By.Id("billing_postcode");
        By phoneLocator = By.Id("billing_phone");
        By emailAddress2Locator = By.Id("billing_email");
        By directBankLocator = By.Id("payment_method_bacs");
        //By checkoxLocator = By.Id("terms");
        By myAccount2Locator = By.XPath("/html/body/div[1]/header/div/div[2]/div/div/div[3]/div[2]/a/span[2]");
        By dropDownLocator = By.CssSelector("ul.wd-sub-menu");
        By logOutLocator = By.LinkText("Logout");

       
        public ProductCategory(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void electronicCategory()
        {
            IWebElement electronicButton = driver.FindElement(electronicLocator);
            electronicButton.Click();

            IWebElement iPhoneRed = driver.FindElement(iPhoneRedLocator);
            iPhoneRed.Click();

            IWebElement addToCart = driver.FindElement(addRoCartLocator);
            addToCart.Click();
        }
    
        public void checkout()
        {
            IWebElement checkoutButton = driver.FindElement(checkoutLocator);
            checkoutButton.Click();

            IWebElement firstName = driver.FindElement(firstNameLocator);
            firstName.Clear();
            firstName.SendKeys("Mimi");


            IWebElement lastName = driver.FindElement(lastNameLocator);
            lastName.Clear();
            lastName.SendKeys("Jovanova");

            IWebElement country = driver.FindElement(countryLocator);
            country.Click();

            IWebElement countryField = driver.FindElement(countryFieldLocator);
            countryField.Clear();
            countryField.SendKeys("North Macedonia");
            countryField.Click();

            IWebElement streetAddress = driver.FindElement(streetAddressLocator);
            streetAddress.Clear();
            streetAddress.SendKeys("Karaorman 4");

            IWebElement postCode = driver.FindElement(postcodeLocator);
            postCode.Clear();
            postCode.SendKeys("1480");

            IWebElement phone = driver.FindElement(phoneLocator);
            phone.Clear();
            phone.SendKeys("073035595");

            IWebElement emailAddress2 = driver.FindElement(emailAddress2Locator);
            emailAddress2.Clear();
            emailAddress2.SendKeys("mimikmk9@gmail.com");


            IWebElement directBank = driver.FindElement(directBankLocator);
            directBank.Click();

           // IWebElement checkbox = driver.FindElement(checkoxLocator);
           // checkbox.Click();

            firstName.Clear();
            lastName.Clear();
            country.Click();
            countryField.Clear();
            streetAddress.Clear();
            postCode.Clear();
            phone.Clear();
            emailAddress2.Clear();
        }

        public void LogOut()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(myAccount2Locator)).Build().Perform();

            Actions action2 = new Actions(driver);
            action.MoveToElement(driver.FindElement(dropDownLocator)).Build().Perform();

            IWebElement logOutButton = driver.FindElement(logOutLocator);
            logOutButton.Click();

        }
    }


}
