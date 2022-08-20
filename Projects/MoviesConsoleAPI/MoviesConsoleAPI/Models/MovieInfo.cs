using Newtonsoft.Json;


namespace MoviesConsoleAPI.Models
{
    /// <summary> <c>MovieInfo</c> A Class that contains the most relevant information to solve the problem </summary>
    /// obs: As we don't need the Title and imdbID to reach the solution, these attributes are not used.
    public class MovieInfo
    {
        
        //public string? Title { get; set; }

        /// <summary> <c>Year</c> The year that the movie was released </summary>
        [JsonProperty("Year")]
        public int Year { get; set; }

        //public string imdbID { get; set; }

    }
}
