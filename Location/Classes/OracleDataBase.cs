using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Location.Classes
{ 
    class OracleDataBase
    {

        string stringConnection = Properties.Settings.Default.StringConnection;

        private DataTable  getAllUsers()
        {
            OracleConnection Connection = new OracleConnection(stringConnection);
            Connection.ConnectionString = stringConnection;
            Connection.Open();

            DataSet dataSet = new DataSet();

            OracleCommand cmd = new OracleCommand("semect * from Users");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Connection;

            using (OracleDataAdapter dataAdapter = new OracleDataAdapter())
            {
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataSet);
            }
            Connection.Close();
            return dataSet.Tables[0];
        }
        private DataTable getResultOfQuery(string query)
        {
            OracleConnection Connection = new OracleConnection(stringConnection);
            Connection.ConnectionString = stringConnection;
            Connection.Open();

            DataSet dataSet = new DataSet();

            OracleCommand cmd = new OracleCommand(query);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Connection;

            using (OracleDataAdapter dataAdapter = new OracleDataAdapter())
            {
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataSet);
            }

            Connection.Close();
            return dataSet.Tables[0];
        }
        private static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }


        public void setTableToDgv(DataGridView DGV, DataTable table)
        {
            DGV.DataSource = table;
        }
        public void loadQueryToGDV(DataGridView DGV, string query)
        {
            DGV.DataSource = getResultOfQuery(query);
        }
        public void addClientWithDetails(Tables.Users user, Tables.User_Details user_Details)
        {
            OracleConnection Connection = new OracleConnection(stringConnection);
            OracleCommand cmd = new OracleCommand("AddUser", Connection);
            OracleCommand cmd2 = new OracleCommand("AddUserDetails", Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd2.CommandType = CommandType.StoredProcedure;
            
            //insert user
            cmd.Parameters.Add("UserId_", OracleDbType.NVarchar2).Value = user.UserId;
            cmd.Parameters.Add("Password_", OracleDbType.NVarchar2).Value = user.UserPassword;
            cmd.Parameters.Add("Admin_", OracleDbType.Int16).Value = user.Admin;

            //insert user details
            cmd2.Parameters.Add("UserId_", OracleDbType.NVarchar2).Value = user.UserId;
            cmd2.Parameters.Add("Email_", OracleDbType.NVarchar2).Value = user_Details.Email;
            cmd2.Parameters.Add("FirstName_", OracleDbType.NVarchar2).Value = user_Details.FirstName;
            cmd2.Parameters.Add("LastName_", OracleDbType.NVarchar2).Value = user_Details.LastName;
            cmd2.Parameters.Add("Adresse_", OracleDbType.NVarchar2).Value = user_Details.Adresse;
            cmd2.Parameters.Add("Phone_", OracleDbType.NVarchar2).Value = user_Details.Phone;
            cmd2.Parameters.Add("BrithDay_", OracleDbType.Date).Value = user_Details.BrithDay;

            //try execute the querys
            try
            {
                Connection.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                Connection.Close();
            }catch(OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }    
        }
        public void addCar(Tables.Car car, Tables.CarPictures carPics)
        {
            OracleConnection Connection = new OracleConnection(stringConnection);
            OracleCommand cmd = new OracleCommand("AddCar", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            //insert user
            cmd.Parameters.Add("Matricule_", OracleDbType.NVarchar2).Value =car.Matricule;
            cmd.Parameters.Add("VoitureName_", OracleDbType.NVarchar2).Value =car.VoitureName;
            cmd.Parameters.Add("Color_", OracleDbType.NVarchar2).Value = car.Color;
            cmd.Parameters.Add("Car_Type_", OracleDbType.NVarchar2).Value = car.Type;
            cmd.Parameters.Add("km_", OracleDbType.Int64).Value = car.Km;

            //insert user details

            

            //try execute the querys
            try
            {
                Connection.Open();
                cmd.ExecuteNonQuery();
                foreach (Image pic in carPics.Pics)
                {
                    OracleCommand cmd2 = new OracleCommand("AddCarPictures", Connection);
                    cmd2.CommandType = CommandType.StoredProcedure;

                    cmd2.Parameters.Add("Matricule_", OracleDbType.NVarchar2).Value = carPics.Matricule;
                    cmd2.Parameters.Add("pic_", OracleDbType.Blob).Value = ImageToByteArray(pic);
                    cmd2.ExecuteNonQuery();
                    Thread.Sleep(5000);
                }
                Connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        // cmd.parmetrs.add("user_phone", oracledbtype.type).direction = parameterdirection.output;
        // cmd.parameters["STD_Name"].size = 20;
        //var =  cmd.paraùeters["Std_name"].value;


    }
}
