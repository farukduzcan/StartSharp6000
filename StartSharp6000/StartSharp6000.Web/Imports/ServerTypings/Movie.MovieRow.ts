namespace StartSharp6000.Movie {
    export interface MovieRow {
        MovieId?: number;
        Title?: string;
        Description?: string;
        Storyline?: string;
        Year?: number;
        ReleaseDate?: string;
        Runtime?: number;
        Kind?: Web.Modules.Movie.Movie.MovieKind;
        Status?: Web.Modules.Movie.Movie.MovieKind;
        GenreList?: number[];
        CastList?: MovieCastRow[];
        PrimaryImage?: string;
        GalleryImages?: string;
        GenreId?: number;
        GenreName?: string;
    }

    export namespace MovieRow {
        export const idProperty = 'MovieId';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'Movie.Movie';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            MovieId = "MovieId",
            Title = "Title",
            Description = "Description",
            Storyline = "Storyline",
            Year = "Year",
            ReleaseDate = "ReleaseDate",
            Runtime = "Runtime",
            Kind = "Kind",
            Status = "Status",
            GenreList = "GenreList",
            CastList = "CastList",
            PrimaryImage = "PrimaryImage",
            GalleryImages = "GalleryImages",
            GenreId = "GenreId",
            GenreName = "GenreName"
        }
    }
}
