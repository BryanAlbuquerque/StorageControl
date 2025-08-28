using System;
using Microsoft.Data.SqlClient;

namespace StorageProject
{
    internal class EnderecoDB
    {
        private static string connectionString =
                 "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=Storage;Trusted_Connection=True;TrustServerCertificate=true;";

        public static bool Enderecamento(int PalletID, string endereco)
        {
            using (var conexao = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Gestao
                        SET Endereco = @endereco
                        WHERE PalletID = @PalletID";


                using (var comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@palletId", PalletID);
                    comando.Parameters.AddWithValue("@endereco", endereco);


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
