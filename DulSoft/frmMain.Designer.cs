
namespace DulSoft
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.mnArchivo = new DevExpress.XtraBars.BarSubItem();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.mnCatalogos = new DevExpress.XtraBars.BarSubItem();
            this.btnClientes = new DevExpress.XtraBars.BarButtonItem();
            this.btnEmpleados = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductos = new DevExpress.XtraBars.BarButtonItem();
            this.btnProveedores = new DevExpress.XtraBars.BarButtonItem();
            this.mnApariencia = new DevExpress.XtraBars.SkinBarSubItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tabMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mnArchivo,
            this.btnSalir,
            this.mnCatalogos,
            this.btnClientes,
            this.btnEmpleados,
            this.btnProductos,
            this.btnProveedores,
            this.mnApariencia});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnArchivo),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnCatalogos),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnApariencia)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // mnArchivo
            // 
            this.mnArchivo.Caption = "Archivo";
            this.mnArchivo.Id = 0;
            this.mnArchivo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalir)});
            this.mnArchivo.Name = "mnArchivo";
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 1;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // mnCatalogos
            // 
            this.mnCatalogos.Caption = "Catálogos";
            this.mnCatalogos.Id = 2;
            this.mnCatalogos.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClientes),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEmpleados),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnProductos),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnProveedores)});
            this.mnCatalogos.Name = "mnCatalogos";
            // 
            // btnClientes
            // 
            this.btnClientes.Caption = "Clientes";
            this.btnClientes.Id = 3;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClientes_ItemClick);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Caption = "Empleados";
            this.btnEmpleados.Id = 4;
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEmpleados_ItemClick);
            // 
            // btnProductos
            // 
            this.btnProductos.Caption = "Productos";
            this.btnProductos.Id = 5;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductos_ItemClick);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Caption = "Proveedores";
            this.btnProveedores.Id = 6;
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProveedores_ItemClick);
            // 
            // mnApariencia
            // 
            this.mnApariencia.Caption = "Apariencia";
            this.mnApariencia.Id = 7;
            this.mnApariencia.Name = "mnApariencia";
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(702, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 347);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(702, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 322);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(702, 25);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 322);
            // 
            // tabMdiManager
            // 
            this.tabMdiManager.MdiParent = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 368);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = global::DulSoft.Properties.Resources.productos_cosmeticos;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ponkosmetic\'s";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem mnArchivo;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarSubItem mnCatalogos;
        private DevExpress.XtraBars.BarButtonItem btnClientes;
        private DevExpress.XtraBars.BarButtonItem btnEmpleados;
        private DevExpress.XtraBars.BarButtonItem btnProductos;
        private DevExpress.XtraBars.BarButtonItem btnProveedores;
        private DevExpress.XtraBars.SkinBarSubItem mnApariencia;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager tabMdiManager;
    }
}