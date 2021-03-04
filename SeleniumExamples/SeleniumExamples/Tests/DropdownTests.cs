﻿using NUnit.Framework;
using SeleniumExamples.Pages;

namespace SeleniumExamples.Tests
{
    [TestFixture]
    public class DropdownTests
    {
        private PageFactory _sut;

        [OneTimeSetUp]
        public void OneTimeSetUp() => _sut = new PageFactory(StaticDriver.Type);

        [OneTimeTearDown]
        public void OneTimeTearDown() => _sut.CloseDriver();

        [Test]
        public void Option0()
        {
            _sut.DropdownPage.NavigateToPage();

            var result = _sut.DropdownPage.ReadDropdownText();

            Assert.That(result, Is.EqualTo("Please select an option"));
        }


        [Test]
        public void ClickOption1()
        {
            _sut.DropdownPage.NavigateToPage();

            _sut.DropdownPage.ClickOption1();
            var result = _sut.DropdownPage.ReadDropdownText();

            Assert.That(result, Is.EqualTo("Option 1"));
        }
    }
}
