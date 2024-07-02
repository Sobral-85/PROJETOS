using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQUARIO_CONTROLE.Entidades
{
    public class Login
    {
        string email;
        string senha;

        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
