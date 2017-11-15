using System;

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Question first = new Question();
            first.Text = "Who was the inventor of Java?" ;
            first.Answer = "James Gosling";

            Console.ReadLine();
        }
    }
}
