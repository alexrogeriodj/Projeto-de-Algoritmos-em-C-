using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Loja.BLL;
using Loja.DAL;
using Loja.Modelos;
using System.Xml;
using System.Xml.Schema;

namespace Loja.UIWindows
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        public void AtualizaGrid()
        {
            // Comunicação com a Camada BLL
            ClientesBLL obj = new ClientesBLL();
            clientesDataGridView.DataSource = obj.Listagem(txtFiltro.Text);
    
            // Atualizando os objetos TextBox
            try
            {
                codigoTextBox.Text = clientesDataGridView[0, clientesDataGridView.CurrentRow.Index].Value.ToString();
                nomeTextBox.Text = clientesDataGridView[1, clientesDataGridView.CurrentRow.Index].Value.ToString();
                emailTextBox.Text = clientesDataGridView[2, clientesDataGridView.CurrentRow.Index].Value.ToString();
                telefoneTextBox.Text = clientesDataGridView[3, clientesDataGridView.CurrentRow.Index].Value.ToString();
            }
            catch
            {
                codigoTextBox.Text = "";
                nomeTextBox.Text = "";
                emailTextBox.Text = "";
                telefoneTextBox.Text = "";
            }
            
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {            
            AtualizaGrid();
            nomeTextBox.Focus();
        }

        private void limparButton_Click(object sender, EventArgs e)
        {            
            codigoTextBox.Text = "";
            nomeTextBox.Text = "";
            emailTextBox.Text = "";
            telefoneTextBox.Text = "";
        }

        private void incluirButton_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteInformation cliente = new ClienteInformation();
                cliente.Nome = nomeTextBox.Text;
                cliente.Email = emailTextBox.Text;
                cliente.Telefone = telefoneTextBox.Text;
                

                ClientesBLL obj = new ClientesBLL();
                obj.Incluir(cliente);
                MessageBox.Show("O cliente foi incluído com sucesso!");
                codigoTextBox.Text = Convert.ToString(cliente.Codigo);
                AtualizaGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            if (codigoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Um cliente deve ser selecionado para alteração.");
            }
            else
                try
                {
                    ClienteInformation cliente = new ClienteInformation();
                    cliente.Codigo = int.Parse(codigoTextBox.Text);
                    cliente.Nome = nomeTextBox.Text;
                    cliente.Email = emailTextBox.Text;
                    cliente.Telefone = telefoneTextBox.Text;
                    

                    ClientesBLL obj = new ClientesBLL();
                    obj.Alterar(cliente);
                    MessageBox.Show("O cliente foi alterado com sucesso!");
                    AtualizaGrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (codigoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Um cliente deve ser selecionado antes da exclusão.");
            }
            else
                try
                {
                    int codigo = Convert.ToInt32(codigoTextBox.Text);
                    ClientesBLL obj = new ClientesBLL();
                    obj.Excluir(codigo);
                    MessageBox.Show("O cliente foi excluído com sucesso!");
                    AtualizaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
        }
        

        private void clientesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            // Atualizando os objetos TextBox
            codigoTextBox.Text = clientesDataGridView[0, clientesDataGridView.CurrentRow.Index].Value.ToString();
            nomeTextBox.Text = clientesDataGridView[1, clientesDataGridView.CurrentRow.Index].Value.ToString();
            emailTextBox.Text = clientesDataGridView[2, clientesDataGridView.CurrentRow.Index].Value.ToString();
            telefoneTextBox.Text = clientesDataGridView[3, clientesDataGridView.CurrentRow.Index].Value.ToString();
            

        }

        private void btFiltro_Click(object sender, EventArgs e)
        {
            
            // Comunicação com a Camada BLL
            ClientesBLL obj = new ClientesBLL();
            clientesDataGridView.DataSource = obj.Listagem(txtFiltro.Text);
            
            // Atualizando os objetos TextBox
            try {
                codigoTextBox.Text =  clientesDataGridView[0, clientesDataGridView.CurrentRow.Index].Value.ToString();
                nomeTextBox.Text = clientesDataGridView[1, clientesDataGridView.CurrentRow.Index].Value.ToString(); ;
                emailTextBox.Text = clientesDataGridView[2, clientesDataGridView.CurrentRow.Index].Value.ToString(); ;
                telefoneTextBox.Text = clientesDataGridView[3, clientesDataGridView.CurrentRow.Index].Value.ToString(); ;            
            }
            catch {
                codigoTextBox.Text = "";
                nomeTextBox.Text = "";
                emailTextBox.Text = "";
                telefoneTextBox.Text = "";
            }

        }

    }
}