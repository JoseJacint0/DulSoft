
namespace DulSoft
{
    partial class frmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnModificar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcEmpleados = new DevExpress.XtraGrid.GridControl();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEmpleados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colapellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coledad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsueldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldomicilio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnActualizar,
            this.btnNuevo,
            this.btnModificar,
            this.btnEliminar});
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnActualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnModificar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Caption = "Actualizar";
            this.btnActualizar.Id = 0;
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.LargeImage")));
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizar_ItemClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.Id = 1;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.LargeImage")));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Caption = "Modificar";
            this.btnModificar.Id = 2;
            this.btnModificar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnModificar.ImageOptions.SvgImage")));
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModificar_ItemClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 3;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.LargeImage")));
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminar_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(798, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 548);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(798, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 524);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(798, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 524);
            // 
            // gcEmpleados
            // 
            this.gcEmpleados.DataSource = this.empleadoBindingSource;
            this.gcEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEmpleados.Location = new System.Drawing.Point(0, 24);
            this.gcEmpleados.MainView = this.gvEmpleados;
            this.gcEmpleados.MenuManager = this.barManager1;
            this.gcEmpleados.Name = "gcEmpleados";
            this.gcEmpleados.Size = new System.Drawing.Size(798, 524);
            this.gcEmpleados.TabIndex = 4;
            this.gcEmpleados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmpleados});
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(DulSoft.BML.Empleado);
            // 
            // gvEmpleados
            // 
            this.gvEmpleados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidEmpleado,
            this.colnombre,
            this.colapellido,
            this.coledad,
            this.colsueldo,
            this.coltelefono,
            this.coldomicilio,
            this.colactivo});
            this.gvEmpleados.GridControl = this.gcEmpleados;
            this.gvEmpleados.Name = "gvEmpleados";
            this.gvEmpleados.OptionsBehavior.Editable = false;
            this.gvEmpleados.OptionsView.ColumnAutoWidth = false;
            this.gvEmpleados.OptionsView.EnableAppearanceEvenRow = true;
            this.gvEmpleados.OptionsView.ShowAutoFilterRow = true;
            this.gvEmpleados.OptionsView.ShowGroupPanel = false;
            // 
            // colidEmpleado
            // 
            this.colidEmpleado.Caption = "ID";
            this.colidEmpleado.FieldName = "idEmpleado";
            this.colidEmpleado.Name = "colidEmpleado";
            this.colidEmpleado.OptionsColumn.AllowEdit = false;
            this.colidEmpleado.OptionsColumn.AllowFocus = false;
            this.colidEmpleado.OptionsColumn.AllowIncrementalSearch = false;
            this.colidEmpleado.OptionsColumn.AllowMove = false;
            this.colidEmpleado.Visible = true;
            this.colidEmpleado.VisibleIndex = 0;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.OptionsColumn.AllowFocus = false;
            this.colnombre.OptionsColumn.AllowIncrementalSearch = false;
            this.colnombre.OptionsColumn.AllowMove = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            // 
            // colapellido
            // 
            this.colapellido.Caption = "Apellido";
            this.colapellido.FieldName = "apellido";
            this.colapellido.Name = "colapellido";
            this.colapellido.OptionsColumn.AllowEdit = false;
            this.colapellido.OptionsColumn.AllowFocus = false;
            this.colapellido.OptionsColumn.AllowIncrementalSearch = false;
            this.colapellido.OptionsColumn.AllowMove = false;
            this.colapellido.Visible = true;
            this.colapellido.VisibleIndex = 2;
            // 
            // coledad
            // 
            this.coledad.Caption = "Edad";
            this.coledad.FieldName = "edad";
            this.coledad.Name = "coledad";
            this.coledad.OptionsColumn.AllowEdit = false;
            this.coledad.OptionsColumn.AllowFocus = false;
            this.coledad.OptionsColumn.AllowIncrementalSearch = false;
            this.coledad.OptionsColumn.AllowMove = false;
            this.coledad.Visible = true;
            this.coledad.VisibleIndex = 3;
            // 
            // colsueldo
            // 
            this.colsueldo.Caption = "Sueldo";
            this.colsueldo.FieldName = "sueldo";
            this.colsueldo.Name = "colsueldo";
            this.colsueldo.OptionsColumn.AllowEdit = false;
            this.colsueldo.OptionsColumn.AllowFocus = false;
            this.colsueldo.OptionsColumn.AllowIncrementalSearch = false;
            this.colsueldo.OptionsColumn.AllowMove = false;
            this.colsueldo.Visible = true;
            this.colsueldo.VisibleIndex = 4;
            // 
            // coltelefono
            // 
            this.coltelefono.Caption = "Teléfono";
            this.coltelefono.FieldName = "telefono";
            this.coltelefono.Name = "coltelefono";
            this.coltelefono.OptionsColumn.AllowEdit = false;
            this.coltelefono.OptionsColumn.AllowFocus = false;
            this.coltelefono.OptionsColumn.AllowIncrementalSearch = false;
            this.coltelefono.OptionsColumn.AllowMove = false;
            this.coltelefono.Visible = true;
            this.coltelefono.VisibleIndex = 5;
            // 
            // coldomicilio
            // 
            this.coldomicilio.Caption = "Domicilio";
            this.coldomicilio.FieldName = "domicilio";
            this.coldomicilio.Name = "coldomicilio";
            this.coldomicilio.OptionsColumn.AllowEdit = false;
            this.coldomicilio.OptionsColumn.AllowFocus = false;
            this.coldomicilio.OptionsColumn.AllowIncrementalSearch = false;
            this.coldomicilio.OptionsColumn.AllowMove = false;
            this.coldomicilio.Visible = true;
            this.coldomicilio.VisibleIndex = 6;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.Name = "colactivo";
            this.colactivo.OptionsColumn.AllowEdit = false;
            this.colactivo.OptionsColumn.AllowFocus = false;
            this.colactivo.OptionsColumn.AllowIncrementalSearch = false;
            this.colactivo.OptionsColumn.AllowMove = false;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 568);
            this.Controls.Add(this.gcEmpleados);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = global::DulSoft.Properties.Resources.empleado;
            this.Name = "frmEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnModificar;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcEmpleados;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmpleados;
        private DevExpress.XtraGrid.Columns.GridColumn colidEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colapellido;
        private DevExpress.XtraGrid.Columns.GridColumn coledad;
        private DevExpress.XtraGrid.Columns.GridColumn colsueldo;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono;
        private DevExpress.XtraGrid.Columns.GridColumn coldomicilio;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
    }
}