using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Bordeianu_Ana_1047
{
    public partial class AdaugaClienti : Form
    {
       List<Client> listaClienti1 = new List<Client>();
        public AdaugaClienti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idClient = Convert.ToInt32(tbIdClient.Text);
                string numeClient = tbNume.Text;
                string nrTelefonClient = tbTelefon.Text;
                string adresaClient = tbAdresa.Text;
                Client c = new Client(idClient, numeClient, nrTelefonClient, adresaClient);
                listaClienti1.Add(c);
                MessageBox.Show("Client adaugat cu succes!");
                functiaMea(this, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                functiaMea(this, e);
            }
        }

        private void functiaMea(object sender, EventArgs e)
        {
            tbIdClient.Clear();
            tbNume.Clear();
            tbTelefon.Clear();
            tbAdresa.Clear();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            VeziClienti veziClienti = new VeziClienti(listaClienti1);
            veziClienti.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 acasa = new Form1();
            acasa.Show();
        }
    }
}
