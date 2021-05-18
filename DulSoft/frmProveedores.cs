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
    public partial class frmProveedores : DevExpress.XtraEditors.XtraForm
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvProveedores.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMProveedor()
            {
                Text = "Nuevo Proveedor"
            }.ShowDialog();
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvProveedores.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvProveedores.GetFocusedRowCellValue("idProveedores") != null)
            {
                new frmNMProveedor((int)gvProveedores.GetFocusedRowCellValue("idProveedor"))
                {
                    Text = "Modificar Proveedor (" + (int)gvProveedores.GetFocusedRowCellValue("idProveedor") + ")"
                }.ShowDialog();
                proveedorBindingSource.DataSource = new Proveedor().GetAll();
                gvProveedores.BestFitColumns();
            }
            else
            {
                XtraMessageBox.Show("No se seleccionó un proveedor a modificar", "Ponkosmetic's",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvProveedores.FocusedRowHandle >= 0)
                if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar el proveedor? \n\n" +
                    "{0}", gvProveedores.GetFocusedRowCellValue("nombre")),
                    "Ponkosmetic's", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {

                    if (new Proveedor()
                    {
                        idProveedor = (int)gvProveedores.GetFocusedRowCellValue("idProveedor")
                    }.Delete() > 0)
                        XtraMessageBox.Show("Proveedor eliminado correctamente", "Ponkosmetic's",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Ocurrió un error al eliminar el proveedor. \nVerifique con el deparamento de TI",
                            "Ponkosmetic's", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    proveedorBindingSource.DataSource = new Proveedor().GetAll();
                    gvProveedores.BestFitColumns();
                }
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvProveedores.BestFitColumns();
        }
    }
}