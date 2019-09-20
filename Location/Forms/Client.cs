using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Location.Classes;
using Oracle.ManagedDataAccess.Client;

namespace Location.Forms
{
    public partial class Client : Form
    {
        string stringConnection = Properties.Settings.Default.StringConnection;

        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            OracleDataBase db = new OracleDataBase();
            db.loadQueryToGDV(dgv_client, "select u.UserId, UserPassword, Admin, Email, FirstName, LastName, Adresse, Phone, BrithDay " +
                "from Users u,User_Details ud where  ud.UserId (+)= u.UserId");
        }
    }
}
