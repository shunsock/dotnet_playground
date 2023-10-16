using NUnit.Framework;
using MyFirstProject;

namespace MyFirstProject.Service.TextOutPutter.Tests
{
    public class NumbersTests
    {
        [Test]
        public void CanCreateInstance()
        {
            Numbers numbers = new Numbers();
            Assert.IsNotNull(numbers);
        }

        [Test]
        public void CanCallNumbers()
        {
            Numbers numbers = new Numbers();
            numbers.SetTextFromNumber(1);
            string result = numbers.Text;
            string expected = "1";
            Assert.That(result, Is.EqualTo(expected));


            numbers.SetTextFromNumber(100);
            result = numbers.Text;
            expected = "100";
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
