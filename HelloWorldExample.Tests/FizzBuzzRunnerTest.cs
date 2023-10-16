using NUnit.Framework;
using MyFirstProject;

namespace MyFirstProject.Service.Runner.Tests
{
    public class FizzBuzzRunnerTests
    {
        [Test]
        public void CanCreateInstance()
        {
            FizzBuzzRunner runner = new FizzBuzzRunner();
            Assert.IsNotNull(runner);
        }

        [Test]
        public void CanRun()
        {
            FizzBuzzRunner runner = new FizzBuzzRunner();
            runner.Run(10);
        }
    }
}
