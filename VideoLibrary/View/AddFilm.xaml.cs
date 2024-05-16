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
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)//save
        {
           // Film film = new Film(Convert.ToInt32(ID), Name.Text, Convert.ToDateTime(Issue), Director.Text, Actors.Text, Convert.ToInt32(Urate), Genre.Text, Convert.ToInt32(Coast), Convert.ToInt32(ALim), Convert.ToInt32(Purchaseld), TName.Text);
            MessageBox.Show("Успешно!");
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
