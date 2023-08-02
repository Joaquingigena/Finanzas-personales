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
            CategoriaNegocio negocioCategoria = new CategoriaNegocio();
            CuentaNegocio negocioCuenta = new CuentaNegocio();

            cboCategoria.DataSource = negocioCategoria.listar();
            cboCuenta.DataSource = negocioCuenta.listar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //      public int Id { get; set; }
            //public Cuenta Cuenta { get; set; }
            //public Tipo Tipo { get; set; }
            //public Categoria Categoria { get; set; }
            //public DateTime Fecha { get; set; }
            //public string Descripcion { get; set; }
            //public decimal Monto { get; set; }
            //public bool Activo { get; set; }
            AccesoDatos datos = new AccesoDatos();
            MovimientoNegocio negocio=new MovimientoNegocio();

            try
            {
                Movimiento movimiento = new Movimiento();
                movimiento.Tipo= new Tipo();

                if (rdbIngreso.Checked)
                {
                    movimiento.Tipo.Id=1;
                }
                else
                {
                    movimiento.Tipo.Id=2;
                }
                movimiento.Cuenta = (Cuenta)cboCuenta.SelectedItem;
                movimiento.Categoria = (Categoria)cboCategoria.SelectedItem;
                movimiento.Monto = decimal.Parse(txtMonto.Text);
                movimiento.Descripcion = txtDecripcion.Text;
                movimiento.Fecha = DateTime.Parse(dtpFecha.Text);

                negocio.agregar(movimiento);

                MessageBox.Show("Movimiento agregado exitosamente.");

                this.Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

            }
        }

    }
}
