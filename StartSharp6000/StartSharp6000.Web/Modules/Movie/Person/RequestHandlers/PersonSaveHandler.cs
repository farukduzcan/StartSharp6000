using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<StartSharp6000.Movie.PersonRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = StartSharp6000.Movie.PersonRow;

namespace StartSharp6000.Movie
{
    public interface IPersonSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class PersonSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPersonSaveHandler
    {
        public PersonSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}