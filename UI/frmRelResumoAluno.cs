﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
   public partial class frmRelResumoAluno : Form
   {
      public frmRelResumoAluno()
      {
         InitializeComponent();

         //this.lblStatus.BackColor = System.Drawing.Color.Yellow;
         //this.lblStatus.Text = "CARGA HORÁRIA MINÍMA NÃO ATINGIDA";



      }

      private void btnVisualizar_Click(object sender, EventArgs e)
      {
         frmVisualizar visualizar = new frmVisualizar();
         visualizar.ShowDialog();
      }

        private void frmRelResumoAluno_Load(object sender, EventArgs e)
        {

        }
    }
}
