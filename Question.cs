using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    #region Question
    public abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public float Mark { get; set; }
        public string Explanation { get; set; }

        public abstract void Display();
        public abstract void ShowCorrectAnswerWithExplanation();


    }
    #endregion


    #region  McQ Question class

    public class MCQQuestion : Question
    {
        private char _correctChoiceIndex = 'A';
        public List<string> Choices { get; set; } = new List<string>();

        public char CorrectChoiceIndex
        {
            get => _correctChoiceIndex;
            set
            {
                char upperValue = char.ToUpper(value);

                while (true)
                {
                    if (upperValue < 'A' || upperValue > 'Z')
                    {
                        Console.WriteLine("Invalid input! Please enter a letter from A-Z.");
                        upperValue = char.ToUpper(Console.ReadKey().KeyChar);
                        Console.WriteLine();
                        continue;
                    }

                    if (Choices != null && (upperValue - 'A') >= Choices.Count)
                    {
                        Console.WriteLine($"Invalid choice! Please enter a letter between A-{(char)('A' + Choices.Count - 1)}.");
                        upperValue = char.ToUpper(Console.ReadKey().KeyChar);
                        Console.WriteLine();
                        continue;
                    }

                    _correctChoiceIndex = upperValue;
                    break;
                }
            }
        }

        public override void ShowCorrectAnswerWithExplanation()
        {
            int index = CorrectChoiceIndex - 'A';
            Console.WriteLine($"\nCorrect Answer: {CorrectChoiceIndex}. {Choices[index]}");

            if (!string.IsNullOrEmpty(Explanation))
            {
                Console.WriteLine($"\n Explanation:\n{Explanation}");
            }
            else
            {
                Console.WriteLine("(No explanation available)");
            }
        }

        public override void Display()
        {
            Console.WriteLine($"[{Header}] {Body} (Mark: {Mark})");

            for (int i = 0; i < Choices.Count; i++)
            {
                char choiceLetter = (char)('A' + i);
                Console.WriteLine($"{choiceLetter}. {Choices[i]}");
            }
        }
    }
    #endregion


    #region TrueFalseQuestion class
    public class TrueFalseQuestion : Question
    {
        private bool _correctAnswer;

        public bool CorrectAnswer
        {
            get => _correctAnswer;
            set => _correctAnswer = value;
        }
        public override void Display()
        {
            Console.WriteLine($"[{Header}] {Body} (Mark: {Mark})");
            Console.WriteLine("1. True");
            Console.WriteLine("2. False");
        }
        public override void ShowCorrectAnswerWithExplanation()
        {
            Console.WriteLine($"\nCorrect Answer: {(_correctAnswer ? "True" : "False")}");

            if (!string.IsNullOrEmpty(Explanation))
            {
                Console.WriteLine($"\n Explanation:\n{Explanation}");
            }
            else
            {
                Console.WriteLine("(No explanation available for this question)");
            }
        }

    }
    #endregion

}
