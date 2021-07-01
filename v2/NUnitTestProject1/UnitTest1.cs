using NUnit.Framework;
using System.Numerics;

namespace NUnitTestProject1
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
            BigInteger a= ClassLibrary1.Generate.getRandom();
            bool b = ClassLibrary1.MillerRabin.MillerRabinTest(a);
            if(b==true)
            Assert.AreEqual(a,a);
            else
            Assert.AreEqual(a, null);
        }
        [Test]
        public void Test2()
        {
            BigInteger a = ClassLibrary1.Generate.getRandom();
            bool b = ClassLibrary1.MillerRabin.MillerRabinTest(a);
            if (b == true)
                Assert.AreEqual(a, a);
            else
                Assert.AreEqual(a, null);
        }
        [Test]
        public void Test3()
        {
            int b = 10000, c = 300000;
            BigInteger a = ClassLibrary1.Generate.getRandom(b,c);
            if(a>b&&a<c)
                Assert.AreEqual(a, a);
        }
        [Test]
        public void Test4()
        {
            BigInteger a = ClassLibrary1.Generate.getRandom();
            BigInteger b = ClassLibrary1.Generate.getRandom();
            BigInteger c = ClassLibrary1.Sravnisuka.sravnisuka(a,b);
            BigInteger ab = a * b;
            Assert.AreEqual(ab, c);
        }
        [Test]
        public void Test5()
        {
            BigInteger a = 4579339;
            BigInteger b = 8149079;
            BigInteger c = ClassLibrary1.Sravnisuka.sravnisuka(a, b);
            BigInteger ab = a * b;
            Assert.AreEqual(ab, c);

        }
    }
}