namespace UI
{
   partial class frmCadCurso
   {
      /// <summary>
      /// Variável de designer necessária.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Limpar os recursos que estão sendo usados.
      /// </summary>
      /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Código gerado pelo Windows Form Designer

      /// <summary>
      /// Método necessário para suporte ao Designer - não modifique 
      /// o conteúdo deste método com o editor de código.
      /// </summary>
      private void InitializeComponent()
      {
         this.label2 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.cboPeriodo = new System.Windows.Forms.ComboBox();
         this.txbDescricao = new System.Windows.Forms.TextBox();
         this.txbCodCurso = new System.Windows.Forms.TextBox();
         this.panel1.SuspendLayout();
         this.pnDados.SuspendLayout();
         this.SuspendLayout();
         // 
         // pnDados
         // 
         this.pnDados.Controls.Add(this.label2);
         this.pnDados.Controls.Add(this.label4);
         this.pnDados.Controls.Add(this.cboPeriodo);
         this.pnDados.Controls.Add(this.txbCodCurso);
         this.pnDados.Controls.Add(this.txbDescricao);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(14, 93);
         this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(82, 19);
         this.label2.TabIndex = 35;
         this.label2.Text = "PERIODO";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(14, 18);
         this.label4.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(190, 19);
         this.label4.TabIndex = 36;
         this.label4.Text = "DESCRIÇÃO DO CURSO";
         // 
         // cboPeriodo
         // 
         this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboPeriodo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cboPeriodo.FormattingEnabled = true;
         this.cboPeriodo.Location = new System.Drawing.Point(18, 118);
         this.cboPeriodo.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
         this.cboPeriodo.Name = "cboPeriodo";
         this.cboPeriodo.Size = new System.Drawing.Size(179, 25);
         this.cboPeriodo.TabIndex = 34;
         // 
         // txbDescricao
         // 
         this.txbDescricao.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbDescricao.Location = new System.Drawing.Point(18, 43);
         this.txbDescricao.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbDescricao.Name = "txbDescricao";
         this.txbDescricao.Size = new System.Drawing.Size(429, 25);
         this.txbDescricao.TabIndex = 33;
         // 
         // txbCodCurso
         // 
         this.txbCodCurso.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbCodCurso.Location = new System.Drawing.Point(486, 43);
         this.txbCodCurso.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbCodCurso.Name = "txbCodCurso";
         this.txbCodCurso.Size = new System.Drawing.Size(58, 25);
         this.txbCodCurso.TabIndex = 33;
         // 
         // frmCadCurso
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.ClientSize = new System.Drawing.Size(784, 561);
         this.Name = "frmCadCurso";
         this.panel1.ResumeLayout(false);
         this.pnDados.ResumeLayout(false);
         this.pnDados.PerformLayout();
         this.ResumeLayout(false);

      }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.TextBox txbCodCurso;
    }
}
