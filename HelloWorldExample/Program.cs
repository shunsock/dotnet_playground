using MyFirstProject.Service.Runner;

namespace MyFirstProject
{
    class Program
    {
        static void Main()
        {
            FizzBuzzRunner runner = new FizzBuzzRunner();
            runner.Run(30);
        }
    }
}
