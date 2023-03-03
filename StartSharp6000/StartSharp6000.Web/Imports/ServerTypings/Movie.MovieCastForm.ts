namespace StartSharp6000.Movie {
    export interface MovieCastForm {
        MovieId: Serenity.IntegerEditor;
        PersonId: Serenity.LookupEditor;
        Character: Serenity.StringEditor;
    }

    export class MovieCastForm extends Serenity.PrefixedContext {
        static formKey = 'Movie.MovieCast';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MovieCastForm.init)  {
                MovieCastForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.LookupEditor;
                var w2 = s.StringEditor;

                Q.initFormType(MovieCastForm, [
                    'MovieId', w0,
                    'PersonId', w1,
                    'Character', w2
                ]);
            }
        }
    }
}
