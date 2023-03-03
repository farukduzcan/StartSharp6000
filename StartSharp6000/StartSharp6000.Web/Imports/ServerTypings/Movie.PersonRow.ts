namespace StartSharp6000.Movie {
    export interface PersonRow {
        PersonId?: number;
        FirstName?: string;
        Lastname?: string;
        BirthDate?: string;
        BirthPlace?: string;
        Height?: number;
        Fullname?: string;
        Gender?: Gender;
        PrimaryImage?: string;
        GalleryImages?: string;
    }

    export namespace PersonRow {
        export const idProperty = 'PersonId';
        export const nameProperty = 'Fullname';
        export const localTextPrefix = 'Movie.Person';
        export const lookupKey = 'Movie.Person';

        export function getLookup(): Q.Lookup<PersonRow> {
            return Q.getLookup<PersonRow>('Movie.Person');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            PersonId = "PersonId",
            FirstName = "FirstName",
            Lastname = "Lastname",
            BirthDate = "BirthDate",
            BirthPlace = "BirthPlace",
            Height = "Height",
            Fullname = "Fullname",
            Gender = "Gender",
            PrimaryImage = "PrimaryImage",
            GalleryImages = "GalleryImages"
        }
    }
}
