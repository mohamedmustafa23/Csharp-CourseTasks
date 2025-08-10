using System.Text;
using System.Transactions;
using Microsoft.VisualBasic;

namespace ExaminationSystem
{

    internal class Program
    {
        static void Main(string[] args)
        {
            ExaminationManager manager = new ExaminationManager();
            
            while (true)
            {

                Console.WriteLine("=================================");
                Console.WriteLine("   Welcome to Examination System");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Doctor");
                Console.WriteLine("2. Student");
                Console.WriteLine("3. Create Doctor Account");
                Console.WriteLine("4. Create Student Account");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice From (1 to 5): ");



                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    if(manager.doctors.Count == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("You dont register yet");
                        Console.ResetColor();
                        continue;
                    }
                    if (manager.IsDoctorRegistered())
                    {
                        Console.WriteLine("===== Doctor Menu =====");
                        Console.WriteLine("1. Add Questions to Bank"); 
                        Console.WriteLine("2. Create a New Exam");   
                        Console.WriteLine("3. Logout");
                        Console.Write("Enter your choice: ");
                        string doctorChoice = Console.ReadLine();

                        if (doctorChoice == "1")
                        {
                            manager.AddQuestionToBank();
                        }
                        else if (doctorChoice == "2") 
                        {
                            manager.CreateNewExam();
                        }
                        else
                        {
                            continue;
                        }
                    }
                
                }
                else if (choice == "2")
                {
                    if (manager.students.Count == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("You dont register yet");
                        Console.ResetColor();
                        continue;
                    }
                    if (manager.IsStudentRegistered())
                    {
                        Console.WriteLine("===== Student Menu =====");
                        Console.WriteLine("1. Take Exam");
                        Console.WriteLine("3. Logout");
                        string studentChoice = Console.ReadLine();

                        if (studentChoice == "1")
                        {
                            Console.Write("Choose 1- FinalExam 2- practiceExam 3- Exit:");
                            int examType;
                            while(!int.TryParse(Console.ReadLine(), out examType))
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                                Console.Write("Enter Number Again: ");
                            }
                            if ( examType == 1)
                            {
                                Console.WriteLine("Available Final Exams:");

                                int count = 0;
                                for (int i = 0; i < manager.exams.Count; i++)
                                {
                                    if(manager.exams[i] is FinalExam)
                                    {
                                        Console.WriteLine($"{i + 1}. Subject: {manager.exams[i].SubjectName}, Questions: {manager.exams[i].questions.Count}, Exam Difficulty:{manager.exams[i].Level}");
                                        count++;
                                    }
                                }
                                if (count == 0)
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.Write("No final exams available at the moment.");
                                    Console.ResetColor ();
                                    continue;
                                }
                                Console.WriteLine("Enter Number of Exam you Want");
                                int examNumber;
                                while(!int.TryParse(Console.ReadLine(), out examNumber))
                                {
                                    Console.WriteLine("Invalid input. Please enter a valid number.");
                                    Console.Write("Enter Number Again: ");
                                }
                                manager.exams[examNumber - 1].DisplayExam();
                                Console.WriteLine(manager.exams[examNumber - 1].CalculateDegree());
                            }
                            else if (examType == 2)
                            {
                                Console.WriteLine("Available Final Exams:");

                                int count = 0;
                                for (int i = 0; i < manager.exams.Count; i++)
                                {
                                    if (manager.exams[i] is PracticalExam)
                                    {
                                        Console.WriteLine($"{i + 1}. Subject: {manager.exams[i].SubjectName}, Questions: {manager.exams[i].questions.Count}");
                                        count++;
                                    }
                                }
                                if (count == 0)
                                {

                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("No practical exams available at the moment.");
                                    Console.ResetColor();
                                    continue;

                                }
                                Console.WriteLine("Enter Number of Exam you Want");
                                int examNumber;
                                while (!int.TryParse(Console.ReadLine(), out examNumber))
                                {
                                    Console.WriteLine("Invalid input. Please enter a valid number.");
                                    Console.Write("Enter Number Again: ");
                                }
                                manager.exams[examNumber - 1].DisplayExam();
                                Console.WriteLine(manager.exams[examNumber - 1].CalculateDegree());

                            }
                            else if (examType == 3)
                            {
                                Environment.Exit(0);
                            }
                        }
                    }
                }
                else if (choice == "3")
                {
                    manager.AddDoctor();
                }
                else if (choice == "4")
                {
                    manager.AddStudent();
                }
                else if(choice == "5") 
                {
                    Environment.Exit(0);
                }

                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }

        }

        //manager.AddDoctor();
        //    manager.AddStudent();

        //    manager.AddExam();
        //    for (int i = 0; i < manager.exams.Count; i++)
        //    {
        //        manager.exams[i].DisplayExam(manager.exams[i]);
        //        Console.WriteLine(manager.exams[i].CalaulateDegree(manager.exams[i]));
            }
            #region
            //        List<Question> questions = new List<Question>();
            //        Console.WriteLine("Enter Total Number of Questions");
            //        int num = Convert.ToInt32(Console.ReadLine());
            //        for (int i = 1; i <= num; i++)
            //        {
            //            Console.WriteLine($"Choose Type Question{i}");
            //            Console.WriteLine("1- Multiple Choice  2- Choose One   3- True Or False");
            //            int type = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("1.enter Body of Question");
            //            string Body = Console.ReadLine();
            //            Console.WriteLine("2.enter Mark for this question");
            //            int Marks = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Enter Number of Correct Answer");
            //            int correctAnswer = Convert.ToInt32(Console.ReadLine());
            //            if (type > 3) break;
            //            if (type == 1)
            //            {
            //                MultipleChoice question = new MultipleChoice(Body, Marks, correctAnswer);

            //                Console.WriteLine("2.enter 4 Choices for this question");
            //                question.AnswerList.Add(new Answer(1, Console.ReadLine()));
            //                question.AnswerList.Add(new Answer(2, Console.ReadLine()));
            //                question.AnswerList.Add(new Answer(3, Console.ReadLine()));
            //                question.AnswerList.Add(new Answer(4, Console.ReadLine()));


            //                questions.Add(question);
            //            }
            //            else if (type == 2)
            //            {
            //                ChooseOne question = new ChooseOne(Body, Marks, correctAnswer);

            //                Console.WriteLine("3.enter 4 Choices for this question");
            //                question.AnswerList.Add(new Answer(1, Console.ReadLine()));
            //                question.AnswerList.Add(new Answer(2, Console.ReadLine()));
            //                question.AnswerList.Add(new Answer(3, Console.ReadLine()));
            //                question.AnswerList.Add(new Answer(4, Console.ReadLine()));

            //                questions.Add(question);
            //            }
            //            else if (type == 3)
            //            {
            //                TrueOrFalse question = new TrueOrFalse(Body, Marks, correctAnswer);

            //                questions.Add(question);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Please Enter Number Between 1 to 3");
            //            }

            //        }

            //        while (true)
            //        {
            //            Console.WriteLine("Choose 1- FinalExam 2- practiceExam :");
            //            int examnum = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Choose Type of Exam");
            //            Console.WriteLine("1- Multiple Choice  2- Choose One   3- True Or False");
            //            int examType = Convert.ToInt32(Console.ReadLine());

            //            if (examnum == 1)
            //            {
            //                Print(questions, examType);
            //            }

            //        }

            //    }
            //    public static void Print(List<Question> questions, int questionType)
            //    {
            //        Console.WriteLine("Enter number of Questions:");
            //        int number = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Enter Exam Time:");
            //        int time = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("enter subject name:");
            //        string subject = Console.ReadLine();
            //        FinalExam exam = new FinalExam(number, time, subject, questions,questionType);

            //        exam.DisplayExam(exam);
            //        exam.CalaulateDegree(exam);
            //    }
            //}
            #endregion
        }
//    }
    
//}
