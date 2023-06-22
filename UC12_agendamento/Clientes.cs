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
    public partial class Clientes : Form
    {

        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        public Clientes()
        {
           


            InitializeComponent();
            
            servidor = "Server=localhost;Database=ti;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO cliente ( nome, telefone, endereco ) VALUES ('"+textBox1.Text+"', '"+textBoxTelefone.Text+"', '"+textBoxEndereco.Text+"');";
                comando.ExecuteNonQuery();


                textBox1.Text = "";
                textBoxEndereco.Text = "";
                textBoxTelefone.Text = "";
                MessageBox.Show("Cadastro concluido !!!");
            }
            catch (Exception mysql_error)
            {
                MessageBox.Show(mysql_error.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }
    }
}
