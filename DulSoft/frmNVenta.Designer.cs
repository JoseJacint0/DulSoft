
namespace DulSoft
{
    partial class frmNVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNVenta));
            this.gcVentaDetalle = new DevExpress.XtraGrid.GridControl();
            this.gvVentaDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.lblCambio = new DevExpress.XtraEditors.LabelControl();
            this.lupClientes = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCliente = new DevExpress.XtraEditors.LabelControl();
            this.gControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblTCambio = new DevExpress.XtraEditors.LabelControl();
            this.lblTPago = new DevExpress.XtraEditors.LabelControl();
            this.lblTTotal = new DevExpress.XtraEditors.LabelControl();
            this.lblTDescuento = new DevExpress.XtraEditors.LabelControl();
            this.lblTSubTotal = new DevExpress.XtraEditors.LabelControl();
            this.lblCambios = new DevExpress.XtraEditors.LabelControl();
            this.lblPago = new DevExpress.XtraEditors.LabelControl();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.lblDescuento = new DevExpress.XtraEditors.LabelControl();
            this.lblSubTotal = new DevExpress.XtraEditors.LabelControl();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcVentaDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentaDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl2)).BeginInit();
            this.gControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupClientes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl1)).BeginInit();
            this.gControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gcVentaDetalle
            // 
            this.gcVentaDetalle.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcVentaDetalle.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcVentaDetalle.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcVentaDetalle.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcVentaDetalle.Location = new System.Drawing.Point(12, 109);
            this.gcVentaDetalle.MainView = this.gvVentaDetalle;
            this.gcVentaDetalle.Name = "gcVentaDetalle";
            this.gcVentaDetalle.Size = new System.Drawing.Size(1040, 472);
            this.gcVentaDetalle.TabIndex = 17;
            this.gcVentaDetalle.UseEmbeddedNavigator = true;
            this.gcVentaDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVentaDetalle});
            // 
            // gvVentaDetalle
            // 
            this.gvVentaDetalle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVentaDetalle.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvVentaDetalle.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVentaDetalle.Appearance.Row.Options.UseFont = true;
            this.gvVentaDetalle.GridControl = this.gcVentaDetalle;
            this.gvVentaDetalle.Name = "gvVentaDetalle";
            this.gvVentaDetalle.OptionsSelection.MultiSelect = true;
            this.gvVentaDetalle.OptionsView.ColumnAutoWidth = false;
            this.gvVentaDetalle.OptionsView.EnableAppearanceOddRow = true;
            this.gvVentaDetalle.OptionsView.ShowFooter = true;
            this.gvVentaDetalle.OptionsView.ShowGroupPanel = false;
            // 
            // gControl2
            // 
            this.gControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gControl2.Controls.Add(this.lblCodigo);
            this.gControl2.Controls.Add(this.txtCodigo);
            this.gControl2.Location = new System.Drawing.Point(12, 52);
            this.gControl2.Name = "gControl2";
            this.gControl2.Size = new System.Drawing.Size(1040, 51);
            this.gControl2.TabIndex = 15;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(12, 19);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(37, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(55, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Size = new System.Drawing.Size(195, 40);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblCambio
            // 
            this.lblCambio.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Appearance.Options.UseFont = true;
            this.lblCambio.Location = new System.Drawing.Point(797, 56);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(92, 19);
            this.lblCambio.TabIndex = 21;
            this.lblCambio.Text = "Su Cambio:";
            // 
            // lupClientes
            // 
            this.lupClientes.Location = new System.Drawing.Point(55, 13);
            this.lupClientes.Name = "lupClientes";
            this.lupClientes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupClientes.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idCliente", "id Cliente", 53, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Clientes", 45, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("razonSocial", "razon Social", 66, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("telefono", "telefono", 49, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descuento", "descuento", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 38, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lupClientes.Properties.DataSource = this.clienteBindingSource;
            this.lupClientes.Properties.DisplayMember = "nombre";
            this.lupClientes.Properties.NullText = "";
            this.lupClientes.Properties.ShowFooter = false;
            this.lupClientes.Properties.ShowHeader = false;
            this.lupClientes.Properties.ValueMember = "idCliente";
            this.lupClientes.Size = new System.Drawing.Size(195, 20);
            this.lupClientes.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.Location = new System.Drawing.Point(12, 16);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(37, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // gControl1
            // 
            this.gControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gControl1.Controls.Add(this.lupClientes);
            this.gControl1.Controls.Add(this.lblCliente);
            this.gControl1.Location = new System.Drawing.Point(12, 0);
            this.gControl1.Name = "gControl1";
            this.gControl1.Size = new System.Drawing.Size(1040, 46);
            this.gControl1.TabIndex = 14;
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.lblTCambio);
            this.groupControl1.Controls.Add(this.lblTPago);
            this.groupControl1.Controls.Add(this.lblTTotal);
            this.groupControl1.Controls.Add(this.lblTDescuento);
            this.groupControl1.Controls.Add(this.lblTSubTotal);
            this.groupControl1.Controls.Add(this.lblCambios);
            this.groupControl1.Controls.Add(this.lblPago);
            this.groupControl1.Controls.Add(this.lblTotal);
            this.groupControl1.Controls.Add(this.lblDescuento);
            this.groupControl1.Controls.Add(this.lblSubTotal);
            this.groupControl1.Location = new System.Drawing.Point(12, 587);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1040, 101);
            this.groupControl1.TabIndex = 32;
            // 
            // lblTCambio
            // 
            this.lblTCambio.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCambio.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.lblTCambio.Appearance.Options.UseFont = true;
            this.lblTCambio.Appearance.Options.UseForeColor = true;
            this.lblTCambio.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTCambio.Location = new System.Drawing.Point(895, 70);
            this.lblTCambio.Name = "lblTCambio";
            this.lblTCambio.Size = new System.Drawing.Size(119, 14);
            this.lblTCambio.TabIndex = 13;
            // 
            // lblTPago
            // 
            this.lblTPago.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPago.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblTPago.Appearance.Options.UseFont = true;
            this.lblTPago.Appearance.Options.UseForeColor = true;
            this.lblTPago.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTPago.Location = new System.Drawing.Point(875, 21);
            this.lblTPago.Name = "lblTPago";
            this.lblTPago.Size = new System.Drawing.Size(119, 14);
            this.lblTPago.TabIndex = 12;
            // 
            // lblTTotal
            // 
            this.lblTTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTotal.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblTTotal.Appearance.Options.UseFont = true;
            this.lblTTotal.Appearance.Options.UseForeColor = true;
            this.lblTTotal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTTotal.Location = new System.Drawing.Point(612, 24);
            this.lblTTotal.Name = "lblTTotal";
            this.lblTTotal.Size = new System.Drawing.Size(119, 14);
            this.lblTTotal.TabIndex = 11;
            // 
            // lblTDescuento
            // 
            this.lblTDescuento.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDescuento.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblTDescuento.Appearance.Options.UseFont = true;
            this.lblTDescuento.Appearance.Options.UseForeColor = true;
            this.lblTDescuento.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTDescuento.Location = new System.Drawing.Point(394, 23);
            this.lblTDescuento.Name = "lblTDescuento";
            this.lblTDescuento.Size = new System.Drawing.Size(119, 14);
            this.lblTDescuento.TabIndex = 10;
            // 
            // lblTSubTotal
            // 
            this.lblTSubTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSubTotal.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblTSubTotal.Appearance.Options.UseFont = true;
            this.lblTSubTotal.Appearance.Options.UseForeColor = true;
            this.lblTSubTotal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTSubTotal.Location = new System.Drawing.Point(114, 19);
            this.lblTSubTotal.Name = "lblTSubTotal";
            this.lblTSubTotal.Size = new System.Drawing.Size(119, 14);
            this.lblTSubTotal.TabIndex = 9;
            // 
            // lblCambios
            // 
            this.lblCambios.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambios.Appearance.Options.UseFont = true;
            this.lblCambios.Location = new System.Drawing.Point(797, 68);
            this.lblCambios.Name = "lblCambios";
            this.lblCambios.Size = new System.Drawing.Size(92, 19);
            this.lblCambios.TabIndex = 8;
            this.lblCambios.Text = "Su Cambio:";
            // 
            // lblPago
            // 
            this.lblPago.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.Appearance.Options.UseFont = true;
            this.lblPago.Location = new System.Drawing.Point(797, 18);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(72, 19);
            this.lblPago.TabIndex = 7;
            this.lblPago.Text = "Su Pago:";
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Location = new System.Drawing.Point(557, 19);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 19);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Appearance.Options.UseFont = true;
            this.lblDescuento.Location = new System.Drawing.Point(297, 19);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(91, 19);
            this.lblDescuento.TabIndex = 5;
            this.lblDescuento.Text = "Descuento:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Appearance.Options.UseFont = true;
            this.lblSubTotal.Location = new System.Drawing.Point(24, 19);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(84, 19);
            this.lblSubTotal.TabIndex = 4;
            this.lblSubTotal.Text = "Sub Total:";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(DulSoft.BML.Cliente);
            // 
            // frmNVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 712);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcVentaDetalle);
            this.Controls.Add(this.gControl2);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.gControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmNVenta.IconOptions.SvgImage")));
            this.Name = "frmNVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Venta";
            this.Load += new System.EventHandler(this.frmNVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcVentaDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentaDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl2)).EndInit();
            this.gControl2.ResumeLayout(false);
            this.gControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupClientes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl1)).EndInit();
            this.gControl1.ResumeLayout(false);
            this.gControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcVentaDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVentaDetalle;
        private DevExpress.XtraEditors.GroupControl gControl2;
        private DevExpress.XtraEditors.LabelControl lblCodigo;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl lblCambio;
        private DevExpress.XtraEditors.LookUpEdit lupClientes;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DevExpress.XtraEditors.LabelControl lblCliente;
        private DevExpress.XtraEditors.GroupControl gControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblTCambio;
        private DevExpress.XtraEditors.LabelControl lblTPago;
        private DevExpress.XtraEditors.LabelControl lblTTotal;
        private DevExpress.XtraEditors.LabelControl lblTDescuento;
        private DevExpress.XtraEditors.LabelControl lblTSubTotal;
        private DevExpress.XtraEditors.LabelControl lblCambios;
        private DevExpress.XtraEditors.LabelControl lblPago;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.LabelControl lblDescuento;
        private DevExpress.XtraEditors.LabelControl lblSubTotal;
    }
}