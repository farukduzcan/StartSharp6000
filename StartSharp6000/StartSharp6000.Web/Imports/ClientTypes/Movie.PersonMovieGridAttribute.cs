using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace StartSharp6000.Movie
{
    public partial class PersonMovieGridAttribute : CustomEditorAttribute
    {
        public const string Key = "StartSharp6000.Movie.PersonMovieGrid";

        public PersonMovieGridAttribute()
            : base(Key)
        {
        }
    }
}
