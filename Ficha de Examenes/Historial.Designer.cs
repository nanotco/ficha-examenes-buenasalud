namespace Ficha_de_Examenes
{
    partial class Historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            this.grbBuscar = new System.Windows.Forms.GroupBox();
            this.rbtResultados = new System.Windows.Forms.RadioButton();
            this.rbtMedicos = new System.Windows.Forms.RadioButton();
            this.rbtPaciente = new System.Windows.Forms.RadioButton();
            this.rbtExamen = new System.Windows.Forms.RadioButton();
            this.rbtAgenda = new System.Windows.Forms.RadioButton();
            this.btnCrearReporte = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rbtTomaExamen = new System.Windows.Forms.RadioButton();
            this.grbBuscar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // grbBuscar
            // 
            this.grbBuscar.Controls.Add(this.rbtTomaExamen);
            this.grbBuscar.Controls.Add(this.rbtResultados);
            this.grbBuscar.Controls.Add(this.rbtMedicos);
            this.grbBuscar.Controls.Add(this.rbtPaciente);
            this.grbBuscar.Controls.Add(this.rbtExamen);
            this.grbBuscar.Controls.Add(this.rbtAgenda);
            this.grbBuscar.Controls.Add(this.btnCrearReporte);
            this.grbBuscar.Location = new System.Drawing.Point(35, 12);
            this.grbBuscar.Name = "grbBuscar";
            this.grbBuscar.Size = new System.Drawing.Size(1010, 100);
            this.grbBuscar.TabIndex = 23;
            this.grbBuscar.TabStop = false;
            this.grbBuscar.Text = "Búsqueda";
            // 
            // rbtResultados
            // 
            this.rbtResultados.AutoSize = true;
            this.rbtResultados.Location = new System.Drawing.Point(657, 48);
            this.rbtResultados.Name = "rbtResultados";
            this.rbtResultados.Size = new System.Drawing.Size(102, 24);
            this.rbtResultados.TabIndex = 29;
            this.rbtResultados.TabStop = true;
            this.rbtResultados.Text = "Resultados";
            this.rbtResultados.UseVisualStyleBackColor = true;
            this.rbtResultados.CheckedChanged += new System.EventHandler(this.rbtResultados_CheckedChanged);
            // 
            // rbtMedicos
            // 
            this.rbtMedicos.AutoSize = true;
            this.rbtMedicos.Location = new System.Drawing.Point(215, 48);
            this.rbtMedicos.Name = "rbtMedicos";
            this.rbtMedicos.Size = new System.Drawing.Size(85, 24);
            this.rbtMedicos.TabIndex = 27;
            this.rbtMedicos.TabStop = true;
            this.rbtMedicos.Text = "Médicos";
            this.rbtMedicos.UseVisualStyleBackColor = true;
            this.rbtMedicos.CheckedChanged += new System.EventHandler(this.rbtMedicos_CheckedChanged);
            // 
            // rbtPaciente
            // 
            this.rbtPaciente.AutoSize = true;
            this.rbtPaciente.Location = new System.Drawing.Point(117, 48);
            this.rbtPaciente.Name = "rbtPaciente";
            this.rbtPaciente.Size = new System.Drawing.Size(92, 24);
            this.rbtPaciente.TabIndex = 26;
            this.rbtPaciente.TabStop = true;
            this.rbtPaciente.Text = "Pacientes";
            this.rbtPaciente.UseVisualStyleBackColor = true;
            this.rbtPaciente.CheckedChanged += new System.EventHandler(this.rbtPaciente_CheckedChanged);
            // 
            // rbtExamen
            // 
            this.rbtExamen.AutoSize = true;
            this.rbtExamen.Location = new System.Drawing.Point(321, 48);
            this.rbtExamen.Name = "rbtExamen";
            this.rbtExamen.Size = new System.Drawing.Size(97, 24);
            this.rbtExamen.TabIndex = 25;
            this.rbtExamen.TabStop = true;
            this.rbtExamen.Text = "Examenes";
            this.rbtExamen.UseVisualStyleBackColor = true;
            this.rbtExamen.CheckedChanged += new System.EventHandler(this.rbtExamen_CheckedChanged);
            // 
            // rbtAgenda
            // 
            this.rbtAgenda.AutoSize = true;
            this.rbtAgenda.Location = new System.Drawing.Point(424, 48);
            this.rbtAgenda.Name = "rbtAgenda";
            this.rbtAgenda.Size = new System.Drawing.Size(80, 24);
            this.rbtAgenda.TabIndex = 24;
            this.rbtAgenda.TabStop = true;
            this.rbtAgenda.Text = "Agenda";
            this.rbtAgenda.UseVisualStyleBackColor = true;
            this.rbtAgenda.CheckedChanged += new System.EventHandler(this.rbtNumero_CheckedChanged);
            // 
            // btnCrearReporte
            // 
            this.btnCrearReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearReporte.Location = new System.Drawing.Point(765, 42);
            this.btnCrearReporte.Name = "btnCrearReporte";
            this.btnCrearReporte.Size = new System.Drawing.Size(129, 36);
            this.btnCrearReporte.TabIndex = 23;
            this.btnCrearReporte.Text = "Crear Reporte";
            this.btnCrearReporte.UseVisualStyleBackColor = true;
            this.btnCrearReporte.Click += new System.EventHandler(this.btnCrearReporte_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvResultados);
            this.groupBox2.Location = new System.Drawing.Point(35, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1010, 455);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResultados.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(6, 27);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.Size = new System.Drawing.Size(1000, 422);
            this.dgvResultados.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicio.Location = new System.Drawing.Point(904, 609);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(171, 36);
            this.btnInicio.TabIndex = 26;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(727, 609);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(171, 36);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rbtTomaExamen
            // 
            this.rbtTomaExamen.AutoSize = true;
            this.rbtTomaExamen.Location = new System.Drawing.Point(527, 48);
            this.rbtTomaExamen.Name = "rbtTomaExamen";
            this.rbtTomaExamen.Size = new System.Drawing.Size(124, 24);
            this.rbtTomaExamen.TabIndex = 30;
            this.rbtTomaExamen.TabStop = true;
            this.rbtTomaExamen.Text = "Toma Examen";
            this.rbtTomaExamen.UseVisualStyleBackColor = true;
            this.rbtTomaExamen.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 657);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbBuscar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Historial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            this.grbBuscar.ResumeLayout(false);
            this.grbBuscar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBuscar;
        private System.Windows.Forms.RadioButton rbtMedicos;
        private System.Windows.Forms.RadioButton rbtPaciente;
        private System.Windows.Forms.RadioButton rbtExamen;
        private System.Windows.Forms.RadioButton rbtAgenda;
        private System.Windows.Forms.Button btnCrearReporte;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RadioButton rbtResultados;
        private System.Windows.Forms.RadioButton rbtTomaExamen;
    }
}