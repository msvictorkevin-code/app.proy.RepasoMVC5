﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_ASP.netMVC09.Models
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public bool EstaEnCartelera { get; set; }
        public string Genero { get; set; }
    }
}