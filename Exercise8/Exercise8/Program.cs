namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem 1

            Console.Write("Enter a number (0-100): ");
            int n = int.Parse(Console.ReadLine());

            // Create the for loop
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }

            // Problem 2

            Console.Write("Enter a row width: ");

        }
    }
}