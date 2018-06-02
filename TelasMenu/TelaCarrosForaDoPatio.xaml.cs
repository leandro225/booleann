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

namespace TelasMenu
{
    /// <summary>
    /// Interaction logic for TelaCarrosForaDoPatio.xaml
    /// </summary>
    public partial class TelaCarrosForaDoPatio : Window
    {
        public TelaCarrosForaDoPatio()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }

}
