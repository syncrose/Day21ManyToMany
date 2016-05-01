using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Day21ManyToMany.Models
{
    public class SampleData
    {
        public static void Initialize(IServiceProvider sp)
        {
            var db = sp.GetService<ApplicationDbContext>();

            if (!db.Movies.Any())
            {
                db.Movies.AddRange(
                    new Movie { Title = "Star Wars" },
                    new Movie { Title = "Blade Runner" }
                    );
                db.SaveChanges();


                db.Actors.AddRange(
                    new Actor { First = "Harrison", Last = "Ford" },
                    new Actor { First = "Carrie", Last = "Fisher" }
                    );
                db.SaveChanges();

                ////////////////////////////////////////


                db.MovieActors.AddRange(
                    new MovieActor
                    {
                       1;
                       1;
                    },
                    new MovieActor
                    {
                        MovieId = 1;
                        ActorId = 2;
                    },

                    new MovieActor
                    {
                        MovieId = 2;
                        ActorId = 1;
                    }



                );
                db.SaveChanges();
            }
        }

    }
}
