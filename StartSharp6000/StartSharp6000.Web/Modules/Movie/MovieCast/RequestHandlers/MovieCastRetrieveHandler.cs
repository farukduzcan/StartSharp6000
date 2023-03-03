using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<StartSharp6000.Movie.MovieCastRow>;
using MyRow = StartSharp6000.Movie.MovieCastRow;

namespace StartSharp6000.Movie
{
    public interface IMovieCastRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieCastRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieCastRetrieveHandler
    {
        public MovieCastRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}