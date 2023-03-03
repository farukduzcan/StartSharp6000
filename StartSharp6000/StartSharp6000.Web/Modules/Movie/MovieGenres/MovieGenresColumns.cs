using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace StartSharp6000.Movie.Columns
{
    [ColumnsScript("Movie.MovieGenres")]
    [BasedOnRow(typeof(MovieGenresRow), CheckNames = true)]
    public class MovieGenresColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int MovieGenreId { get; set; }
        public String MovieTitle { get; set; }
        public String GenreName { get; set; }
    }
}