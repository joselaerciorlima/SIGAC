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
         this.cobPeriodo = new System.Windows.Forms.ComboBox();
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
         this.pnDados.Controls.Add(this.cobPeriodo);
         this.pnDados.Controls.Add(this.txbCodCurso);
         this.pnDados.Controls.Add(this.txbDescricao);
         // 
         // btnNovo
         // 
         this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
         // 
         // btnCancelar
         // 
         this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
         // 
         // btnLocalizar
         // 
         this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
         // 
         // btnSalvar
         // 
         this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
         // 
         // btnEditar
         // 
         this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
         // 
         // btnExcluir
         // 
         this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(14, 93);
         this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(72, 19);
         this.label2.TabIndex = 35;
         this.label2.Text = "Período";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(14, 18);
         this.label4.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(171, 19);
         this.label4.TabIndex = 36;
         this.label4.Text = "Descrição do Curso";
         // 
         // cobPeriodo
         // 
         this.cobPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cobPeriodo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cobPeriodo.FormattingEnabled = true;
         this.cobPeriodo.Location = new System.Drawing.Point(18, 118);
         this.cobPeriodo.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
         this.cobPeriodo.Name = "cobPeriodo";
         this.cobPeriodo.Size = new System.Drawing.Size(179, 26);
         this.cobPeriodo.TabIndex = 34;
         // 
         // txbDescricao
         // 
         this.txbDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txbDescricao.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbDescricao.Location = new System.Drawing.Point(18, 43);
         this.txbDescricao.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbDescricao.Name = "txbDescricao";
         this.txbDescricao.Size = new System.Drawing.Size(429, 25);
         this.txbDescricao.TabIndex = 33;
         // 
         // txbCodCurso
         // 
         this.txbCodCurso.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbCodCurso.Location = new System.Drawing.Point(486, 43);
         this.txbCodCurso.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbCodCurso.Name = "txbCodCurso";
         this.txbCodCurso.Size = new System.Drawing.Size(58, 25);
         this.txbCodCurso.TabIndex = 33;
         this.txbCodCurso.Visible = false;
         // 
         // frmCadCurso
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.ClientSize = new System.Drawing.Size(784, 561);
         this.Name = "frmCadCurso";
         this.Load += new System.EventHandler(this.frmCadCurso_Load);
         this.panel1.ResumeLayout(false);
         this.pnDados.ResumeLayout(false);
         this.pnDados.PerformLayout();
         this.ResumeLayout(false);

      }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cobPeriodo;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.TextBox txbCodCurso;
    }
}
