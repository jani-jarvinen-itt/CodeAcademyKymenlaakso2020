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

namespace LinqDemo
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[] luvut = { 4, 8, 3, 9, 1, 10, 7, 2, 5 };
            List<int> tulokset = new List<int>();
            foreach (int luku in luvut)
            {
                if (luku > 5)
                {
                    tulokset.Add(luku);
                }
            }

            tulokset.Sort();

            foreach (int luku in tulokset)
            {
                MessageBox.Show(luku.ToString());
            }
        }
    }
}
