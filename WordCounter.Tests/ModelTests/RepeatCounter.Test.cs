using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounter
  {
    [TestMethod]
    public void RepeatCounter_CallConstructor_NewInstanceOfRepeatCounter()
    {
      RepeatCounter myCounter = new RepeatCounter();
      Assert.AreEqual(typeof(RepeatCounter), myCounter.GetType());
    }

    [TestMethod]
    public void GetTest_CallGetTest_ReturnTesting()
    {
      RepeatCounter myCounter = new RepeatCounter();
      Assert.AreEqual("testing", myCounter.GetTest());
    }
  }
}
