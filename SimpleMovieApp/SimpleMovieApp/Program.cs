namespace SimpleMovieApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            MovieManager movieManager = new MovieManager();
            movieManager.LoadMovies();
            do
            {
                Console.WriteLine("Choose operation: ");
                Console.WriteLine("1. Add movie");
                Console.WriteLine("2. Display movie");
                Console.WriteLine("3. Clear all");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        movieManager.AddMovie();
                        break;
                    case 2:
                        movieManager.GetMovies();
                        break;
                    case 3:
                        movieManager.ClearAll();
                        break;
                    case 4:
                        Console.WriteLine("Thank you!! Exiting");
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
            } while (choice != 4);
        }
    }
}
