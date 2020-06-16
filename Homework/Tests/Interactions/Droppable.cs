using DemoQA.Tests;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoQA.Interactions
{
    [TestFixture]
    public class Droppable : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/droppable");
        }

        [Test]
        public void DropElementChangeColorOfTarget_When_DragAndDropDragMe()
        {
            var dragMe = Driver.FindElement(By.Id("draggable"));
            var dropHere = Driver.FindElement(By.Id("droppable"));

            var colorBefore = dropHere.GetCssValue("background-color");
            Builder.DragAndDrop(dragMe, dropHere).Perform();
            var colorAfter = dropHere.GetCssValue("background-color");

            Assert.AreNotEqual(colorBefore, colorAfter);
        }

        [Test]
        public void TargetColorChanged_When_DragAcceptableElement()
        {
            var axisRestrictedTab = Driver.FindElement(By.Id("droppableExample-tab-accept"));
            axisRestrictedTab.Click();

            var acceptable = Driver.FindElement(By.Id("acceptable"));
            Builder.MoveToElement(acceptable)
                .ClickAndHold()
                .MoveByOffset(1,1)
                .Perform();

            var classAfterAction = Driver.FindElement(By.Id("droppable")).GetAttribute("class");
            StringAssert.Contains("ui-droppable-active", classAfterAction);
        }

        [Test]
        public void TargetColorNotChanged_When_DragNotAcceptableElement()
        {
            var axisRestrictedTab = Driver.FindElement(By.Id("droppableExample-tab-accept"));
            axisRestrictedTab.Click();

            var notAcceptable = Driver.FindElement(By.Id("notAcceptable"));

            Builder.MoveToElement(notAcceptable)
                .ClickAndHold()
                .MoveByOffset(1, 1)
                .Perform();

            var classAfterAction = Driver.FindElement(By.Id("droppable")).GetAttribute("class");
            StringAssert.DoesNotContain(classAfterAction, "ui-droppable-active");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
