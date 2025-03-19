using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadrastroUsuarios
{
     public class GerenciadorUsuarios
    {
        private List<Usuario> usuarios = new List<Usuario>();
        public void AdicionarUsuario(string nome, string email, int idade)
        {
            usuarios.Add(new Usuario(nome, email, idade));
            Console.WriteLine("Usuário cadastrado com sucesso!");
        }
        public void LisarUsuario()
        {
           if (usuarios.Count == 0)
            {
                Console.WriteLine("Nenhum usuário cadastrado");
                return;
            }
            Console.WriteLine("\n lista de Usuários:");
            foreach (var usuario in usuarios)
            {
                Console.WriteLine(usuario);
            }
        }
        public void BuscarUsuario(string nome)
        {
            var usuario = usuarios.FirstOrDefault(u => u.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (usuario != null)
            {
                
                Console.WriteLine(usuario);
              
            }
          else
            {
                Console.WriteLine($" Usuário '{nome}' não encontrado.");
            }
        }
    }
}
