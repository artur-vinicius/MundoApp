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
    /// Lógica interna para EstadoWindow.xaml
    /// </summary>
    public partial class EstadoWindow : Window
    {
        public EstadoWindow()
        {
            InitializeComponent();
        }
        private void InserirClick(object sender, RoutedEventArgs e)
        {
            Estado p = new Estado();
            p.Id = int.Parse(txtId.Text);
            p.Nome = txtNome.Text;
            p.Populacao = int.Parse(txtPop.Text);
            p.IdPais = int.Parse(txtIdPais.Text);

            NEstado.Inserir(p);

            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listEstado.ItemsSource = null;
            listEstado.ItemsSource = NEstado.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {

            Estado p = new Estado();
            p.Id = int.Parse(txtId.Text);
            p.Nome = txtNome.Text;
            p.Populacao = int.Parse(txtPop.Text);
            p.IdPais = int.Parse(txtIdPais.Text);

            NEstado.Atualizar(p);

            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            Estado p = new Estado();
            p.Id = int.Parse(txtId.Text);

            NEstado.Excluir(p);

            ListarClick(sender, e);
        }

        private void listEstado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listEstado.SelectedItem != null)
            {
                Estado obj = (Estado)listEstado.SelectedItem;

                txtId.Text = obj.Id.ToString();
                txtNome.Text = obj.Nome;
                txtPop.Text = obj.Populacao.ToString();
                txtIdPais.Text = obj.IdPais.ToString();
            }
        }
    }
}
