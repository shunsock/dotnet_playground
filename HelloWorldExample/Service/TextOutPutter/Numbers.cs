using System;

namespace MyFirstProject.Service.TextOutPutter
{
    public class Numbers : TextOutPutter
    {
        public Numbers()
        {
            this._text = "0";
        }

        public void SetTextFromNumber(int number)
        {
            this._text = number.ToString();
        }
    }
}
