using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using PreciseUnitConversionTests.Utils;
using System;

namespace PreciseUnitConversionTests.Pages
{
    class SpeedPage
    {
        AndroidElement Navigation => _driver.FindElementByAccessibilityId("Open navigation drawer");
        AndroidElement ConvertedTextView => _driver.FindElementById("target_value");

        private readonly AppiumDriver<AndroidElement> _driver;

        public SpeedPage(AppiumDriver<AndroidElement> driver)
        {
            _driver = driver;
        }

        public SpeedPage GoToAreaPage()
        {
            Navigation.Click();
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
            return Int32.Parse(ConvertedTextView.GetAttribute("text").Replace(".", ""));
        }
    }
}
