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
    public partial class frmNMProducto : DevExpress.XtraEditors.XtraForm
    {
        private Producto producto;
        //cuando es nuevo producto
        public frmNMProducto()
        {
            InitializeComponent();
        }

        //cuando es modificar el producto
        public frmNMProducto(int idProducto)
        {
            InitializeComponent();
            producto = new Producto
            {
                idProducto = idProducto
            }.GetById();
            txtID.Text = producto.idProducto.ToString();
            txtDescripcion.Text = producto.descripcion;
            txtUnidadM.Text = producto.unidadMedida;
            txtCodigo.Text = producto.codigo;
            txtPrecio.Text = producto.precio.ToString();
            txtStock.Text = producto.stock.ToString();
            txtMarca.Text = producto.marca;
        }

        private void frmNMProducto_Load(object sender, EventArgs e)
        {
            Misc.actualiza = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (producto == null)
                {
                    if (new Producto
                    {
                        descripcion = txtDescripcion.Text,
                        unidadMedida = txtUnidadM.Text,
                        codigo = txtCodigo.Text,
                        precio = Convert.ToDecimal(txtPrecio.Text),
                        stock = Convert.ToInt32(txtStock.Text),
                        marca = txtMarca.Text
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Producto insertado correctamente", "Ponkosmetic's", MessageBoxButtons.OK,
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
                    producto.descripcion = txtDescripcion.Text;
                    producto.unidadMedida = txtUnidadM.Text;
                    producto.codigo = txtCodigo.Text;
                    producto.precio = Convert.ToDecimal(txtPrecio.Text);
                    producto.stock = Convert.ToInt32(txtStock.Text);
                    producto.marca = txtMarca.Text;
                    if (producto.Update() > 0)
                    {
                        XtraMessageBox.Show("Producto modificado correctamente", "Ponkosmetic's", MessageBoxButtons.OK,
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
                txtDescripcion.ErrorText = "Ingresa una descripción";
                txtDescripcion.Focus();
                ban = true;
            }
            if (string.IsNullOrEmpty(txtUnidadM.Text))
            {
                txtUnidadM.ErrorText = "Ingresa una unidad de medida";
                if (!ban)
                {
                    txtUnidadM.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                txtCodigo.ErrorText = "Ingresa un código";
                if (!ban)
                {
                    txtCodigo.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                txtPrecio.ErrorText = "Ingresa un precio";
                if (!ban)
                {
                    txtPrecio.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtStock.Text))
            {
                txtStock.ErrorText = "Ingresa un stock";
                if (!ban)
                {
                    txtStock.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                txtMarca.ErrorText = "Ingresa una marca";
                if (!ban)
                {
                    txtMarca.Focus();
                    ban = true;
                }

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

        private void txtUnidadM_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmNMProducto_FormClosing(object sender, FormClosingEventArgs e)
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