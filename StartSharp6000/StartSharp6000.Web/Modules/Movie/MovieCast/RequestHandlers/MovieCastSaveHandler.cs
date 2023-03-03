using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<StartSharp6000.Movie.MovieCastRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = StartSharp6000.Movie.MovieCastRow;

namespace StartSharp6000.Movie
{
    public interface IMovieCastSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieCastSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieCastSaveHandler
    {
        public MovieCastSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}