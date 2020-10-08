using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreciseUnitConversionTests.Utils
{
    static class Keyboard
    {
        public static void PressButton(AppiumDriver<AndroidElement> driver, int number)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            AndroidElement Button = driver.FindElementByXPath($"//*[contains(@class,'Button') and contains(@text,'{number}')]");
            Button.Click();
        }
    }
}
