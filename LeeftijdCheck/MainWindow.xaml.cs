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

namespace LeeftijdCheck
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

        private void sLeeftijd_Click(object sender, RoutedEventArgs e)
        {
            {
                int sLeeftijd = Int32.Parse(txtLeeftijd.Text);
                if (sLeeftijd >= 18)
                {
                    MessageBox.Show("U mag drinken ! U bent ouder als" + sLeeftijd);
                }
                else
                { 
                MessageBox.Show("U bent nog te jong: De ingevoerde leeftijd is " + sLeeftijd);
                }

            }
        }

        private void txtLeeftijd_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
