using AddSegmentsToYandexMetrika.Contexts;
using OpenQA.Selenium.Chrome;

namespace AddSegmentsToYandexMetrika
{
    public static class Menu
    {
        public static void Run()
        {
            const string Uri = "https://metrika.yandex.ru/list";

            var addedSegmentsSuccess = new Dictionary<string, AddLog>();
            var addedSegmentsError = new Dictionary<string, AddLog>();

            using (var context = new YandexMetrikaSegmentsContext())
            {
                addedSegmentsSuccess = context.SuccessLogs
                    .ToDictionary(x => x.SegmentName, x => x);
                //addedSegmentsError = context.ErrorLogs
                    //.ToDictionary(x => x.SegmentName, x => x);
            }

            //  var options = ProxyConfig.Add();

            var driver = new ChromeDriver();
            driver.Url = Uri;

            //   Ввести код ручками!
            Authentication.Run(driver);
            Selenium.GoToSegments(driver);
            Selenium.AddSegments(driver, addedSegmentsSuccess, addedSegmentsError);

            using (var context = new YandexMetrikaSegmentsContext())
            {
                var addedSegmentsSuccessDelete = context.SuccessLogs
                    .ToList();
                var addedSegmentsErrorDelete = context.ErrorLogs
                    .ToList();

                if (addedSegmentsSuccessDelete.Count > 0)
                context.SuccessLogs
                    .RemoveRange(addedSegmentsSuccessDelete);
                
                if (addedSegmentsErrorDelete.Count > 0)
                context.ErrorLogs
                    .RemoveRange(addedSegmentsErrorDelete);

                context.SuccessLogs
                    .AddRange(addedSegmentsSuccess.Select(x => x.Value));
                context.ErrorLogs
                    .AddRange(addedSegmentsError.Select(x => x.Value));

                context.SaveChanges();
            }
        }
    }
}
