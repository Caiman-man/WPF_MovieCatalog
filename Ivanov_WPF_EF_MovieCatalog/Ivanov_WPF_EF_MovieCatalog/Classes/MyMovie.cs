using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivanov_WPF_EF_MovieCatalog
{
    class MyMovie
    {
        public string Poster { get; set; }
        public int m_ID { get; set; }
        public string Title { get; set; }
        public string m_Year { get; set; }
        public string Budget { get; set; }
        public string m_Country { get; set; }
        public string Description { get; set; }

        public MyMovie() { }

        public MyMovie(string p, int id, string t, string y, string b, string c, string d)
        {
            this.Poster = p;
            this.m_ID = id;
            this.Title = t;
            this.m_Year = y;
            this.Budget = b;
            this.m_Country = c;
            this.Description = d;
        }
    }
}
