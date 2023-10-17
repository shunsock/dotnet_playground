using NUnit.Framework;
using MyFirstProject;

namespace MyFirstProject.Service.TextOutPutter.Tests
{
    public class FizzTests
    {
        [Test]
        public void CanCreateInstance()
        {
            Fizz fizz = new Fizz();
            Assert.IsNotNull(fizz);
        }

        [Test]
        public void CanCallFizz()
        {
            Fizz fizz = new Fizz();
            string result = fizz.GetText();
            string expected = "Fizz";
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
