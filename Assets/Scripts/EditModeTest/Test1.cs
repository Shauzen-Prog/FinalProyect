using NUnit.Framework;

namespace EditModeTest
{
    public class Test1
    {
        // A Test behaves as an ordinary method
        [Test]
        public void Test1SimplePasses()
        {
            Assert.AreEqual(3 + 2, 5, $"Se esperaba que el numero sea igual");
        }
    }
}
