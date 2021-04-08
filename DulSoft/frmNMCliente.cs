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
    public partial class frmNMCliente : DevExpress.XtraEditors.XtraForm
    {
        private Cliente cliente;
        //cuando es nuevo cliente
        public frmNMCliente()
        {
            InitializeComponent();
        }

        //cuando es modificar el cliente
        public frmNMCliente(int idCliente)
        {
            InitializeComponent();
            cliente = new Cliente
            {
                idCliente = idCliente
            }.GetById();
            txtID.Text = cliente.idCliente.ToString();
            txtNombre.Text = cliente.nombre;
            txtRazonS.Text = cliente.razonSocial;
            txtTelefono.Text = cliente.telefono;
            txtDescuento.Text = cliente.descuento.ToString();

        }

        private void frmNMCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (cliente == null)
                {
                    if (new Cliente
                    {
                        nombre = txtNombre.Text,
                        razonSocial = txtRazonS.Text,
                        telefono = txtTelefono.Text,
                        descuento = Convert.ToDecimal(txtDescuento.Text)
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Cliente insertado correctamente", Application.ProductName, MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error en la inserción", Application.ProductName, MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    cliente.nombre = txtNombre.Text;
                    cliente.razonSocial = txtRazonS.Text;
                    cliente.telefono = txtTelefono.Text;
                    cliente.descuento = Convert.ToDecimal(txtDescuento.Text);
                    if (cliente.Update() > 0)
                    {
                        XtraMessageBox.Show("Cliente modificado correctamente", Application.ProductName, MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error en la modificación", Application.ProductName, MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

        }

        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.ErrorText = "Ingresa el nombre";
                txtNombre.Focus();
                ban = true;
            }
            if (string.IsNullOrEmpty(txtRazonS.Text))
            {
                txtRazonS.ErrorText = "Ingresa una razón social";
                if (!ban)
                {
                    txtRazonS.Focus();
                    ban = true;
                }
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
            if (string.IsNullOrEmpty(txtDescuento.Text))
            {
                txtDescuento.ErrorText = "Ingresa un descuento";
                if (!ban)
                {
                    txtDescuento.Focus();
                    ban = true;
                }
            }


            return !ban;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}