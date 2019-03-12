using NUnit.Framework;
using Project;
using System;

namespace Tests
{
    public class TestsClass_Tests
    {
        private TestClass testClass;

        [SetUp]
        public void Setup()
        {
            testClass = new TestClass();
        }

        [TestCase("test1")]
        [TestCase("test2")]
        [TestCase("test3")]
        public void ValueShouldReturnTrue(object value)
        {
            var result = testClass.IsString(value);
            Assert.IsTrue(result);
        }

        [TestCase(1)]
        [TestCase(1.1)]
        [TestCase(-2)]
        public void ValueShouldReturnFalse(object value)
        {
            var result = testClass.IsString(value);
            Assert.IsFalse(result);
        }

        [TestCase(null)]
        public void MethodShouldThrowArgumentNullException(object value)
        {
            Assert.Throws<ArgumentNullException>
                (delegate { testClass.IsString(value); });
        }
    }
}