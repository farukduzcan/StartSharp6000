using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace StartSharp6000.Movie
{
    public partial class MovieCastEditDialogAttribute : CustomEditorAttribute
    {
        public const string Key = "StartSharp6000.Movie.MovieCastEditDialog";

        public MovieCastEditDialogAttribute()
            : base(Key)
        {
        }
    }
}
