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
    public partial class Form1 : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        public Form1()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=ti;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {

            Form TelaCadastro = new Clientes();
            TelaCadastro.Show();
            

        }

        private void buttonNovoagendamento_Click(object sender, EventArgs e)
        {

            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO servico_agendamento (data_agendamento) VALUES ('"+DateTime.Now.ToString("yyyy-MM-dd")+"');";
                comando.ExecuteNonQuery();
            }
            catch (Exception mysql_error)
            {
                MessageBox.Show(mysql_error.Message);
            }
            finally
            {
                conexao.Close();
            }

            try
            {
                conexao.Open();
                comando.CommandText = "SELECT MAX(id) FROM servico_agendamento;";
                MySqlDataReader Readeragendamento = comando.ExecuteReader();

                if (Readeragendamento.Read())
                {
                    G.agendamento = Readeragendamento.GetString(0);
                }

            }
            catch (Exception mysql_error)
            {
                MessageBox.Show(mysql_error.Message);
            }
            finally
            {
                conexao.Close();
            }

            Form TelaNOVOAGENDAMENTO = new N();
            TelaNOVOAGENDAMENTO.Show();

        }

        private void buttonAgendamentoatual_Click(object sender, EventArgs e)
        {
            Form TELAAGENDAMENTOATIVO =  new A_agendamento();
            TELAAGENDAMENTOATIVO.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form TELAAGENDAMENTOINATIVO = new AgendamentoInativo();
            TELAAGENDAMENTOINATIVO.Show();


        }
    }
    }
