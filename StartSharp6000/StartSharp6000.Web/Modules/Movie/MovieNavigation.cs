using Serenity.Navigation;
using MyPages = StartSharp6000.Movie.Pages;
//navigationmenu özelliği navigasyon barına menü oluşturur sonraki "" içi ise ismini belirler
[assembly: NavigationMenu(2000, "Movie", icon: "fa-film")] //2000 değeri aslında bir sıralama bildirir 1 olursa ana navigasyonda en üstte yer alır 
[assembly: NavigationLink(int.MaxValue, "Movie/Movie", typeof(MyPages.MovieController), icon: "fa-solid fa-film")]//movie menüsü içine movie sekmesi oluşturur
[assembly: NavigationLink(int.MaxValue, "Movie/Genre", typeof(MyPages.GenreController), icon: "fa fa-ticket")]//movie menüsü içine genre isimli bir sekme oluşturur
[assembly: NavigationLink(int.MaxValue, "Movie/Movie Genres", typeof(MyPages.MovieGenresController), icon: "fa fa-database")]
[assembly: NavigationLink(int.MaxValue, "Movie/Person", typeof(MyPages.PersonController), icon: "fa-users")]