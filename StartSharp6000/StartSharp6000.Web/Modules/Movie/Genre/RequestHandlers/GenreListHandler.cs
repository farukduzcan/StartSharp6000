using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<StartSharp6000.Movie.GenreRow>;
using MyRow = StartSharp6000.Movie.GenreRow;

namespace StartSharp6000.Movie
{
    public interface IGenreListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class GenreListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IGenreListHandler
    {
        public GenreListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}