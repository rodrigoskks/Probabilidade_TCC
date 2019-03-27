using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probabilidade.Model
{
    public class BuscaResultadoModel
    {
        private int codJogo;

        public int CodJogo { get => codJogo; set => codJogo = value; }
        public string NomeMandante { get => nomeMandante; set => nomeMandante = value; }
        public int GolMandante { get => golMandante; set => golMandante = value; }  
        public string NomeVisitante { get => nomeVisitante; set => nomeVisitante = value; }
        public int GolVisitante { get => golVisitante; set => golVisitante = value; }

        private string nomeMandante;

        private int golMandante;

        private string nomeVisitante;

        private int golVisitante;
    }
}
