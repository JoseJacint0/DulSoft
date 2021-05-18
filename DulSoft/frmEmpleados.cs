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
    public partial class frmEmpleados : DevExpress.XtraEditors.XtraForm
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            empleadoBindingSource.DataSource = new Empleado().GetAll();
            gvEmpleados.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMEmpleado()
            {
                Text = "Nuevo Empleado"
            }.ShowDialog();
            empleadoBindingSource.DataSource = new Empleado().GetAll();
            gvEmpleados.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvEmpleados.GetFocusedRowCellValue("idEmpleado") != null)
            {
                new frmNMEmpleado((int)gvEmpleados.GetFocusedRowCellValue("idEmpleado"))
                {
                    Text = "Modificar Empleado (" + (int)gvEmpleados.GetFocusedRowCellValue("idEmpleado") + ")"
                }.ShowDialog();
                empleadoBindingSource.DataSource = new Empleado().GetAll();
                gvEmpleados.BestFitColumns();
            }
            else
            {
                XtraMessageBox.Show("No se seleccionó un empleado a modificar", "Ponkosmetic's",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvEmpleados.FocusedRowHandle >= 0)
                if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar el empleado? \n\n" +
                    "{0}", gvEmpleados.GetFocusedRowCellValue("nombre")),
                    "Ponkosmetic's", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {

                    if (new Empleado()
                    {
                        idEmpleado = (int)gvEmpleados.GetFocusedRowCellValue("idEmpleado")
                    }.Delete() > 0)
                        XtraMessageBox.Show("Empleado eliminado correctamente", "Ponkosmetic's",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Ocurrió un error al eliminar el empleado. \nVerifique con el deparamento de TI",
                            "Ponkosmetic's", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    empleadoBindingSource.DataSource = new Empleado().GetAll();
                    gvEmpleados.BestFitColumns();
                }
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            empleadoBindingSource.DataSource = new Empleado().GetAll();
            gvEmpleados.BestFitColumns();
        }
    }
}