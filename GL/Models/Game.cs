using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GL.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Distributor { get; set; }
        public int ReleaseYear { get; set; }
    }
}