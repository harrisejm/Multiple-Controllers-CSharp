using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Controllers;
using ToDoList.Models;

namespace ToDoList.Tests
{
    [TestClass]
    public class HomeControllerTest
    {

      [TestMethod]
       public void Index_ReturnsCorrectView_True()
       {
           //Arrange
           HomeController controller = new HomeController();

           //Act
           ViewResult indexView = new HomeController().Index() as ViewResult;

           //Assert
           Assert.IsInstanceOfType(indexView, typeof(ViewResult));
       }


    }
}
