using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using AddSegmentsToYandexMetrika.Contexts;

namespace AddSegmentsToYandexMetrika
{
    public static class Selenium
    {
        public static void ClickButton(ChromeDriver driver, string selector)
        {
            driver.FindElement(By.CssSelector(selector)).Click();
            System.Threading.Thread.Sleep(5000);
        }

        public static void InputValue(ChromeDriver driver, string selector, string value)
        {
            driver.FindElement(By.CssSelector(selector)).SendKeys(value);
            System.Threading.Thread.Sleep(5000);
        }

        public static IWebElement[] GetListElements(ChromeDriver driver, string xpath)
        {
            var elements = driver.FindElements(By.XPath(xpath)).ToArray();
            System.Threading.Thread.Sleep(5000);

            return elements;
        }

        public static void GoToSegments(ChromeDriver driver)
        {
            Selenium.ClickButton(driver, NavigationBar.SelectCounter);
            Selenium.ClickButton(driver, NavigationBar.SelectVisitorsAndClients);
            Selenium.ClickButton(driver, NavigationBar.SelectClients);
            Selenium.ClickButton(driver, NavigationBar.SelectEvents);
            Selenium.ClickButton(driver, NavigationBar.SelectOrders);
            Selenium.ClickButton(driver, NavigationBar.SelectOrderStatus);
        }

        public static void AddSegments(ChromeDriver driver, Dictionary<string, AddLog> addedSegmentsSuccess,
            Dictionary<string, AddLog> addedSegmentsError)
        {
            int addedSegmentsCount = addedSegmentsSuccess.Count;
            int addedSegmentsAllCount = addedSegmentsCount + addedSegmentsError.Count();

            if (addedSegmentsAllCount < 500)
            {
                var orderStatuses = Selenium.GetListElements(driver, NavigationBar.SelectListOrderStatuses).Length;

                if (orderStatuses > 0)
                {
                    if (orderStatuses > addedSegmentsCount)
                    {
                        for (var i = addedSegmentsCount; i < orderStatuses; i++)
                        {
                            var orderStatusesCheck = 20;
                            while (orderStatusesCheck < orderStatuses && orderStatusesCheck != orderStatuses)
                            {
                                orderStatusesCheck = orderStatusesCheck + 20;

                                driver.FindElement(By.XPath(@"//div[@class='segment-panel-checkbox-list__show-more']/button")).Click();
                                System.Threading.Thread.Sleep(1000);
                            }

                            var status = Selenium.GetListElements(driver, NavigationBar.SelectListOrderStatuses)[i];
                            string statusName = status.GetAttribute("value");

                            if (!String.IsNullOrEmpty(statusName) && !addedSegmentsSuccess.ContainsKey(statusName)
                                && !addedSegmentsError.ContainsKey(statusName))
                            {
                                try
                                {
                                    status.Click();
                                    System.Threading.Thread.Sleep(5000);

                                    driver.FindElement(By.XPath(NavigationBar.SelectApplyXPath)).Click();
                                    System.Threading.Thread.Sleep(5000);

                                    Selenium.ClickButton(driver, NavigationBar.SelectPreSaveSegment);
                                    Selenium.ClickButton(driver, NavigationBar.SelectClearInput);

                                    driver.FindElement(By.XPath(NavigationBar.SelectInputXPath))
                                        .SendKeys(statusName);
                                    System.Threading.Thread.Sleep(5000);

                                    Selenium.ClickButton(driver, NavigationBar.SelectSave);

                                    var newAddLog = new AddLog
                                    {
                                        SegmentName = statusName,
                                        Status = Status.Success,
                                        Logs = $"Segment named {statusName} successfully created",
                                        DateCreated = DateTime.Now
                                    };

                                    addedSegmentsSuccess.Add(statusName, newAddLog);

                                    using (var context = new YandexMetrikaSegmentsContext())
                                    {
                                        context.SuccessLogs.Add(newAddLog);
                                        context.SaveChanges();
                                    }

                                    Selenium.ClickButton(driver, NavigationBar.SelectCross);
                                    Selenium.ClickButton(driver, NavigationBar.SelectEvents);
                                    Selenium.ClickButton(driver, NavigationBar.SelectOrders);
                                    Selenium.ClickButton(driver, NavigationBar.SelectOrderStatus);
                                }
                                catch (Exception ex)
                                {
                                    var newAddLog = new AddLog
                                    {
                                        SegmentName = statusName,
                                        Status = Status.Error,
                                        Logs = ex.Message,
                                        DateCreated = DateTime.Now
                                    };

                                    addedSegmentsError.Add(statusName, newAddLog);

                                    using (var context = new YandexMetrikaSegmentsContext())
                                    {
                                        context.ErrorLogs.Add(newAddLog);
                                        context.SaveChanges();
                                    }

                                    break;
                                }
                            }
                        }
                    }

                    driver.FindElement(By.XPath(@"//div[@class='segment-panel-checkbox-list__show-more']/button")).Click();
                    System.Threading.Thread.Sleep(1000);

                    AddSegments(driver, addedSegmentsSuccess, addedSegmentsError);
                }
            }
        }
    }
}
