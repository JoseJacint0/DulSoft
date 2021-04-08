﻿using DevExpress.XtraEditors;
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
    public partial class frmNMEmpleado : DevExpress.XtraEditors.XtraForm
    {
        private Empleado empleado;
        //cuando es nuevo empleado
        public frmNMEmpleado()
        {
            InitializeComponent();
        }

        //cuando es modificar el empleado
        public frmNMEmpleado(int idEmpleado)
        {
            InitializeComponent();
            empleado = new Empleado
            {
                idEmpleado = idEmpleado
            }.GetById();
            txtID.Text = empleado.idEmpleado.ToString();
            txtNombre.Text = empleado.nombre;
            txtApellido.Text = empleado.apellido;
            txtEdad.Text = empleado.edad.ToString();
            txtSueldo.Text = empleado.sueldo.ToString();
            txtTelefono.Text = empleado.telefono;
            txtDomicilio.Text = empleado.domicilio;
        }

        private void frmNMEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (empleado == null)
                {
                    if (new Empleado
                    {
                        nombre = txtNombre.Text,
                        apellido = txtApellido.Text,
                        edad = Convert.ToInt32(txtEdad.Text),
                        sueldo = Convert.ToDecimal(txtSueldo.Text),
                        telefono = txtTelefono.Text,
                        domicilio = txtDomicilio.Text
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Empleado insertado correctamente", Application.ProductName, MessageBoxButtons.OK,
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
                    empleado.nombre = txtNombre.Text;
                    empleado.apellido = txtApellido.Text;
                    empleado.edad = Convert.ToInt32(txtEdad.Text);
                    empleado.sueldo = Convert.ToDecimal(txtSueldo.Text);
                    empleado.telefono = txtTelefono.Text;
                    empleado.domicilio = txtDomicilio.Text;
                    if (empleado.Update() > 0)
                    {
                        XtraMessageBox.Show("Empleado modificado correctamente", Application.ProductName, MessageBoxButtons.OK,
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
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                txtApellido.ErrorText = "Ingresa un apellido";
                if (!ban)
                {
                    txtApellido.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtEdad.Text))
            {
                txtEdad.ErrorText = "Ingresa una edad";
                if (!ban)
                {
                    txtEdad.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtSueldo.Text))
            {
                txtSueldo.ErrorText = "Ingresa un sueldo";
                if (!ban)
                {
                    txtSueldo.Focus();
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
            if (string.IsNullOrEmpty(txtDomicilio.Text))
            {
                txtDomicilio.ErrorText = "Ingresa un domicilio";
                if (!ban)
                {
                    txtDomicilio.Focus();
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