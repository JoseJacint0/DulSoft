
namespace DulSoft
{
    partial class frmNMEmpleado
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDomicilio = new DevExpress.XtraEditors.TextEdit();
            this.lblDomicilio = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.lblTelefono = new DevExpress.XtraEditors.LabelControl();
            this.txtSueldo = new DevExpress.XtraEditors.TextEdit();
            this.lblSueldo = new DevExpress.XtraEditors.LabelControl();
            this.txtEdad = new DevExpress.XtraEditors.TextEdit();
            this.lblEdad = new DevExpress.XtraEditors.LabelControl();
            this.txtApellido = new DevExpress.XtraEditors.TextEdit();
            this.lblApellido = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomicilio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSueldo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(79, 199);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(169, 199);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(79, 161);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(165, 20);
            this.txtDomicilio.TabIndex = 6;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.Location = new System.Drawing.Point(10, 164);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(44, 13);
            this.lblDomicilio.TabIndex = 44;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(79, 135);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(165, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(10, 138);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(46, 13);
            this.lblTelefono.TabIndex = 43;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(79, 109);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(165, 20);
            this.txtSueldo.TabIndex = 4;
            // 
            // lblSueldo
            // 
            this.lblSueldo.Location = new System.Drawing.Point(10, 112);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(36, 13);
            this.lblSueldo.TabIndex = 42;
            this.lblSueldo.Text = "Sueldo:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(79, 83);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(165, 20);
            this.txtEdad.TabIndex = 3;
            // 
            // lblEdad
            // 
            this.lblEdad.Location = new System.Drawing.Point(10, 86);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(28, 13);
            this.lblEdad.TabIndex = 41;
            this.lblEdad.Text = "Edad:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(79, 57);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(165, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(10, 60);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(41, 13);
            this.lblApellido.TabIndex = 40;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(10, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(41, 13);
            this.lblNombre.TabIndex = 39;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(79, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(165, 20);
            this.txtID.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(10, 8);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(15, 13);
            this.lblID.TabIndex = 38;
            this.lblID.Text = "ID:";
            // 
            // frmNMEmpleado
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = global::DulSoft.Properties.Resources.empleado;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNMEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNMEmpleado";
            this.Load += new System.EventHandler(this.frmNMEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDomicilio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSueldo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private DevExpress.XtraEditors.TextEdit txtDomicilio;
        private DevExpress.XtraEditors.LabelControl lblDomicilio;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.LabelControl lblTelefono;
        private DevExpress.XtraEditors.TextEdit txtSueldo;
        private DevExpress.XtraEditors.LabelControl lblSueldo;
        private DevExpress.XtraEditors.TextEdit txtEdad;
        private DevExpress.XtraEditors.LabelControl lblEdad;
        private DevExpress.XtraEditors.TextEdit txtApellido;
        private DevExpress.XtraEditors.LabelControl lblApellido;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl lblNombre;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblID;
    }
}