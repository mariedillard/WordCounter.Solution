using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
    public class CounterControllerTest
    {
        [TestMethod]
        public void Result_ReturnsCorrectActionType_ViewResult()
        {
            //Arrange
            CounterController controller = new CounterController();

            //Act
            IActionResult view = controller.Result("Dog", "Dog");

            //Assert
            Assert.IsInstanceOfType(view, typeof(ViewResult));
        }
    }
}