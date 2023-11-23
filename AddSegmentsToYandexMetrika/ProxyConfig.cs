using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace AddSegmentsToYandexMetrika
{
    public static class ProxyConfig
    {
        public static ChromeOptions Add()
        {
            ChromeOptions options = new ChromeOptions();
            var proxy = new Proxy();

            proxy.Kind = ProxyKind.Manual;
            proxy.IsAutoDetect = false;
            proxy.HttpProxy = "201.91.82.155:3128";

            options.Proxy = proxy;
            options.AddArgument("ignore-certificate-errors");
            options.AddArgument("--ignore-ssl-errors");
            options.AddArgument("--ignore-certificate-errors-spki-list");

            return options;
        }
    }
}
