namespace InOutParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IN OUT DEMO
            int a = 20;
            int result;
            AddTen(in a, out result);
            Console.WriteLine($"Original value (in): {a}");
            Console.WriteLine($"Result after adding 10 (out): {result}");

            // TRY PARSE
            Console.Write("Enter a number: ");
            bool success = int.TryParse(Console.ReadLine(), out int number);
            if (success)
            {
                Console.WriteLine("Integer is: " + number);
                return;
            }
            Console.WriteLine("It is not an integer");

            // PARAMS
            PrintNames("John", "Ron", "Hermoine");
            PrintNames("Abc", "xyz");
        }
        static void AddTen(in int a, out int result)
        {
            result = a + 10;
        }
        static void PrintNames(params string[] names)
        {
            if (names.Length == 0)
            {
                Console.WriteLine("No names are passed");
            }
            Console.WriteLine($"Names:");
            foreach (string name in names)
            {
                Console.Write($"{name}\t");
            }
        }
    }
}
