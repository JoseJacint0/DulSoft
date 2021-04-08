
namespace DulSoft
{
    partial class frmNMCliente
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblDescuento = new DevExpress.XtraEditors.LabelControl();
            this.lblTelefono = new DevExpress.XtraEditors.LabelControl();
            this.lblRazonS = new DevExpress.XtraEditors.LabelControl();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.txtDescuento = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.txtRazonS = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(171, 163);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(79, 163);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblDescuento
            // 
            this.lblDescuento.Location = new System.Drawing.Point(10, 122);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(55, 13);
            this.lblDescuento.TabIndex = 20;
            this.lblDescuento.Text = "Descuento:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(10, 96);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(46, 13);
            this.lblTelefono.TabIndex = 19;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblRazonS
            // 
            this.lblRazonS.Location = new System.Drawing.Point(10, 70);
            this.lblRazonS.Name = "lblRazonS";
            this.lblRazonS.Size = new System.Drawing.Size(64, 13);
            this.lblRazonS.TabIndex = 16;
            this.lblRazonS.Text = "Razón Social:";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(10, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(41, 13);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(10, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(15, 13);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "ID:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(79, 119);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(167, 20);
            this.txtDescuento.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(79, 93);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(167, 20);
            this.txtTelefono.TabIndex = 3;
            // 
            // txtRazonS
            // 
            this.txtRazonS.Location = new System.Drawing.Point(79, 67);
            this.txtRazonS.Name = "txtRazonS";
            this.txtRazonS.Size = new System.Drawing.Size(167, 20);
            this.txtRazonS.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(79, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(167, 20);
            this.txtID.TabIndex = 0;
            // 
            // frmNMCliente
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(284, 216);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtRazonS);
            this.Controls.Add(this.lblRazonS);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = global::DulSoft.Properties.Resources.cambio_de_imagen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNMCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNMCliente";
            this.Load += new System.EventHandler(this.frmNMCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private DevExpress.XtraEditors.TextEdit txtDescuento;
        private DevExpress.XtraEditors.LabelControl lblDescuento;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.LabelControl lblTelefono;
        private DevExpress.XtraEditors.TextEdit txtRazonS;
        private DevExpress.XtraEditors.LabelControl lblRazonS;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl lblNombre;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblID;
    }
}