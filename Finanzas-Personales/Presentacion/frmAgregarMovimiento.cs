using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class frmAgregarMovimiento : Form
    {
        public frmAgregarMovimiento()
        {
            InitializeComponent();



        }
        private void frmAgregarMovimiento_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio=new CategoriaNegocio();
            cboCategoria.DataSource = negocio.listar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
        //      public int Id { get; set; }
        //public Tipo Tipo { get; set; }
        //public Categoria Categoria { get; set; }
        //public DateTime Fecha { get; set; }
        //public string Descripcion { get; set; }
        //public decimal Monto { get; set; }
        //public bool Activo { get; set; }
            AccesoDatos datos = new AccesoDatos();
            Movimiento movimiento= new Movimiento();
            try
            {
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { 
            
            }
        }

    }
}
