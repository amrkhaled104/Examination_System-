using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    #region Exam class
    public abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();

        public abstract void CreateExam();

        public void ShowExam()
        {
            Console.WriteLine($"\n--- Exam Time: {Time} minutes ---\n");
            foreach (var question in Questions)
            {
                question.Display();
                Console.WriteLine();
            }
        }
    }
    #endregion

    #region FinalExam
    public class FinalExam : Exam
    {
        public List<MCQQuestion> MCQList { get; set; }
        public List<TrueFalseQuestion> TFList { get; set; }

        public override void CreateExam()
        {
            if (MCQList != null)
                Questions.AddRange(MCQList);

            if (TFList != null)
                Questions.AddRange(TFList);
        }
    }
    #endregion

    #region PracticalExam class
    public class PracticalExam : Exam
    {
        public List<MCQQuestion> MCQList { get; set; }

        public override void CreateExam()
        {
            if (MCQList != null)
                Questions.AddRange(MCQList);
        }
    }
    #endregion


}
