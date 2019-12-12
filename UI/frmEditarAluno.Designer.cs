namespace SIGAC_Sistema_Gestao_Atividades_Complementares
{
   partial class frmEditarAluno
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarAluno));
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         this.label2 = new System.Windows.Forms.Label();
         this.txbFiltro = new System.Windows.Forms.TextBox();
         this.btnSalvar = new System.Windows.Forms.Button();
         this.btnSair = new System.Windows.Forms.Button();
         this.dgvAluno = new System.Windows.Forms.DataGridView();
         this.btnPesquisar = new System.Windows.Forms.Button();
         this.btnExcluir = new System.Windows.Forms.Button();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.label8 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.cobTurma = new System.Windows.Forms.ComboBox();
         this.cobCurso = new System.Windows.Forms.ComboBox();
         this.txbAluno = new System.Windows.Forms.TextBox();
         this.txbMatricula = new System.Windows.Forms.TextBox();
         this.clnMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(16, 24);
         this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(260, 19);
         this.label2.TabIndex = 7;
         this.label2.Text = "Digite a matrícula ou o nome do aluno";
         // 
         // txbFiltro
         // 
         this.txbFiltro.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbFiltro.Location = new System.Drawing.Point(20, 49);
         this.txbFiltro.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
         this.txbFiltro.Name = "txbFiltro";
         this.txbFiltro.Size = new System.Drawing.Size(359, 25);
         this.txbFiltro.TabIndex = 0;
         // 
         // btnSalvar
         // 
         this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
         this.btnSalvar.Location = new System.Drawing.Point(226, 545);
         this.btnSalvar.Name = "btnSalvar";
         this.btnSalvar.Size = new System.Drawing.Size(55, 41);
         this.btnSalvar.TabIndex = 9;
         this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnSalvar.UseVisualStyleBackColor = true;
         // 
         // btnSair
         // 
         this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnSair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
         this.btnSair.Location = new System.Drawing.Point(436, 545);
         this.btnSair.Name = "btnSair";
         this.btnSair.Size = new System.Drawing.Size(55, 41);
         this.btnSair.TabIndex = 10;
         this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnSair.UseVisualStyleBackColor = true;
         // 
         // dgvAluno
         // 
         this.dgvAluno.AllowUserToDeleteRows = false;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dgvAluno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         this.dgvAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnMatricula,
            this.clnNome});
         this.dgvAluno.Location = new System.Drawing.Point(20, 101);
         this.dgvAluno.MultiSelect = false;
         this.dgvAluno.Name = "dgvAluno";
         this.dgvAluno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dgvAluno.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
         this.dgvAluno.RowHeadersVisible = false;
         this.dgvAluno.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
         this.dgvAluno.RowsDefaultCellStyle = dataGridViewCellStyle3;
         this.dgvAluno.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         this.dgvAluno.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dgvAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dgvAluno.Size = new System.Drawing.Size(472, 238);
         this.dgvAluno.TabIndex = 2;
         this.dgvAluno.TabStop = false;
         // 
         // btnPesquisar
         // 
         this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnPesquisar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
         this.btnPesquisar.Location = new System.Drawing.Point(405, 41);
         this.btnPesquisar.Name = "btnPesquisar";
         this.btnPesquisar.Size = new System.Drawing.Size(55, 41);
         this.btnPesquisar.TabIndex = 1;
         this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnPesquisar.UseVisualStyleBackColor = true;
         // 
         // btnExcluir
         // 
         this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnExcluir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
         this.btnExcluir.Location = new System.Drawing.Point(16, 545);
         this.btnExcluir.Name = "btnExcluir";
         this.btnExcluir.Size = new System.Drawing.Size(55, 41);
         this.btnExcluir.TabIndex = 8;
         this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnExcluir.UseVisualStyleBackColor = true;
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.label8);
         this.groupBox1.Controls.Add(this.label7);
         this.groupBox1.Controls.Add(this.label6);
         this.groupBox1.Controls.Add(this.label5);
         this.groupBox1.Controls.Add(this.cobTurma);
         this.groupBox1.Controls.Add(this.cobCurso);
         this.groupBox1.Controls.Add(this.txbAluno);
         this.groupBox1.Controls.Add(this.txbMatricula);
         this.groupBox1.Location = new System.Drawing.Point(8, 358);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(495, 171);
         this.groupBox1.TabIndex = 3;
         this.groupBox1.TabStop = false;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label8.Location = new System.Drawing.Point(125, 26);
         this.label8.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(146, 19);
         this.label8.TabIndex = 15;
         this.label8.Text = "NOME DO ALUNO";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.Location = new System.Drawing.Point(224, 94);
         this.label7.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(108, 19);
         this.label7.TabIndex = 16;
         this.label7.Text = "ANO TURMA";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(8, 94);
         this.label6.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(64, 19);
         this.label6.TabIndex = 17;
         this.label6.Text = "CURSO";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(8, 26);
         this.label5.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(106, 19);
         this.label5.TabIndex = 18;
         this.label5.Text = "MATRÍCULA";
         // 
         // cobTurma
         // 
         this.cobTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cobTurma.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cobTurma.FormattingEnabled = true;
         this.cobTurma.Location = new System.Drawing.Point(228, 119);
         this.cobTurma.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
         this.cobTurma.Name = "cobTurma";
         this.cobTurma.Size = new System.Drawing.Size(119, 25);
         this.cobTurma.TabIndex = 7;
         // 
         // cobCurso
         // 
         this.cobCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cobCurso.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cobCurso.FormattingEnabled = true;
         this.cobCurso.Location = new System.Drawing.Point(12, 119);
         this.cobCurso.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
         this.cobCurso.Name = "cobCurso";
         this.cobCurso.Size = new System.Drawing.Size(206, 25);
         this.cobCurso.TabIndex = 6;
         // 
         // txbAluno
         // 
         this.txbAluno.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbAluno.Location = new System.Drawing.Point(124, 51);
         this.txbAluno.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
         this.txbAluno.Name = "txbAluno";
         this.txbAluno.Size = new System.Drawing.Size(364, 25);
         this.txbAluno.TabIndex = 5;
         // 
         // txbMatricula
         // 
         this.txbMatricula.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbMatricula.Location = new System.Drawing.Point(12, 51);
         this.txbMatricula.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbMatricula.Name = "txbMatricula";
         this.txbMatricula.Size = new System.Drawing.Size(102, 25);
         this.txbMatricula.TabIndex = 4;
         // 
         // clnMatricula
         // 
         this.clnMatricula.HeaderText = "MATRÍCULA";
         this.clnMatricula.Name = "clnMatricula";
         this.clnMatricula.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.clnMatricula.Width = 110;
         // 
         // clnNome
         // 
         this.clnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.clnNome.HeaderText = "NOME DO ALUNO";
         this.clnNome.Name = "clnNome";
         this.clnNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         // 
         // frmEditarAluno
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(511, 606);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.dgvAluno);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txbFiltro);
         this.Controls.Add(this.btnPesquisar);
         this.Controls.Add(this.btnExcluir);
         this.Controls.Add(this.btnSalvar);
         this.Controls.Add(this.btnSair);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmEditarAluno";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Editar Cadastro - Aluno";
         this.TopMost = true;
         ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txbFiltro;
      private System.Windows.Forms.Button btnSalvar;
      private System.Windows.Forms.Button btnSair;
      private System.Windows.Forms.DataGridView dgvAluno;
      private System.Windows.Forms.Button btnPesquisar;
      private System.Windows.Forms.Button btnExcluir;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.ComboBox cobTurma;
      private System.Windows.Forms.ComboBox cobCurso;
      private System.Windows.Forms.TextBox txbAluno;
      private System.Windows.Forms.TextBox txbMatricula;
      private System.Windows.Forms.DataGridViewTextBoxColumn clnMatricula;
      private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
   }
}