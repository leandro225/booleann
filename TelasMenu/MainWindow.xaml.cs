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

namespace TelasMenu
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

        private void Button_Click_Estacionar(object sender, RoutedEventArgs e)
        {

            TelaEstacionar telaEstacionar = new TelaEstacionar();
            telaEstacionar.ShowDialog();
        }

        private void Button_Click_CarrosPatio(object sender, RoutedEventArgs e)
        {

            TelaCarrosNoPatio telaCarrosNoPatio = new TelaCarrosNoPatio();
            telaCarrosNoPatio.ShowDialog();
        }

        private void Button_Click_CarrosForaPatio(object sender, RoutedEventArgs e)
        {

            TelaCarrosForaDoPatio telaCarrosForaDoPatio = new TelaCarrosForaDoPatio();
            telaCarrosForaDoPatio.ShowDialog();
        }
       
    }

}
