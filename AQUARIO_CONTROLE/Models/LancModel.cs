using AQUARIO_CONTROLE.Controllers;
using AQUARIO_CONTROLE.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQUARIO_CONTROLE.Models
{
    public class LancModel
    {
        LancController controller = new LancController();
        public static int Inserir(Lancamento obj)
        {
            return new LancController().Inserir(obj);
        }
        public static int Editar(Lancamento obj)
        {
            return new LancController().Editar(obj);
        }
        public static int Deletar(Lancamento obj)
        {
            return new LancController().Deletar(obj);
        }
        public List<Lancamento> Buscar(Lancamento obj)
        {
            return new LancController().Buscar(obj);
        }
        public List<Lancamento> BuscarTipo(Lancamento obj)
        {
            return new LancController().BuscarTipo(obj);
        }
        public List<Lancamento> Listar()
        {
            return new LancController().Listar();
        }
    }
}
