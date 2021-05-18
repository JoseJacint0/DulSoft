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
    public partial class frmVentas : DevExpress.XtraEditors.XtraForm
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNVenta().ShowDialog();
            ventaBindingSource.DataSource = new Venta().GetAll();
            gvVentas.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ventaBindingSource.DataSource = new Venta().GetAll();
            gvVentas.BestFitColumns();
        }

        private void btnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvVentas.FocusedRowHandle >= 0)
                if (XtraMessageBox.Show(string.Format("¿Está seguro de cancelar la venta? \n\n" +
                    "{0}", gvVentas.GetFocusedRowCellValue("idVenta")),
                    "Ponkosmetic's", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {

                    if (new Venta()
                    {
                        idVenta = (int)gvVentas.GetFocusedRowCellValue("idVenta")
                    }.Delete() > 0)
                        XtraMessageBox.Show("Venta cancelada correctamente", "Ponkosmetic's",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Ocurrió un error al cancelar la venta. \nVerifique con el deparamento de TI",
                            "Ponkosmetic's", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ventaBindingSource.DataSource = new Venta().GetAll();
                    gvVentas.BestFitColumns();
                }
        }
    }
}