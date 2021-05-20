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
    public partial class frmNMProveedor : DevExpress.XtraEditors.XtraForm
    {
        private Proveedor proveedor;
        //cuando es nuevo proveedor
        public frmNMProveedor()
        {
            InitializeComponent();
        }

        //cuando es modificar el proveedor
        public frmNMProveedor(int idProveedor)
        {
            InitializeComponent();
            proveedor = new Proveedor
            {
                idProveedor = idProveedor
            }.GetById();
            txtID.Text = proveedor.idProveedor.ToString();
            txtNombre.Text = proveedor.nombre;
            txtTelefono.Text = proveedor.telefono;

        }

        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.ErrorText = "Ingresa un nombre";
                txtNombre.Focus();
                ban = true;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                txtTelefono.ErrorText = "Ingresa un teléfono";
                if (!ban)
                {
                    txtTelefono.Focus();
                    ban = true;
                }
            }


            return !ban;
        }

        private void frmNMProveedor_Load(object sender, EventArgs e)
        {
            Misc.actualiza = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (proveedor == null)
                {
                    if (new Proveedor
                    {
                        nombre = txtNombre.Text,
                        telefono = txtTelefono.Text,
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Proveedor insertado correctamente", "Ponkosmetic's", MessageBoxButtons.OK,
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
                    proveedor.nombre = txtNombre.Text;
                    proveedor.telefono = txtTelefono.Text;
                    if (proveedor.Update() > 0)
                    {
                        XtraMessageBox.Show("Proveedor modificado correctamente", "Ponkosmetic's", MessageBoxButtons.OK,
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmNMProveedor_FormClosing(object sender, FormClosingEventArgs e)
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