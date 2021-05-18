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
    public partial class frmFormasPago : DevExpress.XtraEditors.XtraForm
    {
        public frmFormasPago()
        {
            InitializeComponent();
        }

        private void frmFormasPago_Load(object sender, EventArgs e)
        {
            formaPagoBindingSource.DataSource = new FormaPago().GetAll();
            gvFormasPago.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMFPago()
            {
                Text = "Nueva Forma de Pago"
            }.ShowDialog();
            formaPagoBindingSource.DataSource = new FormaPago().GetAll();
            gvFormasPago.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvFormasPago.GetFocusedRowCellValue("idFPago") != null)
            {
                new frmNMFPago((int)gvFormasPago.GetFocusedRowCellValue("idFPago"))
                {
                    Text = "Modificar Forma de Pago (" + (int)gvFormasPago.GetFocusedRowCellValue("idFPago") + ")"
                }.ShowDialog();
                formaPagoBindingSource.DataSource = new FormaPago().GetAll();
                gvFormasPago.BestFitColumns();
            }
            else
            {
                XtraMessageBox.Show("No se seleccionó una forma de pago a modificar", "Ponkosmetic's",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvFormasPago.FocusedRowHandle >= 0)
                if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar la forma de pago? \n\n" +
                    "{0}", gvFormasPago.GetFocusedRowCellValue("descripcion")),
                    "Ponkosmetic's", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {

                    if (new FormaPago()
                    {
                        idFPago = (int)gvFormasPago.GetFocusedRowCellValue("idFPago")
                    }.Delete() > 0)
                        XtraMessageBox.Show("Forma de pago eliminada correctamente", "Ponkosmetic's",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Ocurrió un error al eliminar la forma de pago. \nVerifique con el deparamento de TI",
                            "Ponkosmetic's", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    formaPagoBindingSource.DataSource = new FormaPago().GetAll();
                    gvFormasPago.BestFitColumns();
                }
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formaPagoBindingSource.DataSource = new FormaPago().GetAll();
            gvFormasPago.BestFitColumns();
        }

        
    }
}