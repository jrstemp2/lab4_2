using System;
using System.Collections.Generic;

namespace lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string genre = GetInput("Please pick a genre: ");
                FindMovies(genre);
            } while (GoAgain());
            Console.WriteLine("Thank you for your interest!");
            
            
            static void FindMovies(string genre)
            {
                List<Movie> movies = new List<Movie>();
                movies.Add(new Movie("Cars 3", "animated"));
                movies.Add(new Movie("Star Wars", "scifi"));
                movies.Add(new Movie("Dracula", "horror"));
                movies.Add(new Movie("Star Trek II", "scifi"));
                movies.Add(new Movie("Pokemon the Movie", "animated"));
                movies.Add(new Movie("Field of Dreams", "drama"));
                movies.Add(new Movie("Birds", "horror"));
                movies.Add(new Movie("Toy Story", "animated"));
                movies.Add(new Movie("Iron Man", "scifi"));
                movies.Add(new Movie("Ready Player One", "scifi"));

                foreach (Movie m in movies)
                {
                    if (m.Category == genre)
                    {
                        Console.WriteLine(m);
                    }
                }
            }

            static bool GoAgain()
            {
                char c;
                do
                {
                    Console.Write("Would you like to search another genre or category? (y/n) ");
                    c = Console.ReadKey().KeyChar;

                    if (c == 'n')
                    {
                        return false;
                    }
                } while (c != 'y');

                return true;
            }

            static string GetInput(string prompt)
            {
                string input;

                do
                {
                    Console.Write(prompt);
                    input = Console.ReadLine();
                } while (input != "animated" && input != "drama" && input != "scifi" && input != "horror");
                return input;


                
                
            }

        }
    }
}
