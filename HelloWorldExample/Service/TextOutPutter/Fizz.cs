using System;

namespace MyFirstProject.Service.TextOutPutter
{
    public class Fizz : ITextOutPut
    {
        private string text = "Fizz";

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
