using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnProductos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmProductos))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Productos ...");
            new frmProductos() { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmClientes))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Clientes ...");
            new frmClientes() { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnProveedores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmProveedores))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Proveedores ...");
            new frmProveedores() { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnEmpleados_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmEmpleados))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Empleados ...");
            new frmEmpleados() { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (XtraMessageBox.Show(string.Format("¿Está seguro de cerrar? \n\n"),
                     "Ponkosmetic's", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                     DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Misc.actualiza = false;
        }

        

        private void btnAdministrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmVentas))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Ventas ...");
            new frmVentas() { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            //if (Misc.actualiza == false)
            //    if (XtraMessageBox.Show("¿Deseas cerrar esta pantalla?", "Ponkosmetic's",
            //        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //    {
            //        e.Cancel = true;
            //        return;
            //    }
        }

        private void btnFormasPago_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmFormasPago))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Formas de Pago ...");
            new frmFormasPago() { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }
    }
}