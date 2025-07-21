namespace StudentFeesDiscount
{
    internal class Program
    {
        public static int[] CalculateDiscount(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 7000)
                {
                    array[i] = array[i] - (array[i] * 5 / 100);
                }
            }
            return array;
        }

        static void Main(string[] args)
        {
            int[] studentArry = new int[5];
            Console.WriteLine("Enter fees of 5 students: ");
            for (int i = 0; i < studentArry.Length; i++)
            {
                int fees = 0;
                Console.Write($"Enter fees for Student {i + 1}: ");
                fees = int.Parse(Console.ReadLine());
                if (fees >= 5000 && fees <= 10000)
                {
                    studentArry[i] = fees;
                }
                else
                {
                    Console.WriteLine("Error! fees must be in range 5000 to 10000");
                    i--;
                }
            }
            Console.WriteLine("\nFees with discount are as- ");
            Console.WriteLine(string.Join("\n", CalculateDiscount(studentArry)));
        }
    }
}
