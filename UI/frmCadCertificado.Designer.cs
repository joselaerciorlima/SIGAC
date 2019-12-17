namespace UI
{
   partial class frmCadCertificado
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
         this.label6 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.cobClassificacao = new System.Windows.Forms.ComboBox();
         this.txbCargaHoraria = new System.Windows.Forms.TextBox();
         this.txbNome = new System.Windows.Forms.TextBox();
         this.txbDescricao = new System.Windows.Forms.TextBox();
         this.txbMatricula = new System.Windows.Forms.TextBox();
         this.txbData = new System.Windows.Forms.TextBox();
         this.txbCodAluno = new System.Windows.Forms.TextBox();
         this.panel1.SuspendLayout();
         this.pnDados.SuspendLayout();
         this.SuspendLayout();
         // 
         // pnDados
         // 
         this.pnDados.Controls.Add(this.txbData);
         this.pnDados.Controls.Add(this.txbMatricula);
         this.pnDados.Controls.Add(this.label2);
         this.pnDados.Controls.Add(this.label3);
         this.pnDados.Controls.Add(this.label6);
         this.pnDados.Controls.Add(this.label4);
         this.pnDados.Controls.Add(this.label5);
         this.pnDados.Controls.Add(this.label1);
         this.pnDados.Controls.Add(this.cobClassificacao);
         this.pnDados.Controls.Add(this.txbCodAluno);
         this.pnDados.Controls.Add(this.txbCargaHoraria);
         this.pnDados.Controls.Add(this.txbNome);
         this.pnDados.Controls.Add(this.txbDescricao);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(184, 18);
         this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(126, 19);
         this.label2.TabIndex = 35;
         this.label2.Text = "Nome do Aluno";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(14, 168);
         this.label3.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(261, 19);
         this.label3.TabIndex = 36;
         this.label3.Text = "Classificação do Certificado";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(519, 168);
         this.label6.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(126, 19);
         this.label6.TabIndex = 37;
         this.label6.Text = "Carga Horária";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(14, 93);
         this.label4.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(45, 19);
         this.label4.TabIndex = 38;
         this.label4.Text = "Data";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(112, 93);
         this.label5.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(225, 19);
         this.label5.TabIndex = 39;
         this.label5.Text = "Descrição do Certificado";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(14, 18);
         this.label1.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(90, 19);
         this.label1.TabIndex = 40;
         this.label1.Text = "Matrícula";
         // 
         // cobClassificacao
         // 
         this.cobClassificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cobClassificacao.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cobClassificacao.FormattingEnabled = true;
         this.cobClassificacao.Location = new System.Drawing.Point(18, 193);
         this.cobClassificacao.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
         this.cobClassificacao.Name = "cobClassificacao";
         this.cobClassificacao.Size = new System.Drawing.Size(486, 26);
         this.cobClassificacao.TabIndex = 33;
         // 
         // txbCargaHoraria
         // 
         this.txbCargaHoraria.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbCargaHoraria.Location = new System.Drawing.Point(523, 193);
         this.txbCargaHoraria.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbCargaHoraria.Name = "txbCargaHoraria";
         this.txbCargaHoraria.Size = new System.Drawing.Size(122, 25);
         this.txbCargaHoraria.TabIndex = 34;
         // 
         // txbNome
         // 
         this.txbNome.Enabled = false;
         this.txbNome.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbNome.Location = new System.Drawing.Point(188, 43);
         this.txbNome.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
         this.txbNome.Name = "txbNome";
         this.txbNome.Size = new System.Drawing.Size(455, 25);
         this.txbNome.TabIndex = 31;
         // 
         // txbDescricao
         // 
         this.txbDescricao.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbDescricao.Location = new System.Drawing.Point(116, 118);
         this.txbDescricao.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbDescricao.Name = "txbDescricao";
         this.txbDescricao.Size = new System.Drawing.Size(529, 25);
         this.txbDescricao.TabIndex = 32;
         // 
         // txbMatricula
         // 
         this.txbMatricula.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbMatricula.Location = new System.Drawing.Point(18, 43);
         this.txbMatricula.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbMatricula.Name = "txbMatricula";
         this.txbMatricula.Size = new System.Drawing.Size(156, 25);
         this.txbMatricula.TabIndex = 42;
         // 
         // txbData
         // 
         this.txbData.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbData.Location = new System.Drawing.Point(18, 118);
         this.txbData.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbData.Name = "txbData";
         this.txbData.Size = new System.Drawing.Size(80, 25);
         this.txbData.TabIndex = 42;
         // 
         // txbCodAluno
         // 
         this.txbCodAluno.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbCodAluno.Location = new System.Drawing.Point(684, 43);
         this.txbCodAluno.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbCodAluno.Name = "txbCodAluno";
         this.txbCodAluno.Size = new System.Drawing.Size(63, 25);
         this.txbCodAluno.TabIndex = 34;
         // 
         // frmCadCertificado
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.ClientSize = new System.Drawing.Size(784, 561);
         this.Name = "frmCadCertificado";
         this.Text = "Cadastro - Atividade Complementar";
         this.panel1.ResumeLayout(false);
         this.pnDados.ResumeLayout(false);
         this.pnDados.PerformLayout();
         this.ResumeLayout(false);

      }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobClassificacao;
        private System.Windows.Forms.TextBox txbCargaHoraria;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.TextBox txbMatricula;
        private System.Windows.Forms.TextBox txbData;
        private System.Windows.Forms.TextBox txbCodAluno;
    }
}
