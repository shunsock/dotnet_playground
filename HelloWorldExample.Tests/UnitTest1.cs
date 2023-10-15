using NUnit.Framework;
using MyFirstProject;


namespace MyFisttProject.Tests
{
    public class MyFirstClassTests
    {
        [Test]
        public void CanCreateInstance()
        {
            MyFirstClass myFirstClass = new MyFirstClass();
            Assert.IsNotNull(myFirstClass);
        }
    }
}
