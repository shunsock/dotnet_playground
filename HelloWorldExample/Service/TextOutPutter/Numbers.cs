using System;

namespace MyFirstProject.Service.TextOutPutter
{
    public class Numbers : ITextOutPutWithSetter
    {
        private string text = "0";

        public string Text
        {
            get { return text; }
        }

        public void Output()
        {
            Console.WriteLine(this.Text);
        }

        public void SetTextFromNumber(int number)
        {
            this.text = number.ToString();
        }
    }
}
