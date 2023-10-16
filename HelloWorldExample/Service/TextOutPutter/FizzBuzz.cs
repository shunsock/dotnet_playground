using System;

namespace MyFirstProject.Service.TextOutPutter
{
    public class FizzBuzz : ITextOutPut
    {
        private string text = "FizzBuzz";

        public string Text
        {
            get { return text; }
        }

        public void Output()
        {
            Console.WriteLine(this.Text);
        }
    }
}
