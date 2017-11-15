using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace QuizApp
{
   static class Program
    {
        static List<ChoiceQuestion> Questions = new List<ChoiceQuestion>();
        static void Main(string[] args)
        {
            //Question first = new Question();
            //first.Text = "Who was the inventor of Java?" ;
            //first.Answer = "James Gosling";

            //first.Display();
            //Console.WriteLine("Your answer: ");
            //string Response = Console.ReadLine();

            //Console.WriteLine(first.CheckAnswer(Response));

            Console.WriteLine("Welcome to the quiz");
            Console.WriteLine("Do you want to answer all questions? Enter A.");
            Console.WriteLine("Do you want to answer the questions from easy > hard? Enter B");
            Console.WriteLine("Do you want to answer the questions from hard > easy? Enter C");

            Console.WriteLine("Do you want to answer questions with a specific difficulty? Enter either 1, 2, or 3.");
            Console.WriteLine("Do you want to answer questions from a specific category? Enter either Java, School, or Food.");
            Console.WriteLine();
            CreateQuestions();

            string Input = Console.ReadLine();

            if (Input == "a" || Input == "A")
            {
                RunQuestions(Questions);
            }
            else if (Input == "b" || Input == "B")
            {
                List<ChoiceQuestion> EasyToHard = Questions.OrderByDescending(q => q.Difficulty).ToList();
                RunQuestions(EasyToHard);
            }
            else if (Input == "c" || Input == "B")
            {
                var HardToEasy = Questions.OrderBy(q => q.Difficulty).ToList();
                RunQuestions(HardToEasy);
            }

            else if (Input == "1")
            {
                List<ChoiceQuestion> EasyQuestions = Questions.Where(q => q.Difficulty == 1).ToList();
                  RunQuestions(EasyQuestions);
            }
            else if (Input == "2")
            {
                List<ChoiceQuestion> MediumQuestions = Questions.Where(q => q.Difficulty == 2).ToList();
                RunQuestions(MediumQuestions);
            }
            else if (Input == "3")
            {
                List<ChoiceQuestion> HardQuestions = Questions.Where(q => q.Difficulty == 3).ToList();
                RunQuestions(HardQuestions);
            }
            else if (Input == "Java" || Input == "java")
            {
                List<ChoiceQuestion> JavaQuestions = Questions.Where(q => q.Category=="Java").ToList();
                RunQuestions(JavaQuestions);
            }
            else if (Input == "School" || Input == "school")
            {
                List<ChoiceQuestion> SchoolQuestions = Questions.Where(q => q.Category == "School").ToList();
                RunQuestions(SchoolQuestions);
            }
            else if (Input == "Food" || Input == "food")
            {
                List<ChoiceQuestion> FoodQuestions = Questions.Where(q => q.Category == "Food").ToList();
                RunQuestions(FoodQuestions);
            }

        }

        public static void CreateQuestions()
        {
            ChoiceQuestion cq1 = new ChoiceQuestion()
            {
                Text = "What was the original name of the java language?",
                Difficulty = 2,
                Category = "Java"
            };

            ChoiceQuestion cq2 = new ChoiceQuestion()
            {
                Text = "In which country was the inventor of java born?",
                Difficulty = 2,
                Category = "Java"
            };

            ChoiceQuestion cq3 = new ChoiceQuestion()

            {
                Text = "In which classroom are most exams given?",
                Difficulty = 3,
                Category = "School",
            };

            ChoiceQuestion cq4 = new ChoiceQuestion()
            {
                Text = "How is peanutbutter made?",
                Difficulty = 1,
                Category = "Food"
            };

 

            cq1.AddChoice("7", false);
            cq1.AddChoice("Duke", false);
            cq1.AddChoice("Oak", true);
            cq1.AddChoice("Gosling", false);

            cq2.AddChoice("Australia", false);
            cq2.AddChoice("England", true);
            cq2.AddChoice("'Murica", false);

            cq3.AddChoice("Sl5.32", false);
            cq3.AddChoice("Sl2.12", true);
            cq3.AddChoice("'SL2.15", false);

            cq4.AddChoice("With peanuts", false);
            cq4.AddChoice("With bananas", true);
            cq4.AddChoice("With ganja", false);

            Questions.Add(cq1);
            Questions.Add(cq2);
            Questions.Add(cq3);
            Questions.Add(cq4);




            Console.ReadLine();
        }

        public static void RunQuestions(List<ChoiceQuestion> ModifiedList)
        {
            foreach (var q in ModifiedList)
            {
                PresentQuestion(q);
            }
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
