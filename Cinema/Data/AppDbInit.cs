using Cinema.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cinema.Data
{
    public class AppDbInit
    {
        public static void Insert(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinemaa>()
                    {
                        new Cinemaa()
                        {
                            Nom = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinemaa()
                        {
                            Nom = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinemaa()
                        {
                            Nom = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinemaa()
                        {
                            Nom = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinemaa()
                        {
                            Nom = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Acteurs
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Acteur>()
                    {
                        new Acteur()
                        {
                            NomComplet = "Acteur 1",
                            Bio = "This is the Bio of the first Acteur",
                            ProfilImageUrl = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Acteur()
                        {
                            NomComplet = "Acteur 2",
                            Bio = "This is the Bio of the second Acteur",
                            ProfilImageUrl = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Acteur()
                        {
                            NomComplet = "Acteur 3",
                            Bio = "This is the Bio of the second Acteur",
                            ProfilImageUrl = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Acteur()
                        {
                            NomComplet = "Acteur 4",
                            Bio = "This is the Bio of the second Acteur",
                            ProfilImageUrl = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Acteur()
                        {
                            NomComplet = "Acteur 5",
                            Bio = "This is the Bio of the second Acteur",
                            ProfilImageUrl = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producteur>()
                    {
                        new Producteur()
                        {
                            NomComplet = "Producer 1",
                            Bio = "This is the Bio of the first Acteur",
                            ProfilImageUrl = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producteur()
                        {
                            NomComplet = "Producer 2",
                            Bio = "This is the Bio of the second Acteur",
                            ProfilImageUrl = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producteur()
                        {
                            NomComplet = "Producer 3",
                            Bio = "This is the Bio of the second Acteur",
                            ProfilImageUrl = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producteur()
                        {
                            NomComplet = "Producer 4",
                            Bio = "This is the Bio of the second Acteur",
                            ProfilImageUrl = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producteur()
                        {
                            NomComplet = "Producer 5",
                            Bio = "This is the Bio of the second Acteur",
                            ProfilImageUrl = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Film>()
                    {
                        new Film()
                        {
                            Nom = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            DateDebut = DateTime.Now.AddDays(-10),
                            Datefin = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducteurId = 3,
                            CategorieFilm = CategorieFilm.Documentaire
                        },
                        new Film()
                        {
                            Nom = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            DateDebut = DateTime.Now,
                            Datefin = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducteurId = 1,
                            CategorieFilm = CategorieFilm.Action
                        },
                        new Film()
                        {
                            Nom = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            DateDebut = DateTime.Now,
                            Datefin = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducteurId = 4,
                            CategorieFilm = CategorieFilm.Horror
                        },
                        new Film()
                        {
                            Nom = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            DateDebut = DateTime.Now.AddDays(-10),
                            Datefin = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducteurId = 2,
                            CategorieFilm = CategorieFilm.Documentaire
                        },
                        new Film()
                        {
                            Nom = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            DateDebut = DateTime.Now.AddDays(-10),
                            Datefin = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducteurId = 3,
                            CategorieFilm = CategorieFilm.Cartoon
                        },
                        new Film()
                        {
                            Nom = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            DateDebut = DateTime.Now.AddDays(3),
                            Datefin = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducteurId = 5,
                            CategorieFilm = CategorieFilm.Drama
                        }
                    });
                    context.SaveChanges();
                }

                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Acteur_Film>()
                    {

                         new Acteur_Film()
                        {
                            ActeurId = 4,
                            FilmId = 2
                        },

                        new Acteur_Film()
                        {
                            ActeurId = 2,
                            FilmId = 3
                        },
                        new Acteur_Film()
                        {
                            ActeurId = 5,
                            FilmId = 3
                        },


                        new Acteur_Film()
                        {
                            ActeurId = 2,
                            FilmId = 4
                        },
                        new Acteur_Film()
                        {
                            ActeurId = 3,
                            FilmId = 4
                        },
                        new Acteur_Film()
                        {
                            ActeurId = 4,
                            FilmId = 4
                        },


                        new Acteur_Film()
                        {
                            ActeurId = 2,
                            FilmId = 5
                        },
                        new Acteur_Film()
                        {
                            ActeurId = 3,
                            FilmId = 5
                        },
                        new Acteur_Film()
                        {
                            ActeurId = 4,
                            FilmId = 5
                        },
                        new Acteur_Film()
                        {
                            ActeurId = 5,
                            FilmId = 5
                        },


                        new Acteur_Film()
                        {
                            ActeurId = 3,
                            FilmId = 6
                        },
                        new Acteur_Film()
                        {
                            ActeurId = 4,
                            FilmId = 6
                        },
                        new Acteur_Film()
                        {
                            ActeurId = 5,
                            FilmId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }

}