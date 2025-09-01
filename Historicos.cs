using System;
using System.Windows.Forms;

namespace StorageProject
{
    public partial class Historicos : Form
    {
        HistoricoDB HistoricoDB = new HistoricoDB();
        public Historicos()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
            this.Close();
        }

        private void Historicos_Load(object sender, EventArgs e)
        {
            dataGridBaixa.AutoGenerateColumns = true;
            dataGridBaixa.DataSource = HistoricoDB.CarregarDados();

            dataGridEndereco.AutoGenerateColumns = true;
            dataGridEndereco.DataSource = HistoricoDB.CarregarDadosEnderecos();

        }

        private void btnBaixas_Click(object sender, EventArgs e)
        {
            dataGridBaixa.Visible = true;
            dataGridEndereco.Visible = false;
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            dataGridEndereco.Visible = true;
            dataGridBaixa.Visible = false;
        }
    }
}
