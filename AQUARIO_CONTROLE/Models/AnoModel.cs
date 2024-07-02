using AQUARIO_CONTROLE.Controllers;
using AQUARIO_CONTROLE.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQUARIO_CONTROLE.Models
{
    public class AnoModel
    {
        public static int Inserir(Ano obj)
        {
            return new AnoController().Inserir(obj);
        }
        public static int Editar(Ano obj)
        {
            return new AnoController().Editar(obj);
        }
        public static int Deletar(Ano obj)
        {
            return new AnoController().Deletar(obj);
        }
        public List<Ano> Buscar(Ano obj)
        {
            return new AnoController().Buscar(obj);
        }
        public List<Ano> Listar()
        {
            return new AnoController().Listar();
        }
    }
}
