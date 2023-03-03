namespace StartSharp6000.Movie {
    export interface MovieForm {
        Title: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        CastList: MovieCastEditor;
        Storyline: Serenity.StringEditor;
        Year: Serenity.IntegerEditor;
        ReleaseDate: Serenity.DateEditor;
        Runtime: Serenity.IntegerEditor;
        GenreList: Serenity.LookupEditor;
        Kind: Serenity.EnumEditor;
        Status: Serenity.EnumEditor;
    }

    export class MovieForm extends Serenity.PrefixedContext {
        static formKey = 'Movie.Movie';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MovieForm.init)  {
                MovieForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = MovieCastEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.DateEditor;
                var w4 = s.LookupEditor;
                var w5 = s.EnumEditor;

                Q.initFormType(MovieForm, [
                    'Title', w0,
                    'Description', w0,
                    'CastList', w1,
                    'Storyline', w0,
                    'Year', w2,
                    'ReleaseDate', w3,
                    'Runtime', w2,
                    'GenreList', w4,
                    'Kind', w5,
                    'Status', w5
                ]);
            }
        }
    }
}
