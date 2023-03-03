using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<StartSharp6000.Movie.GenreRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = StartSharp6000.Movie.GenreRow;

namespace StartSharp6000.Movie
{
    public interface IGenreSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class GenreSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IGenreSaveHandler
    {
        public GenreSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}