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
    public partial class ShowActor : Window
    {
        public ShowActor(string photo, int id, string name, string age, string birthdate, string country)
        {
            InitializeComponent();
            if (photo.Contains("."))
                actorImage.Source = new BitmapImage(new Uri(photo));
            idTB.Text = id.ToString();
            nameTB.Text = name;
            ageTB.Text = age;
            birthdateTB.Text = birthdate;
            countryTB.Text = country;
        }
    }
}
