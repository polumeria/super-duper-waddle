using Microsoft.VisualStudio.TestTools.UnitTesting;
using forms;

namespace formsTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestCheckString()
    {
        string[] actingstring = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
        foreach (var word in actingstring)
        {
            bool result = word.CheckString();
            Assert.IsTrue(result,
                   string.Format("Expected for '{0}': true; Actual: {1}", word, result));
        }
    }
}
