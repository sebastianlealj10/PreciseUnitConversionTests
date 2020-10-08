using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using PreciseUnitConversionTests.Utils;
using System;
using System.Threading;

namespace PreciseUnitConversionTests.Pages
{
    class SpeedPage
    {
        AndroidElement navigation => _driver.FindElementByAccessibilityId("Open navigation drawer");
        AndroidElement fiveButton => _driver.FindElementByXPath("//*[contains(@class,'Button') and contains(@text,'5')]");
        AndroidElement convertedTextView => _driver.FindElementById("target_value");

        private AppiumDriver<AndroidElement> _driver;

        public SpeedPage(AppiumDriver<AndroidElement> driver)
        {
            _driver = driver;
        }

        public SpeedPage GoToAreaPage()
        {
            navigation.Click();
            ScrollMenu.FindAndClickOnElement(_driver, "Speed");
            return this;
        }

        public SpeedPage PushButton(int value)
        {
            Keyboard.PressButton(_driver, value);
            return this;
        }

        public int GetConvertedValue()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            return Int32.Parse(convertedTextView.GetAttribute("text").Replace(".", ""));
        }
    }
}
