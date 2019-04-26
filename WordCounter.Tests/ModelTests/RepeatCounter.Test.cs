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
      RepeatCounter myCounter = new RepeatCounter("mom", "hi mom", false);
      Assert.AreEqual(typeof(RepeatCounter), myCounter.GetType());
    }

    [TestMethod]
    public void GetTarget_CallConstructor_GetTargetReturnsTarget()
    {
      RepeatCounter myCounter = new RepeatCounter("mom", "hi mom", false);
      Assert.AreEqual("mom", myCounter.GetTarget());
    }

    [TestMethod]
    public void GetPhrase_CallConstructor_GetPhraseReturnsPhrase()
    {
      RepeatCounter myCounter = new RepeatCounter("mom", "hi mom", false);
      Assert.AreEqual("hi mom", myCounter.GetPhrase());
    }

    [TestMethod]
    public void CalculateCount_TargetAndPhraseAreSame_ReturnOne()
    {
      RepeatCounter myCounter = new RepeatCounter("mom", "mom", false);
      Assert.AreEqual(1, myCounter.CalculateCount());
    }

    [TestMethod]
    public void CalculateCount_SingleInstanceInMultiWordPhrase_ReturnOne()
    {
      RepeatCounter myCounter = new RepeatCounter("mom", "hi mom", false);
      Assert.AreEqual(1, myCounter.CalculateCount());
    }

    

  }
}
