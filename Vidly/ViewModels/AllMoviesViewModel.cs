using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class AllMoviesViewModel
    {
        public string Header { get; set; }
        public List<Movie> Movie { get; set; }
    }
}