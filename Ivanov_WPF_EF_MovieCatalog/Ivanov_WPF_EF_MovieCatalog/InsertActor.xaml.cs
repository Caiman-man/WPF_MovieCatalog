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
    public delegate void InsertActorDelegate(string photo, string name, string age, string birthdate, string country);

    public partial class InsertActor : Window
    {
        public event InsertActorDelegate PerformInsertActor;
        string imagePath = System.AppDomain.CurrentDomain.BaseDirectory;

        public InsertActor()
        {
            InitializeComponent();
            actorImage.Tag = $@"Images\Actors\default.png";
        }

        //insert
        private void insertB_Click(object sender, RoutedEventArgs e)
        {
            if (nameTB.Text == " Name" || ageTB.Text == " Age" || birthdateTB.Text == " Birthdate" || countryTB.Text == " Country")
                MessageBox.Show("All fields are required!");
            else
            {
                PerformInsertActor?.Invoke((string)actorImage.Tag, nameTB.Text, ageTB.Text, birthdateTB.Text, countryTB.Text);
                this.Close();
            }
        }

        //clear
        private void clearB_Click(object sender, RoutedEventArgs e)
        {
            actorImage.Source = new BitmapImage(new Uri($@"{imagePath}Images\Actors\default.png"));
            actorImage.Tag = $@"Images\Actors\default.png";
            nameTB.Text = " Name";
            ageTB.Text = " Age";
            birthdateTB.Text = " Birthdate";
            countryTB.Text = " Country";
        }

        //cancel
        private void cancelB_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
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

        //при нажатии в пустом месте формы, проверить поля на заполнение
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CheckFieldsEmpty();
        }

        //при нажатии на любой textbox проверить остальные на заполнение и очистить его, если в нем стандартный текст
        private void nameTB_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CheckFieldsEmpty();
            if (nameTB.Text == " Name")
                nameTB.Text = "";
        }

        private void ageTB_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CheckFieldsEmpty();
            if (ageTB.Text == " Age")
                ageTB.Text = "";
        }

        private void birthdateTB_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CheckFieldsEmpty();
            if (birthdateTB.Text == " Birthdate")
                birthdateTB.Text = "";
        }

        private void countryTB_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CheckFieldsEmpty();
            if (countryTB.Text == " Country")
                countryTB.Text = "";
        }

        //если поля пустые, то заполнить их стандартными названиями
        private void CheckFieldsEmpty()
        {
            if (nameTB.Text == "")
                nameTB.Text = " Name";
            if (ageTB.Text == "")
                ageTB.Text = " Age";
            if (birthdateTB.Text == "")
                birthdateTB.Text = " Birthdate";
            if (countryTB.Text == "")
                countryTB.Text = " Country";
        }    
    }
}
