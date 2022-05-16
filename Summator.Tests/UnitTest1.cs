using NUnit.Framework;
namespace Summator.Tests
{
    public class Tests
    {
        [Test]
       public void testSumToPositiveNumbers()
        {
            long result = Summator.Sum(new int[] { 5,7,});
            Assert.That(result == 12);
        }

        [Test]
        public void testSumOnePositiveNumber()
        {
            long result = Summator.Sum(new int[] { 5, });
            Assert.That(result == 5);
        }
       
        [Test]
        public void testSumNegativeumbers()
        {
            long result = Summator.Sum(new int[] { -6,  -7, });
            Assert.That(result == -13);
        }
        [Test]
        public void testSumEmptyArray()
        {
            long result = Summator.Sum(new int[] {  });
            Assert.That(result == 0);
        }

        [Test]
        public void testSumBignumbers()
        {
            long result = Summator.Sum(new int[] { 200_000_000,200_000_000,200_000_000 });
            Assert.That(result == 600_000_000);
        }
        [Test]
        public void testAverageToPositiveNums()
        {
            int espected = 6;
            int result = Summator.Average(new int[] { 5, 7, });
            Assert.That(result == espected );
        }
        [Test]
        public void testSumOneElementArray()
        {
            int espected = 5;
            long result = Summator.Sum(new int[] { 5, });
            Assert.That(result == espected);
        }
    }
}