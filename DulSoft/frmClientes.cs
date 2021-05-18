using DevExpress.XtraEditors;
using DulSoft.BML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DulSoft
{
    public partial class frmClientes : DevExpress.XtraEditors.XtraForm
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMCliente()
            {
                Text = "Nuevo Cliente"
            }.ShowDialog();
            clienteBindingSource.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvClientes.GetFocusedRowCellValue("idCliente") != null)
            {
                new frmNMCliente((int)gvClientes.GetFocusedRowCellValue("idCliente"))
                {
                    Text = "Modificar Cliente (" + (int)gvClientes.GetFocusedRowCellValue("idCliente") + ")"
                }.ShowDialog();
                clienteBindingSource.DataSource = new Cliente().GetAll();
                gvClientes.BestFitColumns();
            }
            else
            {
                XtraMessageBox.Show("No se seleccionó un cliente a modificar", "Ponkosmetic's",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvClientes.FocusedRowHandle >= 0)
                if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar el cliente? \n\n" +
                    "{0}", gvClientes.GetFocusedRowCellValue("nombre")),
                    "Ponkosmetic's", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {

                    if (new Cliente()
                    {
                        idCliente = (int)gvClientes.GetFocusedRowCellValue("idCliente")
                    }.Delete() > 0)
                        XtraMessageBox.Show("Cliente eliminado correctamente", "Ponkosmetic's",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Ocurrió un error al eliminar el cliente. \nVerifique con el deparamento de TI",
                            "Ponkosmetic's", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clienteBindingSource.DataSource = new Cliente().GetAll();
                    gvClientes.BestFitColumns();
                }
            else
                    XtraMessageBox.Show("No se seleccionó un cliente para eliminar",
                    "Ponkosmetic's", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clienteBindingSource.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }
    }
}