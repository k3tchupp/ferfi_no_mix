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

namespace _11_30
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
        Random vel = new Random();

        private void txtNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                lbNok.Items.Add(txtNo.Text);
                txtNo.Text = "";
            }
        }

        private void txtFerfi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                lbFerfiak.Items.Add(txtFerfi.Text);
                txtFerfi.Text = "";
            }
        }

        private void btnMix_Click(object sender, KeyEventArgs e)
        {
            int parok = 0;
            if (lbFerfiak.Items.Count > lbNok.Items.Count) { parok = lbNok.Items.Count; }
            else { parok = lbFerfiak.Items.Count; }

            for (int i = 0; i < parok; i++)
            {
                int ferfi = vel.Next(0, parok - 1);
                int no = vel.Next(0, parok - 1);

                lbMix.Items.Add($"{lbFerfiak.Items[ferfi]} + {lbNok.Items[no]}");
                lbFerfiak.Items.RemoveAt(ferfi);
                lbNok.Items.RemoveAt(no);
            }
            
        }

        private void btnMix_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}