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

namespace OpenPort
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        setPort setPort = new setPort();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MySql_button_Click(object sender, RoutedEventArgs e)
        {
            setPort.MySql(MySql_button);
        }
        private void apache_button_Click(object sender, RoutedEventArgs e)
        {
            setPort.Apache(apache_button);
        }

    }
}
