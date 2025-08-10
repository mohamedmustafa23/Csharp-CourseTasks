using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public abstract class Exam 
    {
        public String Level { get; set; }
        public string SubjectName { get; set; }
        public List<Question> questions { get; set; }
        protected Exam(string subjectName, List<Question> questions, string level)
        {
            SubjectName = subjectName;
            this.questions = questions;
            Level = level;
        }
        public abstract void DisplayExam();
        public virtual string CalculateDegree()
        {
            int degree = 0;
            int totalMarks = 0;
            foreach (var question in questions)
            {
                bool isCorrect = false;

                if (question.StudentAnswer != null && question.CorrectAnswer != null)
                {
                    isCorrect = question.StudentAnswer.Count == question.CorrectAnswer.Count && !question.StudentAnswer.Except(question.CorrectAnswer).Any();
                }

                if (isCorrect)
                {
                    degree += question.Marks;
                }

                totalMarks += question.Marks;
            }
            return $"Your Degree is:{degree} from {totalMarks}";
        }
    }

    public class FinalExam : Exam
    {
        public int Time { get; set; }
        
       
        public FinalExam(int time, string subjectName, List<Question> questions, string level) : base( subjectName, questions, level)
        {
            Time = time;
        }

        public override void DisplayExam()
        {
            Console.WriteLine($"------------------------------ Starting Final Exam for {SubjectName} ---------------------------");
            Console.WriteLine($"------------------------------ Duration: {Time} minutes | Total Questions: {questions.Count}");

            for (int i = 0; i < questions.Count; i++)
            {
                questions[i].DisplayQuestion();
                Console.WriteLine("------------------------------------------");
            }

        }
        public override string CalculateDegree()
        {
           return base.CalculateDegree();
        }


    }
    public class PracticalExam : Exam
    {
        public PracticalExam(string subjectName, List<Question> questions, string level) : base(subjectName, questions, level)
        {
        }

        

        public override void DisplayExam()
        {
            Console.WriteLine($"------------------------------ Starting Practical Exam for {SubjectName} ---------------------------");
            Console.WriteLine($"----------------------------------------Total Questions: {questions.Count} -------------------");
            for (int i = 0; i < questions.Count; i++)
            {
                questions[i].DisplayQuestion();
                Console.WriteLine("------------------------------------------");
            }

        }
        public override string CalculateDegree()
        {
            return base.CalculateDegree();
        }
    }
}
