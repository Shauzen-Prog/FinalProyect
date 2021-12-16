using NUnit.Framework;

namespace EditModeTest
{
    public class Test1
    {
        // A Test behaves as an ordinary method
        [Test]
        public void Test1SimplePasses()
        {
            Assert.AreEqual(2 + 2, 4);
            
        }
    }
}
