using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCountersControllerTest
  {
    [TestMethod]
    public void New_ReturnsCorrectView_True()
    {
      RepeatCountersController controller = new RepeatCountersController();
      ActionResult indexView = controller.New();
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void Show_ReturnsCorrectView_True()
    {
      RepeatCountersController controller = new RepeatCountersController();
      ActionResult indexView = controller.Show();
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }
  }
}
