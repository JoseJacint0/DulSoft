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
    public partial class frmNVenta : DevExpress.XtraEditors.XtraForm
    {
        public frmNVenta()
        {
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Inicializando nueva venta ...");
            InitializeComponent();
        }

        private void frmNVenta_Load(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = new Cliente().GetAll();
        }
    }
}