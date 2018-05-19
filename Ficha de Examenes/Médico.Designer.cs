namespace Ficha_de_Examenes
{
    partial class Médico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Médico));
            this.grbPaciente = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBusc = new System.Windows.Forms.Button();
            this.txtDV = new System.Windows.Forms.TextBox();
            this.pnlEspecialidad = new System.Windows.Forms.Panel();
            this.btnCancelar2 = new System.Windows.Forms.Button();
            this.btnNuevaEspecialidad = new System.Windows.Forms.Button();
            this.txtNuevaEspecilidad = new System.Windows.Forms.TextBox();
            this.lblNuevaEspecialidad = new System.Windows.Forms.Label();
            this.txtRun = new System.Windows.Forms.TextBox();
            this.btnIngresaEspecialidad = new System.Windows.Forms.Button();
            this.pnlCiudad = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrarCiudad = new System.Windows.Forms.Button();
            this.txtNuevaCiudad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCiudad = new System.Windows.Forms.Button();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevaConsulta = new System.Windows.Forms.Button();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbPaciente.SuspendLayout();
            this.pnlEspecialidad.SuspendLayout();
            this.pnlCiudad.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPaciente
            // 
            this.grbPaciente.Controls.Add(this.btnNuevo);
            this.grbPaciente.Controls.Add(this.label11);
            this.grbPaciente.Controls.Add(this.btnBusc);
            this.grbPaciente.Controls.Add(this.txtDV);
            this.grbPaciente.Controls.Add(this.pnlEspecialidad);
            this.grbPaciente.Controls.Add(this.txtRun);
            this.grbPaciente.Controls.Add(this.btnIngresaEspecialidad);
            this.grbPaciente.Controls.Add(this.pnlCiudad);
            this.grbPaciente.Controls.Add(this.btnCiudad);
            this.grbPaciente.Controls.Add(this.cmbCiudad);
            this.grbPaciente.Controls.Add(this.label8);
            this.grbPaciente.Controls.Add(this.cmbRegion);
            this.grbPaciente.Controls.Add(this.label9);
            this.grbPaciente.Controls.Add(this.btnRegistrar);
            this.grbPaciente.Controls.Add(this.btnModificar);
            this.grbPaciente.Controls.Add(this.btnNuevaConsulta);
            this.grbPaciente.Controls.Add(this.cmbEspecialidad);
            this.grbPaciente.Controls.Add(this.label7);
            this.grbPaciente.Controls.Add(this.txtEmail);
            this.grbPaciente.Controls.Add(this.label6);
            this.grbPaciente.Controls.Add(this.txtTelefono);
            this.grbPaciente.Controls.Add(this.txtDireccion);
            this.grbPaciente.Controls.Add(this.label5);
            this.grbPaciente.Controls.Add(this.label4);
            this.grbPaciente.Controls.Add(this.txtApellido);
            this.grbPaciente.Controls.Add(this.label3);
            this.grbPaciente.Controls.Add(this.txtNombre);
            this.grbPaciente.Controls.Add(this.label2);
            this.grbPaciente.Controls.Add(this.label1);
            this.grbPaciente.Location = new System.Drawing.Point(1, 15);
            this.grbPaciente.Name = "grbPaciente";
            this.grbPaciente.Size = new System.Drawing.Size(772, 457);
            this.grbPaciente.TabIndex = 21;
            this.grbPaciente.TabStop = false;
            this.grbPaciente.Text = "Datos Médico";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(158, 415);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(171, 36);
            this.btnNuevo.TabIndex = 51;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(243, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 20);
            this.label11.TabIndex = 50;
            this.label11.Text = "-";
            // 
            // btnBusc
            // 
            this.btnBusc.Enabled = false;
            this.btnBusc.Location = new System.Drawing.Point(292, 35);
            this.btnBusc.Name = "btnBusc";
            this.btnBusc.Size = new System.Drawing.Size(171, 36);
            this.btnBusc.TabIndex = 49;
            this.btnBusc.Text = "Buscar";
            this.btnBusc.UseVisualStyleBackColor = true;
            this.btnBusc.Click += new System.EventHandler(this.btnBusc_Click);
            // 
            // txtDV
            // 
            this.txtDV.Enabled = false;
            this.txtDV.Location = new System.Drawing.Point(263, 40);
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(23, 28);
            this.txtDV.TabIndex = 48;
            // 
            // pnlEspecialidad
            // 
            this.pnlEspecialidad.BackColor = System.Drawing.Color.White;
            this.pnlEspecialidad.Controls.Add(this.btnCancelar2);
            this.pnlEspecialidad.Controls.Add(this.btnNuevaEspecialidad);
            this.pnlEspecialidad.Controls.Add(this.txtNuevaEspecilidad);
            this.pnlEspecialidad.Controls.Add(this.lblNuevaEspecialidad);
            this.pnlEspecialidad.Location = new System.Drawing.Point(37, 320);
            this.pnlEspecialidad.Name = "pnlEspecialidad";
            this.pnlEspecialidad.Size = new System.Drawing.Size(646, 89);
            this.pnlEspecialidad.TabIndex = 38;
            this.pnlEspecialidad.Visible = false;
            // 
            // btnCancelar2
            // 
            this.btnCancelar2.Location = new System.Drawing.Point(466, 48);
            this.btnCancelar2.Name = "btnCancelar2";
            this.btnCancelar2.Size = new System.Drawing.Size(171, 36);
            this.btnCancelar2.TabIndex = 40;
            this.btnCancelar2.Text = "Cancelar";
            this.btnCancelar2.UseVisualStyleBackColor = true;
            this.btnCancelar2.Click += new System.EventHandler(this.btnCancelar2_Click);
            // 
            // btnNuevaEspecialidad
            // 
            this.btnNuevaEspecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaEspecialidad.Location = new System.Drawing.Point(289, 48);
            this.btnNuevaEspecialidad.Name = "btnNuevaEspecialidad";
            this.btnNuevaEspecialidad.Size = new System.Drawing.Size(171, 36);
            this.btnNuevaEspecialidad.TabIndex = 39;
            this.btnNuevaEspecialidad.Text = "Registrar";
            this.btnNuevaEspecialidad.UseVisualStyleBackColor = true;
            this.btnNuevaEspecialidad.Click += new System.EventHandler(this.btnNuevaEspecialidad_Click);
            // 
            // txtNuevaEspecilidad
            // 
            this.txtNuevaEspecilidad.Location = new System.Drawing.Point(13, 53);
            this.txtNuevaEspecilidad.MaxLength = 50;
            this.txtNuevaEspecilidad.Name = "txtNuevaEspecilidad";
            this.txtNuevaEspecilidad.Size = new System.Drawing.Size(270, 28);
            this.txtNuevaEspecilidad.TabIndex = 1;
            // 
            // lblNuevaEspecialidad
            // 
            this.lblNuevaEspecialidad.AutoSize = true;
            this.lblNuevaEspecialidad.Location = new System.Drawing.Point(9, 20);
            this.lblNuevaEspecialidad.Name = "lblNuevaEspecialidad";
            this.lblNuevaEspecialidad.Size = new System.Drawing.Size(142, 20);
            this.lblNuevaEspecialidad.TabIndex = 0;
            this.lblNuevaEspecialidad.Text = "Nueva Especialidad";
            // 
            // txtRun
            // 
            this.txtRun.Location = new System.Drawing.Point(137, 40);
            this.txtRun.MaxLength = 8;
            this.txtRun.Name = "txtRun";
            this.txtRun.Size = new System.Drawing.Size(100, 28);
            this.txtRun.TabIndex = 47;
            this.txtRun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRun_KeyPress);
            this.txtRun.Leave += new System.EventHandler(this.txtRun_Leave);
            // 
            // btnIngresaEspecialidad
            // 
            this.btnIngresaEspecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresaEspecialidad.Location = new System.Drawing.Point(512, 336);
            this.btnIngresaEspecialidad.Name = "btnIngresaEspecialidad";
            this.btnIngresaEspecialidad.Size = new System.Drawing.Size(171, 36);
            this.btnIngresaEspecialidad.TabIndex = 46;
            this.btnIngresaEspecialidad.Text = "Ingresar Especialidad";
            this.btnIngresaEspecialidad.UseVisualStyleBackColor = true;
            this.btnIngresaEspecialidad.Click += new System.EventHandler(this.btnIngresaEspecialidad_Click);
            // 
            // pnlCiudad
            // 
            this.pnlCiudad.BackColor = System.Drawing.Color.White;
            this.pnlCiudad.Controls.Add(this.btnCancelar);
            this.pnlCiudad.Controls.Add(this.btnRegistrarCiudad);
            this.pnlCiudad.Controls.Add(this.txtNuevaCiudad);
            this.pnlCiudad.Controls.Add(this.label10);
            this.pnlCiudad.Location = new System.Drawing.Point(41, 170);
            this.pnlCiudad.Name = "pnlCiudad";
            this.pnlCiudad.Size = new System.Drawing.Size(644, 132);
            this.pnlCiudad.TabIndex = 45;
            this.pnlCiudad.Visible = false;
            this.pnlCiudad.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCiudad_Paint);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(466, 85);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(171, 36);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrarCiudad
            // 
            this.btnRegistrarCiudad.Location = new System.Drawing.Point(292, 85);
            this.btnRegistrarCiudad.Name = "btnRegistrarCiudad";
            this.btnRegistrarCiudad.Size = new System.Drawing.Size(171, 36);
            this.btnRegistrarCiudad.TabIndex = 19;
            this.btnRegistrarCiudad.Text = "Registrar";
            this.btnRegistrarCiudad.UseVisualStyleBackColor = true;
            this.btnRegistrarCiudad.Click += new System.EventHandler(this.btnRegistrarCiudad_Click);
            // 
            // txtNuevaCiudad
            // 
            this.txtNuevaCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNuevaCiudad.Location = new System.Drawing.Point(13, 90);
            this.txtNuevaCiudad.MaxLength = 50;
            this.txtNuevaCiudad.Name = "txtNuevaCiudad";
            this.txtNuevaCiudad.Size = new System.Drawing.Size(265, 28);
            this.txtNuevaCiudad.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nombre Ciudad";
            // 
            // btnCiudad
            // 
            this.btnCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCiudad.Location = new System.Drawing.Point(512, 255);
            this.btnCiudad.Name = "btnCiudad";
            this.btnCiudad.Size = new System.Drawing.Size(171, 36);
            this.btnCiudad.TabIndex = 44;
            this.btnCiudad.Text = "Ingresar Ciudad";
            this.btnCiudad.UseVisualStyleBackColor = true;
            this.btnCiudad.Click += new System.EventHandler(this.btnCiudad_Click);
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(420, 226);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(263, 28);
            this.cmbCiudad.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Ciudad:";
            // 
            // cmbRegion
            // 
            this.cmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Location = new System.Drawing.Point(137, 226);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(263, 28);
            this.cmbRegion.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Región:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.Location = new System.Drawing.Point(512, 415);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(171, 36);
            this.btnRegistrar.TabIndex = 25;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(335, 415);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(171, 36);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevaConsulta
            // 
            this.btnNuevaConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaConsulta.Location = new System.Drawing.Point(512, 35);
            this.btnNuevaConsulta.Name = "btnNuevaConsulta";
            this.btnNuevaConsulta.Size = new System.Drawing.Size(171, 36);
            this.btnNuevaConsulta.TabIndex = 36;
            this.btnNuevaConsulta.Text = "Nueva Consulta";
            this.btnNuevaConsulta.UseVisualStyleBackColor = true;
            this.btnNuevaConsulta.Click += new System.EventHandler(this.btnNuevaConsulta_Click);
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(137, 336);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(256, 28);
            this.cmbEspecialidad.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Especialidad:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(137, 294);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(546, 28);
            this.txtEmail.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Email:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(137, 260);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(263, 28);
            this.txtTelefono.TabIndex = 31;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(137, 170);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(546, 28);
            this.txtDireccion.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Teléfono:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(137, 125);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(546, 28);
            this.txtApellido.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 85);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(546, 28);
            this.txtNombre.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "RUT:";
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicio.Location = new System.Drawing.Point(595, 492);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(171, 36);
            this.btnInicio.TabIndex = 23;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(418, 492);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(171, 36);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Médico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 540);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbPaciente);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Médico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Médico";
            this.Load += new System.EventHandler(this.Médico_Load);
            this.grbPaciente.ResumeLayout(false);
            this.grbPaciente.PerformLayout();
            this.pnlEspecialidad.ResumeLayout(false);
            this.pnlEspecialidad.PerformLayout();
            this.pnlCiudad.ResumeLayout(false);
            this.pnlCiudad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPaciente;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlEspecialidad;
        private System.Windows.Forms.Button btnNuevaConsulta;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Button btnNuevaEspecialidad;
        private System.Windows.Forms.TextBox txtNuevaEspecilidad;
        private System.Windows.Forms.Label lblNuevaEspecialidad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCiudad;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbRegion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlCiudad;
        private System.Windows.Forms.Button btnRegistrarCiudad;
        private System.Windows.Forms.TextBox txtNuevaCiudad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnIngresaEspecialidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBusc;
        private System.Windows.Forms.TextBox txtDV;
        private System.Windows.Forms.TextBox txtRun;
        private System.Windows.Forms.Button btnCancelar2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
    }
}