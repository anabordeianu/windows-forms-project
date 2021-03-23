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
    public partial class Form1 : Form
    {
        List<Client> listaClienti = new List<Client>();
        public Form1()
        {
            InitializeComponent();
        }

        private void vizualizareClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VeziClienti veziClienti = new VeziClienti();
            veziClienti.Show();
        }

        private void adaugaClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugaClienti adaugaClient = new AdaugaClienti();
            adaugaClient.Show();
        }

        private void adaugaFurnizorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugaFurnizor adaugaFurnizor = new AdaugaFurnizor();
            adaugaFurnizor.Show();
        }

        private void vizualizareFurnizoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VeziFurnizori veziFurnizori = new VeziFurnizori();
            veziFurnizori.Show();
        }

        private void adaugaProdusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugaProdus adaugaProdus = new AdaugaProdus();
            adaugaProdus.Show();
        }

        private void vizualizareProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VeziProduse veziProduse = new VeziProduse();
            veziProduse.Show();
        }

     
        private void facturiVechiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VeziFacturi veziFacturi = new VeziFacturi();
            veziFacturi.Show();
        }

        private void evoluțieComenziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValoriComenzi evolutieComenzi = new ValoriComenzi();
            evolutieComenzi.Show();

        }

        private void adaugareFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugareFactura adaugareFactura = new AdaugareFactura();
            adaugareFactura.Show();
        }
    }
}
