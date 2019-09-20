using Location.Classes;
using System;
using System.Windows.Forms;

namespace Location.Forms
{
    public partial class Contrat : Form
    {
        public Contrat()
        {
            InitializeComponent();
        }

        private void Contrat_Load(object sender, EventArgs e)
        {
            OracleDataBase db = new OracleDataBase();
            db.loadQueryToGDV(dgv_contrat, "select * from Contrat");
        }
    }
}
