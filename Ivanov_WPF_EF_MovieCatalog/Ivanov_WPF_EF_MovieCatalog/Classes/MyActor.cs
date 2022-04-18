using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivanov_WPF_EF_MovieCatalog
{
    class MyActor
    {
        public string Photo { get; set; }
        public int a_ID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Birthdate { get; set; }
        public string a_Country { get; set; }

        public MyActor() { }

        public MyActor(string p, int id, string n, string a, string b, string c)
        {
            this.Photo = p;
            this.a_ID = id;
            this.Name = n;
            this.Age = a;
            this.Birthdate = b;
            this.a_Country = c;
        }
    }
}
