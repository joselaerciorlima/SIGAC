using Funcoes;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Relatorios
{
   public partial class frmRelatorio : Form
   {
      public frmRelatorio()
      {
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         // Cria um documento com 150 linhas
         string[] textoParaImpressao = new string[151];
         for (int i = 0; i < 151; i++)
         {
            textoParaImpressao[i] = i.ToString();
            textoParaImpressao[i] += "http://www.macoratti.net - Quase tudo para Visual Basic.";
         }

         PrintDocument doc = new ImprimirDocumento(textoParaImpressao);
         doc.PrintPage += this.Doc_PrintPage;

         PrintDialog dialogo = new PrintDialog();
         dialogo.Document = doc;

         PrintPreviewDialog ppdlg = new PrintPreviewDialog();
         ppdlg.Document = doc;
         ppdlg.ShowDialog();
      }
      private void Doc_PrintPage(object sender, PrintPageEventArgs e)
      {
         // Recupera o documento que enviou este evento.
         ImprimirDocumento doc = (ImprimirDocumento)sender;

         // Define a fonte e determina a altura da linha
         using (Font fonte = new Font("Verdana", 10))
         {
            float alturaLinha = fonte.GetHeight(e.Graphics);

            // Cria as variáveis para tratar a posição na página
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            // Incrementa o contador de página para refletir
            // a página que esta sendo impressa
            doc.NumeroPagina += 1;

            // Imprime toda a informação que cabe na página
            // O laço termina quando a próxima linha
            // iria passar a borda da margem ou quando não
            // houve mais linhas a imprimir
            while ((y + alturaLinha) < e.MarginBounds.Bottom &&
              doc.Offset <= doc.Texto.GetUpperBound(0))
            {
               e.Graphics.DrawString(doc.Texto[doc.Offset], fonte,
                 Brushes.Black, x, y);

               // move para a proxima linha
               doc.Offset += 1;

               // Move uma linha para baixo (proxima linha)
               y += alturaLinha;
            }

            if (doc.Offset < doc.Texto.GetUpperBound(0))
            {
               // Havendo ainda pelo menos mais uma página.
               // Sinaliza o evento para disparar novamente
               e.HasMorePages = true;
            }
            else
            {
               // A impressão terminou
               doc.Offset = 0;
            }
         }
      }

   }
}

