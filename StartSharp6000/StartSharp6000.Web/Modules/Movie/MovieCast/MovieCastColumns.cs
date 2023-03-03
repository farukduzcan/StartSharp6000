using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace StartSharp6000.Movie.Columns
{
    [ColumnsScript("Movie.MovieCast")]
    [BasedOnRow(typeof(MovieCastRow), CheckNames = true)]
    public class MovieCastColumns
    {
        [EditLink, Width(220)]
        public string PersonFullname { get; set; }
        [EditLink, Width(150)]
        public string Character { get; set; }
    }
}