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
    public partial class N : Form
    {

         Dictionary<string, string> dicionario = new Dictionary<string, string>();
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        public N()
        {


            InitializeComponent();

            servidor = "Server=localhost;Database=ti;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            listarclientes();
        }

        private void listarclientes()
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT id, nome FROM cliente;";

                MySqlDataReader readerclientes = comando.ExecuteReader();
                string nome = "";
                string id = "";
                while (readerclientes.Read())
                {
                   
                   nome = readerclientes.GetString(1);
                   id = readerclientes.GetString(0);

                    dicionario.Add(nome, id);
                    comboBoxCliente.DataSource = dicionario.ToList();
                    comboBoxCliente.ValueMember = "Value";
                    comboBoxCliente.DisplayMember = "Key";


                }
                


            }
            catch (MySqlException mysql_erro)
            {
                MessageBox.Show(mysql_erro.Message);

            }
            finally
            {
                conexao.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO servico (descricao, preco_servico, preco_material, fk_agendamento, ativo) VALUES ('"+textBoxDescricao.Text+"', '"+textBoxPrecoservico.Text.Replace(",",".")+"', '"+textBoxPrecomaterial.Text.Replace(",", ".") + "', "+G.agendamento+", "+1+");";
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
                comando.CommandText = " UPDATE servico_agendamento SET data_prevista = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', fk_cliente = " + comboBoxCliente.SelectedValue.ToString() +" WHERE id = "+G.agendamento+";";
                comando.ExecuteNonQuery();
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

            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPrecomaterial_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrecoservico_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDescricao_Click(object sender, EventArgs e)
        {

        }
    }
}
