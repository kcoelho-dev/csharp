using MoviesConsoleAPI.Models;
using Newtonsoft.Json;

namespace MoviesConsoleAPI.Controller
{
    /// <summary> Class <c>Reader</c> Reads the API URL and distributes the information
    /// to the corresponding classes (MovieInfo and PageInfo </summary>
    /// 
    public class Reader
    {
        /// <summary> <c>BaseURL</c> Is the Base URL to reach the API resquests </summary>
        public readonly static string BaseURL = "http://jsonmock.hackerrank.com/api/movies/search?";
        /// <summary> <c>pageInfo</c> An instance of PageInfo class to store some necessary informations to complete the request </summary>
        public static PageInfo pageInfo = new PageInfo(1);

        /// <summary> <c>RetrieveMovies</c> The function that calls the URL, converts to json pattern and distributes to
        /// the responsible classes
        /// </summary>
        /// <returns> <c>movieInfo</c> Returns the Task result of reading the API URL, creating a List of movies</returns>
        public async Task<List<MovieInfo>> RetrieveMovies()
        {
            var movieInfo = new List<MovieInfo>();
            
            Console.WriteLine("Type the movie Title to search: ");
            string movieTitle = Console.ReadLine();
            

            using (var httpClient = new HttpClient())
            {
                do
                {
                    //Get the response from API URL, checking if its OK to continue the procedures
                    HttpResponseMessage urlAnswear = await httpClient.GetAsync($"{BaseURL}Title={movieTitle}&page={pageInfo.Page}");
                    if (urlAnswear.IsSuccessStatusCode && movieTitle != "")
                    {
                        string json = await urlAnswear.Content.ReadAsStringAsync();

                        //Deserialize the JSON format content to each properties of the class PageInfo object pageRetrievedInfos
                        PageInfo pageRetrievedInfos = JsonConvert.DeserializeObject<PageInfo>(json);
                        pageInfo.TotalPages = pageRetrievedInfos.TotalPages;  //Input to class
                        pageInfo.Total = pageRetrievedInfos.Total;            //Input to class

                        //Check if the pageRetrievedInfos is not null and if its contains any elements
                        if (pageRetrievedInfos != null && pageRetrievedInfos.Data.Any())
                        {
                            //Adds the Data(from MovieInfo) pattern into movieInfo instance of class MovieInfo
                            movieInfo.AddRange(pageRetrievedInfos.Data);
                            pageInfo.Page++;
                        }
                        else
                        {
                            Console.WriteLine($"No movie found with title '{movieTitle}'");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Title: type at least one character!");
                        break;
                    }
                }
                while (pageInfo.Page <= pageInfo.TotalPages);
            }
            return movieInfo;
        }
    }
}
