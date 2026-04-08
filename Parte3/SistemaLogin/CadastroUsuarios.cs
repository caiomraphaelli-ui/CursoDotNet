using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    static internal class CadastroUsuarios
    {
        private static Usuario[] usuarios =
        {
            new Usuario() {Nome = "admin", Senha = "admin"},
            new Usuario() {Nome = "Caio", Senha = "caio123"},
            new Usuario() {Nome = "Maria", Senha = "mariaX@@!"}
        };

        private static Usuario _userLogado = null;

        public static Usuario Usuario_logado
        {
            get { return _userLogado; }
            private set { _userLogado = value; }
        }
        
        public static bool Login (string nome, string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nome.Equals(nome) && usuario.Senha.Equals(senha))
                {
                    Usuario_logado = usuario;
                    return true;
                }
            }
            return false;
        }

    }
}
