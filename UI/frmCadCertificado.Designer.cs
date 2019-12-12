namespace SIGAC_Sistema_Gestao_Atividades_Complementares
{
   partial class frmCadCertificado
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCertificado));
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.cobClassificacao = new System.Windows.Forms.ComboBox();
         this.prbAluno = new System.Windows.Forms.ProgressBar();
         this.txbAluno = new System.Windows.Forms.TextBox();
         this.txbMatricula = new System.Windows.Forms.TextBox();
         this.btnSalvar = new System.Windows.Forms.Button();
         this.btnSair = new System.Windows.Forms.Button();
         this.txbData = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.txbDescricao = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.txbCargaHoraria = new System.Windows.Forms.TextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(129, 24);
         this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(146, 19);
         this.label2.TabIndex = 7;
         this.label2.Text = "NOME DO ALUNO";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(12, 162);
         this.label3.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(136, 19);
         this.label3.TabIndex = 9;
         this.label3.Text = "CLASSIFICAÇÃO";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(12, 24);
         this.label1.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(106, 19);
         this.label1.TabIndex = 10;
         this.label1.Text = "MATRÍCULA";
         // 
         // cobClassificacao
         // 
         this.cobClassificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cobClassificacao.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cobClassificacao.FormattingEnabled = true;
         this.cobClassificacao.Location = new System.Drawing.Point(16, 187);
         this.cobClassificacao.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
         this.cobClassificacao.Name = "cobClassificacao";
         this.cobClassificacao.Size = new System.Drawing.Size(476, 25);
         this.cobClassificacao.TabIndex = 4;
         // 
         // prbAluno
         // 
         this.prbAluno.Location = new System.Drawing.Point(1, 302);
         this.prbAluno.Name = "prbAluno";
         this.prbAluno.Size = new System.Drawing.Size(595, 23);
         this.prbAluno.TabIndex = 13;
         // 
         // txbAluno
         // 
         this.txbAluno.Enabled = false;
         this.txbAluno.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbAluno.Location = new System.Drawing.Point(128, 49);
         this.txbAluno.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
         this.txbAluno.Name = "txbAluno";
         this.txbAluno.Size = new System.Drawing.Size(364, 25);
         this.txbAluno.TabIndex = 1;
         // 
         // txbMatricula
         // 
         this.txbMatricula.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbMatricula.Location = new System.Drawing.Point(16, 49);
         this.txbMatricula.Margin = new System.Windows.Forms.Padding(15, 3, 4, 5);
         this.txbMatricula.Name = "txbMatricula";
         this.txbMatricula.Size = new System.Drawing.Size(102, 25);
         this.txbMatricula.TabIndex = 0;
         // 
         // btnSalvar
         // 
         this.btnSalvar.AutoSize = true;
         this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
         this.btnSalvar.Location = new System.Drawing.Point(450, 240);
         this.btnSalvar.Name = "btnSalvar";
         this.btnSalvar.Size = new System.Drawing.Size(55, 41);
         this.btnSalvar.TabIndex = 6;
         this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnSalvar.UseVisualStyleBackColor = true;
         // 
         // btnSair
         // 
         this.btnSair.AutoSize = true;
         this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnSair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
         this.btnSair.Location = new System.Drawing.Point(527, 240);
         this.btnSair.Name = "btnSair";
         this.btnSair.Size = new System.Drawing.Size(55, 41);
         this.btnSair.TabIndex = 7;
         this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnSair.UseVisualStyleBackColor = true;
         // 
         // txbData
         // 
         this.txbData.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbData.Location = new System.Drawing.Point(502, 49);
         this.txbData.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbData.Name = "txbData";
         this.txbData.Size = new System.Drawing.Size(80, 25);
         this.txbData.TabIndex = 2;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(498, 24);
         this.label4.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(51, 19);
         this.label4.TabIndex = 10;
         this.label4.Text = "DATA";
         // 
         // txbDescricao
         // 
         this.txbDescricao.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbDescricao.Location = new System.Drawing.Point(16, 117);
         this.txbDescricao.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbDescricao.Name = "txbDescricao";
         this.txbDescricao.Size = new System.Drawing.Size(566, 25);
         this.txbDescricao.TabIndex = 3;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(12, 92);
         this.label5.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(244, 19);
         this.label5.TabIndex = 10;
         this.label5.Text = "DESCRIÇÃO DO CERTIFICADO";
         // 
         // txbCargaHoraria
         // 
         this.txbCargaHoraria.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbCargaHoraria.Location = new System.Drawing.Point(502, 187);
         this.txbCargaHoraria.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbCargaHoraria.Name = "txbCargaHoraria";
         this.txbCargaHoraria.Size = new System.Drawing.Size(80, 25);
         this.txbCargaHoraria.TabIndex = 5;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(498, 162);
         this.label6.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(40, 19);
         this.label6.TabIndex = 10;
         this.label6.Text = "C. H";
         // 
         // frmCadCertificados
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(597, 329);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.cobClassificacao);
         this.Controls.Add(this.prbAluno);
         this.Controls.Add(this.txbCargaHoraria);
         this.Controls.Add(this.txbData);
         this.Controls.Add(this.txbAluno);
         this.Controls.Add(this.txbDescricao);
         this.Controls.Add(this.txbMatricula);
         this.Controls.Add(this.btnSalvar);
         this.Controls.Add(this.btnSair);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmCadCertificados";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Cadastros - Certificados";
         this.TopMost = true;
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox cobClassificacao;
      private System.Windows.Forms.ProgressBar prbAluno;
      private System.Windows.Forms.TextBox txbAluno;
      private System.Windows.Forms.TextBox txbMatricula;
      private System.Windows.Forms.Button btnSalvar;
      private System.Windows.Forms.Button btnSair;
      private System.Windows.Forms.TextBox txbData;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txbDescricao;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox txbCargaHoraria;
      private System.Windows.Forms.Label label6;
   }
}