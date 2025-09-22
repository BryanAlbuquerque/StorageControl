using System.Data;
using Microsoft.Data.SqlClient;

namespace StorageControl.Classes
{
    internal class HistoricoDB
    {
        private static string connectionString =
             "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=Storage;Trusted_Connection=True;TrustServerCertificate=true";

        private SqlDataAdapter _adapter;
        private DataTable _dt;

        public DataTable CarregarDadosBaixas()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT Data_Realizada, ID_RegistroEmpresarial, PalletID, Setor_Solicitante, Quantidade 
                         FROM Baixas_Realizadas";

                _adapter = new SqlDataAdapter(query, conn);
                _dt = new DataTable();
                _adapter.Fill(_dt);
            }
            return _dt;
        }

        public DataTable CarregarDadosEnderecos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT Data_Realizada, ID_RegistroEmpresarial, PalletID, Endereco
                         FROM Historico_Enderecos";

                _adapter = new SqlDataAdapter(query, conn);
                _dt = new DataTable();
                _adapter.Fill(_dt);
            }
            return _dt;
        }
    }
}
