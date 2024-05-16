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
            AddFilm film = new AddFilm();
            film.Show();
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