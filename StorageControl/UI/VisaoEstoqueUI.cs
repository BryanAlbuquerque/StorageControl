using System.Drawing;
using System.Windows.Forms;
using StorageProject.Classes;

namespace StorageProject.UI
{
    internal class VisaoEstoqueUI
    {
        private DashBoard dashBoard;

        public VisaoEstoqueUI()
        {
            dashBoard = new DashBoard();
        }

        public Panel CriarPainel()
        {
            Panel panel = new Panel
            {
                Size = new System.Drawing.Size(500, 300),
                Location = new System.Drawing.Point(220, 300),
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(20),
                AutoScroll = true
            };

            var informacoesEstoque = dashBoard.ObterInformacoesEstoque();

            int yOffset = 10;

            foreach (var info in informacoesEstoque)
            {
                Label nome = new Label
                {
                    Text = $"Produto: {info.NomeInsumo}",
                    AutoSize = true,
                    Location = new Point(10, yOffset),
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };

                Label quantidade = new Label
                {
                    Text = $"Quantidade: {info.Quantidade}",
                    AutoSize = true,
                    Location = new Point(30, yOffset + 25),
                    Font = new Font("Arial", 10)
                };

                Label valorTotal = new Label
                {
                    Text = $"Valor: R$ {info.ValorTotal:F2}",
                    AutoSize = true,
                    Location = new Point(30, yOffset + 50),
                    Font = new Font("Arial", 10)
                };


                panel.Controls.Add(nome);
                panel.Controls.Add(quantidade);
                panel.Controls.Add(valorTotal);

                yOffset += 80;
            }

            return panel;
        }
    }
}

