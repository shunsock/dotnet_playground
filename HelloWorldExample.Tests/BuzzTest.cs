using NUnit.Framework;
using MyFirstProject;

namespace MyFirstProject.Service.TextOutPutter.Tests
{
    public class BuzzTests
    {
        [Test]
        public void CanCreateInstance()
        {
            Buzz buzz = new Buzz();
            Assert.IsNotNull(buzz);
        }

        [Test]
        public void CanCallBuzz()
        {
            Buzz buzz = new Buzz();
            string result = buzz.Text;
            string expected = "Buzz";
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
