using NUnit.Framework;
using MyFirstProject;

namespace MyFirstProject.Service.TextOutPutter.Tests
{
    public class FizzBuzzTests
    {
        [Test]
        public void CanCreateInstance()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.IsNotNull(fizzBuzz);
        }

        [Test]
        public void CanCallBuzz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.GetText();
            string expected = "FizzBuzz";
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
