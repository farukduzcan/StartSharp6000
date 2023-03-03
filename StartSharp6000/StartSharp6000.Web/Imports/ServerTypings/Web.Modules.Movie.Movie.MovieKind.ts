namespace StartSharp6000.Web.Modules.Movie.Movie {
    export enum MovieKind {
        Film = 1,
        TvSeries = 2,
        MiniSeries = 3
    }
    Serenity.Decorators.registerEnumType(MovieKind, 'StartSharp6000.Web.Modules.Movie.Movie.MovieKind', 'MovieDB.MovieKind');
}
