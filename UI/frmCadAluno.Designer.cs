namespace SIGAC_Sistema_Gestao_Atividades_Complementares
{
   partial class CodigoCurso
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodigoCurso));
         this.label1 = new System.Windows.Forms.Label();
         this.txbMatricula = new System.Windows.Forms.TextBox();
         this.prbAluno = new System.Windows.Forms.ProgressBar();
         this.cobCurso = new System.Windows.Forms.ComboBox();
         this.txbNome = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.cobTurma = new System.Windows.Forms.ComboBox();
         this.label4 = new System.Windows.Forms.Label();
         this.btnSalvar = new System.Windows.Forms.Button();
         this.btnSair = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(20, 19);
         this.label1.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(106, 19);
         this.label1.TabIndex = 1;
         this.label1.Text = "MATRÍCULA";
         // 
         // txbMatricula
         // 
         this.txbMatricula.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbMatricula.Location = new System.Drawing.Point(24, 44);
         this.txbMatricula.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbMatricula.Name = "txbMatricula";
         this.txbMatricula.Size = new System.Drawing.Size(102, 25);
         this.txbMatricula.TabIndex = 0;
         // 
         // prbAluno
         // 
         this.prbAluno.Location = new System.Drawing.Point(1, 210);
         this.prbAluno.Name = "prbAluno";
         this.prbAluno.Size = new System.Drawing.Size(529, 23);
         this.prbAluno.TabIndex = 3;
         // 
         // cobCurso
         // 
         this.cobCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cobCurso.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cobCurso.FormattingEnabled = true;
         this.cobCurso.Location = new System.Drawing.Point(24, 112);
         this.cobCurso.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
         this.cobCurso.Name = "cobCurso";
         this.cobCurso.Size = new System.Drawing.Size(206, 25);
         this.cobCurso.TabIndex = 2;
         // 
         // txbNome
         // 
         this.txbNome.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbNome.Location = new System.Drawing.Point(136, 44);
         this.txbNome.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
         this.txbNome.Name = "txbNome";
         this.txbNome.Size = new System.Drawing.Size(364, 25);
         this.txbNome.TabIndex = 1;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(137, 19);
         this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(146, 19);
         this.label2.TabIndex = 1;
         this.label2.Text = "NOME DO ALUNO";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(20, 87);
         this.label3.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(64, 19);
         this.label3.TabIndex = 1;
         this.label3.Text = "CURSO";
         // 
         // cobTurma
         // 
         this.cobTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cobTurma.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cobTurma.FormattingEnabled = true;
         this.cobTurma.Items.AddRange(new object[] {
            "1º ANO",
            "2º ANO",
            "3º ANO",
            "4º ANO"});
         this.cobTurma.Location = new System.Drawing.Point(240, 112);
         this.cobTurma.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
         this.cobTurma.Name = "cobTurma";
         this.cobTurma.Size = new System.Drawing.Size(119, 25);
         this.cobTurma.TabIndex = 3;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(236, 87);
         this.label4.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(108, 19);
         this.label4.TabIndex = 1;
         this.label4.Text = "ANO TURMA";
         // 
         // btnSalvar
         // 
         this.btnSalvar.AutoSize = true;
         this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
         this.btnSalvar.Location = new System.Drawing.Point(369, 155);
         this.btnSalvar.Name = "btnSalvar";
         this.btnSalvar.Size = new System.Drawing.Size(55, 41);
         this.btnSalvar.TabIndex = 4;
         this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnSalvar.UseVisualStyleBackColor = true;
         this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
         // 
         // btnSair
         // 
         this.btnSair.AutoSize = true;
         this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnSair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
         this.btnSair.Location = new System.Drawing.Point(446, 155);
         this.btnSair.Name = "btnSair";
         this.btnSair.Size = new System.Drawing.Size(55, 41);
         this.btnSair.TabIndex = 5;
         this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnSair.UseVisualStyleBackColor = true;
         this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
         // 
         // CodigoCurso
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(530, 237);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.cobTurma);
         this.Controls.Add(this.cobCurso);
         this.Controls.Add(this.prbAluno);
         this.Controls.Add(this.txbNome);
         this.Controls.Add(this.txbMatricula);
         this.Controls.Add(this.btnSalvar);
         this.Controls.Add(this.btnSair);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "CodigoCurso";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Cadastros - Alunos";
         this.Load += new System.EventHandler(this.CodigoCurso_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnSair;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txbMatricula;
      private System.Windows.Forms.ProgressBar prbAluno;
      private System.Windows.Forms.ComboBox cobCurso;
      private System.Windows.Forms.TextBox txbNome;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.ComboBox cobTurma;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button btnSalvar;
   }
}

