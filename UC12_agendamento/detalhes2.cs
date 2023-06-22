using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UC12_agendamento
{
    public partial class detalhes2 : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        public detalhes2()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=ti;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();


            inicio();
        }

        private void inicio()
        {
            textBoxDescricao.Text = G.descricao2;
            textBoxPrecoservico.Text = G.preco_servico2;
            textBoxPrecomaterial.Text = G.preco_material2;
            textBoxRelatorio.Text = G.relatorio2;
            textBoxDate.Text = G.date2;
            labelCliente.Text = G.cliente2;




        }

        private void buttonReativar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE servico SET ativo = 1 WHERE id = " + G.id2 + ";";
                comando.ExecuteNonQuery();

                MessageBox.Show("Serviço Reativado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            Form form = new AgendamentoInativo();
            form.Show();
            this.Close();
           
        }
    }
}
