using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQUARIO_CONTROLE.Entidades
{
    public class CadLogin
    {
        string login;
        string senha;

        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
