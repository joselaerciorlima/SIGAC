using System;
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
   public partial class frmModelo : Form
   {
      public string operacao;
      public frmModelo()
      {
         InitializeComponent();
      }
      public void alteraBotoes(int op)
      {
         pnDados.Enabled = false;
         btnNovo.Enabled = false;
         btnEditar.Enabled = false;
         btnLocalizar.Enabled = false;
         btnSalvar.Enabled = false;
         btnCancelar.Enabled = false;
         btnExcluir.Enabled = false;

         switch (op)
         {
            case 1:
               btnNovo.Enabled = true;
               btnLocalizar.Enabled = true;
               break;
            case 2:
               pnDados.Enabled = true;
               btnSalvar.Enabled = true;
               btnCancelar.Enabled = true;
               break;
            case 3:
               btnEditar.Enabled = true;
               btnExcluir.Enabled = true;
               btnCancelar.Enabled = true;
               break;
         }
      }
   }
}
