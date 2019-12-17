namespace UI
{
   partial class frmCadAtividade
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
         this.label3 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.cobGrupo = new System.Windows.Forms.ComboBox();
         this.txbCargaHoraria = new System.Windows.Forms.TextBox();
         this.txbDescricao = new System.Windows.Forms.TextBox();
         this.txbCodAtividade = new System.Windows.Forms.TextBox();
         this.panel1.SuspendLayout();
         this.pnDados.SuspendLayout();
         this.SuspendLayout();
         // 
         // pnDados
         // 
         this.pnDados.Controls.Add(this.label2);
         this.pnDados.Controls.Add(this.label1);
         this.pnDados.Controls.Add(this.label3);
         this.pnDados.Controls.Add(this.txbCodAtividade);
         this.pnDados.Controls.Add(this.txbDescricao);
         this.pnDados.Controls.Add(this.txbCargaHoraria);
         this.pnDados.Controls.Add(this.cobGrupo);
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
         this.label2.Size = new System.Drawing.Size(126, 19);
         this.label2.TabIndex = 33;
         this.label2.Text = "Carga Horária";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(153, 92);
         this.label3.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(54, 19);
         this.label3.TabIndex = 34;
         this.label3.Text = "Grupo";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(14, 18);
         this.label1.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(324, 19);
         this.label1.TabIndex = 35;
         this.label1.Text = "Descrição da Atividade Complementar";
         // 
         // cobGrupo
         // 
         this.cobGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cobGrupo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cobGrupo.FormattingEnabled = true;
         this.cobGrupo.Location = new System.Drawing.Point(157, 117);
         this.cobGrupo.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
         this.cobGrupo.Name = "cobGrupo";
         this.cobGrupo.Size = new System.Drawing.Size(213, 26);
         this.cobGrupo.TabIndex = 37;
         // 
         // txbCargaHoraria
         // 
         this.txbCargaHoraria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txbCargaHoraria.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbCargaHoraria.Location = new System.Drawing.Point(18, 118);
         this.txbCargaHoraria.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
         this.txbCargaHoraria.Name = "txbCargaHoraria";
         this.txbCargaHoraria.Size = new System.Drawing.Size(122, 25);
         this.txbCargaHoraria.TabIndex = 36;
         // 
         // txbDescricao
         // 
         this.txbDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txbDescricao.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbDescricao.Location = new System.Drawing.Point(18, 43);
         this.txbDescricao.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbDescricao.Name = "txbDescricao";
         this.txbDescricao.Size = new System.Drawing.Size(623, 25);
         this.txbDescricao.TabIndex = 32;
         // 
         // txbCodAtividade
         // 
         this.txbCodAtividade.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbCodAtividade.Location = new System.Drawing.Point(660, 43);
         this.txbCodAtividade.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbCodAtividade.Name = "txbCodAtividade";
         this.txbCodAtividade.Size = new System.Drawing.Size(58, 25);
         this.txbCodAtividade.TabIndex = 32;
         // 
         // frmCadAtividade
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.ClientSize = new System.Drawing.Size(784, 561);
         this.Name = "frmCadAtividade";
         this.Text = "Cadastro - Atividade Complementar";
         this.Load += new System.EventHandler(this.frmCadAtividade_Load);
         this.panel1.ResumeLayout(false);
         this.pnDados.ResumeLayout(false);
         this.pnDados.PerformLayout();
         this.ResumeLayout(false);

      }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox cobGrupo;
        private System.Windows.Forms.TextBox txbCargaHoraria;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.TextBox txbCodAtividade;
    }
}
