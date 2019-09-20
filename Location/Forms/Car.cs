using Location.Classes;
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
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }

        private void Car_Load(object sender, EventArgs e)
        {
            OracleDataBase db = new OracleDataBase();
            db.loadQueryToGDV(dgv_car, "select * from Car c, CarPictures cp where c.Matricule = cp.Matricule");
        }
    }
}
