using DemoQA.Tests;
using DemoQA.Utilities.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace DemoQA.Interactions
{
    [TestFixture]
    public class Sortable : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/sortable");
        }

        [Test]
        public void OptionPlaceIsSwitch_When_DragAndDropUnderOtherOption()
        {
            var listOfOptions = Driver.FindElements(By.XPath("//div[@id='demo-tabpane-list']//div[contains(@class, 'list-group-item')]"));

            var index = 1;

            Builder.DragAndDropToOffset(listOfOptions[index], 0, 50).Perform();

            Assert.AreEqual("Two", listOfOptions[index + 1].Text);
        }

        [Test]
        public void OptionPlaceIsSwitch_When_DragAndDropOverOtherOption()
        {
            var container = Driver.FindElement(By.Id("demo-tabpane-list"));
            var listOfOptions = Driver.FindElements(By.XPath("//div[@id='demo-tabpane-list']//div[contains(@class, 'list-group-item')]"));

            var index = 4;

            Builder.DragAndDropToOffset(listOfOptions[index], 100, 50).Perform();

            Assert.AreEqual("Five", listOfOptions[index - 1].Text);
        }

        [Test]
        public void AllOptionsAreOrdered_When_DragAndDropSingleOption()
        {
            var container = Driver.FindElement(By.CssSelector("#demo-tabpane-list > div"));
            var listOfOptions = Driver.FindElements(By.XPath("//div[@id='demo-tabpane-list']//div[contains(@class, 'list-group-item')]"));

            Builder.DragAndDropToOffset(listOfOptions[4], 100, 50).Perform();

            Assert.IsTrue(listOfOptions.All(o => o.Location.X == container.Location.X));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
