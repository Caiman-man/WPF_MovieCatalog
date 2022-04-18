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
    public delegate void InsertMovieDelegate(string poster, string title, string year, string budget, string country, string description);

    public partial class InsertMovie : Window
    {
        public event InsertMovieDelegate PerformInsertMovie;
        string imagePath = System.AppDomain.CurrentDomain.BaseDirectory;

        public InsertMovie()
        {
            InitializeComponent();
            movieImage.Tag = $@"Images\Movies\default.png";
        }

        //insert
        private void insertB_Click(object sender, RoutedEventArgs e)
        {
            if (titleTB.Text == " Title" || yearTB.Text == " Year" || budgetTB.Text == " Budget" || countryTB.Text == " Country" || descriptionTB.Text == " Description")
                MessageBox.Show("All fields are required!");
            else
            {
                PerformInsertMovie?.Invoke((string)movieImage.Tag, titleTB.Text, yearTB.Text, budgetTB.Text, countryTB.Text, descriptionTB.Text);
                this.Close();
            }
        }

        //clear
        private void clearB_Click(object sender, RoutedEventArgs e)
        {
            movieImage.Source = new BitmapImage(new Uri($@"{imagePath}Images\Movies\default.png"));
            movieImage.Tag = $@"Images\Movies\default.png";
            titleTB.Text = " Title";
            yearTB.Text = " Year";
            budgetTB.Text = " Budget";
            countryTB.Text = " Country";
            descriptionTB.Text = " Description";
        }

        //cancel
        private void cancelB_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
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

        //при нажатии в пустом месте формы, проверить поля на заполнение
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CheckFieldsEmpty();
        }

        //при нажатии на любой textbox проверить остальные на заполнение и очистить его, если в нем стандартный текст
        private void titleTB_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            CheckFieldsEmpty();
            if (titleTB.Text == " Title")
                titleTB.Text = "";
        }

        private void yearTB_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            CheckFieldsEmpty();
            if (yearTB.Text == " Year")
                yearTB.Text = "";
        }

        private void budgetTB_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            CheckFieldsEmpty();
            if (budgetTB.Text == " Budget")
                budgetTB.Text = "";
        }

        private void countryTB_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            CheckFieldsEmpty();
            if (countryTB.Text == " Country")
                countryTB.Text = "";
        }

        private void descriptionTB_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            CheckFieldsEmpty();
            if (descriptionTB.Text == " Description")
                descriptionTB.Text = "";
        }

        //если поля пустые, то заполнить их стандартными названиями
        private void CheckFieldsEmpty()
        {
            if (titleTB.Text == "")
                titleTB.Text = " Title";
            if (yearTB.Text == "")
                yearTB.Text = " Year";
            if (budgetTB.Text == "")
                budgetTB.Text = " Budget";
            if (countryTB.Text == "")
                countryTB.Text = " Country";
            if (descriptionTB.Text == "")
                descriptionTB.Text = " Description";
        } 
    }
}