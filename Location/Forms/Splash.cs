using System;
using System.Windows.Forms;

namespace Location.Forms
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void modify_client_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void modify_car_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Show();
        }

        private void modify_contrat_Click(object sender, EventArgs e)
        {
            Contrat contrat = new Contrat();
            contrat.Show();
        }

        private void add_client_Click(object sender, EventArgs e)
        {
            ClientDetails clientDetails = new ClientDetails();
            clientDetails.Show();
        }

        private void add_car_Click(object sender, EventArgs e)
        {
            CarDetails carDetails = new CarDetails();
            carDetails.Show();
        }

        private void add_contrat_Click(object sender, EventArgs e)
        {
            ContratDetails contratDetails = new ContratDetails();
            contratDetails.Show();
        }
    }
}
