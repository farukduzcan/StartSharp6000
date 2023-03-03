
using Serenity.Services;
using System.Collections.Generic;

namespace StartSharp6000.Movie.Endpoints
{
    public class MovieListRequest : ListRequest
    {
        public List<int> Genres { get; set; }
    }
}