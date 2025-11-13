using StorageProject.Classes;
using System.Drawing;
using System.Windows.Forms;

namespace StorageProject.UI
{
    internal class ValorTotalEstoqueUI
    {
        private DashBoard dashBoard;

        public ValorTotalEstoqueUI()
        {
            dashBoard = new DashBoard();
        }

        public Panel CriarPainel() 
        {
            Panel panel = new Panel
            {
                Size = new Size(300, 120),
                Location = new Point(550, 130),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(15)
            };

            Label titulo = new Label
            {
                Text = "Valor Total do Estoque",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(10, 10)

            };

            Label valorTotal = new Label
            {
                Text = $"R$ {dashBoard.ValorTotalEstoque():N2}",
                Font = new Font("Arial", 24, FontStyle.Bold),
                ForeColor = Color.Green,
                AutoSize = true,
                Location = new Point(10, 40)

            };

            Label descricao = new Label
            {
                Text = "Valor total dos produtos em estoque",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                AutoSize = true,
                ForeColor = Color.Gray,
                Location = new Point(10, 90)
            };

            panel.Controls.Add(titulo);
            panel.Controls.Add(valorTotal);
            panel.Controls.Add(descricao);

            return panel;
        }
    }
}
