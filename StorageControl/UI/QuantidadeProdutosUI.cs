using StorageProject.Classes;
using System.Drawing;
using System.Windows.Forms;

namespace StorageProject.UI
{
    internal class QuantidadeProdutosUI
    {
        private DashBoard dashBoard;


        public QuantidadeProdutosUI()
        {
            dashBoard = new DashBoard();
        }

        public Panel CriarPainel()
        {
            Panel panel = new Panel
            {
                Size = new Size(250, 120),
                Location = new Point(250, 130),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(15)
            };

            Label titulo = new Label
            {
                Text = "Produtos em Estoque",
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.Black,
                Location = new Point(10, 10)
            };

            Label quantidade = new Label
            {
                Text = dashBoard.QuantidadeProdutos().ToString(),
                Font = new Font("Arial", 24, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.Blue,
                Location = new Point(10, 40)
            };

            Label descricao = new Label
            {
                Text = "Quantidade total produtos no estoque",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                AutoSize = true,
                ForeColor = Color.Gray,
                Location = new Point(10, 90)
            };


            panel.Controls.Add(titulo);
            panel.Controls.Add(quantidade);
            panel.Controls.Add(descricao);

            return panel;
        }
    }
}
