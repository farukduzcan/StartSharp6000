namespace StartSharp6000.Movie
{ 
     @Serenity.Decorators.registerEditor("StartSharp6000.Movie.MovieCastEditor")
    export class MovieCastEditor extends GridEditorBase<MovieCastRow>{
     protected getColumnsKey() { return "MovieDB.MovieCast"; }
    protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }

    constructor(container: JQuery)
    {
        super(container);
    }

} }

