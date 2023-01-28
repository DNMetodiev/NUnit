using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;

namespace Summator.UnitTests
{
    public class SummatorTests
    {
        //positive test
        [Test]
       public void Test_Summator_SumTwoPositiveNumber()
        {
            var nums = new int[] { 1, 2 };
            var actual = Summator.Sum(nums);

            var expected = 3;

            Assert.AreEqual(expected, actual);
        }
        //negative test
        [Test]
        public void Test_Summator_SumTwoNegativeNumbers()
        {
            var nums = new int[] { -1, -99 };
            var actual = Summator.Sum(nums);

            var expected = -100;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_OneNumber()
        {
            var nums = new int[] { 6 };
            var actual = Summator.Sum(nums);

            var expected = 6;

            Assert.AreEqual(expected, actual);
        }
    }
}