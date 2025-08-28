using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageProject
{
    internal class EntradaDB
    {
        public static string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=Storage;Trusted_Connection=True;TrustServerCertificate=true";

        public static bool Entrada(
            DateTime dataEntrada,
            string nome,
            string fornecedor,
            int quantidade,
            string valorUnitario,
            string valorTotal,
            int numeroNotaFiscal,
            string numeroPedido,
            int PLID,
            int reColab
            )
        {
            using (var conexao = new SqlConnection(connectionString))
            {
                string query = @" 
                    INSERT INTO Gestao 
                    (DataEntrada, NomeInsumo, Fornecedor, Quantidade, ValorUnitario, ValorTotal, NumeroNotaFiscal, NumeroPedido, PalletID, ID_RegistroEmpresarial)
                    VALUES 
                    (@dataEntrada, @nome, @fornecedor, @quantidade, @valorUnitario, @valorTotal, @numeroNotaFiscal, @numeroPedido, @PalletID, @reColab)";

                using (var comando = new SqlCommand(query, conexao)) 
                {
                    comando.Parameters.AddWithValue("@dataEntrada", dataEntrada);
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@fornecedor", fornecedor);
                    comando.Parameters.AddWithValue("@quantidade", quantidade);
                    comando.Parameters.AddWithValue("@valorUnitario", valorUnitario);
                    comando.Parameters.AddWithValue("@valorTotal", valorTotal);
                    comando.Parameters.AddWithValue("@numeroNotaFiscal", numeroNotaFiscal);
                    comando.Parameters.AddWithValue("@numeroPedido", numeroPedido);
                    comando.Parameters.AddWithValue("@PalletID", PLID);
                    comando.Parameters.AddWithValue("@reColab", reColab);

                    try
                    {
                        conexao.Open();
                        comando.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Erro ao inserir dados: " + ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}
