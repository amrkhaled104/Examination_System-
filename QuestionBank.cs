using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public static class QuestionBank
    {
        #region Math
        #region MCQ
        public static List<MCQQuestion> MathMCQQuestions { get; } = new List<MCQQuestion>
        {
            new MCQQuestion
            {
                Header = "Q1",
                Body = "What is 2 + 2?",
                Mark = 1,
                Choices = new List<string> { "3", "4", "5" },
                CorrectChoiceIndex = 'B',
                Explanation = "Basic addition: 2 + 2 = 4"
            },
            new MCQQuestion
            {
                Header = "Q2",
                Body = "What is the derivative of x^2?",
                Mark = 2,
                Choices = new List<string> { "2x", "x", "x^2" },
                CorrectChoiceIndex = 'A',
                Explanation = "The derivative of x^2 is 2x"
            },
            new MCQQuestion
            {
                Header = "Q3",
                Body = "What is the value of Pi?",
                Mark = 1,
                Choices = new List<string> { "3.12", "3.14", "3.16" },
                CorrectChoiceIndex = 'B',
                Explanation = "Pi is approximately 3.14159"
            },
            new MCQQuestion
            {
                Header = "Q4",
                Body = "What is the square root of 25?",
                Mark = 1,
                Choices = new List<string> { "4", "5", "6" },
                CorrectChoiceIndex = 'B',
                Explanation = "The square root of 25 is 5"
            },
            new MCQQuestion
            {
                Header = "Q5",
                Body = "What is the result of 5 * 3?",
                Mark = 1,
                Choices = new List<string> { "15", "20", "25" },
                CorrectChoiceIndex = 'A',
                Explanation = "5 multiplied by 3 equals 15"
            }
        };
        #endregion

        #region TF
        public static List<TrueFalseQuestion> MathTrueFalseQuestions { get; } = new List<TrueFalseQuestion>
        {
            new TrueFalseQuestion
            {
                Header = "Q1",
                Body = "Pi is approximately 3.14",
                Mark = 1,
                CorrectAnswer = true,
                Explanation = "Correct! Pi ≈ 3.14159"
            },
            new TrueFalseQuestion
            {
                Header = "Q2",
                Body = "The square root of 16 is 5",
                Mark = 1,
                CorrectAnswer = false,
                Explanation = "The square root of 16 is 4"
            },
            new TrueFalseQuestion
            {
                Header = "Q3",
                Body = "0 is an even number",
                Mark = 1,
                CorrectAnswer = true,
                Explanation = "0 is considered an even number."
            },
            new TrueFalseQuestion
            {
                Header = "Q4",
                Body = "The sum of two odd numbers is always even",
                Mark = 1,
                CorrectAnswer = false,
                Explanation = "The sum of two odd numbers is always even."
            },
            new TrueFalseQuestion
            {
                Header = "Q5",
                Body = "The derivative of a constant is zero",
                Mark = 1,
                CorrectAnswer = true,
                Explanation = "The derivative of any constant is zero."
            }
        };
        #endregion
        #endregion

        #region Physics
        #region MCQ
        public static List<MCQQuestion> PhysicsMCQQuestions { get; } = new List<MCQQuestion>
        {
            new MCQQuestion
            {
                Header = "Q1",
                Body = "What is the speed of light?",
                Mark = 2,
                Choices = new List<string> { "3 x 10^8 m/s", "2 x 10^8 m/s", "5 x 10^8 m/s" },
                CorrectChoiceIndex = 'A',
                Explanation = "The speed of light is approximately 3 x 10^8 meters per second."
            },
            new MCQQuestion
            {
                Header = "Q2",
                Body = "What is the unit of force?",
                Mark = 1,
                Choices = new List<string> { "Newton", "Joule", "Watt" },
                CorrectChoiceIndex = 'A',
                Explanation = "Force is measured in Newtons (N)."
            },
            new MCQQuestion
            {
                Header = "Q3",
                Body = "What is the formula for gravitational force?",
                Mark = 2,
                Choices = new List<string> { "F = ma", "F = G(m1 * m2) / r^2", "F = kx" },
                CorrectChoiceIndex = 'B',
                Explanation = "Gravitational force is given by F = G(m1 * m2) / r^2."
            },
            new MCQQuestion
            {
                Header = "Q4",
                Body = "Which planet is closest to the Sun?",
                Mark = 1,
                Choices = new List<string> { "Earth", "Venus", "Mercury" },
                CorrectChoiceIndex = 'C',
                Explanation = "Mercury is the closest planet to the Sun."
            },
            new MCQQuestion
            {
                Header = "Q5",
                Body = "What is the kinetic energy formula?",
                Mark = 2,
                Choices = new List<string> { "KE = mv^2", "KE = 1/2 mv^2", "KE = mgh" },
                CorrectChoiceIndex = 'B',
                Explanation = "Kinetic energy is given by KE = 1/2 mv^2."
            }
        };
        #endregion

        #region TF
        public static List<TrueFalseQuestion> PhysicsTrueFalseQuestions { get; } = new List<TrueFalseQuestion>
        {
            new TrueFalseQuestion
            {
                Header = "Q1",
                Body = "The speed of sound is faster than the speed of light",
                Mark = 1,
                CorrectAnswer = false,
                Explanation = "The speed of light is much faster than the speed of sound."
            },
            new TrueFalseQuestion
            {
                Header = "Q2",
                Body = "Heat always flows from high to low temperature",
                Mark = 1,
                CorrectAnswer = true,
                Explanation = "Heat always flows from a body of higher temperature to lower temperature."
            },
            new TrueFalseQuestion
            {
                Header = "Q3",
                Body = "Gravity is the same everywhere on Earth",
                Mark = 1,
                CorrectAnswer = false,
                Explanation = "Gravity varies slightly depending on your location on Earth."
            },
            new TrueFalseQuestion
            {
                Header = "Q4",
                Body = "The Earth revolves around the Sun in a perfect circle",
                Mark = 1,
                CorrectAnswer = false,
                Explanation = "The Earth's orbit around the Sun is elliptical."
            },
            new TrueFalseQuestion
            {
                Header = "Q5",
                Body = "An object in free fall accelerates at 9.8 m/s^2",
                Mark = 1,
                CorrectAnswer = true,
                Explanation = "Objects in free fall accelerate at 9.8 m/s^2 due to gravity."
            }
        };
        #endregion
        #endregion

        #region CS
        #region MCQ
        public static List<MCQQuestion> CSMCQQuestions { get; } = new List<MCQQuestion>
        {
            new MCQQuestion
            {
                Header = "Q1",
                Body = "What is the full form of OOP?",
                Mark = 1,
                Choices = new List<string> { "Object-Oriented Programming", "Open Online Programming", "Object-Oriented Process" },
                CorrectChoiceIndex = 'A',
                Explanation = "OOP stands for Object-Oriented Programming."
            },
            new MCQQuestion
            {
                Header = "Q2",
                Body = "What does HTML stand for?",
                Mark = 1,
                Choices = new List<string> { "Hyper Text Markup Language", "High Tech Machine Language", "Hyperlink Text Markup Language" },
                CorrectChoiceIndex = 'A',
                Explanation = "HTML stands for HyperText Markup Language."
            },
            new MCQQuestion
            {
                Header = "Q3",
                Body = "What is the main purpose of the 'this' keyword in C#?",
                Mark = 1,
                Choices = new List<string> { "Refers to the current object", "Creates a new object", "None of the above" },
                CorrectChoiceIndex = 'A',
                Explanation = "'this' refers to the current instance of the class."
            },
            new MCQQuestion
            {
                Header = "Q4",
                Body = "Which of the following is a primitive data type in C#?",
                Mark = 1,
                Choices = new List<string> { "String", "Int", "Object" },
                CorrectChoiceIndex = 'B',
                Explanation = "Int is a primitive data type in C#."
            },
            new MCQQuestion
            {
                Header = "Q5",
                Body = "Which of these is used for defining a class in C#?",
                Mark = 2,
                Choices = new List<string> { "class", "struct", "module" },
                CorrectChoiceIndex = 'A',
                Explanation = "The keyword 'class' is used to define a class in C#."
            }
        };
        #endregion

        #region TF
        public static List<TrueFalseQuestion> CSTrueFalseQuestions { get; } = new List<TrueFalseQuestion>
        {
            new TrueFalseQuestion
            {
                Header = "Q1",
                Body = "In C#, 'String' is a primitive data type",
                Mark = 1,
                CorrectAnswer = false,
                Explanation = "String is not a primitive data type in C#."
            },
            new TrueFalseQuestion
            {
                Header = "Q2",
                Body = "A class can have multiple constructors in C#",
                Mark = 1,
                CorrectAnswer = true,
                Explanation = "C# allows multiple constructors in a class with different parameters."
            },
            new TrueFalseQuestion
            {
                Header = "Q3",
                Body = "C# is a statically typed language",
                Mark = 1,
                CorrectAnswer = true,
                Explanation = "C# is statically typed, meaning variable types are known at compile time."
            },
            new TrueFalseQuestion
            {
                Header = "Q4",
                Body = "The 'void' keyword in C# indicates a function return type of 'nothing'",
                Mark = 1,
                CorrectAnswer = true,
                Explanation = "'void' means the method doesn't return any value."
            },
            new TrueFalseQuestion
            {
                Header = "Q5",
                Body = "The 'static' keyword in C# allows access to a method or variable without creating an instance of the class",
                Mark = 1,
                CorrectAnswer = true,
                Explanation = "'static' allows you to access methods or variables without creating an instance."
            }
        };
        #endregion
        #endregion
    }
}
