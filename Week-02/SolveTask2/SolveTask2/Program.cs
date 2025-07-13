namespace SolveTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            while (true)
            {
                DisplayMainMenu();
                string choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "p":
                        if (numbers.Count == 0)
                        {
                            OutPut("[] - the list is empty");
                            break;
                        }
                        else
                            PrintList(numbers);
                        break;

                    case "o":
                        //دي حاله بتقدر تضيف فيها ليست بعدد العناصر اللي انت عايزه وكمان مش بتكرر الارقام لو دخلت رقم مكرر 
                        Console.Write("Enter the number of elements you want to add: ");
                        string lengthInput = Console.ReadLine();
                        int length;

                        while (!int.TryParse(lengthInput, out length) || length <= 0)
                        {
                            OutPut("Invalid input. Please enter a valid positive number.");
                            Console.Write("Enter the number of elements you want to add: ");
                            lengthInput = Console.ReadLine();
                        }

                        string listnumber = "";
                        int inputs = 0;
                        for (int i = 0; i < length; i++)
                        {
                            listnumber = Console.ReadLine();
                            if (int.TryParse(listnumber, out inputs))
                            {
                                if (numbers.Contains(inputs))
                                {
                                    OutPut($"{inputs} Alredy added");
                                    length++;
                                    continue;
                                }
                                numbers.Add(inputs);
                            }
                            else
                            {
                                OutPut("Enter only Numbers");
                                length++;
                                continue;
                            }
                        }
                        PrintList(numbers);
                        break;

                    case "a":
                        int newNumber = 0;
                        Console.Write("Enter a number to add: ==> ");
                        //هنا استخدمت TryParse علشان لو اليوزر دخل حاجه غير الارقام
                        string input = Console.ReadLine();
                        if (int.TryParse(input, out newNumber))
                        {
                            // Bouns don't allow duplicate entries
                            if (numbers.Contains(newNumber))
                            {
                                OutPut($"{newNumber} Alredy added");
                                break;
                            }
                            numbers.Add(newNumber);
                            OutPut($"{newNumber} Added");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Unknown Number, please try again");
                        }
                        break;


                    case "m":
                        int mean = 0;
                        int sum = 0;
                        if (numbers.Count == 0)
                        {
                            OutPut("[] - the list is empty");
                            break;
                        }
                        for (int j = 0; j < numbers.Count; j++)
                        {
                            sum += numbers[j];
                        }
                        mean = sum / numbers.Count;
                        OutPut($"Mean : {mean}");
                        break;

                    case "s":
                        if (numbers.Count == 0)
                        {
                            OutPut("[] - the list is empty");
                            break;
                        }
                        int smallestNumber = numbers[0];
                        for (int j = 0; j < numbers.Count; j++)
                        {
                            if (smallestNumber > numbers[j])
                            {
                                smallestNumber = numbers[j];
                            }
                        }
                        OutPut($"The samllest number is : {smallestNumber}");
                        break;

                    case "l":
                        if (numbers.Count == 0)
                        {
                            OutPut("[] - the list is empty");
                            break;
                        }
                        int largestNumber = numbers[0];
                        for (int j = 0; j < numbers.Count; j++)
                        {
                            if (largestNumber < numbers[j])
                            {
                                largestNumber = numbers[j];
                            }
                        }
                        OutPut($"The largest number is : {largestNumber}");
                        break;

                    case "f":
                        if (numbers.Count == 0)
                        {
                            OutPut("[] - the list is empty");
                            break;
                        }
                        Console.Write("Enter the number :");
                        int num = Convert.ToInt32(Console.ReadLine());
                        if (numbers.Contains(num))
                        {
                            OutPut($"{num} Found at index {numbers.IndexOf(num)}");
                        }
                        else
                            OutPut($"{num} not found");
                        break;

                    case "c":
                        numbers.Clear();
                        OutPut("List clear successed");
                        break;

                    case "so":
                        if (numbers.Count == 0)
                        {
                            OutPut("[] - the list is empty");
                            break;
                        }
                        // هنا انا محتاج اعرف List جديده علشان متاثرش علي الList الاصليه 
                        List<int> sortedList = AscendingSort(new List<int>(numbers));
                        PrintList(sortedList);
                        break;


                    case "q":
                        OutPut("Goodbye");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Unknown selection, please try again");
                        break;
                }
            }
            static void DisplayMainMenu()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                           ╔═════ Main Menu ══════════════════╗");
                Console.WriteLine("                           ║                                  ║");
                Console.WriteLine("                           ║  P - Print numbers               ║");
                Console.WriteLine("                           ║  A - Add a number                ║");
                Console.WriteLine("                           ║  O - Add List of numbers         ║");
                Console.WriteLine("                           ║ SO - Display Ascending sort      ║");
                Console.WriteLine("                           ║  M - Display mean of the numbers ║");
                Console.WriteLine("                           ║  S - Display the smallest number ║");
                Console.WriteLine("                           ║  L - Display the largest number  ║");
                Console.WriteLine("                           ║  F - Find a number               ║");
                Console.WriteLine("                           ║  C - Clear the whole list        ║");
                Console.WriteLine("                           ║  Q - Quit                        ║");
                Console.WriteLine("                           ╚══════════════════════════════════╝");
                Console.Write("==>");
            }
            static void OutPut(string message)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                           ╔═════ Out Put ════════════════════╗");
                Console.WriteLine("                           ║                                  ║");
                Console.WriteLine($"                                 {message}                             ");
                Console.WriteLine("                           ║                                  ║");
                Console.WriteLine("                           ╚══════════════════════════════════╝");
            }
            static List<int> AscendingSort(List<int> list)
            {
                int num = 0;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    for (int j = 0; j < list.Count - 1 - i; j++)
                    {
                        if (list[j] > list[j + 1])
                        {
                            num = list[j];
                            list[j] = list[j + 1];
                            list[j + 1] = num;
                        }
                    }
                }
                return list;
            }
            static void PrintList(List<int> list)
            {
                string message = "";
                for (int j = 0; j < list.Count; j++)
                {
                    message += list[j] + " ";
                }
                OutPut($"{{ {message}}}");
            }
        }
    }
}
