namespace ClassDiagram
{
    internal class LoopTest
    {
        static void Main(string[] args)
        {
            string name = "Akanksha Dodamani";

            Console.WriteLine("Using FOR loop:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Using WHILE loop:");
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine(name);
                j++;
            }
        }
    }
}
