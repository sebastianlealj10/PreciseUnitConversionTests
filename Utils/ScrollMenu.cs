using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using System;

namespace PreciseUnitConversionTests.Utils
{
    static class ScrollMenu
    {
        public static void FindAndClickOnElement(AppiumDriver<AndroidElement> driver, string locator)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            int pressX = driver.Manage().Window.Size.Width / 3;
            int pressy = driver.Manage().Window.Size.Height / 2;
            int movex = pressX - driver.Manage().Window.Size.Width / 4;
            int movey = pressX - driver.Manage().Window.Size.Width / 4;
            int i = 0;
            bool isPresent;

            do
            {

                isPresent = driver.FindElementsByXPath($"//*[contains(@text,'{locator}')]").Count > 0;
                if (isPresent)
                {
                    AndroidElement element = driver.FindElementByXPath($"//*[contains(@text,'{locator}')]");
                    element.Click();
                    break;
                }
                else
                {
                    TouchAction touchAction = new TouchAction(driver);
                    try
                    {
                        touchAction.LongPress(pressX, pressy).MoveTo(movex, movey).Release().Perform();
                    }

                    catch (WebDriverException wd) { Console.WriteLine(wd); }
                }
                i++;

            } while (i <= 4);
        }
    }
}
