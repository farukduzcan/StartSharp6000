using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<StartSharp6000.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = StartSharp6000.Administration.LanguageRow;


namespace StartSharp6000.Administration
{
    public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
    public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
    {
        public LanguageSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}