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
            string result = numbers.GetText();
            string expected = "1";
            Assert.That(result, Is.EqualTo(expected));


            numbers.SetTextFromNumber(100);
            result = numbers.GetText();
            expected = "100";
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
