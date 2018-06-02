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
    /// Interaction logic for TelaEstacionado.xaml
    /// </summary>
    public partial class TelaEstacionado : Window
    {
        public TelaEstacionado()
        {
            InitializeComponent();

            Entrada recebeEstacionar = new Entrada();
          
            recebeEstacionar = Controllers.EstacionarController.ultimoCarro;          
            
            Carro c = Controllers.CarrosController.retornaCarroPorId(recebeEstacionar.clienteId);
   
            blockPlaca.Text = c.Placa;
            blockModelo.Text = c.Modelo;
            blockCor.Text = c.Cor;
            txtData.Text = recebeEstacionar.DataEstacionar;      
            

        }

        private void Button_Fechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }

}
