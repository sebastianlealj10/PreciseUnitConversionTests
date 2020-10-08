# PreciseUnitConversionTests

## Objective

Automate two test cases:

1. The Area feature for the converter is working correctly\
  **Automated test case**: TheAreaConvertionFromHectareToSquareMeterIsCorrect()
  
2. The Speed feature for the converter is working correctly\
  **Automated test case**: TheSpeedConvertionFromMilePerHourToSquareMeterIsCorrect()

## Solution properties

- **Language**: C# .Net Framework 4.7
- **API to communicate with the APK**: Appium
- **Logic abstraction**: Page Object Model
- **Test Runner**: MSTest

## Technical debt:

* Use explicit waits instead implicit waits
* Improve the helper to scroll up the menu too.
* Use ThreadLocal or another strategy to execute the tests in parallel
* Start the virtual device automatly with the execution
* Add a new helper to handle the filters for each convertion
