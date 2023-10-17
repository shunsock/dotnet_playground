using System;
using MyFirstProject.Service.TextOutPutter.Interface;

namespace MyFirstProject.Service.TextOutPutter
{
    public class TextOutPutter : ITextOutPut
    {
        protected string _text = "";

        public void Output()
        {
            Console.WriteLine(this._text);
        }

        public string GetText()
        {
            return this._text;
        }
    }
}
