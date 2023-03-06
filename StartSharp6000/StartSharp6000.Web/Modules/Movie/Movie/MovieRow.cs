using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using StartSharp6000.Web.Modules.Movie.Movie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace StartSharp6000.Movie
{
    //Movie "Row" kısmında yaptığımız değişiklikler sunucu tarafı olan Movie columuns ve kullanıcı tarafı olan movie form'da otomatik değişir.
    [ConnectionKey("Default"), Module("Movie"), TableName("[mov].[Movie]")]
    [DisplayName("Movies"), InstanceName("Movie")] //Display name ile sayfamızın başında görülen "movie" yazısını "Movies" olarak düzelttik
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MovieRow : Row<MovieRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Movie Id"), Identity, IdProperty] //Display Name kolonda ve formda gözüken isim
        public int? MovieId
        {
            get => fields.MovieId[this];
            set => fields.MovieId[this] = value;
        }

        [DisplayName("Title"), Size(200), NotNull, QuickSearch, NameProperty] //Quick Search üst tarafta arama yapıldığında aradığı kısımdır yani Title kolonunda arama yapacak buna göre
        public string Title
        {
            get => fields.Title[this];
            set => fields.Title[this] = value;
        }

        [DisplayName("Description"), Size(1000)]
        public string Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        [DisplayName("Storyline")]
        public string Storyline
        {
            get => fields.Storyline[this];
            set => fields.Storyline[this] = value;
        }

        [DisplayName("Year")]
        public int? Year
        {
            get => fields.Year[this];
            set => fields.Year[this] = value;
        }

        [DisplayName("Release Date")]
        public DateTime? ReleaseDate
        {
            get => fields.ReleaseDate[this];
            set => fields.ReleaseDate[this] = value;
        }

        [DisplayName("Runtime")]
        public int? Runtime
        {
            get => fields.Runtime[this];
            set => fields.Runtime[this] = value;
        }
        [DisplayName("Kind")]
        public MovieKind? Kind
        {
            get => fields.Kind[this];
            set => fields.Kind[this] = value;
        }
        [DisplayName("Genres")]
        [LookupEditor(typeof(GenreRow), Multiple = true), NotMapped]
        [LinkingSetRelation(typeof(MovieGenresRow), "MovieId", "GenreId")]
        public List<int> GenreList
        {
            get => fields.GenreList[this];
            set => fields.GenreList[this] = value;
        }
        [DisplayName("Status")]
        public MovieKind? Status
        {
            get => fields.Kind[this];
            set => fields.Kind[this] = value;
        }
        [MasterDetailRelation(foreignKey: "MovieId", IncludeColumns = "PersonFullname")]
        [DisplayName("Cast List"), NotMapped]
        public List<MovieCastRow> CastList
        {
            get => fields.CastList[this];
            set => fields.CastList[this] = value;
        }
        [DisplayName("Primary Image"), Size(100),
         ImageUploadEditor(FilenameFormat = "Movie/PrimaryImage/~")]
        public string PrimaryImage
        {
            get => fields.PrimaryImage[this];
            set => fields.PrimaryImage[this] = value;
        }

        [DisplayName("Gallery Images"),
         MultipleImageUploadEditor(FilenameFormat = "Movie/GalleryImages/~")]
        public string GalleryImages
        {
            get => fields.GalleryImages[this];
            set => fields.GalleryImages[this] = value;
        }

        public MovieRow()
            : base()
        {
        }

        public MovieRow(RowFields fields)
            : base(fields)
        {
        }


        public class RowFields : RowFieldsBase
        {
            public Int32Field MovieId;
            public StringField Title;
            public StringField Description;
            public StringField Storyline;
            public Int32Field Year;
            public DateTimeField ReleaseDate;
            public Int32Field Runtime;
            public EnumField<MovieKind> Kind;
            public EnumField<Status> Status;
            public ListField<Int32> GenreList;
            public RowListField<MovieCastRow> CastList;
            public StringField PrimaryImage;
            public StringField GalleryImages;

        }
    }
}
