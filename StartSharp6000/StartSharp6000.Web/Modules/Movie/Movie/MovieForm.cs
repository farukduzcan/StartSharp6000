using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using StartSharp6000.Web.Modules.Movie.Movie;

namespace StartSharp6000.Movie.Forms
{
    [FormScript("Movie.Movie")]
    [BasedOnRow(typeof(MovieRow), CheckNames = true)]
    public class MovieForm
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Storyline { get; set; }
        public int Year { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Runtime { get; set; }
        [Width(200), GenreListFormatter, QuickFilter]
        public List<int> GenreList { get; set; }
        public MovieKind Kind { get; set; }
        public Status Status { get; set; }

    }
}