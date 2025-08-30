using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageProject
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
}