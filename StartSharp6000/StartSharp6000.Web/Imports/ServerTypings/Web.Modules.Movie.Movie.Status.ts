namespace StartSharp6000.Web.Modules.Movie.Movie {
    export enum Status {
        Active = 1,
        Passive = 2,
        Deleted = 3
    }
    Serenity.Decorators.registerEnumType(Status, 'StartSharp6000.Web.Modules.Movie.Movie.Status', 'MovieDB.Status');
}
