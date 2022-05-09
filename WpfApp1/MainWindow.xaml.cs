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

namespace WpfApp1
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
        bool Even = true;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = ((Button)sender);
            if (!string.IsNullOrEmpty((string?)button.Content)) return;
            if (Even)
                button.Content = "X";
            else
                button.Content = "O";
            Even = !Even;
            if ((Button1.Content.ToString() == "X") && (Button2.Content.ToString() == "X") && (Button3.Content.ToString() == "X"))
            {

            }
                //MessageBox mb = new MessageBox("hi");
        }
    }
}
