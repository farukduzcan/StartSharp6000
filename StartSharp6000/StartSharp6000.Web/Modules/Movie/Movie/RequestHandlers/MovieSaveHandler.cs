using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<StartSharp6000.Movie.MovieRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = StartSharp6000.Movie.MovieRow;

namespace StartSharp6000.Movie
{
    public interface IMovieSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieSaveHandler
    {
        public MovieSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}