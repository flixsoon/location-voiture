using System;
using System.Windows.Forms;
using Location.Classes;
 
namespace Location.Forms
{
    public partial class ClientDetails : Form
    {
        public ClientDetails()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //test if the fields
            OracleDataBase db = new OracleDataBase();
            Tables.User_Details user_Details = new Tables.User_Details(txb_user_name.Text, txb_email.Text, txb_first_name.Text,
                txb_last_name.Text, txb_adresse.Text, txb_phone_number.Text, DateTime.Parse(dtp_brith_day.Text), false);
            Tables.Users user = new Tables.Users(txb_user_name.Text, txb_password.Text, cb_admin.Checked);

            db.addClientWithDetails(user,user_Details);
            clearTextBoxes();

            //test if the fields is not null
            //add client if note exist else update with comfirmation msg
            //get user detail by id for modify
        }
        private void clearTextBoxes()
        {
            cb_admin.Checked = false;

            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void ClientDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
