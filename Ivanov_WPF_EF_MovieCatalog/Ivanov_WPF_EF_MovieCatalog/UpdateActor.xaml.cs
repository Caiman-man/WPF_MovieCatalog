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
    public delegate void UpdateActorDelegate(string photo, string name, string age, string birthdate, string country);

    public partial class UpdateActor : Window
    {
        public event UpdateActorDelegate PerformUpdateActor;
        string imagePath = System.AppDomain.CurrentDomain.BaseDirectory;
        string defaultPhoto, defaultName, defaultAge, defaultBirthdate, defaultCountry;

        public UpdateActor(string photo, string name, string age, string birthdate, string country)
        {
            InitializeComponent();

            if (photo.Contains("."))
            {
                defaultPhoto = photo;
                actorImage.Source = new BitmapImage(new Uri(photo));
                actorImage.Tag = $@"Images\Actors\{System.IO.Path.GetFileName(photo)}";
            }
            defaultName = nameTB.Text = name;
            defaultAge = ageTB.Text = age;
            defaultBirthdate = birthdateTB.Text = birthdate;
            defaultCountry = countryTB.Text = country;
        }

        //update
        private void updateB_Click(object sender, RoutedEventArgs e)
        {
            if (nameTB.Text == "" || ageTB.Text == "" || birthdateTB.Text == "" || countryTB.Text == "")
                MessageBox.Show("All fields are required!");
            else
            {
                PerformUpdateActor?.Invoke((string)actorImage.Tag, nameTB.Text, ageTB.Text, birthdateTB.Text, countryTB.Text);
                this.Close();
            }
        }

        //установка картинки
        private void actorImage_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.InitialDirectory = $@"{imagePath}Images\Actors\";
            dlg.FilterIndex = 2;
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png";
            bool? result = dlg.ShowDialog();
            if (result == true)
            {
                actorImage.Tag = $@"Images\Actors\{dlg.SafeFileName}";
                actorImage.Source = new BitmapImage(new Uri($@"{imagePath}Images\Actors\{dlg.SafeFileName}"));
            }
        }

        //default
        private void defaultB_Click(object sender, RoutedEventArgs e)
        {
            actorImage.Source = new BitmapImage(new Uri(defaultPhoto));
            actorImage.Tag = $@"Images\Actors\{System.IO.Path.GetFileName(defaultPhoto)}";
            nameTB.Text = defaultName;
            ageTB.Text = defaultAge;
            birthdateTB.Text = defaultBirthdate;
            countryTB.Text = defaultCountry;
        }

        //cancel
        private void cancelB_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}