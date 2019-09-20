using Location.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Location.Forms
{
    public partial class CarDetails : Form
    {
        char type_car;
        public CarDetails()
        {
            InitializeComponent();

        }

        private void add_images_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dialog.Multiselect = true;
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Selectioner les images de cette voiture";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string[] files = dialog.FileNames;
                int x = 20, y = 20, maxHeight = -1;

                foreach(string file in files)
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(file);
                    pic.Location = new Point(x, y);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    x += pic.Width + 10 ;
                    maxHeight = Math.Max(pic.Height, maxHeight);
                    if(x > this.ClientSize.Width - 100)
                    {
                        x = 20;
                        y += maxHeight + 5;
                    }
                    this.panel_car_pics.Controls.Add(pic);
                }
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            List<Image> pics = new List<Image>();
            foreach(PictureBox pic in panel_car_pics.Controls)
            {
                pics.Add(pic.Image);
            }
            //test if the fields is not null
            OracleDataBase db = new OracleDataBase();
            Tables.Car car = new Tables.Car(txb_matricule.Text, txb_name.Text, txb_color.Text, type_car, Convert.ToDouble(txb_km.Text));
            Tables.CarPictures carPictures = new Tables.CarPictures(txb_matricule.Text, pics);
            db.addCar(car, carPictures);
            //add client if note exist else update with comfirmation msg
            //get user detail by id for modify
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            type_car = 'D';
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            type_car = 'E';
        }
    }
}
