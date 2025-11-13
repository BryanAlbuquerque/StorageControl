using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace StorageProject.Classes
{
    internal class DashBoard
    {
        private readonly string ConnectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=Storage;Trusted_Connection=True;TrustServerCertificate=true";

        public int QuantidadeProdutos() 
        {
            using (SqlConnection conexao = new SqlConnection(ConnectionString)) 
            { 
                string query = @"SELECT COUNT(*) FROM Gestao";

                SqlCommand comando = new SqlCommand(query, conexao);
                conexao.Open();
                return (int)comando.ExecuteScalar();
            }
        }

        public double ValorTotalEstoque()
        {
            using (SqlConnection conexao = new SqlConnection(ConnectionString))
            {
                string query = @"SELECT SUM(TRY_CAST(ValorTotal AS DECIMAL(18,2)) * Quantidade) FROM Gestao";
                SqlCommand comando = new SqlCommand(query, conexao);
                conexao.Open();

                var resultado = comando.ExecuteScalar();

                if (resultado == DBNull.Value || resultado == null)
                    return 0;

                return Convert.ToDouble(resultado);
            }
        }

        public class EstoqueInfo
        {
            public string NomeInsumo { get; set; }
            public int Quantidade { get; set; }
            public double ValorTotal { get; set; }
        }
        public List<EstoqueInfo> ObterInformacoesEstoque()
        {
            List<EstoqueInfo> informacoes = new List<EstoqueInfo>();
            using (SqlConnection conexao = new SqlConnection(ConnectionString))
            {
                string query = @"SELECT NomeInsumo, Quantidade, ValorTotal FROM Gestao";
                SqlCommand comando = new SqlCommand(query, conexao);
                conexao.Open();
                using (SqlDataReader leitor = comando.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        EstoqueInfo info = new EstoqueInfo
                        {
                            NomeInsumo = leitor["NomeInsumo"].ToString(),
                            Quantidade = Convert.ToInt32(leitor["Quantidade"]),
                            ValorTotal = Convert.ToDouble(leitor["ValorTotal"])
                        };
                        informacoes.Add(info);
                    }
                }
            }
            return informacoes;
        }

    }
}
