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
    public partial class frmPagos : DevExpress.XtraEditors.XtraForm
    {
        public frmPagos()
        {
            InitializeComponent();
        }

        private void frmPagos_Load(object sender, EventArgs e)
        {
            formaPagoBindingSource.DataSource = new FormaPago().GetAll();
            Clean();
            txtTotalPago.EditValue = Misc.totalPago;
            txtPago.EditValue = Misc.totalPago;
            txtCambio.EditValue = 0;
        }

        private void Clean()
        {
            txtTotalPago.EditValue = null;
            txtPago.EditValue = null;
            txtCambio.EditValue = null;
            lupFormaPago.EditValue = 1;
        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                if (txtPago.EditValue != null)
                    if (Convert.ToDecimal(txtPago.EditValue) >= Misc.totalPago)
                    {
                        txtCambio.EditValue = (Misc.totalPago - Convert.ToDecimal(txtPago.EditValue)) * -1;
                        btnRegistrarVenta.Focus();
                    }
        }

        private void lupFormaPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                if (lupFormaPago.EditValue != null)
                    txtPago.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (lupFormaPago.EditValue == null)
                return;
            Misc.pago = Convert.ToDecimal(txtPago.EditValue);
            Misc.idFPago = Convert.ToInt32(lupFormaPago.EditValue);
            txtCambio.EditValue = (Misc.totalPago - Misc.pago) * -1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}