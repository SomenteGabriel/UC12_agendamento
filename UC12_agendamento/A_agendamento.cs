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
    public partial class A_agendamento : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        public A_agendamento()
        {
            InitializeComponent();

            servidor = "Server=localhost;Database=ti;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();

            listargrid();
        }

        private void listargrid()
        {

            try
            {
                conexao.Open();
                comando.CommandText = "SELECT nome,descricao, preco_servico, preco_material, relatorio, data_prevista, servico.id FROM servico INNER JOIN servico_agendamento on (servico.fk_agendamento = servico_agendamento.id) INNER JOIN cliente on (servico_agendamento.Fk_cliente = cliente.id) WHERE ativo = 1;";
                MySqlDataAdapter adaptadorGRID = new MySqlDataAdapter(comando);
                DataTable tabelaGRID = new DataTable();
                adaptadorGRID.Fill(tabelaGRID);

                dataGridView1.DataSource = tabelaGRID;
                dataGridView1.Columns["nome"].HeaderText = "Cliente";
                dataGridView1.Columns["descricao"].HeaderText = "Descrição";
                dataGridView1.Columns["preco_servico"].HeaderText = "Preço Serviço";
                dataGridView1.Columns["preco_material"].HeaderText = "Preço Material";
                dataGridView1.Columns["relatorio"].HeaderText = "Relatório";
                dataGridView1.Columns["data_prevista"].HeaderText = "Data Prevista";

            }
            catch (Exception mysql)
            {
                MessageBox.Show(mysql.Message);
            }
            finally
            {
                conexao.Close();
            }






        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            G.cliente = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            G.descricao = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            G.preco_servico = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            G.preco_material = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            G.relatorio = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            G.date = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            G.id = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            this.Close();
            Form TELADETALHES = new Detalhes();
            TELADETALHES.Show();
            
        }

        private void A_agendamento_Load(object sender, EventArgs e)
        {

        }
    }
}
