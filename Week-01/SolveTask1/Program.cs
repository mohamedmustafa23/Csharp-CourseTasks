namespace SolveTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallCarpetPrice = 25;
            int largeCarpetPrice = 35;
            float taxRate = 0.06f;
            
            Console.Write("Enter the number of small carpets: ");
            int smallCarpetCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of large carpets: ");
            int largeCarpetCount = Convert.ToInt32(Console.ReadLine());

            int cost =  smallCarpetPrice * smallCarpetCount + largeCarpetPrice * largeCarpetCount ;
            float tax = taxRate * cost;
            // concatenation
            Console.WriteLine("Price per small room: $" + smallCarpetPrice);

            // interpolation
            Console.WriteLine($"Price per large room: ${largeCarpetPrice}");

            Console.WriteLine($"Cost : ${cost}");
            Console.WriteLine($"Tax: ${tax}");
            
            Console.WriteLine("==========================");

            // Output the total cost including tax
            Console.WriteLine($"Total estimate: {cost + tax:C1}");
            Console.WriteLine("This estimate is valid for 30 days.");

        }
    }
}
