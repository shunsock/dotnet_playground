using System;
using MyFirstProject.Service.TextOutPutter;

namespace MyFirstProject.Service.Runner
{
    public class FizzBuzzRunner : IIterationRunner
    {
        private Fizz fizz = new Fizz();
        private Buzz buzz = new Buzz();
        private FizzBuzz fizzBuzz = new FizzBuzz();
        private Numbers numbers = new Numbers();

        public void Run(int numberOfIterations)
        {
            for (int i = 1; i <= numberOfIterations; i++)
            {
                if (i % 15 == 0)
                {
                    fizzBuzz.Output();
                }
                else if (i % 3 == 0)
                {
                    fizz.Output();
                }
                else if (i % 5 == 0)
                {
                    buzz.Output();
                }
                else
                {
                    numbers.SetTextFromNumber(i);
                    numbers.Output();
                }
            }
        }
    }
}
