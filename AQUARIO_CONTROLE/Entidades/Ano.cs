using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQUARIO_CONTROLE.Entidades
{
    // Campos que contém no banco de dados
    public class Ano
    {
        int id_ano;
        int anos;


        //Recebimento e envio de dados 
        public int Id_ano { get => id_ano; set => id_ano = value; }
        public int Anos { get => anos; set => anos = value; }
    }
}
