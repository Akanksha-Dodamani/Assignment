namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Sachin, Aurionpro, Mumbai";

            string[] parts = input.Split(',');

            if (parts.Length == 3)
            {
                Console.WriteLine("Name: " + parts[0]);
                Console.WriteLine("Company: " + parts[1]);
                Console.WriteLine("Location: " + parts[2]);
            }
            else
            {
                Console.WriteLine("Invalid input string format.");
            }
        }
    }
}
