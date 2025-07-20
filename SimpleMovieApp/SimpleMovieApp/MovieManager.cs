using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMovieApp
{
    internal class MovieManager
    {
        public static string filePath = @"C:\Users\akanksha.dodamani\Downloads\Book.csv";
        public static Movie[] movies = new Movie[5];
        public static int count = 0;

        // DESERIALIZATION
        public void LoadMovies()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("No path found");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length == 0)
            {
                Console.WriteLine("Empty file");
                return;
            }
            foreach (string line in lines)
            {
                if (count > movies.Length)
                {
                    Console.WriteLine("Movie array is full!!");
                    return;
                }
                Movie movie = Movie.FromFile(line);
                movies[count++] = movie;
            }
            Console.WriteLine("Movies loaded successfully!!");
        }
        public void AddMovie()
        {
            if (count >= 5)
            {
                Console.WriteLine("Can not add more than 5 movies");
                return;
            }

            Console.Write("Enter Movie Id = ");
            string id = Console.ReadLine();

            Console.Write("Enter Name = ");
            string name = Console.ReadLine();

            Console.Write("Enter genre = ");
            string genre = Console.ReadLine();

            Console.Write("Enter Year = ");
            string year = Console.ReadLine();

            movies[count++] = new Movie(id, name, genre, year);
            Console.WriteLine("Movie has been added");
            SaveMovies();
            Console.WriteLine("Movie has been saved!");
        }
        // SERIALIZATION
        public void SaveMovies()
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                for (int i = 0; i < count; i++)
                {
                    sw.WriteLine(movies[i].ToString());
                }
            }
        }
        public void GetMovies()
        {
            {
                if (count == 0)
                {
                    Console.WriteLine("No movies found");
                    return;
                }

                Console.WriteLine("Movie List");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(movies[i]);
                }
            }
        }
        public void ClearAll()
        {
            count = 0;
            SaveMovies();
            Console.WriteLine("All movies are cleared");
        }
    }
}
