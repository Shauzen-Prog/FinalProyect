using NUnit.Framework;

namespace EditModeTest
{
    public class Test1
    {
        // A Test behaves as an ordinary method
        [Test]
        public void Test1SimplePasses()
        {
            var value1 = 3;
            var value2 = 2;
            var result = 5;
            
            Assert.AreEqual(value1 + value2, result, $"The expect number is {result} but is {value1 + value2}");
        }
    }
}
