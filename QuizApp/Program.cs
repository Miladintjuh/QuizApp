using System;

namespace QuizApp
{
    class Program
    {
        void Main(string[] args)
        {

            //Question first = new Question();
            //first.Text = "Who was the inventor of Java?" ;
            //first.Answer = "James Gosling";



            //first.Display();
            //Console.WriteLine("Your answer: ");
            //string Response = Console.ReadLine();

            //Console.WriteLine(first.CheckAnswer(Response));
            Console.WriteLine("Welcome to the quiz");
            Console.WriteLine("Do you want to answer all questions? Enter A." );
            Console.WriteLine("Do you want to answer questions with a specific difficulty? Enter either 1, 2, or 3." );
            string Input = Console.ReadLine();

            if (Input == "a")
            {
                RunQuestions();
            }
            else if (Input == "1")
            {
                // Give difficulty 1 questions
            }
            else if (Input == "2")
            {
                // Give difficulty 2 questions
            }
            else if (Input == "3")
            {
                // Give difficulty 3 questions
            }


        }

        public static void PresentQuestion(ChoiceQuestion q)
        {
            q.Display();
            Console.WriteLine("Your answer: ");
            string response = Console.ReadLine();
            Console.WriteLine(q.CheckAnswer(response));

        }
    
        public void RunQuestions()
        {
            ChoiceQuestion cq1 = new ChoiceQuestion();
            cq1.Text = "What was the original name of the java language?";
            cq1.AddChoice("7", false);
            cq1.AddChoice("Duke", false);
            cq1.AddChoice("Oak", true);
            cq1.AddChoice("Gosling", false);
            cq1.Difficulty = 2;
            cq1.Category = "Java";

            ChoiceQuestion cq2 = new ChoiceQuestion();
            cq2.Text = "In which country was the inventor of java born?";
            cq2.AddChoice("Australia", false);
            cq2.AddChoice("England", true);
            cq2.AddChoice("'Murica", false);
            cq2.Difficulty = 2;
            cq2.Category = "Java";

            ChoiceQuestion cq3 = new ChoiceQuestion();
            cq3.Text = "In which classroom are most exams given?";
            cq3.AddChoice("Sl5.32", false);
            cq3.AddChoice("Sl2.12", true);
            cq3.AddChoice("'SL2.15", false);
            cq3.Difficulty = 3;
            cq3.Category = "School";

            ChoiceQuestion cq4 = new ChoiceQuestion();
            cq4.Text = "How is peanutbutter made?";
            cq4.AddChoice("With peanuts", false);
            cq4.AddChoice("With bananas", true);
            cq4.AddChoice("With ganja", false);
            cq4.Difficulty = 1;
            cq4.Category = "Food";

            PresentQuestion(cq1);
            PresentQuestion(cq2);
            PresentQuestion(cq3);
            PresentQuestion(cq4);


            Console.ReadLine();

        }
    }
}
