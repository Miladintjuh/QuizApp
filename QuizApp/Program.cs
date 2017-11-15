using System;

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Question first = new Question();
            //first.Text = "Who was the inventor of Java?" ;
            //first.Answer = "James Gosling";



            //first.Display();
            //Console.WriteLine("Your answer: ");
            //string Response = Console.ReadLine();

            //Console.WriteLine(first.CheckAnswer(Response));


            ChoiceQuestion cq1= new ChoiceQuestion();
            cq1.Text = "What was the original name of the java language?";
            cq1.AddChoice("7", false);
            cq1.AddChoice("Duke", false);
            cq1.AddChoice("Oak", true);
            cq1.AddChoice("Gosling", false);

            ChoiceQuestion cq2 = new ChoiceQuestion();
            cq2.Text = "In which country was the inventor of java born?";
            cq2.AddChoice("Australia", false);
            cq2.AddChoice("England", true);
            cq2.AddChoice("'Murica", false);

            PresentQuestion(cq1);
            PresentQuestion(cq2);
            
           

            Console.ReadLine();
        }

        public static void PresentQuestion(ChoiceQuestion q)
        {
            q.Display();
            Console.WriteLine("Your answer: ");
            string response = Console.ReadLine();
            Console.WriteLine(q.CheckAnswer(response));
        }
    }
}
