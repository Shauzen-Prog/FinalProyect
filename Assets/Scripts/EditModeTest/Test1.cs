using NUnit.Framework;

namespace EditModeTest
{
    public class Test1
    {
        [TestCase(1,2, 3)]
        [TestCase(3,5, 8)]
        [TestCase(8,4, 12)]
        public void WhenInsertTwoValues_ThenCalculateResult(int value1, int value2, int result)
        {
            Assert.AreEqual(value1 + value2, result, $"The expect number is {result} but is {value1 + value2}");
        }
    }
}
