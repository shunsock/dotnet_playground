using System;
using System.Collections.Generic;

namespace MyFirstProject
{
    public class MyFirstClass
    {
        private string myString;
        private List<int> myIntList = new List<int>();

        public MyFirstClass()
        {
            // insert string value into myString
            this.myString = "Hello World!";

            // insert int values into myIntList
            this.myIntList.Add(1);
            this.myIntList.Add(2);
            this.myIntList.Add(3);
            this.myIntList.Add(4);
            this.myIntList.Add(5);
        }

        public void Main()
        {
            ShowMyString();
            ShowMyIntList();
        }

        private void ShowMyString()
        {
            Console.WriteLine(this.myString);
        }

        private void ShowMyIntList()
        {
            foreach (int i in this.myIntList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
