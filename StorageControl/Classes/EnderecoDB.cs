using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace StorageControl.Classes
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

        public static bool HistoricoEnderecos(int re, int palletID, string endereco)
        { 
            using (var conexao = new SqlConnection(connectionString)) 
            { 
                string query = @"
                INSERT INTO Historico_Enderecos (ID_RegistroEmpresarial, PalletID, Endereco, Data_Realizada)
                  VALUES (@re, @palletId, @endereco, GETDATE())";

                using (var comando = new SqlCommand(query, conexao)) 
                {
                    comando.Parameters.AddWithValue("@re", re);
                    comando.Parameters.AddWithValue("@palletId", palletID);
                    comando.Parameters.AddWithValue("@endereco", endereco);
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
