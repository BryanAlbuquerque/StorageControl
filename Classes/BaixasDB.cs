using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace StorageControl.Classes
{
    internal class BaixasDB
    {
        private static string connectionString =
          "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=Storage;Trusted_Connection=True;TrustServerCertificate=true";

        public static bool Baixas(int palletID, int quantidade)
        {
            using (var conexao = new SqlConnection(connectionString)) // Variavel que chama a conexão acima
            {
                string query = @"
                    UPDATE Gestao
                    SET 
                        QuantidadeAtual = 
                    CASE 
                        WHEN QuantidadeAtual IS NULL THEN Quantidade - @quantidade
                        ELSE QuantidadeAtual - @quantidade
                        END,
                    Consumo = 
                        ISNULL(Consumo, 0) + @quantidade
                         WHERE PalletID = @palletId";

                using (var comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@palletId", palletID);
                    comando.Parameters.AddWithValue("@quantidade", quantidade);

                    try
                    {
                        conexao.Open();
                        int rowsAffected = comando.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            return true;
                        else
                        {
                            Console.WriteLine("Nenhum registro foi atualizado.");
                            return false;
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Erro ao atualizar dados: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public static bool BaixasRealizadas(int re, int palletID, string setor, int quantidade)
        {
            using (var conexao = new SqlConnection(connectionString))
            {
                string query = @"
                   INSERT INTO Baixas_Realizadas (ID_RegistroEmpresarial, PalletID, Setor_Solicitante, Quantidade, Data_Realizada)
                   VALUES (@re, @palletId, @setor, @quantidade, GETDATE())";

                using (var comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@re", re);
                    comando.Parameters.AddWithValue("@palletId", palletID);
                    comando.Parameters.AddWithValue("@setor", setor);
                    comando.Parameters.AddWithValue("@quantidade", quantidade);
                    try
                    {
                        conexao.Open();
                        int rowsAffected = comando.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            return true;
                        else
                        {
                            MessageBox.Show("Nenhum registro foi inserido.");
                            return false;
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao inserir dados: " + ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}


