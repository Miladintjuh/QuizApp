using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp
{
    public class Question
    {
        public string Text { get; set; }
        public string Answer { get; set; }

        public Question()
        {
            Text = "";
            Answer = "";

        }


        public bool CheckAnswer(string response)
        {
            return response.Equals(Answer);
        }


        public void Display()
        {
            Console.WriteLine(Text);
        }
    }
}
