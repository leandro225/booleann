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
using System.Windows.Shapes;
using Modelos;

namespace TelasMenu
{
    /// <summary>
    /// Interaction logic for TelaCarrosNoPatio.xaml
    /// </summary>
    public partial class TelaCarrosNoPatio : Window
    {

        public static List<Carro> novaLista = new List<Carro>();
        public static List<Carro> novaLista1 = new List<Carro>();

        public TelaCarrosNoPatio()
        {
            InitializeComponent();
            DtGrid.ItemsSource = null;
            novaLista1 = Controllers.EstacionarController.PesquisaCarroPorStatus();

            DtGrid.ItemsSource = novaLista1;
        }

        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }

}
