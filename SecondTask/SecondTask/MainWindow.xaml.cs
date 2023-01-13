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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SecondTask
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            //Задание 1
            //int age = 222;
            //double km = 12.2;
            //float b = -1045;
            //bool working = true;
            //var hello = "hello";
            //char e = 'e';
            //string str = "str";
            //decimal money = 250;
            //long d = 0b104;




            //Задание 3
            int photo = 52;
            int photoinrow = 3;
            int fullrow = photo / photoinrow;
            full.Content = fullrow;
            int overflow = photo % photoinrow;
            over.Content = overflow;
        }
        //Задание 4
        double gold = 0;
        int cristal = 0;
        private void Buy_Click(object sender, RoutedEventArgs e)
        {
            
            int cristal = 0;
            double gold = Convert.ToInt32(goldtext.Text);
            if (gold > 100)
            {
                gold -= 109;
                cristal += 10;
                cristalquantity.Content = $"Кол-во кристалов : {cristal}";
                cristalquantity.Foreground = Brushes.Black;
                goldtext.Text = $"{gold}";
            }
            else
            {
                goldtext.Foreground = Brushes.Red;
                goldtext.Text = "недостаточно денег для покупки";
            }
        }
        //Задание 5
        private void TIME_Click(object sender, RoutedEventArgs e)
        {
            int people = Convert.ToInt32(peoplee.Text);
            try
            {
                L.Content = $" вы должны отстоять в очереди {people * 10 / 60} часов и {people * 10 % 60} мин";
            }
            catch
            {

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            L.Content = (_1.Text,_2.Text,_3.Text,_4.Text);
        }
    }  
}
