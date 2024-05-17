using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VideoLibrary.View;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Azure;
using VideoLibrary.Models;

namespace VideoLibrary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddFilm film = new();
            if (film.ShowDialog() == true)
            {
                using (МедиатекаContext db = new())
                {
                    Film film1 = new Film();
                    film1.Name = film.tbName.Text;
                    film1.Genre = film.tbGenre.Text;
                    film1.YearOfIssue = DateOnly.FromDateTime(Convert.ToDateTime(film.tbIssue.Text));
                    film1.Director = film.tbDirector.Text;
                    film1.MainActor = film.tbActors.Text;
                    film1.UserRate = Convert.ToDouble(film.tbUrate.Text);
                    film1.FilmCoast = Convert.ToDecimal(film.tbCoast.Text);
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //обновление
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //удаление какого то фильма
        }
    }
}