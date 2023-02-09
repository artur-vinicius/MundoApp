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
    /// Lógica interna para MapaEstadoWindow.xaml
    /// </summary>
    public partial class MapaEstadoWindow : Window
    {
        public MapaEstadoWindow()
        {
            InitializeComponent();
            listEstados.ItemsSource = NEstado.Listar();
        }
        private void ListarClick(object sender, RoutedEventArgs e)
        {
            if (listEstados.SelectedItem != null)
            {
                Estado c = (Estado)listEstados.SelectedItem;
                listCidades.ItemsSource = null;
                listCidades.ItemsSource = NCidade.Listar(c);
            }
            else
                MessageBox.Show("Selecione um estado");
        }
    }
}
