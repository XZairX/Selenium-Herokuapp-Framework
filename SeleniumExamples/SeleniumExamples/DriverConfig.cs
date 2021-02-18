﻿using System;
using OpenQA.Selenium;

namespace SeleniumExamples
{
    public class DriverConfig<T> where T : IWebDriver, new()
    {
        public DriverConfig(int elementWaitTime, int pageWaitTime)
        {
            Driver = new T();
            ConfigureDriverTimeouts(elementWaitTime, pageWaitTime);
        }

        public T Driver { get; private set; }

        private void ConfigureDriverTimeouts(int elementWaitTime, int pageWaitTime)
        {
            Driver.Manage().Timeouts().ImplicitWait = 
                TimeSpan.FromSeconds(elementWaitTime);

            Driver.Manage().Timeouts().PageLoad =
                TimeSpan.FromSeconds(pageWaitTime);
        }
    }
}