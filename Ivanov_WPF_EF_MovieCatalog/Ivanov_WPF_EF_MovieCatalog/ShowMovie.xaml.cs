using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ivanov_WPF_EF_MovieCatalog
{
    public partial class ShowMovie : Window
    {
        public ShowMovie(string poster, int id, string title, string year, string budget, string country, string description)
        {
            InitializeComponent();
            if (poster.Contains("."))
                movieImage.Source = new BitmapImage(new Uri(poster));
            idTB.Text = id.ToString();
            titleTB.Text = title;
            yearTB.Text = year;
            budgetTB.Text = budget;
            countryTB.Text = country;
            descriptionTB.Text = description;
        }
    }
}
