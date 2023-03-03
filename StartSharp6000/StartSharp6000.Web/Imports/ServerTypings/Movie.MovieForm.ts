namespace StartSharp6000.Movie {
    export interface MovieForm {
        Title: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        CastList: MovieCastEditor;
        PrimaryImage: Serenity.ImageUploadEditor;
        GalleryImages: Serenity.MultipleImageUploadEditor;
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
                var w2 = s.ImageUploadEditor;
                var w3 = s.MultipleImageUploadEditor;
                var w4 = s.IntegerEditor;
                var w5 = s.DateEditor;
                var w6 = s.LookupEditor;
                var w7 = s.EnumEditor;

                Q.initFormType(MovieForm, [
                    'Title', w0,
                    'Description', w0,
                    'CastList', w1,
                    'PrimaryImage', w2,
                    'GalleryImages', w3,
                    'Storyline', w0,
                    'Year', w4,
                    'ReleaseDate', w5,
                    'Runtime', w4,
                    'GenreList', w6,
                    'Kind', w7,
                    'Status', w7
                ]);
            }
        }
    }
}
