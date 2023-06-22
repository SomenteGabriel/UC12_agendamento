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
    public partial class Detalhes : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        public Detalhes()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=ti;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();


            inicio();
        }

        private void inicio()
        {
            textBoxDescricao.Text = G.descricao;
            textBoxPrecoservico.Text = G.preco_servico;
            textBoxPrecomaterial.Text = G.preco_material;
            textBoxRelatorio.Text = G.relatorio;
            textBoxDate.Text = G.date;
            labelCliente.Text = G.cliente;



           
        }

        private void Detalhes_Load(object sender, EventArgs e)
        {

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {


            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE servico SET descricao = '"+textBoxDescricao.Text+"', preco_servico = '"+textBoxPrecoservico.Text+"', preco_material = '"+textBoxPrecomaterial.Text+"', relatorio = '"+textBoxRelatorio.Text+"' WHERE id = "+G.id+";";
                comando.ExecuteNonQuery();

                MessageBox.Show("Informações alteradas com sucesso!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE servico SET ativo = 2 WHERE id = "+G.id+";";
                comando.ExecuteNonQuery();

                MessageBox.Show("Serviço Finalizado !!!!\n Bom Trabalho!!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            Form form = new A_agendamento();
            form.Show();
            this.Close();
            
        }
    }
}
