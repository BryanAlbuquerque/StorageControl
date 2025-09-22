using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageControl.Classes
{
    public class Admin
    {
        public string Usuario { get; set; } = "Storage@Admin";
        public string Senha { get; set; } = "Admin2025";

        public bool ValidarLogin(string usuario, string senha)
        {
            return usuario == Usuario && senha == Senha;
        }
    }

    //Controla o Usuario logado
    public static class SessaoUsuario
    {
        public static bool IsAdmin { get; set; } = false;
    }
}