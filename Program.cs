using System;
using System.Collections.Generic;

namespace Examination_System
{
    class Program
    {
        static void Main()
        {
            List<Question> examQuestions = new List<Question>
            {
                new MCQQuestion
                {
                    Header = "MCQ:",
                    Body = "What is the capital of France?",
                    Mark = 2,
                    Choices = new List<string> { "Berlin", "Madrid", "Paris", "Rome" },
                    CorrectChoiceIndex = 'C',
                    Explanation = "Paris is the capital of France."
                },
                new TrueFalseQuestion
                {
                    Header = "TF:",
                    Body = "The sun rises from the west.",
                    Mark = 1,
                    CorrectAnswer = false,
                    Explanation = "The sun rises from the east, not the west."
                },
                new MCQQuestion
                {
                    Header = "MCQ:",
                    Body = "Which planet is known as the Red Planet?",
                    Mark = 2,
                    Choices = new List<string> { "Earth", "Mars", "Jupiter", "Venus" },
                    CorrectChoiceIndex = 'B',
                    Explanation = "Mars is called the Red Planet due to its reddish appearance."
                }
            };

            int totalScore = 0;
            int userScore = 0;

            Console.WriteLine(" Welcome to the Examination System!\n");

            foreach (var question in examQuestions)
            {
                question.Display();
                Console.Write("\nYour Answer: ");

                bool isCorrect = false;

                if (question.Header.StartsWith("MCQ:"))
                {
                    MCQQuestion mcq = (MCQQuestion)question;
                    char userAnswer = char.ToUpper(Console.ReadKey().KeyChar);
                    Console.WriteLine();
                    
                    if (userAnswer == mcq.CorrectChoiceIndex)
                    {
                        isCorrect = true;
                    }
                }
                else if (question.Header.StartsWith("TF:"))
                {
                    TrueFalseQuestion tf = (TrueFalseQuestion)question;
                    int userAnswer;
                    while (!int.TryParse(Console.ReadLine(), out userAnswer) || (userAnswer != 1 && userAnswer != 2))
                    {
                        Console.Write(" Invalid input! Please enter 1 for True or 2 for False: ");
                    }

                    if ((userAnswer == 1 && tf.CorrectAnswer) || (userAnswer == 2 && !tf.CorrectAnswer))
                    {
                        isCorrect = true;
                    }
                }

                totalScore += (int)question.Mark;

                if (isCorrect)
                {
                    Console.WriteLine(" Correct Answer!\n");
                    userScore += (int)question.Mark;
                }
                else
                {
                    Console.WriteLine(" Wrong Answer!");
                    question.ShowCorrectAnswerWithExplanation();
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Exam Finished! Your Score: {userScore}/{totalScore}");
            Console.WriteLine("Thank you for participating!");
        }
    }
}