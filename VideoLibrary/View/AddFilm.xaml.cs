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
using System.Xml.Linq;
using VideoLibrary.Models;


namespace VideoLibrary.View
{
    /// <summary>
    /// Логика взаимодействия для AddFilm.xaml
    /// </summary>
    public partial class AddFilm : Window
    {

        public AddFilm()
        {
            InitializeComponent();
        }
        public AddFilm(Film film)
        {
            tbName.Text = film.Name;
            tbGenre.Text = film.Genre;
            tbIssue.Text = film.YearOfIssue.ToString();
            tbDirector.Text = film.Director;
            tbActors.Text = film.MainActor;
            tbUrate.Text = film.UserRate.ToString();
            tbCoast.Text = film.FilmCoast.ToString();
        }
        public string NamePrep
        {
            get { return tbName.Text; }
            set { tbName.Text = value; }
        }
        private void Button_Click(object sender, RoutedEventArgs e)//save
        {
            DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//update
        {
            //обновленеи фильмов
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)//delite
        {
            //удаление фильмов
        }
    }
}
