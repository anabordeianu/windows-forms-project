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
    public partial class AdaugaProdus : Form
    {
        List<Produs> listaProduse = new List<Produs>();
        public AdaugaProdus()
        {
            InitializeComponent();
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
                float pret = Convert.ToInt64(tbPret.Text);
                int cod = Convert.ToInt32(tbCodProdus.Text);
                Produs p = new Produs(pret, nume, cod, id);
                listaProduse.Add(p);
                MessageBox.Show("Produs adaugat cu succes!");
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
            tbCodProdus.Clear();
            tbPret.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VeziProduse veziProduse = new VeziProduse(listaProduse);
            veziProduse.Show();
        }
    }
}
