using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day21ManyToMany.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }

        public ICollection<MovieActor> MovieActors { get; set; }

    }
}
