namespace CmdLineArgs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[args.Length];

            for (int i = 0; i < args.Length; i++)
            {
                numbers[i] = int.Parse(args[i]);
            }

            int sum = 0, count = 0, max = numbers[0], min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                sum += number;
                count++;

                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }
            double average = (double)sum / count;

            Console.WriteLine("Numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("\n\nSum: " + sum);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Count: " + count);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);

        }
    }
}
