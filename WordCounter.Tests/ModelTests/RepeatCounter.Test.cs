using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void RepeatCounter_CallConstructor_NewInstanceOfRepeatCounter()
    {
      RepeatCounter myCounter = new RepeatCounter();
      Assert.AreEqual("testing", myCounter.test);
    }

    [TestMethod]
    public void RepeatCounter

  }
}
