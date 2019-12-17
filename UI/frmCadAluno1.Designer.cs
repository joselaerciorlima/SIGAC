namespace UI
{
   partial class frmCadAluno1
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
         this.label3 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.cobTurma = new System.Windows.Forms.ComboBox();
         this.cobCurso = new System.Windows.Forms.ComboBox();
         this.txbNome = new System.Windows.Forms.TextBox();
         this.txbMatricula = new System.Windows.Forms.TextBox();
         this.txbCodAluno = new System.Windows.Forms.TextBox();
         this.panel1.SuspendLayout();
         this.pnDados.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Size = new System.Drawing.Size(681, 52);
         // 
         // pnDados
         // 
         this.pnDados.BackColor = System.Drawing.SystemColors.Control;
         this.pnDados.Controls.Add(this.label2);
         this.pnDados.Controls.Add(this.label4);
         this.pnDados.Controls.Add(this.label3);
         this.pnDados.Controls.Add(this.label1);
         this.pnDados.Controls.Add(this.cobTurma);
         this.pnDados.Controls.Add(this.cobCurso);
         this.pnDados.Controls.Add(this.txbNome);
         this.pnDados.Controls.Add(this.txbCodAluno);
         this.pnDados.Controls.Add(this.txbMatricula);
         this.pnDados.Size = new System.Drawing.Size(681, 346);
         // 
         // panel2
         // 
         this.panel2.BackColor = System.Drawing.SystemColors.Control;
         this.panel2.Location = new System.Drawing.Point(0, 398);
         this.panel2.Size = new System.Drawing.Size(681, 30);
         // 
         // btnNovo
         // 
         this.btnNovo.Location = new System.Drawing.Point(9, 2);
         this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
         // 
         // btnCancelar
         // 
         this.btnCancelar.Location = new System.Drawing.Point(564, 2);
         this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
         // 
         // btnLocalizar
         // 
         this.btnLocalizar.Location = new System.Drawing.Point(111, 2);
         this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
         // 
         // btnSalvar
         // 
         this.btnSalvar.Location = new System.Drawing.Point(460, 2);
         this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
         // 
         // btnEditar
         // 
         this.btnEditar.Location = new System.Drawing.Point(231, 2);
         this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
         // 
         // btnExcluir
         // 
         this.btnExcluir.Location = new System.Drawing.Point(333, 2);
         this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(12, 93);
         this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(146, 19);
         this.label2.TabIndex = 26;
         this.label2.Text = "NOME DO ALUNO";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(12, 243);
         this.label4.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(108, 19);
         this.label4.TabIndex = 27;
         this.label4.Text = "ANO TURMA";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(12, 168);
         this.label3.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(64, 19);
         this.label3.TabIndex = 28;
         this.label3.Text = "CURSO";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(12, 18);
         this.label1.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(106, 19);
         this.label1.TabIndex = 29;
         this.label1.Text = "MATRÍCULA";
         // 
         // cobTurma
         // 
         this.cobTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cobTurma.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cobTurma.FormattingEnabled = true;
         this.cobTurma.Location = new System.Drawing.Point(16, 268);
         this.cobTurma.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
         this.cobTurma.Name = "cobTurma";
         this.cobTurma.Size = new System.Drawing.Size(119, 25);
         this.cobTurma.TabIndex = 32;
         // 
         // cobCurso
         // 
         this.cobCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cobCurso.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cobCurso.FormattingEnabled = true;
         this.cobCurso.Location = new System.Drawing.Point(16, 193);
         this.cobCurso.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
         this.cobCurso.Name = "cobCurso";
         this.cobCurso.Size = new System.Drawing.Size(332, 25);
         this.cobCurso.TabIndex = 31;
         // 
         // txbNome
         // 
         this.txbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txbNome.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbNome.Location = new System.Drawing.Point(16, 118);
         this.txbNome.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
         this.txbNome.Name = "txbNome";
         this.txbNome.Size = new System.Drawing.Size(582, 25);
         this.txbNome.TabIndex = 30;
         // 
         // txbMatricula
         // 
         this.txbMatricula.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbMatricula.Location = new System.Drawing.Point(16, 43);
         this.txbMatricula.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbMatricula.Name = "txbMatricula";
         this.txbMatricula.Size = new System.Drawing.Size(156, 25);
         this.txbMatricula.TabIndex = 25;
         this.txbMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMatricula_KeyPress);
         // 
         // txbCodAluno
         // 
         this.txbCodAluno.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbCodAluno.Location = new System.Drawing.Point(192, 43);
         this.txbCodAluno.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbCodAluno.Name = "txbCodAluno";
         this.txbCodAluno.Size = new System.Drawing.Size(156, 25);
         this.txbCodAluno.TabIndex = 25;
         this.txbCodAluno.Visible = false;
         this.txbCodAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMatricula_KeyPress);
         // 
         // frmCadAluno1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.ClientSize = new System.Drawing.Size(681, 428);
         this.Name = "frmCadAluno1";
         this.Text = "Cadastro - Aluno";
         this.Load += new System.EventHandler(this.frmCadAluno1_Load);
         this.panel1.ResumeLayout(false);
         this.pnDados.ResumeLayout(false);
         this.pnDados.PerformLayout();
         this.ResumeLayout(false);

      }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobTurma;
        protected System.Windows.Forms.ComboBox cobCurso;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbMatricula;
        private System.Windows.Forms.TextBox txbCodAluno;
    }
}
