﻿using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using Serenity.Demo.Northwind;

namespace StartSharp6000.Movie.Columns
{
    [ColumnsScript("Movie.Person")]
    [BasedOnRow(typeof(PersonRow), CheckNames = true)]
    public class PersonColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int PersonId { get; set; }
        [EditLink]
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public Gender Gender { get; set; }
        public int Height { get; set; }
    }
}