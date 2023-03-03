using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<StartSharp6000.Movie.MovieCastRow>;
using MyRow = StartSharp6000.Movie.MovieCastRow;

namespace StartSharp6000.Movie
{
    public interface IMovieCastListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieCastListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMovieCastListHandler
    {
        public MovieCastListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}