using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Probabilidade.Data;
using System.Configuration;
using Probabilidade.DAL;
using Probabilidade.Model;

namespace Probabilidade
{    
    public partial class FrmProbabilidade : Form
    {
        // ConnectionString in App.config
        public string _stringConnection = ConfigurationManager.AppSettings["ConnectionString"].ToString();
        public FrmProbabilidade()
        {
            InitializeComponent();
            DataManager.DbHelper.StringConnection = _stringConnection;
        }

        private void FrmProbabilidade_Load(object sender, EventArgs e)
        {
            List<string> buscaMandante  = BuscaResultado.BuscaTimeMandante();
            List<string> buscaVisitante = BuscaResultado.BuscaTimeVisitante();

            foreach (string item in buscaMandante)
            {
                cbMandante.Items.Add(item);
            }

            foreach (string item in buscaVisitante)
            {
                cbVisitante.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<BuscaResultadoModel> modelBuscaMandante = BuscaResultado.BuscaResultadoMandante(Convert.ToInt32(cbMandante.Text.Split('-')[0]));
            List<BuscaResultadoModel> modelBuscaVisitante = BuscaResultado.BuscaResultadoMandante(Convert.ToInt32(cbVisitante.Text.Split('-')[0]));

            dtgMandante.DataSource  = modelBuscaMandante;
            dtgVisitante.DataSource = modelBuscaVisitante;
        }
    }
}
