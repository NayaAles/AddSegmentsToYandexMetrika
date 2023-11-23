using OpenQA.Selenium.Chrome;

namespace AddSegmentsToYandexMetrika
{
    public static class Authentication
    {
        public static void Run(ChromeDriver driver)
        {
            Selenium.InputValue(driver, NavigationBar.SelectInputEmail, SecureData.Get("Email"));
            Selenium.ClickButton(driver, NavigationBar.SelectLogIn);
            Selenium.InputValue(driver, NavigationBar.SelectInputPsw, SecureData.Get("Password"));
            Selenium.ClickButton(driver, NavigationBar.SelectLogIn);
        }
    }
}
