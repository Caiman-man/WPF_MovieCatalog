using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivanov_WPF_EF_MovieCatalog
{
    class GeneralClass
    {
        public string Photo { get; set; }
        public int a_ID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Birthdate { get; set; }
        public string a_Country { get; set; }

        public string Poster { get; set; }
        public int m_ID { get; set; }
        public string Title { get; set; }
        public string m_Year { get; set; }
        public string Budget { get; set; }
        public string m_Country { get; set; }
        public string Description { get; set; }

        public GeneralClass()
        {
            MyActor actor = new MyActor();
            MyMovie movie = new MyMovie();
        }
    }
}
