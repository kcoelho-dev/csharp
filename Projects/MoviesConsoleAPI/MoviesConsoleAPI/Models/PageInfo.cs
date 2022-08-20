using Newtonsoft.Json;

namespace MoviesConsoleAPI.Models
{
    /// <summary> <c>PageInfo</c> A class to store basic informations of the reached page.
    /// e.g.: current page, total of results, total of pages containing results, total of pages
    /// and the data containing movies information
    /// </summary>
    public class PageInfo
    {
        /// <summary> <c>PageInfo(int page)</c> Constructor to initialize the an instance of the class at the first page</summary>
        public PageInfo(int page) { Page = page; }

        [JsonProperty("page")]
        /// <summary> <c>Page</c> Current page to reach the API results </summary>
        public int Page { get; set; }

        /// <summary> <c>Total</c> Total of results based on the search title </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
        
        /// <summary> <c>TotalPages</c> The total of pages than contains results </summary>
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        /// <summary> <c>Data</c> The data to be stored at MovieInfo class <summary>
        public IEnumerable<MovieInfo> Data { get; set; }
    }
}
