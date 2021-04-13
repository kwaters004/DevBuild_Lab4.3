using System;
using System.Collections.Generic;
using System.Threading;
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
using Lab4._3;

namespace Interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //inputBox.Select(0,0);
            inputBox.Focus();
            //progressBar.Visibility = Visibility.Visible;



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //progressBar.Visibility = Visibility.Visible;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Thread.Sleep(500);
            //    progressBar.Value += 10;
            //}
            //progressBar.Visibility = Visibility.Hidden;


            if (Validator.CheckInt(inputBox.Text))
            {
                errorBox.Text = "";
                int num = Int32.Parse(inputBox.Text);
                outputBox.Text = $"The number {num} prime is {Prime.GetPrime(num)}";
                inputBox.Select(0, inputBox.Text.Length);
                inputBox.Focus();
                inputBox.ScrollToHome();
            }
            else
            {
                errorBox.Text = "Invalid Entry";
                outputBox.Text = "";
                inputBox.Select(0, inputBox.Text.Length);
                inputBox.Focus();
                inputBox.ScrollToHome();

            }
        }
    }
}
