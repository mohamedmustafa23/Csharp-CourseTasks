using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class ExaminationManager
    {
        public List<Student> students = new List<Student>();
        public List<Doctor> doctors = new List<Doctor>();
        public List<Exam> exams = new List<Exam>();
        public List<Question> QuestionBank = new List<Question>();


        public void AddQuestionToBank()
        {
            Console.Write("Enter Total Number of Questions: ");
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Enter Number Again: ");
            }
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Choose Type Question{i}");
                Console.WriteLine("1- Multiple Choice  2- Choose One   3- True Or False");
                int type;

                while (!int.TryParse(Console.ReadLine(), out type))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write("Enter Number Again: ");
                }
                Console.WriteLine("1.enter Body of Question");
                string Body = Console.ReadLine();
                Console.WriteLine("2.enter Mark for this question");
                int Marks;
                while (!int.TryParse(Console.ReadLine(), out Marks))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write("Enter Number Again: ");
                }
                if (type > 3) break;
                if (type == 1)
                {
                    Console.WriteLine("Enter Numbers of Correct Answer seperated by ,");
                    string inputAnswer = Console.ReadLine();
                    List<int> correctAnswers = inputAnswer.Split(',').Select(int.Parse).ToList();

                    MultipleChoice question = new MultipleChoice(Body, Marks, correctAnswers);

                    Console.WriteLine("2.enter 4 Choices for this question");
                    question.AnswerList.Add(new Answer(1, Console.ReadLine()));
                    question.AnswerList.Add(new Answer(2, Console.ReadLine()));
                    question.AnswerList.Add(new Answer(3, Console.ReadLine()));
                    question.AnswerList.Add(new Answer(4, Console.ReadLine()));


                    QuestionBank.Add(question);
                }
                else if (type == 2)
                {
                    Console.WriteLine("Enter Number of Correct Answer");
                    int chooseOneAnswer;
                    while (!int.TryParse(Console.ReadLine(), out chooseOneAnswer))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.Write("Enter Number Again: ");
                    }
                    List<int> answer = new List<int>();
                    answer.Add(chooseOneAnswer);

                    ChooseOne question = new ChooseOne(Body, Marks, answer);

                    Console.WriteLine("3.enter 4 Choices for this question");
                    question.AnswerList.Add(new Answer(1, Console.ReadLine()));
                    question.AnswerList.Add(new Answer(2, Console.ReadLine()));
                    question.AnswerList.Add(new Answer(3, Console.ReadLine()));
                    question.AnswerList.Add(new Answer(4, Console.ReadLine()));

                    QuestionBank.Add(question);
                }
                else if (type == 3)
                {
                    Console.WriteLine("Enter Number of Correct Answer");
                    int trueOrFalseAnswer;
                    while (!int.TryParse(Console.ReadLine(), out trueOrFalseAnswer))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.Write("Enter Number Again: ");
                    }
                    List<int> answer = new List<int>();
                    answer.Add(trueOrFalseAnswer);
                    TrueOrFalse question = new TrueOrFalse(Body, Marks, answer);

                    QuestionBank.Add(question);
                }
                else
                {
                    Console.WriteLine("Please Enter Number Between 1 to 3");
                }
            }
        }

        public void CreateNewExam()
        {
            List<Question> selectedQuestionsForExam = new List<Question>();
            if (QuestionBank.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Question Bank is empty. Please add questions first.");
                Console.ResetColor();
                return;
            }
            Console.WriteLine("----------------------Available Questions--------------------");
            for (int i = 0; i < QuestionBank.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {QuestionBank[i]}");
            }
            Console.Write("Enter the numbers of the questions you want for this exam, separated by a comma:");
            string input = Console.ReadLine();

            var questionNumbers = input.Split(',');

            foreach (var numStr in questionNumbers)
            {
                
                if (int.TryParse(numStr.Trim(), out int qNumber) && qNumber > 0 && qNumber <= QuestionBank.Count)
                {
                    selectedQuestionsForExam.Add(QuestionBank[qNumber - 1]);
                }
                else
                {
                    Console.WriteLine($"Warning: Invalid question number '{numStr}' was ignored.");
                }
            }
            if (selectedQuestionsForExam.Count == 0)
            {
                Console.WriteLine("No valid questions were selected. Exam creation cancelled.");
                return;
            }

            Console.WriteLine("\nChoose Exam Type:\n 1- Final Exam\n 2- Practical Exam");
            int examType;
            while (!int.TryParse(Console.ReadLine(), out examType) || (examType != 1 && examType != 2))
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2.");
            }
            Console.Write("Enter subject name:");
            string subject = Console.ReadLine();
            Console.Write("Enter Exam Difficulty:");
            string examLevel = Console.ReadLine();
            if (examType == 1)
            {
                Console.WriteLine("Enter Exam Time:");
                int time;
                while (!int.TryParse(Console.ReadLine(), out time))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write("Enter Number Again: ");
                }
                FinalExam exam = new FinalExam(time, subject, selectedQuestionsForExam, examLevel);
                exams.Add(exam);
                Console.WriteLine($"Success! Practical exam for '{subject}' created with {exam.questions.Count} questions.");
            }
            else if (examType == 2)
            {
                PracticalExam exam = new PracticalExam( subject, selectedQuestionsForExam, examLevel);
                exams.Add(exam);
                Console.WriteLine($"Success! Practical exam for '{subject}' created with {exam.questions.Count} questions.");
            }
            

        }
   
        public void AddDoctor()
        {
            Console.Write("Enter the doctor Name:");
            string name = Console.ReadLine();
            Console.Write("Enter the doctor Id:");
            string id = Console.ReadLine();
            Console.Write("Enter the doctor password:");
            string password = Console.ReadLine();
            Doctor doctor = new Doctor(name, id, password);
            doctors.Add(doctor);
        }
        public void AddStudent()
        {
            Console.Write("Enter the student Name:");
            string name = Console.ReadLine();
            Console.Write("Enter the student Id:");
            string id = Console.ReadLine();
            Student student = new Student(name, id);
            students.Add(student);
        }
        public bool IsDoctorRegistered()
        {
            bool status = false;
            while (!status)
            {
                Console.Write("Enter your Id:");
                string doctorId = Console.ReadLine();
                Console.Write("Enter your Password:");
                string doctorPassword = Console.ReadLine();

                for (int i = 0; i < doctors.Count; i++)
                {
                    if (doctors[i].Id == doctorId && doctors[i].Password == doctorPassword)
                    {
                        status = true;
                        break;
                    }
                }
                if (status)
                {
                    return status;
                }
                else
                {
                    Console.WriteLine("Your Id Or Password Wrong Try Again");
                }
            }

            return status;

        }
        public bool IsStudentRegistered()
        {
            bool status = false;
            while (!status)
            {
                Console.Write("Enter your Id:");
                string studentId = Console.ReadLine();

                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].Id == studentId)
                    {
                        status = true;
                        break;
                    }
                }
                if (status)
                {
                    return status;
                }
                else
                {
                    Console.WriteLine("Your Id Or Password Wrong Try Again");
                }
            }

            return status;

        }
    }
}

