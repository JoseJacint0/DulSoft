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
    public partial class frmProductos : DevExpress.XtraEditors.XtraForm
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void gcProductos_Click(object sender, EventArgs e)
        {

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            productoBindingSource.DataSource = new Producto().GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMProducto()
            {
                Text = "Nuevo Producto"
            }.ShowDialog();
            productoBindingSource.DataSource = new Producto().GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvProductos.GetFocusedRowCellValue("idProducto") != null)
            {
                new frmNMProducto((int)gvProductos.GetFocusedRowCellValue("idProducto"))
                {
                    Text = "Modificar Producto (" + (int)gvProductos.GetFocusedRowCellValue("idProducto") + ")"
                }.ShowDialog();
                productoBindingSource.DataSource = new Producto().GetAll();
                gvProductos.BestFitColumns();
            }
            else
            {
                XtraMessageBox.Show("No se seleccionó un producto a modificar", "Ponkosmetic's",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvProductos.FocusedRowHandle >= 0)
                if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar el producto? \n\n" +
                    "{0}", gvProductos.GetFocusedRowCellValue("descripcion")),
                    "Ponkosmetic's", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {

                    if (new Producto()
                    {
                        idProducto = (int)gvProductos.GetFocusedRowCellValue("idProducto")
                    }.Delete() > 0)
                        XtraMessageBox.Show("Producto eliminado correctamente", "Ponkosmetic's",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Ocurrió un error al eliminar el producto. \nVerifique con el deparamento de TI",
                            "Ponkosmetic's", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    productoBindingSource.DataSource = new Producto().GetAll();
                    gvProductos.BestFitColumns();
                }
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            productoBindingSource.DataSource = new Producto().GetAll();
            gvProductos.BestFitColumns();
        }
    }
}