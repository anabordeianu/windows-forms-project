using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proiect_Bordeianu_Ana_1047
{
    public partial class AdaugareFactura : Form
    {
        string connString;
        public AdaugareFactura()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Companie.accdb";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 acasa = new Form1();
            acasa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VeziFacturi veziFacturi = new VeziFacturi();
            veziFacturi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "INSERT INTO FACTURI VALUES(?, ?, ?, ?)";
                comanda.Parameters.Add("CODFactura", OleDbType.Integer).Value = Convert.ToInt32(tbCod.Text);
                comanda.Parameters.Add("IDClient", OleDbType.Char, 20).Value = Convert.ToInt32(tbId.Text);
                comanda.Parameters.Add("NumarProduse", OleDbType.Integer).Value = Convert.ToInt32(tbNrP.Text);
                comanda.Parameters.Add("Valoare", OleDbType.Integer).Value = Convert.ToInt32(tbVal.Text); ;
                comanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                tbCod.Clear();
                tbId.Clear();
                tbNrP.Clear();
                tbVal.Clear();
            }
        }
    }
}
