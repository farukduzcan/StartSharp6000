﻿using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using Serenity.Demo.Northwind;

namespace StartSharp6000.Movie.Forms
{
    [FormScript("Movie.Person")]
    [BasedOnRow(typeof(PersonRow), CheckNames = true)]
    public class PersonForm
    {
        [Tab("Person")]
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public Gender Gender { get; set; }
        public int Height { get; set; }
        [Tab("Movies"), IgnoreName, PersonMovieGrid, LabelWidth("0")]
        public string MoviesGrid { get; set; }
    }
}