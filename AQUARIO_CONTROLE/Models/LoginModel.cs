using AQUARIO_CONTROLE.Controllers;
using AQUARIO_CONTROLE.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQUARIO_CONTROLE.Models
{
    public class LoginModel
    {
        public static int Inserir(CadLogin obj)
        {
            return new LoginCadController().Inserir(obj); 
        }
        public static int Editar(CadLogin obj)
        {
            return new LoginCadController().Editar(obj);
        }
        public bool VerificarLogin(CadLogin obj)
        {
            return new LoginCadController().VerificarLogin(obj);
        }

    }
}
