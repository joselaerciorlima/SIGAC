using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UI
{
   public partial class frmPrincipal : Form
   {
      public frmPrincipal()
      {
         InitializeComponent();
      }

      private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
      {
         tabControl1.SelectTab(1);
      }

      private void atividadeComplementarToolStripMenuItem_Click(object sender, EventArgs e)
      {
         tabControl1.SelectTab(2);
      }

      private void sairToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Close();
      }

      private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
      {
         tabControl1.SelectTab(0);
      }
   }
}
