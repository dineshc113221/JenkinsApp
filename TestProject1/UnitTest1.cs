using Maths;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void AddTest()
        {
            MyMaths myMaths = new MyMaths();
            int exresult = 12;
            int actresult = myMaths.Add(5, 7);
            Assert.AreEqual(exresult, actresult, "Add is not correct");
        }
        [Test]
        public void MulTest()
        {
            MyMaths myMaths = new MyMaths();
            int exresult = 35;
            int actresult = myMaths.Mul(5, 7);
            Assert.AreEqual(exresult, actresult, "Mul is not correct");
        }
    }
}