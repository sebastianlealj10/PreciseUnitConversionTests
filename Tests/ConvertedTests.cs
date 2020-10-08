using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using PreciseUnitConversionTests.Pages;
using System;

namespace PreciseUnitConversionTests.Tests
{
    [TestClass]
    public class ConvertedTests
    {
        private static AppiumDriver<AndroidElement> _driver;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            var appPath = "C:/Users/sebas/Downloads/PreciseUnitConversion.apk";
            var capabilities = new AppiumOptions();

            capabilities.AddAdditionalCapability("app", appPath);
            capabilities.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            capabilities.AddAdditionalCapability(MobileCapabilityType.App, appPath);
            capabilities.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Pixel 2 XL API 26");

            _driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), capabilities);
        }

        [TestMethod]
        public void TheAreaConvertionFromHectareToSquareMeterIsCorrect()
        {
            var areaPage = new AreaPage(_driver);
            var convertedValue = areaPage
                .GoToAreaPage()
                .PushButton(5)
                .GetConvertedValue();
            Assert.AreEqual(50000, convertedValue);
        }

        [TestMethod]
        public void TheSpeedConvertionFromMilePerHourToSquareMeterIsCorrect()
        {
            var areaPage = new SpeedPage(_driver);
            var convertedValue = areaPage
                .GoToAreaPage()
                .PushButton(8)
                .GetConvertedValue();
            Assert.AreEqual(128748, convertedValue);
        }
    }
}
