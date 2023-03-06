using FluentMigrator;
using System;

namespace StartSharp6000.Migrations.DefaultDB //burası hangi veritabanına oluşturduğumuzu gösteriyor biz DefaultDB'ye oluşturuyoruz.
{
    [Migration(20221114_150500)] //migration sınıf niteliği ekledik
    public class DefaultDB_20221114_150500_MovieTable : AutoReversingMigration
    {
        public override void Up() //bu migration uygulandığında hangi kodların çalışması gerektiğini up()'ın altına yazıyoruz
        {
            Create.Schema("mov");//mov adlı yeni bir şema oluşturmasını sağlıyoruz (veritabanında oluşturuyoruz veritabanı seçimi yukarda)
                                
            Create.Table("Movie").InSchema("mov")
                .WithColumn("MovieId").AsInt32().Identity().PrimaryKey().NotNullable() //boş bırakılamaz birincil anahtar movieID sütunu oluşturuyor
                .WithColumn("Title").AsString(200).NotNullable()
                .WithColumn("Description").AsString(1000).Nullable()
                .WithColumn("Storyline").AsString(Int32.MaxValue).Nullable()
                .WithColumn("Year").AsInt32().Nullable()
                .WithColumn("ReleaseDate").AsDateTime().Nullable()
                .WithColumn("Runtime").AsInt32().Nullable();
        }
    }
}
