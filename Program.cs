using System;
using System.Collections.Generic;

namespace Examination_System
{
    class Program
    {
        static List<Subject> subjects = new List<Subject>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your role (admin/user/exist): ");
                string role = Console.ReadLine().ToLower();

                if (role == "admin")
                {
                    AdminMenu();
                }
                else if (role == "user")
                {
                    UserMenu();
                }
                else if (role == "exist")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid role. Please restart and enter either 'admin' or 'user'.");
                }

            }
           
        }
        #region Admin
        static void AdminMenu()
        {
            Console.WriteLine("\nAdmin Menu:");
            Console.WriteLine("1. Create Final Exam");
            Console.WriteLine("2. Create Practical Exam");
            Console.WriteLine("3. Modify Question Bank");
            Console.WriteLine("4. Display Exam");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateFinalExam();
                    break;
                case 2:
                    CreatePracticalExam();
                    break;
                case 3:
                    ModifyQuestionBank();
                    break;
                case 4:
                    DisplayExam();
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }

        #endregion

        #region CreateFinalExam
        public static void CreateFinalExam()
        {
            Console.WriteLine("Enter the subject name:");
            string subjectName = Console.ReadLine().ToLower();

            Console.WriteLine("Enter the subject ID:");
            int subjectId = int.Parse(Console.ReadLine());

            Subject newSubject = subjects.FirstOrDefault(s => s.SubjectName.Equals(subjectName, StringComparison.OrdinalIgnoreCase));

            if (newSubject == null)
            {
                newSubject = new Subject { SubjectId = subjectId, SubjectName = subjectName };
                subjects.Add(newSubject);
            }

            Console.WriteLine("Enter the exam time in minutes:");
            int examTime = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of questions:");
            int examNumber = int.Parse(Console.ReadLine());

            FinalExam finalExam = new FinalExam
            {
                Time = examTime,
                NumberOfQuestions = examNumber,
                MCQList = new List<MCQQuestion>(),
                TFList = new List<TrueFalseQuestion>()
            };

            Console.WriteLine($"\nChoose MCQ questions for the {subjectName} final exam:");
            DisplayMCQBank(subjectName);

            Console.WriteLine("Enter the MCQ question numbers to add to the exam (comma separated):");
            var selectedMCQIndices = Console.ReadLine()
                .Split(',')
                .Select(x => int.TryParse(x.Trim(), out var n) ? n : -1)
                .Where(i => i > 0)
                .ToList();

            foreach (var index in selectedMCQIndices)
            {
                switch (subjectName)
                {
                    case "math":
                        if (index <= QuestionBank.MathMCQQuestions.Count)
                            finalExam.MCQList.Add(QuestionBank.MathMCQQuestions[index - 1]);
                        break;
                    case "physics":
                        if (index <= QuestionBank.PhysicsMCQQuestions.Count)
                            finalExam.MCQList.Add(QuestionBank.PhysicsMCQQuestions[index - 1]);
                        break;
                    case "cs":
                        if (index <= QuestionBank.CSMCQQuestions.Count)
                            finalExam.MCQList.Add(QuestionBank.CSMCQQuestions[index - 1]);
                        break;
                }
            }

            Console.WriteLine($"\nChoose True/False questions for the {subjectName} final exam:");
            DisplayTFBank(subjectName);

            Console.WriteLine("Enter the True/False question numbers to add to the exam (comma separated):");
            var selectedTFIndices = Console.ReadLine()
                .Split(',')
                .Select(x => int.TryParse(x.Trim(), out var n) ? n : -1)
                .Where(i => i > 0)
                .ToList();

            foreach (var index in selectedTFIndices)
            {
                switch (subjectName)
                {
                    case "math":
                        if (index <= QuestionBank.MathTrueFalseQuestions.Count)
                            finalExam.TFList.Add(QuestionBank.MathTrueFalseQuestions[index - 1]);
                        break;
                    case "physics":
                        if (index <= QuestionBank.PhysicsTrueFalseQuestions.Count)
                            finalExam.TFList.Add(QuestionBank.PhysicsTrueFalseQuestions[index - 1]);
                        break;
                    case "cs":
                        if (index <= QuestionBank.CSTrueFalseQuestions.Count)
                            finalExam.TFList.Add(QuestionBank.CSTrueFalseQuestions[index - 1]);
                        break;
                }
            }

            newSubject.CreateExam(finalExam);
            Console.WriteLine("✅ Final exam created successfully.\n");
        }


        #endregion

        #region DisplayMCQBank
        public static void DisplayMCQBank(string subjectName)
        {
            switch (subjectName)
            {
                case "math":
                    Console.WriteLine("--- Math MCQ Questions ---");
                    foreach (var question in QuestionBank.MathMCQQuestions)
                    {
                        Console.WriteLine($"{question.Header} - {question.Body}");
                        foreach (var choice in question.Choices)
                        {
                            Console.WriteLine($"    - {choice}");
                        }
                        Console.WriteLine($"Correct Answer: {question.CorrectChoiceIndex}");
                        Console.WriteLine($"Explanation: {question.Explanation}");
                        Console.WriteLine();
                    }
                    break;

                case "physics":
                    Console.WriteLine("--- Physics MCQ Questions ---");
                    foreach (var question in QuestionBank.PhysicsMCQQuestions)
                    {
                        Console.WriteLine($"{question.Header} - {question.Body}");
                        foreach (var choice in question.Choices)
                        {
                            Console.WriteLine($"    - {choice}");
                        }
                        Console.WriteLine($"Correct Answer: {question.CorrectChoiceIndex}");
                        Console.WriteLine($"Explanation: {question.Explanation}");
                        Console.WriteLine();
                    }
                    break;

                case "cs":
                    Console.WriteLine("--- CS MCQ Questions ---");
                    foreach (var question in QuestionBank.CSMCQQuestions)
                    {
                        Console.WriteLine($"{question.Header} - {question.Body}");
                        foreach (var choice in question.Choices)
                        {
                            Console.WriteLine($"    - {choice}");
                        }
                        Console.WriteLine($"Correct Answer: {question.CorrectChoiceIndex}");
                        Console.WriteLine($"Explanation: {question.Explanation}");
                        Console.WriteLine();
                    }
                    break;

                default:
                    Console.WriteLine($"No MCQ questions available for {subjectName}.");
                    break;
            }
        }

        public static void DisplayTFBank(string subjectName)
        {
            switch (subjectName)
            {
                case "math":
                    Console.WriteLine("--- Math True/False Questions ---");
                    foreach (var question in QuestionBank.MathTrueFalseQuestions)
                    {
                        Console.WriteLine($"{question.Header} - {question.Body}");
                        Console.WriteLine($"Correct Answer: {(question.CorrectAnswer ? "True" : "False")}");
                        Console.WriteLine($"Explanation: {question.Explanation}");
                        Console.WriteLine();
                    }
                    break;

                case "physics":
                    Console.WriteLine("--- Physics True/False Questions ---");
                    foreach (var question in QuestionBank.PhysicsTrueFalseQuestions)
                    {
                        Console.WriteLine($"{question.Header} - {question.Body}");
                        Console.WriteLine($"Correct Answer: {(question.CorrectAnswer ? "True" : "False")}");
                        Console.WriteLine($"Explanation: {question.Explanation}");
                        Console.WriteLine();
                    }
                    break;

                case "cs":
                    Console.WriteLine("--- CS True/False Questions ---");
                    foreach (var question in QuestionBank.CSTrueFalseQuestions)
                    {
                        Console.WriteLine($"{question.Header} - {question.Body}");
                        Console.WriteLine($"Correct Answer: {(question.CorrectAnswer ? "True" : "False")}");
                        Console.WriteLine($"Explanation: {question.Explanation}");
                        Console.WriteLine();
                    }
                    break;

                default:
                    Console.WriteLine($"No True/False questions available for {subjectName}.");
                    break;
            }
        }

        #endregion

        #region DisplayExam
        static void DisplayExam()
        {
            Console.Write("Enter subject name: ");
            string subjectName = Console.ReadLine();

            Console.Write("Enter exam type (final/practical): ");
            string examType = Console.ReadLine().ToLower();

            var subject = subjects.FirstOrDefault(s => s.SubjectName.Equals(subjectName, StringComparison.OrdinalIgnoreCase));

            if (subject == null)
            {
                Console.WriteLine("❌ Subject not found.");
                return;
            }

            if (subject.Exam == null)
            {
                Console.WriteLine("❌ No exam has been created for this subject.");
                return;
            }

            Exam exam = null;

            if (examType == "final" && subject.Exam is FinalExam)
            {
                exam = subject.Exam as FinalExam;
            }
            else if (examType == "practical" && subject.Exam is PracticalExam)
            {
                exam = subject.Exam as PracticalExam;
            }
            else
            {
                Console.WriteLine("❌ Exam type doesn't match the stored exam for this subject.");
                return;
            }

            exam.CreateExam();

            if (exam.Questions == null || exam.Questions.Count == 0)
            {
                Console.WriteLine("⚠️ No questions available in this exam.");
                return;
            }

            Console.WriteLine($"\n📘 --- {examType.ToUpper()} Exam for {subjectName} ---");
            exam.ShowExam();
        }
        #endregion

        #region CreatePracticalExam
        public static void CreatePracticalExam()
        {
            Console.WriteLine("Enter the subject name:");
            string subjectName = Console.ReadLine().ToLower();

            Console.WriteLine("Enter the subject ID:");
            int subjectId = int.Parse(Console.ReadLine());

            Subject newSubject = subjects.FirstOrDefault(s => s.SubjectName.Equals(subjectName, StringComparison.OrdinalIgnoreCase));

            if (newSubject == null)
            {
                newSubject = new Subject { SubjectId = subjectId, SubjectName = subjectName };
                subjects.Add(newSubject);
            }

            Console.WriteLine("Enter the exam time in minutes:");
            int examTime = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of MCQ questions:");
            int examNumber = int.Parse(Console.ReadLine());

            PracticalExam practicalExam = new PracticalExam
            {
                Time = examTime,
                NumberOfQuestions = examNumber,
                MCQList = new List<MCQQuestion>()
            };

            Console.WriteLine($"\nChoose MCQ questions for the {subjectName} practical exam:");
            DisplayMCQBank(subjectName);

            Console.WriteLine("Enter the MCQ question numbers to add to the exam (comma separated):");
            var selectedMCQIndices = Console.ReadLine()
                .Split(',')
                .Select(x => int.TryParse(x.Trim(), out var n) ? n : -1)
                .Where(i => i > 0)
                .ToList();

            foreach (var index in selectedMCQIndices)
            {
                switch (subjectName)
                {
                    case "math":
                        if (index <= QuestionBank.MathMCQQuestions.Count)
                            practicalExam.MCQList.Add(QuestionBank.MathMCQQuestions[index - 1]);
                        break;
                    case "physics":
                        if (index <= QuestionBank.PhysicsMCQQuestions.Count)
                            practicalExam.MCQList.Add(QuestionBank.PhysicsMCQQuestions[index - 1]);
                        break;
                    case "cs":
                        if (index <= QuestionBank.CSMCQQuestions.Count)
                            practicalExam.MCQList.Add(QuestionBank.CSMCQQuestions[index - 1]);
                        break;
                }
            }

            newSubject.CreateExam(practicalExam);
            Console.WriteLine("Practical exam created successfully.\n");
        }


        #endregion

        #region UserMenu
        static void UserMenu()
        {
            Console.WriteLine("\nUser Menu:");
            Console.WriteLine("1. Take Final Exam");
            Console.WriteLine("2. Take Practical Exam");
            Console.WriteLine("3. View Exam Results");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    TakeFinalExam();
                    break;
                case 2:
                    TakePracticalExam();
                    break;
                case 3:
                    ViewExamResults();
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }

        #endregion


        #region ModifyQuestionBank
        static void ModifyQuestionBank()
        {
            Console.WriteLine("Enter subject name (math/physics/cs):");
            string subject = Console.ReadLine()?.ToLower();

            Console.WriteLine("Enter question type (mcq/tf):");
            string questionType = Console.ReadLine()?.ToLower();

            if (questionType != "mcq" && questionType != "tf")
            {
                Console.WriteLine("❌ Invalid question type.");
                return;
            }

            if (questionType == "mcq")
            {
                var mcqList = subject switch
                {
                    "math" => QuestionBank.MathMCQQuestions,
                    "physics" => QuestionBank.PhysicsMCQQuestions,
                    "cs" => QuestionBank.CSMCQQuestions,
                    _ => null
                };

                if (mcqList == null)
                {
                    Console.WriteLine(" Invalid subject or no MCQ questions found.");
                    return;
                }

                DisplayMCQBank(subject);

                ManageMCQList(mcqList);
            }
            else 
            {
                var tfList = subject switch
                {
                    "math" => QuestionBank.MathTrueFalseQuestions,
                    "physics" => QuestionBank.PhysicsTrueFalseQuestions,
                    "cs" => QuestionBank.CSTrueFalseQuestions,
                    _ => null
                };

                if (tfList == null)
                {
                    Console.WriteLine(" Invalid subject or no True/False questions found.");
                    return;
                }

                DisplayTFBank(subject);

                ManageTFList(tfList);
            }
        }
        static void ManageMCQList(List<MCQQuestion> list)
        {
            Console.WriteLine("\nWhat do you want to do?");
            Console.WriteLine("1. Edit a question");
            Console.WriteLine("2. Add a new question");
            Console.WriteLine("3. Delete a question");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter question number to edit: ");
                    if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= list.Count)
                    {
                        var q = list[index - 1];
                        Console.Write("New Header (or leave blank): ");
                        string header = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(header)) q.Header = header;

                        Console.Write("New Body: ");
                        string body = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(body)) q.Body = body;

                        Console.Write("New Mark: ");
                        if (float.TryParse(Console.ReadLine(), out float mark)) q.Mark = mark;

                        Console.Write("New Explanation: ");
                        string explanation = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(explanation)) q.Explanation = explanation;

                        Console.Write("Enter new choices (comma separated A,B,C,...): ");
                        string choices = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(choices))
                        {
                            q.Choices = choices.Split(',').Select(c => c.Trim()).ToList();
                        }

                        if (q.Choices?.Count > 0)
                        {
                            Console.Write($"Correct choice letter (A-{(char)('A' + q.Choices.Count - 1)}): ");
                            string correct = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(correct)) q.CorrectChoiceIndex = correct[0];
                        }

                        Console.WriteLine(" MCQ Question updated.");
                    }
                    else
                    {
                        Console.WriteLine(" Invalid question number.");
                    }
                    break;

                case "2":
                    MCQQuestion newQ = new MCQQuestion();

                    Console.Write("Header: ");
                    newQ.Header = Console.ReadLine();

                    Console.Write("Body: ");
                    newQ.Body = Console.ReadLine();

                    Console.Write("Mark: ");
                    newQ.Mark = float.Parse(Console.ReadLine());

                    Console.Write("Explanation: ");
                    newQ.Explanation = Console.ReadLine();

                    Console.Write("Enter choices (comma separated): ");
                    newQ.Choices = Console.ReadLine().Split(',').Select(c => c.Trim()).ToList();

                    Console.Write($"Correct choice letter (A-{(char)('A' + newQ.Choices.Count - 1)}): ");
                    newQ.CorrectChoiceIndex = Console.ReadLine()[0];

                    list.Add(newQ);
                    Console.WriteLine("✅ Question added.");
                    break;

                case "3":
                    Console.Write("Enter question number to delete: ");
                    if (int.TryParse(Console.ReadLine(), out int delIndex) && delIndex > 0 && delIndex <= list.Count)
                    {
                        list.RemoveAt(delIndex - 1);
                        Console.WriteLine(" Question deleted.");
                    }
                    else
                    {
                        Console.WriteLine(" Invalid number.");
                    }
                    break;

                default:
                    Console.WriteLine(" Invalid option.");
                    break;
            }
        }
        static void ManageTFList(List<TrueFalseQuestion> list)
        {
            Console.WriteLine("\nWhat do you want to do?");
            Console.WriteLine("1. Edit a question");
            Console.WriteLine("2. Add a new question");
            Console.WriteLine("3. Delete a question");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter question number to edit: ");
                    if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= list.Count)
                    {
                        var q = list[index - 1];
                        Console.Write("New Header (or leave blank): ");
                        string header = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(header)) q.Header = header;

                        Console.Write("New Body: ");
                        string body = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(body)) q.Body = body;

                        Console.Write("New Mark: ");
                        if (float.TryParse(Console.ReadLine(), out float mark)) q.Mark = mark;

                        Console.Write("New Explanation: ");
                        string explanation = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(explanation)) q.Explanation = explanation;

                        Console.Write("Enter correct answer (true/false): ");
                        string correct = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(correct) && bool.TryParse(correct, out bool boolAnswer))
                        {
                            q.CorrectAnswer = boolAnswer;
                        }

                        Console.WriteLine(" True/False Question updated.");
                    }
                    else
                    {
                        Console.WriteLine(" Invalid question number.");
                    }
                    break;

                case "2":
                    TrueFalseQuestion newQ = new TrueFalseQuestion();

                    Console.Write("Header: ");
                    newQ.Header = Console.ReadLine();

                    Console.Write("Body: ");
                    newQ.Body = Console.ReadLine();

                    Console.Write("Mark: ");
                    newQ.Mark = float.Parse(Console.ReadLine());

                    Console.Write("Explanation: ");
                    newQ.Explanation = Console.ReadLine();

                    Console.Write("Enter correct answer (true/false): ");
                    newQ.CorrectAnswer = bool.Parse(Console.ReadLine());

                    list.Add(newQ);
                    Console.WriteLine(" Question added.");
                    break;

                case "3":
                    Console.Write("Enter question number to delete: ");
                    if (int.TryParse(Console.ReadLine(), out int delIndex) && delIndex > 0 && delIndex <= list.Count)
                    {
                        list.RemoveAt(delIndex - 1);
                        Console.WriteLine(" Question deleted.");
                    }
                    else
                    {
                        Console.WriteLine(" Invalid number.");
                    }
                    break;

                default:
                    Console.WriteLine(" Invalid option.");
                    break;
            }
        }
        #endregion



        static void TakeFinalExam()
                {
                    
                }

                static void TakePracticalExam()
                {
                }

                static void ViewExamResults()
                {
                }
    }
}
