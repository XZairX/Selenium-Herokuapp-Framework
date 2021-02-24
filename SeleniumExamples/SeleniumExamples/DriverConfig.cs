﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumExamples
{
    public class DriverConfig
    {
        private readonly int _elementWaitTime;
        private readonly int _pageWaitTime;

        public DriverConfig(Type driverType,
            bool isHeadless, int elementWaitTime, int pageWaitTime)
        {
            if (isHeadless)
            {
                if (driverType == typeof(FirefoxDriver))
                {
                    FirefoxOptions options = new FirefoxOptions();
                    options.AddArguments("--headless");
                    Driver = new FirefoxDriver(options);
                }
                else if (driverType == typeof(ChromeDriver))
                {
                    ChromeOptions options = new ChromeOptions();
                    options.AddArguments("--headless");
                    Driver = new ChromeDriver(options);
                }
            }
            else
            {
                if (driverType == typeof(FirefoxDriver))
                {
                    Driver = new FirefoxDriver();
                }
                else if (driverType == typeof(ChromeDriver))
                {
                    Driver = new ChromeDriver();
                }
            }
            _elementWaitTime = elementWaitTime;
            _pageWaitTime = pageWaitTime;
            ConfigureDriverTimeouts();
        }

        public IWebDriver Driver { get; set; }

        private void ConfigureDriverTimeouts()
        {
            if (_elementWaitTime > 0)
            {
                Driver.Manage().Timeouts().ImplicitWait =
                    TimeSpan.FromSeconds(_elementWaitTime);
            }

            if (_pageWaitTime > -1)
            {
                Driver.Manage().Timeouts().PageLoad =
                    TimeSpan.FromSeconds(_pageWaitTime);
            }
        }
    }
}
