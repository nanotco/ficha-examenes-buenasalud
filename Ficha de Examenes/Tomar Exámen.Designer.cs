﻿namespace Ficha_de_Examenes
{
    partial class Tomar_Exámen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tomar_Exámen));
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbBusqueda = new System.Windows.Forms.GroupBox();
            this.btnRegistrarPaciente = new System.Windows.Forms.Button();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnNuevaConsulta = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBusc = new System.Windows.Forms.Button();
            this.txtDV = new System.Windows.Forms.TextBox();
            this.txtRun = new System.Windows.Forms.TextBox();
            this.cmbExamen = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservación = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbBusqueda.SuspendLayout();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicio.Location = new System.Drawing.Point(653, 534);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(171, 36);
            this.btnInicio.TabIndex = 26;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(476, 534);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(171, 36);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grbBusqueda
            // 
            this.grbBusqueda.Controls.Add(this.btnRegistrarPaciente);
            this.grbBusqueda.Controls.Add(this.txtComentario);
            this.grbBusqueda.Controls.Add(this.label14);
            this.grbBusqueda.Controls.Add(this.txtHora);
            this.grbBusqueda.Controls.Add(this.label12);
            this.grbBusqueda.Controls.Add(this.label13);
            this.grbBusqueda.Controls.Add(this.txtFecha);
            this.grbBusqueda.Controls.Add(this.label11);
            this.grbBusqueda.Controls.Add(this.btnNuevaConsulta);
            this.grbBusqueda.Controls.Add(this.label9);
            this.grbBusqueda.Controls.Add(this.btnBusc);
            this.grbBusqueda.Controls.Add(this.txtDV);
            this.grbBusqueda.Controls.Add(this.txtRun);
            this.grbBusqueda.Controls.Add(this.cmbExamen);
            this.grbBusqueda.Controls.Add(this.label8);
            this.grbBusqueda.Controls.Add(this.txtPaciente);
            this.grbBusqueda.Controls.Add(this.label6);
            this.grbBusqueda.Controls.Add(this.label1);
            this.grbBusqueda.Location = new System.Drawing.Point(9, 12);
            this.grbBusqueda.Name = "grbBusqueda";
            this.grbBusqueda.Size = new System.Drawing.Size(813, 235);
            this.grbBusqueda.TabIndex = 27;
            this.grbBusqueda.TabStop = false;
            this.grbBusqueda.Text = "Búsqueda Agenda";
            // 
            // btnRegistrarPaciente
            // 
            this.btnRegistrarPaciente.Location = new System.Drawing.Point(639, 23);
            this.btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            this.btnRegistrarPaciente.Size = new System.Drawing.Size(171, 36);
            this.btnRegistrarPaciente.TabIndex = 66;
            this.btnRegistrarPaciente.Text = "Registrar Paciente";
            this.btnRegistrarPaciente.UseVisualStyleBackColor = true;
            this.btnRegistrarPaciente.Click += new System.EventHandler(this.btnRegistrarPaciente_Click);
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(130, 130);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.ReadOnly = true;
            this.txtComentario.Size = new System.Drawing.Size(561, 100);
            this.txtComentario.TabIndex = 65;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 20);
            this.label14.TabIndex = 64;
            this.label14.Text = "Comentario";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(546, 99);
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(145, 28);
            this.txtHora.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(463, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 62;
            this.label12.Text = "Fecha";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(463, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 20);
            this.label13.TabIndex = 61;
            this.label13.Text = "Hora";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(546, 65);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(145, 28);
            this.txtFecha.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 58;
            this.label11.Text = "Paciente";
            // 
            // btnNuevaConsulta
            // 
            this.btnNuevaConsulta.Location = new System.Drawing.Point(462, 23);
            this.btnNuevaConsulta.Name = "btnNuevaConsulta";
            this.btnNuevaConsulta.Size = new System.Drawing.Size(171, 36);
            this.btnNuevaConsulta.TabIndex = 56;
            this.btnNuevaConsulta.Text = "Nueva Consulta";
            this.btnNuevaConsulta.UseVisualStyleBackColor = true;
            this.btnNuevaConsulta.Click += new System.EventHandler(this.btnNuevaConsulta_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 20);
            this.label9.TabIndex = 55;
            this.label9.Text = "-";
            // 
            // btnBusc
            // 
            this.btnBusc.Enabled = false;
            this.btnBusc.Location = new System.Drawing.Point(285, 23);
            this.btnBusc.Name = "btnBusc";
            this.btnBusc.Size = new System.Drawing.Size(171, 36);
            this.btnBusc.TabIndex = 54;
            this.btnBusc.Text = "Buscar";
            this.btnBusc.UseVisualStyleBackColor = true;
            this.btnBusc.Click += new System.EventHandler(this.btnBusc_Click);
            // 
            // txtDV
            // 
            this.txtDV.Enabled = false;
            this.txtDV.Location = new System.Drawing.Point(256, 28);
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(23, 28);
            this.txtDV.TabIndex = 53;
            // 
            // txtRun
            // 
            this.txtRun.Location = new System.Drawing.Point(130, 28);
            this.txtRun.MaxLength = 8;
            this.txtRun.Name = "txtRun";
            this.txtRun.Size = new System.Drawing.Size(100, 28);
            this.txtRun.TabIndex = 52;
            this.txtRun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRun_KeyPress);
            this.txtRun.Leave += new System.EventHandler(this.txtRun_Leave);
            // 
            // cmbExamen
            // 
            this.cmbExamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExamen.FormattingEnabled = true;
            this.cmbExamen.Location = new System.Drawing.Point(130, 62);
            this.cmbExamen.Name = "cmbExamen";
            this.cmbExamen.Size = new System.Drawing.Size(326, 28);
            this.cmbExamen.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Exámen";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(130, 96);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(326, 28);
            this.txtPaciente.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Rut Paciente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.btnNuevo);
            this.grbDatos.Controls.Add(this.btnGuardar);
            this.grbDatos.Controls.Add(this.dtpHora);
            this.grbDatos.Controls.Add(this.label5);
            this.grbDatos.Controls.Add(this.txtObservación);
            this.grbDatos.Controls.Add(this.label4);
            this.grbDatos.Controls.Add(this.cmbMedico);
            this.grbDatos.Controls.Add(this.dtpFecha);
            this.grbDatos.Controls.Add(this.label3);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Location = new System.Drawing.Point(9, 253);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(813, 275);
            this.grbDatos.TabIndex = 28;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos del exámen";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(419, 228);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(171, 36);
            this.btnNuevo.TabIndex = 30;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(596, 228);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(171, 36);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtpHora
            // 
            this.dtpHora.Enabled = false;
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(343, 59);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(103, 28);
            this.dtpHora.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hora:";
            // 
            // txtObservación
            // 
            this.txtObservación.Location = new System.Drawing.Point(119, 96);
            this.txtObservación.MaxLength = 50;
            this.txtObservación.Multiline = true;
            this.txtObservación.Name = "txtObservación";
            this.txtObservación.Size = new System.Drawing.Size(648, 126);
            this.txtObservación.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Observación:";
            // 
            // cmbMedico
            // 
            this.cmbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(119, 25);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(382, 28);
            this.cmbMedico.TabIndex = 3;
            this.cmbMedico.SelectedIndexChanged += new System.EventHandler(this.cmbMedico_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(119, 59);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(154, 28);
            this.dtpFecha.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Realizado Por:";
            // 
            // Tomar_Exámen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 582);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.grbBusqueda);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnSalir);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Tomar_Exámen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toma de Exámen";
            this.Load += new System.EventHandler(this.Tomar_Exámen_Load);
            this.grbBusqueda.ResumeLayout(false);
            this.grbBusqueda.PerformLayout();
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grbBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.TextBox txtObservación;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbExamen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNuevaConsulta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBusc;
        private System.Windows.Forms.TextBox txtDV;
        private System.Windows.Forms.TextBox txtRun;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRegistrarPaciente;
    }
}