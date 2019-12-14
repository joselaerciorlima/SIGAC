namespace UI
{
   partial class frmCadAluno
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadAluno));
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.btnNovo = new System.Windows.Forms.ToolStripButton();
         this.btnEditar = new System.Windows.Forms.ToolStripButton();
         this.btnExcluir = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.btnSalvar = new System.Windows.Forms.ToolStripButton();
         this.btnCancelar = new System.Windows.Forms.ToolStripButton();
         this.panel1 = new System.Windows.Forms.Panel();
         this.pnlDados = new System.Windows.Forms.Panel();
         this.label2 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.cobTurma = new System.Windows.Forms.ComboBox();
         this.cobCurso = new System.Windows.Forms.ComboBox();
         this.txbNome = new System.Windows.Forms.TextBox();
         this.txbMatricula = new System.Windows.Forms.TextBox();
         this.pnlLista = new System.Windows.Forms.Panel();
         this.dgvAluno = new System.Windows.Forms.DataGridView();
         this.clnMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.toolStrip1.SuspendLayout();
         this.panel1.SuspendLayout();
         this.pnlDados.SuspendLayout();
         this.pnlLista.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
         this.SuspendLayout();
         // 
         // toolStrip1
         // 
         this.toolStrip1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnEditar,
            this.btnExcluir,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.btnSalvar,
            this.btnCancelar});
         this.toolStrip1.Location = new System.Drawing.Point(0, 0);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(784, 39);
         this.toolStrip1.TabIndex = 17;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // btnNovo
         // 
         this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
         this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.btnNovo.Name = "btnNovo";
         this.btnNovo.Size = new System.Drawing.Size(101, 36);
         this.btnNovo.Text = "Novo";
         this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
         // 
         // btnEditar
         // 
         this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
         this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.btnEditar.Name = "btnEditar";
         this.btnEditar.Size = new System.Drawing.Size(107, 36);
         this.btnEditar.Text = "Editar";
         // 
         // btnExcluir
         // 
         this.btnExcluir.Enabled = false;
         this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
         this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.btnExcluir.Name = "btnExcluir";
         this.btnExcluir.Size = new System.Drawing.Size(118, 36);
         this.btnExcluir.Text = "Excluir";
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
         // 
         // btnSalvar
         // 
         this.btnSalvar.Enabled = false;
         this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
         this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
         this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.btnSalvar.Name = "btnSalvar";
         this.btnSalvar.Size = new System.Drawing.Size(108, 36);
         this.btnSalvar.Text = "Salvar";
         this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
         // 
         // btnCancelar
         // 
         this.btnCancelar.Enabled = false;
         this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
         this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.btnCancelar.Name = "btnCancelar";
         this.btnCancelar.Size = new System.Drawing.Size(134, 36);
         this.btnCancelar.Text = "Cancelar";
         this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.Aqua;
         this.panel1.Controls.Add(this.toolStrip1);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(784, 47);
         this.panel1.TabIndex = 18;
         // 
         // pnlDados
         // 
         this.pnlDados.BackColor = System.Drawing.Color.Lime;
         this.pnlDados.Controls.Add(this.label2);
         this.pnlDados.Controls.Add(this.label4);
         this.pnlDados.Controls.Add(this.label3);
         this.pnlDados.Controls.Add(this.label1);
         this.pnlDados.Controls.Add(this.cobTurma);
         this.pnlDados.Controls.Add(this.cobCurso);
         this.pnlDados.Controls.Add(this.txbNome);
         this.pnlDados.Controls.Add(this.txbMatricula);
         this.pnlDados.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pnlDados.Enabled = false;
         this.pnlDados.Location = new System.Drawing.Point(0, 47);
         this.pnlDados.Name = "pnlDados";
         this.pnlDados.Size = new System.Drawing.Size(784, 514);
         this.pnlDados.TabIndex = 19;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(191, 10);
         this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(146, 19);
         this.label2.TabIndex = 18;
         this.label2.Text = "NOME DO ALUNO";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(362, 72);
         this.label4.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(108, 19);
         this.label4.TabIndex = 19;
         this.label4.Text = "ANO TURMA";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(20, 72);
         this.label3.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(64, 19);
         this.label3.TabIndex = 20;
         this.label3.Text = "CURSO";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(20, 10);
         this.label1.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(106, 19);
         this.label1.TabIndex = 21;
         this.label1.Text = "MATRÍCULA";
         // 
         // cobTurma
         // 
         this.cobTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cobTurma.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cobTurma.FormattingEnabled = true;
         this.cobTurma.Location = new System.Drawing.Point(366, 97);
         this.cobTurma.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
         this.cobTurma.Name = "cobTurma";
         this.cobTurma.Size = new System.Drawing.Size(119, 25);
         this.cobTurma.TabIndex = 24;
         // 
         // cobCurso
         // 
         this.cobCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cobCurso.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cobCurso.FormattingEnabled = true;
         this.cobCurso.Location = new System.Drawing.Point(24, 97);
         this.cobCurso.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
         this.cobCurso.Name = "cobCurso";
         this.cobCurso.Size = new System.Drawing.Size(332, 25);
         this.cobCurso.TabIndex = 23;
         // 
         // txbNome
         // 
         this.txbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txbNome.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbNome.Location = new System.Drawing.Point(190, 35);
         this.txbNome.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
         this.txbNome.Name = "txbNome";
         this.txbNome.Size = new System.Drawing.Size(582, 25);
         this.txbNome.TabIndex = 22;
         // 
         // txbMatricula
         // 
         this.txbMatricula.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbMatricula.Location = new System.Drawing.Point(24, 35);
         this.txbMatricula.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbMatricula.Name = "txbMatricula";
         this.txbMatricula.Size = new System.Drawing.Size(156, 25);
         this.txbMatricula.TabIndex = 17;
         // 
         // pnlLista
         // 
         this.pnlLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.pnlLista.Controls.Add(this.dgvAluno);
         this.pnlLista.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.pnlLista.Enabled = false;
         this.pnlLista.Location = new System.Drawing.Point(0, 202);
         this.pnlLista.Name = "pnlLista";
         this.pnlLista.Size = new System.Drawing.Size(784, 359);
         this.pnlLista.TabIndex = 0;
         // 
         // dgvAluno
         // 
         this.dgvAluno.AllowUserToAddRows = false;
         this.dgvAluno.AllowUserToDeleteRows = false;
         dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dgvAluno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
         this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         this.dgvAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnMatricula,
            this.clnNome,
            this.clnCurso,
            this.clnTurma});
         this.dgvAluno.Location = new System.Drawing.Point(12, 3);
         this.dgvAluno.MultiSelect = false;
         this.dgvAluno.Name = "dgvAluno";
         this.dgvAluno.ReadOnly = true;
         this.dgvAluno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle17.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dgvAluno.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
         this.dgvAluno.RowHeadersVisible = false;
         this.dgvAluno.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
         dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle18.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
         this.dgvAluno.RowsDefaultCellStyle = dataGridViewCellStyle18;
         this.dgvAluno.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         this.dgvAluno.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dgvAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dgvAluno.Size = new System.Drawing.Size(760, 323);
         this.dgvAluno.TabIndex = 26;
         this.dgvAluno.TabStop = false;
         // 
         // clnMatricula
         // 
         this.clnMatricula.HeaderText = "MATRÍCULA";
         this.clnMatricula.Name = "clnMatricula";
         this.clnMatricula.ReadOnly = true;
         this.clnMatricula.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.clnMatricula.Width = 110;
         // 
         // clnNome
         // 
         this.clnNome.HeaderText = "NOME DO ALUNO";
         this.clnNome.Name = "clnNome";
         this.clnNome.ReadOnly = true;
         this.clnNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.clnNome.Width = 330;
         // 
         // clnCurso
         // 
         this.clnCurso.HeaderText = "CURSO";
         this.clnCurso.Name = "clnCurso";
         this.clnCurso.ReadOnly = true;
         this.clnCurso.Width = 190;
         // 
         // clnTurma
         // 
         this.clnTurma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.clnTurma.HeaderText = "TURMA";
         this.clnTurma.Name = "clnTurma";
         this.clnTurma.ReadOnly = true;
         // 
         // frmCadAluno
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(784, 561);
         this.Controls.Add(this.pnlLista);
         this.Controls.Add(this.pnlDados);
         this.Controls.Add(this.panel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmCadAluno";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Cadastro - Aluno";
         this.Load += new System.EventHandler(this.frmCadAluno_Load);
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.pnlDados.ResumeLayout(false);
         this.pnlDados.PerformLayout();
         this.pnlLista.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
         this.ResumeLayout(false);

      }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Panel pnlLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobTurma;
        protected System.Windows.Forms.ComboBox cobCurso;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbMatricula;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
      private System.Windows.Forms.DataGridView dgvAluno;
      private System.Windows.Forms.DataGridViewTextBoxColumn clnMatricula;
      private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
      private System.Windows.Forms.DataGridViewTextBoxColumn clnCurso;
      private System.Windows.Forms.DataGridViewTextBoxColumn clnTurma;
   }
}