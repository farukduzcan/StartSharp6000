﻿using Serenity;
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
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int MovieCastId { get; set; }
        public String MovieTitle { get; set; }
        public String PersonFirstName { get; set; }
        [EditLink]
        public string Character { get; set; }
    }
}