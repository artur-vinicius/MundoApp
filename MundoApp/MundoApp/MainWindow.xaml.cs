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

namespace MundoApp
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

        private void PaisClick(object sender, RoutedEventArgs e)
        {
            PaisWindow w = new PaisWindow();
            w.ShowDialog();
        }

        private void EstadoClick(object sender, RoutedEventArgs e)
        {
            EstadoWindow w = new EstadoWindow();
            w.ShowDialog();
        }

        private void CidadeClick(object sender, RoutedEventArgs e)
        {
            CidadeWindow w = new CidadeWindow();
            w.ShowDialog();
        }

        private void MapaEstadosClick(object sender, RoutedEventArgs e)
        {
            MapaEstadoWindow w = new MapaEstadoWindow();
            w.ShowDialog();
        }

        private void MapaPaisClick(object sender, RoutedEventArgs e)
        {
            MapaPaisWindow w = new MapaPaisWindow();
            w.ShowDialog();
        }
    }
}
