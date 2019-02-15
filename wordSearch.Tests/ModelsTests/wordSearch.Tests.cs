using Microsoft.VisualStudio.TestTools.UnitTesting;
using wordSearch;

namespace wordSearch.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void IsRepeatCount_TestOne_True()
    {
      Assert.AreEqual(true, RepeatCounter.testOne());
    }
    [TestMethod]
    public void IsRepeatCount_TestTwo_True()
    {
      Assert.AreEqual(true, RepeatCounter.testTwo());
    }
  }
}
