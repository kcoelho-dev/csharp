using MoviesConsoleAPI.Models;
using MoviesConsoleAPI.Controller;


namespace MovieRetrieve
{
    public class Program
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader(); ///<summary> <c>reader</c> An instance of the class Reader, that allows to retrieve informations from API </summary>
            List<int> years = new List<int>(); ///<summary> <c>years</c> A list of integers to store all years recorded </summary>
            List<int> uniqueYears = new List<int>(); ///<summary> <c>uniqueYears</c> A list of integers to get unique year values from the 'List<int> years' </summary>
            
            ///<summary> <c>movies</c> An IEnumerable<MovieInfo> instantiated as a list to store all movies information recovered
            /// as return of RetrieveMovies() function.
            /// </summary>
            IEnumerable<MovieInfo> movies = reader.RetrieveMovies().GetAwaiter().GetResult();
            
            // Orders the movies results by Year, ascending.
            movies = movies.OrderBy(obj => obj.Year).ToList();

            //Adds all years (even equals) from movies and store at 'years' list
            foreach (MovieInfo mv in movies)
            {
                years.Add(mv.Year);
            }
            //Get only distinct years to store to allow the count of each year
            uniqueYears = years.Distinct().ToList();


            Console.WriteLine("{\n  \"moviesByYear\":[\n");

            //Prints the result
            for(int i = 0; i < uniqueYears.Count(); i++)
            {
                Console.WriteLine("\t{\n\t\"year\":" + uniqueYears[i]+",\n\t\"movies\":" + years.Where(x => x.Equals(uniqueYears[i])).Count() + "\n\t},");
            }
            Console.WriteLine("],\n\"total\":" + years.Count + "\n}");

            Console.ReadKey();
        }
    }
}
