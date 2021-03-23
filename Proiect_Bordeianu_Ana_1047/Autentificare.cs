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
    public partial class Autentificare : Form
    {
        public Autentificare()
        {
            InitializeComponent();
            userControl11.ConnString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Companie.accdb";
            userControl11.Tabela = "utilizatori";
        }

      
    }
}
