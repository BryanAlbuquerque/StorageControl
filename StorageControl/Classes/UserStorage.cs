using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace StorageControl.Classes
{
    public class UserStorage
    {
        private static string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=Storage;Trusted_Connection=True;TrustServerCertificate=True";

        public string Usuario { get; set; }
        public string Senha { get; set; }
        public int Re { get; set; }

        public UserStorage() { }
        public UserStorage(string usuario, string senha, int re) 
        {
            Usuario = usuario;
            Senha = senha;
            Re = re;
        }

        public static bool CadastrarUsuario(string usuario, string senha, int re)
        {
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
                return false;

            usuario = usuario.Trim();

            using (var conexao = new SqlConnection(connectionString))
            {
                conexao.Open();

                // Verifica se o RE existe e está ativo na tabela Funcionarios
                const string sqlVerificaReAtivo = @"
                    SELECT 1
                    FROM Funcionarios
                    WHERE ID_RegistroEmpresarial = @re
                    AND Situacao = 'Ativo'";

                using (var cmdVerifica = new SqlCommand(sqlVerificaReAtivo, conexao))
                {
                    cmdVerifica.Parameters.Add("@re", SqlDbType.Int).Value = re;

                    var ok = cmdVerifica.ExecuteScalar();
                    if (ok == null) // não existe RE ou não está ativo
                        return false;
                }

                // Insere o usuário na tabela Usuarios
                const string sqlInsert = @"
                    INSERT INTO Usuarios (Usuario, Senha, ID_RegistroEmpresarial)
                    VALUES (@usuario, @senha, @re)";

                using (var cmdInsert = new SqlCommand(sqlInsert, conexao))
                {
                    cmdInsert.Parameters.Add("@usuario", SqlDbType.VarChar, 100).Value = usuario;
                    cmdInsert.Parameters.Add("@senha", SqlDbType.VarChar, 100).Value = senha;
                    cmdInsert.Parameters.Add("@re", SqlDbType.Int).Value = re;

                    try
                    {
                        cmdInsert.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627 || ex.Number == 2601)
                            return false;
                        throw;
                    }
                }
            }
        }

        //Faz autenticação do usuário
        public static bool Autenticar(string usuario, string senha)
        {
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
                return false;

            usuario = usuario.Trim();

            using (var conexao = new SqlConnection(connectionString))
            {
                const string sqlAuth = @"
                    SELECT 1
                    FROM Usuarios u
                    INNER JOIN Funcionarios f
                    ON f.ID_RegistroEmpresarial = u.ID_RegistroEmpresarial
                    WHERE u.Usuario = @usuario
                    AND u.Senha = @senha
                    AND f.Situacao = 'Ativo'";

                using (var cmd = new SqlCommand(sqlAuth, conexao))
                {
                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 100).Value = usuario;
                    cmd.Parameters.Add("@senha", SqlDbType.VarChar, 100).Value = senha;

                    conexao.Open();
                    var ok = cmd.ExecuteScalar();
                    return ok != null;
                }
            }
        }
    }
}
