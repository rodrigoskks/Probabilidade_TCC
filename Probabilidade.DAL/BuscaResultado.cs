using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Probabilidade.Model;
using System.Data;
using Probabilidade.Data;

namespace Probabilidade.DAL
{
    public class BuscaResultado
    {

        public static List<BuscaResultadoModel> BuscaResultadoMandante(int id_mandante)
        {
            StringBuilder sql = new StringBuilder();

            List<BuscaResultadoModel> listBusca = new List<BuscaResultadoModel>();

            sql.Append("select top 5 jogo.id_jogo as Código_do_Jogo, jogo.mandante as Código_do_mandante, ");
            sql.Append("time_Mandante.nome_time as TIME_MANDANTE,  jogo.visitante as Código_do_Visitante, ");
            sql.Append("time_Visitante.nome_time as TIME_VISITANTE, ");
            sql.Append("resultado.GOL_MANDANTE as GOL_MANDANTE, ");
            sql.Append("resultado.GOL_VISITANTE as GOL_VISITANTE, ");
            sql.Append("resultado.id_jogo ");
            sql.Append("from jogo ");
            sql.Append("inner join time_Visitante on jogo.visitante = time_Visitante.id_time ");
            sql.Append("inner join time_Mandante on jogo.mandante = time_Mandante.id_time ");
            sql.Append("inner join resultado on jogo.id_jogo = resultado.id_jogo ");
            sql.Append("where jogo.mandante = " + id_mandante + " order by id_jogo ");

            DataSet dt = DataManager.DbHelper.GetDataSet(sql.ToString());

            if (dt.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in dt.Tables[0].Rows)
                {
                    BuscaResultadoModel busca = new BuscaResultadoModel();

                    busca.CodJogo = Convert.ToInt32(item["Código_do_Jogo"].ToString());
                    busca.GolMandante = Convert.ToInt32(item["GOL_MANDANTE"].ToString());
                    busca.GolVisitante = Convert.ToInt32(item["GOL_VISITANTE"].ToString());
                    busca.NomeMandante = item["TIME_MANDANTE"].ToString();
                    busca.NomeVisitante = item["TIME_VISITANTE"].ToString();

                    listBusca.Add(busca);
                }
            }

            return listBusca;
        }

        public static List<BuscaResultadoModel> BuscaResultadoVisitante(int id_visitante)
        {
            StringBuilder sql = new StringBuilder();

            List<BuscaResultadoModel> listBusca = new List<BuscaResultadoModel>();

            sql.Append("select top 5 jogo.id_jogo as Código_do_Jogo, jogo.mandante as Código_do_mandante, ");
            sql.Append("time_Mandante.nome_time as TIME_MANDANTE,  jogo.visitante as Código_do_Visitante, ");
            sql.Append("time_Visitante.nome_time as TIME_VISITANTE, ");
            sql.Append("resultado.GOL_MANDANTE as GOL_MANDANTE, ");
            sql.Append("resultado.GOL_VISITANTE as GOL_VISITANTE, ");
            sql.Append("resultado.id_jogo ");
            sql.Append("from jogo ");
            sql.Append("inner join time_Visitante on jogo.visitante = time_Visitante.id_time ");
            sql.Append("inner join time_Mandante on jogo.mandante = time_Mandante.id_time ");
            sql.Append("inner join resultado on jogo.id_jogo = resultado.id_jogo ");
            sql.Append("where jogo.visitante = " + id_visitante + " order by id_jogo ");

            DataSet dt = DataManager.DbHelper.GetDataSet(sql.ToString());

            if (dt.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in dt.Tables[0].Rows)
                {
                    BuscaResultadoModel busca = new BuscaResultadoModel();

                    busca.CodJogo = Convert.ToInt32(item["Código_do_Jogo"].ToString());
                    busca.GolMandante = Convert.ToInt32(item["GOL_MANDANTE"].ToString());
                    busca.GolVisitante = Convert.ToInt32(item["GOL_VISITANTE"].ToString());
                    busca.NomeMandante = item["TIME_MANDANTE"].ToString();
                    busca.NomeVisitante = item["TIME_VISITANTE"].ToString();

                    listBusca.Add(busca);
                }
            }

            return listBusca;
        }

        public static List<string> BuscaTimeMandante()
        {
            StringBuilder sql = new StringBuilder();

            List<string> listBusca = new List<string>();

            sql.Append("select * from TIME_MANDANTE ");           

            DataSet dt = DataManager.DbHelper.GetDataSet(sql.ToString());

            if (dt.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in dt.Tables[0].Rows)
                {                   
                    listBusca.Add(item["ID_TIME"].ToString() + "-"  +item["NOME_TIME"].ToString());
                }
            }

            return listBusca;
        }


        public static List<string> BuscaTimeVisitante()
        {
            StringBuilder sql = new StringBuilder();

            List<string> listBusca = new List<string>();

            sql.Append("select * from TIME_VISITANTE ");

            DataSet dt = DataManager.DbHelper.GetDataSet(sql.ToString());

            if (dt.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in dt.Tables[0].Rows)
                {
                    listBusca.Add(item["ID_TIME"].ToString() + "-" + item["NOME_TIME"].ToString());
                }
            }

            return listBusca;
        }
    }
}
