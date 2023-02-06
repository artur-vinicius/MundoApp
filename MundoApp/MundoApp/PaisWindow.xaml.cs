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
    /// Lógica interna para PaisWindow.xaml
    /// </summary>
    public partial class PaisWindow : Window
    {
        public PaisWindow()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            Pais p = new Pais();
            p.Id = int.Parse(txtId.Text);
            p.Nome = txtPais.Text;
            p.Populacao = int.Parse(txtPop.Text);

            NPais.Inserir(p);

            ListarClick(sender, e);

        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            ListPais.ItemsSource = null;
            ListPais.ItemsSource = NPais.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {

            Pais p = new Pais();
            p.Id = int.Parse(txtId.Text);
            p.Nome = txtPais.Text;
            p.Populacao = int.Parse(txtPop.Text);

            NPais.Atualizar(p);

            ListarClick(sender, e);

        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            Pais p = new Pais();
            p.Id = int.Parse(txtId.Text);

            NPais.Excluir(p);

            ListarClick(sender, e);
        }

        private void ListPais_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListPais.SelectedItem != null)
            {
                Pais obj = (Pais)ListPais.SelectedItem;

                txtId.Text = obj.Id.ToString();
                txtPais.Text = obj.Nome;
                txtPop.Text = obj.Populacao.ToString();
            }
        }
    }
}
