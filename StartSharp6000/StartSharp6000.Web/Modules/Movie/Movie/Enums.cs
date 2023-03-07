using Serenity.ComponentModel;
using System.ComponentModel;

namespace StartSharp6000.Web.Modules.Movie.Movie
{
    [EnumKey("MovieDB.MovieKind")] //kind alanı için seçenekleri burada tanımlıyoruz bunlar statik değerler buradan eklenir veya değiştirilir konsolda bir değişim yapılamaz
    public enum MovieKind
    {
        [Description("Film")]
        Film = 1,
        [Description("TV Series")]
        TvSeries = 2,
        [Description("Mini Series")]
        MiniSeries = 3
    }

    [EnumKey("MovieDB.Status")]
    public enum Status
    {
        [Description("Aktif")]
        Active = 1,
        [Description("Passive")]
        Passive = 2,
        [Description("Deleted")]
        Deleted = 3
    }
}
