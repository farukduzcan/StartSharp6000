using Serenity.Navigation;
using MyPages = StartSharp6000.Movie.Pages;
[assembly: NavigationMenu(2000, "Movie", icon: "fa-film")]
[assembly: NavigationLink(int.MaxValue, "Movie/Movie", typeof(MyPages.MovieController), icon: "fa-solid fa-film")]
[assembly: NavigationLink(int.MaxValue, "Movie/Genre", typeof(MyPages.GenreController), icon: "fa fa-ticket")]
[assembly: NavigationLink(int.MaxValue, "Movie/Movie Genres", typeof(MyPages.MovieGenresController), icon: "fa fa-database")]
[assembly: NavigationLink(int.MaxValue, "Movie/Person", typeof(MyPages.PersonController), icon: "fa-users")]