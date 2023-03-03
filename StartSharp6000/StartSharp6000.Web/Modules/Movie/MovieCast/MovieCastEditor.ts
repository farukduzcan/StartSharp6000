namespace StartSharp6000.Movie {
    @Serenity.Decorators.registerEditor("StartSharp6000.Movie.MovieCastEditor")
    export class MovieCastEditor extends Serenity.Extensions.GridEditorBase<MovieCastRow>{
        protected getColumnsKey() { return "Movie.MovieCast"; }
        protected getDialogType() { return MovieCastEditDialog; }
        protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
        protected getAddButtonCaption() {
            return "Add";
        }
        protected validateEntity(row: MovieCastRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;

            row.PersonFullname = PersonRow.getLookup()
                .itemById[row.PersonId].Fullname;

            return true;
        }

    }
}