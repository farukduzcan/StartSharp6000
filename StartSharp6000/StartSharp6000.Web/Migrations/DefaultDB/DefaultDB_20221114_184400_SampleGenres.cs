using FluentMigrator;

namespace StartSharp6000.Migrations.DefaultDB
{
    public class DefaultDB_20221114_184400_SampleGenres
    {
        [Migration(20221114_184400)]
        public class DefaultDB20221114184400SampleGenres : AutoReversingMigration
        {
            public override void Up()
            {
                Insert.IntoTable("Genre").InSchema("mov")
                    .Row(new
                    {
                        Name = "Action"
                    })
                    .Row(new
                    {
                        Name = "Drama"
                    })
                    .Row(new
                    {
                        Name = "Comedy"
                    })
                    .Row(new
                    {
                        Name = "Sci-fi"
                    })
                    .Row(new
                    {
                        Name = "Fantasy"
                    })
                    .Row(new
                    {
                        Name = "Documentary"
                    });
            }
        }
    }
}
