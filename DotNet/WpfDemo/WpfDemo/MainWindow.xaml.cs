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

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void summaButton_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(luku1TextBox.Text);
            int b = int.Parse(luku2TextBox.Text);
            int summa = a + b;
            MessageBox.Show(summa.ToString());
        }
    }
}
