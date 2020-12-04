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

namespace Daniel.Country_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> countries = new List<string>() { " ", " ", " ", " ", };
            List<string> name = new List<string>();

            int ctr = 0;
            foreach ( string country in countries )
            {
                name.Add(ctr + " " + country);
                ctr = ctr + 1;
            }
            lstCoutries.ItemsSource = name ;
        }
    }
}
