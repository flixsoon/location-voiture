using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Location.Forms
{
    public partial class ContratDetails : Form
    {
        public ContratDetails()
        {
            InitializeComponent();
        }
        private void ContratDetails_Load(object sender, EventArgs e)
        {
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            //test if the fields is not null
            //add client if note exist else update with comfirmation msg
            //get user detail by id for modify
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
