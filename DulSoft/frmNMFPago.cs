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
    public partial class frmNMFPago : DevExpress.XtraEditors.XtraForm
    {
        private FormaPago formapago;
        //cuando es nueva Forma de Pago
        public frmNMFPago()
        {
            InitializeComponent();
        }

        //cuando es modificar la forma de pago
        public frmNMFPago(int idFPago)
        {
            InitializeComponent();
            formapago = new FormaPago
            {
                idFPago = idFPago
            }.GetById();
            txtID.Text = formapago.idFPago.ToString();
            txtDescripcion.Text = formapago.descripcion;

        }

        private void frmNMFPago_Load(object sender, EventArgs e)
        {
            Misc.actualiza = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (formapago == null)
                {
                    if (new FormaPago
                    {
                        descripcion = txtDescripcion.Text
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Forma de pago insertada correctamente", "Ponkosmetic's", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        Misc.actualiza = true;
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrió un error en la inserción", "Ponkosmetic's", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                        Misc.actualiza = false;
                    }
                    this.Close();
                }
                else
                {
                    formapago.descripcion = txtDescripcion.Text;
                    if (formapago.Update() > 0)
                    {
                        XtraMessageBox.Show("Forma de pago modificada correctamente", "Ponkosmetic's", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        Misc.actualiza = true;
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrió un error en la modificación", "Ponkosmetic's", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        Misc.actualiza = false;
                    }
                    this.Close();
                }
            }
        }

        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                txtDescripcion.ErrorText = "Ingresa la descripción";
                txtDescripcion.Focus();
                ban = true;
            }

            return !ban;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnGuardar_Click(null, null);
            }
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                btnCancelar_Click(null, null);
            }
            Misc.actualiza = false;
        }

        private void frmNMFPago_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Misc.actualiza == false)
                if (XtraMessageBox.Show("¿Deseas cerrar esta pantalla?", "Ponkosmetic's",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
        }
    }
}