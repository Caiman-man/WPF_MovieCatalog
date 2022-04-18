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
    public delegate void UpdateMovieDelegate(string poster, string title, string year, string budget, string country, string description);

    public partial class UpdateMovie : Window
    {
        public event UpdateMovieDelegate PerformUpdateMovie;
        string imagePath = System.AppDomain.CurrentDomain.BaseDirectory;
        string defaultPoster, defaultTitle, defaultYear, defaultBudget, defaultCountry, defaultDescr;

        public UpdateMovie(string poster, string title, string year, string budget, string country, string description)
        {
            InitializeComponent();
            if (poster.Contains("."))
            {
                defaultPoster = poster;
                movieImage.Source = new BitmapImage(new Uri(poster));
                movieImage.Tag = $@"Images\Movies\{System.IO.Path.GetFileName(poster)}";
            }
            defaultTitle = titleTB.Text = title;
            defaultYear = yearTB.Text = year;
            defaultBudget = budgetTB.Text = budget;
            defaultCountry = countryTB.Text = country;
            defaultDescr = descriptionTB.Text = description;
        }

        //update
        private void updateB_Click(object sender, RoutedEventArgs e)
        {
            if (titleTB.Text == "" || yearTB.Text == "" || budgetTB.Text == "" || countryTB.Text == "" || descriptionTB.Text == "")
                MessageBox.Show("All fields are required!");
            else
            {
                PerformUpdateMovie?.Invoke((string)movieImage.Tag, titleTB.Text, yearTB.Text, budgetTB.Text, countryTB.Text, descriptionTB.Text);
                this.Close();
            }
        }

        //установка картинки
        private void movieImage_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.InitialDirectory = $@"{imagePath}Images\Movies\";
            dlg.FilterIndex = 2;
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png";
            bool? result = dlg.ShowDialog();
            if (result == true)
            {
                movieImage.Tag = $@"Images\Movies\{dlg.SafeFileName}";
                movieImage.Source = new BitmapImage(new Uri($@"{imagePath}Images\Movies\{dlg.SafeFileName}"));
            }
        }

        //default
        private void defaultB_Click(object sender, RoutedEventArgs e)
        {
            movieImage.Source = new BitmapImage(new Uri(defaultPoster));
            movieImage.Tag = $@"Images\Movies\{System.IO.Path.GetFileName(defaultPoster)}";
            titleTB.Text = defaultTitle;
            yearTB.Text = defaultYear;
            budgetTB.Text = defaultBudget;
            countryTB.Text = defaultCountry;
            descriptionTB.Text = defaultDescr;
        }

        //cancel
        private void cancelB_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}