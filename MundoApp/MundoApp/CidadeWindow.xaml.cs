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
    /// Lógica interna para CidadeWindow.xaml
    /// </summary>
    public partial class CidadeWindow : Window
    {
        public CidadeWindow()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            Cidade p = new Cidade();
            p.Id = int.Parse(txtId.Text);
            p.Nome = txtNome.Text;
            p.Populacao = int.Parse(txtPop.Text);
            p.IdEstado = int.Parse(txtIdEstado.Text);

            NCidade.Inserir(p);

            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listCidade.ItemsSource = null;
            listCidade.ItemsSource = NCidade.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            Cidade p = new Cidade();
            p.Id = int.Parse(txtId.Text);
            p.Nome = txtNome.Text;
            p.Populacao = int.Parse(txtPop.Text);
            p.IdEstado = int.Parse(txtIdEstado.Text);

            NCidade.Atualizar(p);

            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            Cidade p = new Cidade();
            p.Id = int.Parse(txtId.Text);

            NCidade.Excluir(p);

            ListarClick(sender, e);
        }

        private void listCidade_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listCidade.SelectedItem != null)
            {
                Cidade obj = (Cidade)listCidade.SelectedItem;

                txtId.Text = obj.Id.ToString();
                txtNome.Text = obj.Nome;
                txtPop.Text = obj.Populacao.ToString();
                txtIdEstado.Text = obj.IdEstado.ToString();
            }
        }
    }
}
