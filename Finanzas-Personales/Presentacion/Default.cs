using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();
        }

        private void btnAgregarMovimento_Click(object sender, EventArgs e)
        {
            frmAgregarMovimiento ventana= new frmAgregarMovimiento();
            ventana.ShowDialog();
        }
    }
}
