﻿namespace UI
{
   partial class frmCadAtividade
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadAtividade));
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.cobGrupo = new System.Windows.Forms.ComboBox();
         this.prbAtividade = new System.Windows.Forms.ProgressBar();
         this.txbCargaHoraria = new System.Windows.Forms.TextBox();
         this.txbDescricao = new System.Windows.Forms.TextBox();
         this.btnSalvar = new System.Windows.Forms.Button();
         this.btnSair = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label2
         // 
         this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(592, 123);
         this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(44, 19);
         this.label2.TabIndex = 19;
         this.label2.Text = "C. H.";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(148, 191);
         this.label3.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(65, 19);
         this.label3.TabIndex = 20;
         this.label3.Text = "GRUPO";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(148, 123);
         this.label1.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(362, 19);
         this.label1.TabIndex = 21;
         this.label1.Text = "DESCRIÇÃO DA ATIVIDADE COMPLEMENTAR";
         // 
         // cobGrupo
         // 
         this.cobGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cobGrupo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cobGrupo.FormattingEnabled = true;
         this.cobGrupo.Location = new System.Drawing.Point(152, 216);
         this.cobGrupo.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
         this.cobGrupo.Name = "cobGrupo";
         this.cobGrupo.Size = new System.Drawing.Size(179, 25);
         this.cobGrupo.TabIndex = 16;
         // 
         // prbAtividade
         // 
         this.prbAtividade.Location = new System.Drawing.Point(136, 305);
         this.prbAtividade.Name = "prbAtividade";
         this.prbAtividade.Size = new System.Drawing.Size(529, 23);
         this.prbAtividade.TabIndex = 22;
         // 
         // txbCargaHoraria
         // 
         this.txbCargaHoraria.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbCargaHoraria.Location = new System.Drawing.Point(591, 148);
         this.txbCargaHoraria.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
         this.txbCargaHoraria.Name = "txbCargaHoraria";
         this.txbCargaHoraria.Size = new System.Drawing.Size(54, 25);
         this.txbCargaHoraria.TabIndex = 15;
         // 
         // txbDescricao
         // 
         this.txbDescricao.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbDescricao.Location = new System.Drawing.Point(152, 148);
         this.txbDescricao.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbDescricao.Name = "txbDescricao";
         this.txbDescricao.Size = new System.Drawing.Size(429, 25);
         this.txbDescricao.TabIndex = 14;
         // 
         // btnSalvar
         // 
         this.btnSalvar.AutoSize = true;
         this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
         this.btnSalvar.Location = new System.Drawing.Point(514, 247);
         this.btnSalvar.Name = "btnSalvar";
         this.btnSalvar.Size = new System.Drawing.Size(55, 41);
         this.btnSalvar.TabIndex = 17;
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
         this.btnSair.Location = new System.Drawing.Point(591, 247);
         this.btnSair.Name = "btnSair";
         this.btnSair.Size = new System.Drawing.Size(55, 41);
         this.btnSair.TabIndex = 18;
         this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnSair.UseVisualStyleBackColor = true;
         this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
         // 
         // frmCadAtividade
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.cobGrupo);
         this.Controls.Add(this.prbAtividade);
         this.Controls.Add(this.txbCargaHoraria);
         this.Controls.Add(this.txbDescricao);
         this.Controls.Add(this.btnSalvar);
         this.Controls.Add(this.btnSair);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "frmCadAtividade";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Cadastro - Atividades Complementares";
         this.Load += new System.EventHandler(this.frmCadAtividade_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobGrupo;
        private System.Windows.Forms.ProgressBar prbAtividade;
        private System.Windows.Forms.TextBox txbCargaHoraria;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
    }
}