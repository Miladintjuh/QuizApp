using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp
{
    public class Question
    {
        public string Text { get; set; }
        public string Answer { get; set; }
        public int Difficulty { get; set; }
        public string Category { get; set; }

        public Question()
        {
            Text = "";
            Answer = "";
            Difficulty = 0;
            Category = "";
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
