using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ivanov_WPF_EF_MovieCatalog
{
    public partial class MainWindow : Window
    {
        //режимы активных таблиц
        enum TableMode { Default, Actors, Movies }
        TableMode currentMode = TableMode.Actors;

        //получить полный путь к папке с картинками
        string currentPath = System.AppDomain.CurrentDomain.BaseDirectory;

        Ivanov_MovieCatalogEntities context = new Ivanov_MovieCatalogEntities();

        public MainWindow()
        {
            InitializeComponent();
            //showAllButton_Click((Button)showAllButton, new RoutedEventArgs());                       
        }

        //navicon
        private void Navicon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var np = navig_panel;
            var tp = top_panel;
            var dg = data_panel;

            if (np.Width == 200)
            {
                np.Width = 60;
                tp.Margin = new Thickness(60, 0, 0, 0);
                dg.Margin = new Thickness(60, 40, 0, 0);
            }
            else if (np.Width == 60)
            {
                np.Width = 200;
                tp.Margin = new Thickness(200, 0, 0, 0);
                dg.Margin = new Thickness(200, 40, 0, 0);
            }
        }

        //exit
        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //actors
        private void actorsB_Click(object sender, RoutedEventArgs e)
        {
            //показываем колонки актеров
            dataGrid.Columns[0].Visibility = Visibility.Visible;
            dataGrid.Columns[1].Visibility = Visibility.Visible;
            dataGrid.Columns[2].Visibility = Visibility.Visible;
            dataGrid.Columns[3].Visibility = Visibility.Visible;
            dataGrid.Columns[4].Visibility = Visibility.Visible;
            dataGrid.Columns[5].Visibility = Visibility.Visible;

            //скрываем колонки фильмов
            dataGrid.Columns[6].Visibility = Visibility.Hidden;
            dataGrid.Columns[7].Visibility = Visibility.Hidden;
            dataGrid.Columns[8].Visibility = Visibility.Hidden;
            dataGrid.Columns[9].Visibility = Visibility.Hidden;
            dataGrid.Columns[10].Visibility = Visibility.Hidden;
            dataGrid.Columns[11].Visibility = Visibility.Hidden;
            dataGrid.Columns[12].Visibility = Visibility.Hidden;

            var result = from a in context.Actors
                         select new MyActor
                         {
                             Photo = currentPath + a.photo,
                             a_ID = a.actor_id,
                             Name = a.name,
                             Age = a.age,
                             Birthdate = a.birthdate.ToString(),
                             a_Country = a.a_country
                         };

            ObservableCollection<MyActor> observableCollection = new ObservableCollection<MyActor>(result);
            CollectionViewSource collection = new CollectionViewSource() { Source = observableCollection };

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = collection.View;           
            currentMode = TableMode.Actors;
        }

        //movies
        private void moviesB_Click(object sender, RoutedEventArgs e)
        {
            //скрываем колонки актеров
            dataGrid.Columns[0].Visibility = Visibility.Hidden;
            dataGrid.Columns[1].Visibility = Visibility.Hidden;
            dataGrid.Columns[2].Visibility = Visibility.Hidden;
            dataGrid.Columns[3].Visibility = Visibility.Hidden;
            dataGrid.Columns[4].Visibility = Visibility.Hidden;
            dataGrid.Columns[5].Visibility = Visibility.Hidden;

            //показываем колонки фильмов
            dataGrid.Columns[6].Visibility = Visibility.Visible;
            dataGrid.Columns[7].Visibility = Visibility.Visible;
            dataGrid.Columns[8].Visibility = Visibility.Visible;
            dataGrid.Columns[9].Visibility = Visibility.Visible;
            dataGrid.Columns[10].Visibility = Visibility.Visible;
            dataGrid.Columns[11].Visibility = Visibility.Visible;
            dataGrid.Columns[12].Visibility = Visibility.Visible;

            var result = from m in context.Movies
                         select new MyMovie
                         {
                             Poster = currentPath + m.poster,
                             m_ID = m.movie_id,
                             Title = m.title,
                             m_Year = m.m_year,
                             Budget = m.budget.ToString(),
                             m_Country = m.m_country,
                             Description = m.description
                         };

            ObservableCollection<MyMovie> observableCollection = new ObservableCollection<MyMovie>(result);
            CollectionViewSource collection = new CollectionViewSource() { Source = observableCollection };

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = collection.View;
            currentMode = TableMode.Movies;          
        }

        //show all actors and their movies
        private void showAllButton_Click(object sender, RoutedEventArgs e)
        {
            //показываем все колонки
            foreach (var col in dataGrid.Columns)
                col.Visibility = Visibility.Visible;

            var result = from m in context.Movies
                         join am in context.ActorMovie on m.movie_id equals am.movie_id
                         join a in context.Actors on am.actor_id equals a.actor_id
                         select new GeneralClass
                         {
                             Photo = currentPath + a.photo,
                             a_ID = a.actor_id,
                             Name = a.name,
                             Age = a.age,
                             Birthdate = a.birthdate.ToString(),
                             a_Country = a.a_country,
                             Poster = currentPath + m.poster,
                             m_ID = m.movie_id,
                             Title = m.title,
                             m_Year = m.m_year,
                             Budget = m.budget.ToString(),
                             m_Country = m.m_country,
                             Description = m.description
                         };

            ObservableCollection<GeneralClass> observableCollection = new ObservableCollection<GeneralClass>(result);
            CollectionViewSource collection = new CollectionViewSource() { Source = observableCollection };

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = collection.View;

            //включить стандартный режим
            currentMode = TableMode.Default;

            //заполнить combobox'ы
            var names = context.Actors.Select(a => a.name).Distinct();
            actorFilterCB.ItemsSource = names.ToList();
            var titles = context.Movies.Select(m => m.title).Distinct();
            movieFilterCB.ItemsSource = titles.ToList();
        }

        //actor filter
        private void actorFilterB_Click(object sender, RoutedEventArgs e)
        {
            //показываем все колонки
            foreach (var col in dataGrid.Columns)
                col.Visibility = Visibility.Visible;

            var result = (from m in context.Movies
                          join am in context.ActorMovie on m.movie_id equals am.movie_id
                          join a in context.Actors on am.actor_id equals a.actor_id
                          select new GeneralClass
                          {
                              Photo = currentPath + a.photo,
                              a_ID = a.actor_id,
                              Name = a.name,
                              Age = a.age,
                              Birthdate = a.birthdate.ToString(),
                              a_Country = a.a_country,
                              Poster = currentPath + m.poster,
                              m_ID = m.movie_id,
                              Title = m.title,
                              m_Year = m.m_year,
                              Budget = m.budget.ToString(),
                              m_Country = m.m_country,
                              Description = m.description
                          }).Where(n => n.Name == actorFilterCB.Text);

            ObservableCollection<GeneralClass> observableCollection = new ObservableCollection<GeneralClass>(result);
            CollectionViewSource collection = new CollectionViewSource() { Source = observableCollection };

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = collection.View;
            currentMode = TableMode.Actors;
        }

        //movie filter
        private void movieFilterB_Click(object sender, RoutedEventArgs e)
        {
            //показываем все колонки
            foreach (var col in dataGrid.Columns)
                col.Visibility = Visibility.Visible;

            var result = (from m in context.Movies
                          join am in context.ActorMovie on m.movie_id equals am.movie_id
                          join a in context.Actors on am.actor_id equals a.actor_id
                          select new GeneralClass
                          {
                              Photo = currentPath + a.photo,
                              a_ID = a.actor_id,
                              Name = a.name,
                              Age = a.age,
                              Birthdate = a.birthdate.ToString(),
                              a_Country = a.a_country,
                              Poster = currentPath + m.poster,
                              m_ID = m.movie_id,
                              Title = m.title,
                              m_Year = m.m_year,
                              Budget = m.budget.ToString(),
                              m_Country = m.m_country,
                              Description = m.description
                          }).Where(n => n.Title == movieFilterCB.Text);

            ObservableCollection<GeneralClass> observableCollection = new ObservableCollection<GeneralClass>(result);
            CollectionViewSource collection = new CollectionViewSource() { Source = observableCollection };

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = collection.View;
            currentMode = TableMode.Movies;
        }

        //insert
        private void insertButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentMode == TableMode.Actors)
            {
                InsertActor actor = new InsertActor();
                actor.Owner = this;
                actor.PerformInsertActor += InsertActorEvent;
                actor.ShowDialog();
            }
            else if (currentMode == TableMode.Movies)
            {
                InsertMovie movie = new InsertMovie();
                movie.Owner = this;
                movie.PerformInsertMovie += InsertMovieEvent;
                movie.ShowDialog();
            }
            else
                MessageBox.Show("Choose table to insert!");
        }

        //event for insert actor
        private void InsertActorEvent(string _photo, string _name, string _age, string _birthdate, string _country)
        {
            Actors a = new Actors
            {
                photo = _photo,
                name = _name,
                age = _age,
                birthdate = Convert.ToDateTime(_birthdate),
                a_country = _country,
            };

            context.Actors.Add(a);
            context.SaveChanges();
            actorsB_Click(this, null);
        }

        //event for insert movie
        private void InsertMovieEvent(string _poster, string _title, string _year, string _budget, string _country, string _description)
        {
            Movies m = new Movies
            {
                poster = _poster,
                title = _title,
                m_year = _year,
                budget = Convert.ToDecimal(_budget),
                m_country = _country,
                description = _description
            };

            context.Movies.Add(m);
            context.SaveChanges();
            moviesB_Click(this, null);
        }

        //show
        private void showButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentMode == TableMode.Actors)
            {
                MyActor selectedRow = dataGrid.SelectedItem as MyActor;
                string selectedPhoto = selectedRow.Photo;
                int selectedId = selectedRow.a_ID;
                string selectedName = selectedRow.Name;
                string selectedAge = selectedRow.Age;
                string selectedBirthdate = selectedRow.Birthdate;
                string selectedCountry = selectedRow.a_Country;

                string p = selectedPhoto;
                int i = selectedId;
                string n = "";
                if (selectedName != null) 
                    n = selectedName;
                string a = "";
                if (selectedAge != null) 
                    a = selectedAge;
                string b = "";
                if (selectedBirthdate != null)
                    b = selectedBirthdate;
                string c = "";
                if (selectedCountry != null)
                    c = selectedCountry;

                ShowActor actor = new ShowActor(p, i, n, a, b, c);
                actor.Owner = this;
                actor.ShowDialog();
            }
            else if (currentMode == TableMode.Movies)
            {
                MyMovie selectedRow = dataGrid.SelectedItem as MyMovie;
                string selectedPoster = selectedRow.Poster;
                int selectedId = selectedRow.m_ID;
                string selectedTitle = selectedRow.Title;
                string selectedYear = selectedRow.m_Year;
                string selectedBudget = selectedRow.Budget;
                string selectedCountry = selectedRow.m_Country;
                string selectedDescription = selectedRow.Description;

                string p = selectedPoster;
                int i = selectedId;
                string t = "";
                if (selectedTitle != null)
                    t = selectedTitle;
                string y = "";
                if (selectedYear != null)
                    y = selectedYear;
                string b = "";
                if (selectedBudget != null)
                    b = selectedBudget;
                string c = "";
                if (selectedCountry != null)
                    c = selectedCountry;
                string d = "";
                if (selectedDescription != null)
                    d = selectedDescription;

                ShowMovie movie = new ShowMovie(p, i, t, y, b, c, d);
                movie.Owner = this;
                movie.ShowDialog();
            }
            else
                MessageBox.Show("Choose table to show");
        }

        //edit
        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentMode == TableMode.Actors)
            {
                MyActor selectedRow = dataGrid.SelectedItem as MyActor;
                string selectedPhoto = selectedRow.Photo;
                int selectedId = selectedRow.a_ID;
                string selectedName = selectedRow.Name;
                string selectedAge = selectedRow.Age;
                string selectedBirthdate = selectedRow.Birthdate;
                string selectedCountry = selectedRow.a_Country;

                string p = selectedPhoto;
                int i = selectedId;
                string n = "";
                if (selectedName != null)
                    n = selectedName;
                string a = "";
                if (selectedAge != null)
                    a = selectedAge;
                string b = "";
                if (selectedBirthdate != null)
                    b = selectedBirthdate;
                string c = "";
                if (selectedCountry != null)
                    c = selectedCountry;

                UpdateActor actor = new UpdateActor(p, n, a, b, c);
                actor.Owner = this;
                actor.PerformUpdateActor += UpdateActorEvent;
                actor.ShowDialog();
            }
            else if (currentMode == TableMode.Movies)
            {
                MyMovie selectedRow = dataGrid.SelectedItem as MyMovie;
                string selectedPoster = selectedRow.Poster;
                int selectedId = selectedRow.m_ID;
                string selectedTitle = selectedRow.Title;
                string selectedYear = selectedRow.m_Year;
                string selectedBudget = selectedRow.Budget;
                string selectedCountry = selectedRow.m_Country;
                string selectedDescription = selectedRow.Description;

                string p = selectedPoster;
                int i = selectedId;
                string t = "";
                if (selectedTitle != null)
                    t = selectedTitle;
                string y = "";
                if (selectedYear != null)
                    y = selectedYear;
                string b = "";
                if (selectedBudget != null)
                    b = selectedBudget;
                string c = "";
                if (selectedCountry != null)
                    c = selectedCountry;
                string d = "";
                if (selectedDescription != null)
                    d = selectedDescription;

                UpdateMovie movie = new UpdateMovie(p, t, y, b, c, d);
                movie.Owner = this;
                movie.PerformUpdateMovie += UpdateMovieEvent;
                movie.ShowDialog();
            }
            else
                MessageBox.Show("Choose table to update!");
        }

        //event for edit actor
        private void UpdateActorEvent(string _photo, string _name, string _age, string _birthdate, string _country)
        {
            MyActor selectedRow = dataGrid.SelectedItem as MyActor;
            int id = selectedRow.a_ID;

            Actors ac = context.Actors.First(a => a.actor_id == id);
            ac.photo = _photo;
            ac.name = _name;
            ac.age = _age;
            ac.birthdate = Convert.ToDateTime(_birthdate);
            ac.a_country = _country;

            context.SaveChanges();
            actorsB_Click(this, null);
        }

        //event for edit movie
        private void UpdateMovieEvent(string _poster, string _title, string _year, string _budget, string _country, string _description)
        {
            MyMovie selectedRow = dataGrid.SelectedItem as MyMovie;
            int id = selectedRow.m_ID;

            Movies mv = context.Movies.First(m => m.movie_id == id);
            mv.poster = _poster;
            mv.title = _title;
            mv.m_year = _year;
            if(!_budget.Contains("."))
            {
                mv.budget = Convert.ToDecimal(_budget);
            }
            else if (_budget.EndsWith(".00"))
            {
                _budget = _budget.Remove(_budget.Length - 3, 3);
                mv.budget = Convert.ToDecimal(_budget);
            }
            mv.m_country = _country;
            mv.description = _description;

            context.SaveChanges();
            moviesB_Click(this, null);
        }

        //delete
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentMode == TableMode.Actors)
            {
                MessageBoxResult dialog = new MessageBoxResult();
                dialog = MessageBox.Show($"Are you sure you want to delete actor?", "Deleting", MessageBoxButton.YesNo);
                if (dialog == MessageBoxResult.Yes)
                {
                    MyActor selectedRow = dataGrid.SelectedItem as MyActor;
                    int selectedId = selectedRow.a_ID;

                    Actors ac = (from a in context.Actors
                                  where a.actor_id == selectedId
                                  select a).First();

                    context.Actors.Remove(ac);
                    context.SaveChanges();
                    actorsB_Click(this, null);
                }
            }
            else if (currentMode == TableMode.Movies)
            {
                MessageBoxResult dialog = new MessageBoxResult();
                dialog = MessageBox.Show($"Are you sure you want to delete movie?", "Deleting", MessageBoxButton.YesNo);
                if (dialog == MessageBoxResult.Yes)
                {
                    MyMovie selectedRow = dataGrid.SelectedItem as MyMovie;
                    int selectedId = selectedRow.m_ID;

                    Movies mv = (from m in context.Movies
                                 where m.movie_id == selectedId
                                 select m).First();

                    context.Movies.Remove(mv);
                    context.SaveChanges();
                    moviesB_Click(this, null);
                }
            }
            else
                MessageBox.Show("Choose table to delete");
        }
    }
}
