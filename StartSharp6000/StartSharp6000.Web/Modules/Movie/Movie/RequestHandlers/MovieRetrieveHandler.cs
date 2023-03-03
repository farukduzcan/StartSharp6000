using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<StartSharp6000.Movie.MovieRow>;
using MyRow = StartSharp6000.Movie.MovieRow;

namespace StartSharp6000.Movie
{
    public interface IMovieRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieRetrieveHandler
    {
        public MovieRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}