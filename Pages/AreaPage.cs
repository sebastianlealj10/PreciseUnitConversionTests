using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using PreciseUnitConversionTests.Utils;
using System;

namespace PreciseUnitConversionTests.Pages
{
    internal class AreaPage
    {
        AndroidElement navigation => _driver.FindElementByAccessibilityId("Open navigation drawer");
        AndroidElement convertedTextView => _driver.FindElementById("target_value");
        private AppiumDriver<AndroidElement> _driver;

        public AreaPage(AppiumDriver<AndroidElement> driver)
        {
            _driver = driver;
        }

        public AreaPage GoToAreaPage()
        {
            navigation.Click();
            ScrollMenu.FindAndClickOnElement(_driver, "Area");
            return this;
        }

        public AreaPage PushButton(int value)
        {
            Keyboard.PressButton(_driver, value);
            return this;
        }

        public int GetConvertedValue()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            return Int32.Parse(convertedTextView.GetAttribute("text").Replace(" ", ""));
        }
    }
}
