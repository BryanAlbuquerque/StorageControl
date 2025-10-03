using Microsoft.Data.SqlClient;
using System.Data;

namespace StorageControl.Classes
{
    internal class GestaoDB
    {
        private static string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=Storage;Trusted_Connection=True;TrustServerCertificate=true";

        private SqlDataAdapter _adapter;
        private DataTable _dt;

        public DataTable CarregarDados()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string query = @"SELECT Endereco, PalletID, DataEntrada, NomeInsumo, Fornecedor, Quantidade, ValorUnitario, ValorTotal, 
                             NumeroNotaFiscal, NumeroPedido, Consumo, QuantidadeAtual, ID_RegistroEmpresarial FROM Gestao";

            _adapter = new SqlDataAdapter(query, conn);

            // cria automaticamente os comandos de Insert/Update/Delete
            SqlCommandBuilder builder = new SqlCommandBuilder(_adapter);

            _dt = new DataTable();
            _adapter.Fill(_dt);

            return _dt;
        }

        public void AlteracoesAdmin()
        {
            if (_adapter != null && _dt != null)
            {
                _adapter.Update(_dt); // aplica alterações do DataGrid
            }
        }
    }
}
