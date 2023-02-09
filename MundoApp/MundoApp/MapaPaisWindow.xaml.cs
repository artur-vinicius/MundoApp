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

namespace MundoApp
{
    /// <summary>
    /// Lógica interna para MapaPaisWindow.xaml
    /// </summary>
    public partial class MapaPaisWindow : Window
    {
        public MapaPaisWindow()
        {
            InitializeComponent(); listPais.ItemsSource = NPais.Listar();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            if (listPais.SelectedItem != null)
            {
                Pais p = (Pais)listPais.SelectedItem;
                listEstados.ItemsSource = null;
                listEstados.ItemsSource = NEstado.Listar(p);
            }
            else
                MessageBox.Show("Selecione um país");
        }
    }
}
