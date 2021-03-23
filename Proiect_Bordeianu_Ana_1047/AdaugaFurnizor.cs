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
    public partial class AdaugaFurnizor : Form
    {
        List<Furnizor> listaFurnizori = new List<Furnizor>();
        public AdaugaFurnizor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VeziFurnizori veziFurnizori = new VeziFurnizori(listaFurnizori);
            veziFurnizori.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 acasa = new Form1();
            acasa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tbIdFurnizor.Text);
                string nume = tbNume.Text;
                string nrTelefon = tbTelefon.Text;
                string adresa = tbAdresa.Text;
                Furnizor f = new Furnizor(id, nume, nrTelefon, adresa);
                listaFurnizori.Add(f);
                MessageBox.Show("Furnizor adaugat cu succes!");
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
            tbIdFurnizor.Clear();
            tbNume.Clear();
            tbTelefon.Clear();
            tbAdresa.Clear();
        }

    }
}
