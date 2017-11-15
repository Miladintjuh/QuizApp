using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp
{
    class ChoiceQuestion : Question
    {
        private List<string> Choices = new List<string>();

        public void AddChoice(string Choice, bool Correct)
        {
            Choices.Add(Choice);
            if (Correct)
            {
                string ChoiceString = "" + Choices.Count;
                Answer= ChoiceString;
            }
                
        }

        public new void Display()
        {
            for (int i = 0; i < Choices.Count; i++)
            {
                int ChoiceNumber = i + 1;
                Console.WriteLine(ChoiceNumber + ": " + Choices[i]);
            }
        }

    }
}
