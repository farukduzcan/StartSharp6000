using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<StartSharp6000.Movie.GenreRow>;
using MyRow = StartSharp6000.Movie.GenreRow;

namespace StartSharp6000.Movie
{
    public interface IGenreRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class GenreRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IGenreRetrieveHandler
    {
        public GenreRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}