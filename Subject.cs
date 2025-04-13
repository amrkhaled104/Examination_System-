using Examination_System;

public class Subject
{
    public int SubjectId { get; set; }
    public string SubjectName { get; set; }

    public FinalExam FinalExam { get; set; }
    public PracticalExam PracticalExam { get; set; }

    public void CreateExam(Exam exam)
    {
        if (exam is FinalExam final)
        {
            FinalExam = final;
        }
        else if (exam is PracticalExam practical)
        {
            PracticalExam = practical;
        }
    }
}