
namespace DulSoft
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnImprimirTicket = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.gcVentas = new DevExpress.XtraGrid.GridControl();
            this.gvVentas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnImprimirRemision = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
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
            this.btnImprimirTicket,
            this.btnCancelar,
            this.btnImprimirRemision});
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
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
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnActualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnImprimirTicket, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnImprimirRemision, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancelar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Caption = "Actualizar";
            this.btnActualizar.Id = 0;
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnActualizar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizar_ItemClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.Id = 1;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.btnNuevo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnImprimirTicket
            // 
            this.btnImprimirTicket.Caption = "Imprimir Ticket";
            this.btnImprimirTicket.Id = 2;
            this.btnImprimirTicket.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.btnImprimirTicket.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.btnImprimirTicket.Name = "btnImprimirTicket";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Caption = "Cancelar";
            this.btnCancelar.Id = 3;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.btnCancelar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelar_ItemClick);
            // 
            // gcVentas
            // 
            this.gcVentas.DataSource = this.ventaBindingSource;
            this.gcVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVentas.Location = new System.Drawing.Point(0, 24);
            this.gcVentas.MainView = this.gvVentas;
            this.gcVentas.MenuManager = this.barManager1;
            this.gcVentas.Name = "gcVentas";
            this.gcVentas.Size = new System.Drawing.Size(798, 524);
            this.gcVentas.TabIndex = 8;
            this.gcVentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVentas});
            // 
            // gvVentas
            // 
            this.gvVentas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidVenta,
            this.colidCliente,
            this.colfecha,
            this.colcantidad,
            this.colimporte,
            this.colstatus});
            this.gvVentas.GridControl = this.gcVentas;
            this.gvVentas.Name = "gvVentas";
            this.gvVentas.OptionsBehavior.Editable = false;
            this.gvVentas.OptionsView.ColumnAutoWidth = false;
            this.gvVentas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvVentas.OptionsView.ShowAutoFilterRow = true;
            this.gvVentas.OptionsView.ShowGroupPanel = false;
            // 
            // colidVenta
            // 
            this.colidVenta.Caption = "ID";
            this.colidVenta.FieldName = "idVenta";
            this.colidVenta.Name = "colidVenta";
            this.colidVenta.OptionsColumn.AllowEdit = false;
            this.colidVenta.OptionsColumn.AllowFocus = false;
            this.colidVenta.OptionsColumn.AllowIncrementalSearch = false;
            this.colidVenta.OptionsColumn.AllowMove = false;
            this.colidVenta.Visible = true;
            this.colidVenta.VisibleIndex = 0;
            // 
            // colidCliente
            // 
            this.colidCliente.Caption = "Cliente";
            this.colidCliente.FieldName = "idCliente";
            this.colidCliente.Name = "colidCliente";
            this.colidCliente.OptionsColumn.AllowEdit = false;
            this.colidCliente.OptionsColumn.AllowFocus = false;
            this.colidCliente.OptionsColumn.AllowIncrementalSearch = false;
            this.colidCliente.OptionsColumn.AllowMove = false;
            this.colidCliente.Visible = true;
            this.colidCliente.VisibleIndex = 1;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.DisplayFormat.FormatString = "d";
            this.colfecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.OptionsColumn.AllowFocus = false;
            this.colfecha.OptionsColumn.AllowIncrementalSearch = false;
            this.colfecha.OptionsColumn.AllowMove = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 2;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.OptionsColumn.AllowFocus = false;
            this.colcantidad.OptionsColumn.AllowIncrementalSearch = false;
            this.colcantidad.OptionsColumn.AllowMove = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 3;
            // 
            // colimporte
            // 
            this.colimporte.Caption = "Importe";
            this.colimporte.DisplayFormat.FormatString = "c";
            this.colimporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colimporte.FieldName = "importe";
            this.colimporte.Name = "colimporte";
            this.colimporte.OptionsColumn.AllowEdit = false;
            this.colimporte.OptionsColumn.AllowFocus = false;
            this.colimporte.OptionsColumn.AllowIncrementalSearch = false;
            this.colimporte.OptionsColumn.AllowMove = false;
            this.colimporte.Visible = true;
            this.colimporte.VisibleIndex = 4;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            this.colstatus.OptionsColumn.AllowEdit = false;
            this.colstatus.OptionsColumn.AllowFocus = false;
            this.colstatus.OptionsColumn.AllowIncrementalSearch = false;
            this.colstatus.OptionsColumn.AllowMove = false;
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataSource = typeof(DulSoft.BML.Venta);
            // 
            // btnImprimirRemision
            // 
            this.btnImprimirRemision.Caption = "Imprimir Remisión";
            this.btnImprimirRemision.Id = 4;
            this.btnImprimirRemision.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirRemision.ImageOptions.Image")));
            this.btnImprimirRemision.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnImprimirRemision.ImageOptions.LargeImage")));
            this.btnImprimirRemision.Name = "btnImprimirRemision";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 568);
            this.Controls.Add(this.gcVentas);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmVentas.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnImprimirTicket;
        private DevExpress.XtraBars.BarButtonItem btnCancelar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcVentas;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVentas;
        private DevExpress.XtraGrid.Columns.GridColumn colidVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colidCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraBars.BarButtonItem btnImprimirRemision;
    }
}