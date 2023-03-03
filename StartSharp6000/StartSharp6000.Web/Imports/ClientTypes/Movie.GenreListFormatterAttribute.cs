using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace StartSharp6000.Movie
{
    public partial class GenreListFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "StartSharp6000.Movie.GenreListFormatter";

        public GenreListFormatterAttribute()
            : base(Key)
        {
        }
    }
}
