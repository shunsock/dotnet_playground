using System;

namespace MyFirstProject.Service.TextOutPutter
{
        public class Buzz : ITextOutPut
    {
        private string text = "Buzz";

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
