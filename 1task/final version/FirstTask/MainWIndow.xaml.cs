using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace FirstTask
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.choice.Items.Add("+");
            this.choice.Items.Add("-");
            this.choice.Items.Add("/");
            this.choice.Items.Add("*");
            this.choice.Items.Add("sin");
            this.choice.Items.Add("cos");
            this.choice.Items.Add("tan");
            this.choice.Items.Add("artan");
        }

        private void decision_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (choice.SelectedIndex)
                {
                    case 0:
                        double x = Convert.ToDouble(number1.Text);
                        double y = Convert.ToDouble(number2.Text);
                        answer.Content = x + y;

                        break;

                    case 1:
                        x = Convert.ToDouble(number1.Text);
                        y = Convert.ToDouble(number2.Text);
                        answer.Content = x - y;
                        dop.Content = "";
                        break;

                    case 2:
                        x = Convert.ToDouble(number1.Text);
                        y = Convert.ToDouble(number2.Text);
                        if (y == 0)
                        {
                            dop.Content = "На ноль делить нельзя";
                            dop.Foreground = Brushes.Red;
                        }


                        else
                        {
                            answer.Content = x / y;
                            dop.Content = "";
                        }
                        break;

                    case 3:
                        x = Convert.ToDouble(number1.Text);
                        y = Convert.ToDouble(number2.Text);
                        answer.Content = x * y;
                        dop.Content = "";
                        break;

                    case 4:
                        x = Convert.ToDouble(number1.Text);
                        answer.Content = Math.Round(Math.Sin(x));
                        dop.Content = "Число для подсчета вводиться в первое поле";
                        dop.Foreground = Brushes.Black;
                        break;

                    case 5:
                        x = Convert.ToDouble(number1.Text);
                        answer.Content = Math.Round(Math.Cos(x));
                        dop.Content = "Число для подсчета вводиться в первое поле";
                        dop.Foreground = Brushes.Black;
                        break;

                    case 6:
                        x = Convert.ToDouble(number1.Text);
                        answer.Content = Math.Round(Math.Tan(x));
                        dop.Content = "Число для подсчета вводиться в первое поле";
                        dop.Foreground = Brushes.Black;  
                        break;

                    case 7:
                        x = Convert.ToDouble(number1.Text);
                        answer.Content = Math.Round(1 / Math.Tan(x));
                        dop.Content = "Число для подсчета вводиться в первое поле";
                        dop.Foreground = Brushes.Black; 
                        break;
                }
            }

            catch
            {
                answer.Content = "Введите число для подсчета в первое полe";
            }


        }


        private void choice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void number2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
