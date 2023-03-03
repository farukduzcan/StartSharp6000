using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<StartSharp6000.Movie.PersonRow>;
using MyRow = StartSharp6000.Movie.PersonRow;

namespace StartSharp6000.Movie
{
    public interface IPersonRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class PersonRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPersonRetrieveHandler
    {
        public PersonRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}