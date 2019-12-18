using Relatorios;
using System;
using System.Windows.Forms;
//using Relatorios;

namespace UI
{
   static class Program
   {
      /// <summary>
      /// Ponto de entrada principal para o aplicativo.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         //Application.Run(new frmPrincipal());
         Application.Run(new frmRelatorio());
      }
   }
}
