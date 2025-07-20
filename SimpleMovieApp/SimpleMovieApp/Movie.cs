using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMovieApp
{
    internal class Movie
    {
        public string movieId;
        public string movieName, yearOfRelease, movieGenre;

        public Movie(string id, string name, string year, string genre)
        {
            movieId = id;
            movieName = name;
            yearOfRelease = year;
            movieGenre = genre;
        }
        public override string ToString()
        {
            return $"Id: {movieId}, Name: {movieName}, Year of Release: {yearOfRelease}, Genre: {movieGenre}";
        }

        public static Movie FromFile(string data)
        {
            string[] attributes = data.Split(',');
            return new Movie(attributes[0], attributes[1], attributes[2], attributes[3]);
        }
    }
}
