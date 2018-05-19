﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha_de_Examenes
{
    public partial class Manual_Instalación : Form
    {
        public Manual_Instalación()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            login frm = new login();
            this.Close();
            frm.Close();
            Application.Exit();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Principal frm = new Principal();
            frm.Show();
            this.Close();
        }

        private void Manual_Instalación_Load(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(@"C:\Users\hernan\Downloads\Ficha de Examenes\Ficha de Examenes\Resources\Manual de Instalación.pdf");
            axAcroPDF1.Show();
        }
    }
}
