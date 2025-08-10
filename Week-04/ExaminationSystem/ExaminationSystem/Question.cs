using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public abstract class Question
    {
        
        public string Header { get; set; }
        public string Body { get; set; }
        public int Marks { get; set; }
        public List<Answer> AnswerList { get; set; }
        public List<int> CorrectAnswer { get; set; }
        public List<int> StudentAnswer { get; set; }

        protected Question(string header, string body, int marks, List<int> correctAnswer)
        {
            Header = header;
            Body = body;
            Marks = marks;
            AnswerList = new List<Answer>();
            CorrectAnswer = correctAnswer;
            StudentAnswer = new List<int>();
        }
        public virtual void DisplayQuestion()
        {
            Console.WriteLine($"Header: {Header}\nBody: {Body} (Marks: {Marks})");

            for (int i = 0; i < AnswerList.Count; i++)
            {
                Console.Write($"{AnswerList[i].id}- {AnswerList[i].Text} \t");
            }
        }
        public override string ToString()
        {
            return $"Header: {Header}\nBody: {Body}\nMarks: {Marks}";
        }
    }
    public class MultipleChoice : Question
    {
        public MultipleChoice(string body, int marks, List<int> correctAnswer) : base("MultipleChoice", body, marks, correctAnswer) 
        {
        }

        public override void DisplayQuestion()
        {
            base.DisplayQuestion();
            Console.WriteLine("\nEnter your answer Numbers Separated by ,: ");
            string inputAnswer = Console.ReadLine();
            StudentAnswer = inputAnswer.Split(',').Select(int.Parse).ToList();
        }
    }

    public class ChooseOne : Question
    {
        public ChooseOne( string body, int marks, List<int> correctAnswer) : base("ChooseOne", body, marks, correctAnswer)
        {
        }

        public override void DisplayQuestion()
        {
            base.DisplayQuestion();
            Console.WriteLine("\nEnter your answer Number: ");
            int studentAnswer;
            while (!int.TryParse(Console.ReadLine(), out studentAnswer))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Enter Number Again: ");
            }
            StudentAnswer.Add(studentAnswer);
        }
    }
    public class TrueOrFalse : Question
    {

        public TrueOrFalse(string body, int marks, List<int> correctAnswer) : base("TrueOrFalse", body, marks, correctAnswer)
        {
            AnswerList.Add(new Answer(1,"True"));
            AnswerList.Add(new Answer(2,"False"));
        }
        public override void DisplayQuestion()
        {
            base.DisplayQuestion();
            Console.WriteLine("\nEnter your answer Number: ");
            int studentAnswer;
            while (!int.TryParse(Console.ReadLine(), out studentAnswer))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Enter Number Again: ");
            }
            StudentAnswer.Add(studentAnswer);
        }
    }
}
