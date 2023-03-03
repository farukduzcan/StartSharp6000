using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using Serenity.Demo.Northwind;

namespace StartSharp6000.Movie.Columns
{
    [ColumnsScript("Movie.PersonMovie")]
    [BasedOnRow(typeof(MovieCastRow))]
    public class PersonMovieColumns
    {
        [Width(220)]
        public string MovieTitle { get; set; }
        [Width(100)]
        public int MovieYear { get; set; }
        [Width(200)]
        public string Character { get; set; }
    }
}