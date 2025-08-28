using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace StorageProject
{
    internal class GestaoDB
    {
        private static string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=Storage;Trusted_Connection=True;TrustServerCertificate=true;";

        public DataTable CarregarDados()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Endereco, PalletID, DataEntrada, NomeInsumo, Fornecedor, Quantidade, ValorUnitario, ValorTotal, NumeroNotaFiscal, NumeroPedido, Consumo, QuantidadeAtual, ID_RegistroEmpresarial FROM Gestao";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
