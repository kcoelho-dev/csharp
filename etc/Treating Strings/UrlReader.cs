namespace TreatingStrings
{
    public class UrlReader
    {
        public string URL { get; set; }
        public int UrlSize { get; set; }

        public string?  From { get; set; }
        public string?  To { get; set; }

        public bool acessibility { get; set; }


		public UrlReader(string url)
		{
			if(string.IsNullOrEmpty(url))
			{
				throw new ArgumentException("The url argument can not be null or void.", nameof(url));
			}
			URL = url;
		}
        public string GetNextValue()
        {
			return " ";
		}



    }	//End of class UrlReader
}   //End of namespace TreatingStrings