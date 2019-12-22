namespace UI
{
   partial class frmCadAluno
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadAluno));
         this.label2 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.cobTurma = new System.Windows.Forms.ComboBox();
         this.cobCurso = new System.Windows.Forms.ComboBox();
         this.txbNome = new System.Windows.Forms.TextBox();
         this.txbMatricula = new System.Windows.Forms.TextBox();
         this.txbCodAluno = new System.Windows.Forms.TextBox();
         this.dgvDados = new System.Windows.Forms.DataGridView();
         this.clnMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.button1 = new System.Windows.Forms.Button();
         this.rbNome = new System.Windows.Forms.RadioButton();
         this.rbMatricula = new System.Windows.Forms.RadioButton();
         this.label5 = new System.Windows.Forms.Label();
         this.txbFiltro = new System.Windows.Forms.TextBox();
         this.panel1.SuspendLayout();
         this.pnDados.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Size = new System.Drawing.Size(800, 63);
         // 
         // pnDados
         // 
         this.pnDados.Controls.Add(this.dgvDados);
         this.pnDados.Controls.Add(this.button1);
         this.pnDados.Controls.Add(this.rbNome);
         this.pnDados.Controls.Add(this.rbMatricula);
         this.pnDados.Controls.Add(this.label5);
         this.pnDados.Controls.Add(this.txbFiltro);
         this.pnDados.Controls.Add(this.label2);
         this.pnDados.Controls.Add(this.label4);
         this.pnDados.Controls.Add(this.label3);
         this.pnDados.Controls.Add(this.label1);
         this.pnDados.Controls.Add(this.cobTurma);
         this.pnDados.Controls.Add(this.cobCurso);
         this.pnDados.Controls.Add(this.txbNome);
         this.pnDados.Controls.Add(this.txbCodAluno);
         this.pnDados.Controls.Add(this.txbMatricula);
         this.pnDados.Size = new System.Drawing.Size(800, 537);
         // 
         // btnNovo
         // 
         this.btnNovo.FlatAppearance.BorderSize = 0;
         this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
         this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
         // 
         // btnCancelar
         // 
         this.btnCancelar.FlatAppearance.BorderSize = 0;
         this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
         this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
         // 
         // btnLocalizar
         // 
         this.btnLocalizar.FlatAppearance.BorderSize = 0;
         this.btnLocalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
         this.btnLocalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
         // 
         // btnSalvar
         // 
         this.btnSalvar.FlatAppearance.BorderSize = 0;
         this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
         this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
         // 
         // btnEditar
         // 
         this.btnEditar.FlatAppearance.BorderSize = 0;
         this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
         this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
         // 
         // btnExcluir
         // 
         this.btnExcluir.FlatAppearance.BorderSize = 0;
         this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
         this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
         // 
         // btnFecharForm
         // 
         this.btnFecharForm.FlatAppearance.BorderSize = 0;
         this.btnFecharForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
         this.btnFecharForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.btnFecharForm.Location = new System.Drawing.Point(754, 2);
         this.btnFecharForm.Click += new System.EventHandler(this.btnFecharForm_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(180, 18);
         this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(126, 19);
         this.label2.TabIndex = 26;
         this.label2.Text = "Nome do Aluno";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(356, 89);
         this.label4.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(90, 19);
         this.label4.TabIndex = 27;
         this.label4.Text = "Ano Turma";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(14, 89);
         this.label3.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(54, 19);
         this.label3.TabIndex = 28;
         this.label3.Text = "Curso";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(14, 18);
         this.label1.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(90, 19);
         this.label1.TabIndex = 29;
         this.label1.Text = "Matrícula";
         // 
         // cobTurma
         // 
         this.cobTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cobTurma.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cobTurma.FormattingEnabled = true;
         this.cobTurma.Location = new System.Drawing.Point(360, 114);
         this.cobTurma.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
         this.cobTurma.Name = "cobTurma";
         this.cobTurma.Size = new System.Drawing.Size(119, 26);
         this.cobTurma.TabIndex = 32;
         // 
         // cobCurso
         // 
         this.cobCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cobCurso.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cobCurso.FormattingEnabled = true;
         this.cobCurso.Location = new System.Drawing.Point(18, 114);
         this.cobCurso.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
         this.cobCurso.Name = "cobCurso";
         this.cobCurso.Size = new System.Drawing.Size(332, 26);
         this.cobCurso.TabIndex = 31;
         // 
         // txbNome
         // 
         this.txbNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txbNome.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbNome.Location = new System.Drawing.Point(184, 43);
         this.txbNome.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
         this.txbNome.Name = "txbNome";
         this.txbNome.Size = new System.Drawing.Size(595, 25);
         this.txbNome.TabIndex = 30;
         // 
         // txbMatricula
         // 
         this.txbMatricula.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbMatricula.Location = new System.Drawing.Point(18, 43);
         this.txbMatricula.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbMatricula.Name = "txbMatricula";
         this.txbMatricula.Size = new System.Drawing.Size(156, 25);
         this.txbMatricula.TabIndex = 25;
         this.txbMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMatricula_KeyPress);
         // 
         // txbCodAluno
         // 
         this.txbCodAluno.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbCodAluno.Location = new System.Drawing.Point(545, 12);
         this.txbCodAluno.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbCodAluno.Name = "txbCodAluno";
         this.txbCodAluno.Size = new System.Drawing.Size(68, 25);
         this.txbCodAluno.TabIndex = 25;
         this.txbCodAluno.Visible = false;
         this.txbCodAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMatricula_KeyPress);
         // 
         // dgvDados
         // 
         this.dgvDados.AllowUserToAddRows = false;
         this.dgvDados.AllowUserToDeleteRows = false;
         this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.dgvDados.ColumnHeadersHeight = 27;
         this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnMatricula,
            this.clnNome,
            this.clnCurso,
            this.clnTurma,
            this.clnCodigo});
         this.dgvDados.Location = new System.Drawing.Point(21, 252);
         this.dgvDados.MultiSelect = false;
         this.dgvDados.Name = "dgvDados";
         this.dgvDados.ReadOnly = true;
         this.dgvDados.RowHeadersVisible = false;
         this.dgvDados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
         this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dgvDados.Size = new System.Drawing.Size(758, 261);
         this.dgvDados.TabIndex = 52;
         // 
         // clnMatricula
         // 
         this.clnMatricula.HeaderText = "MATRÍCULA";
         this.clnMatricula.Name = "clnMatricula";
         this.clnMatricula.ReadOnly = true;
         this.clnMatricula.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.clnMatricula.Width = 130;
         // 
         // clnNome
         // 
         this.clnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.clnNome.HeaderText = "NOME DO ALUNO";
         this.clnNome.Name = "clnNome";
         this.clnNome.ReadOnly = true;
         // 
         // clnCurso
         // 
         this.clnCurso.HeaderText = "curso";
         this.clnCurso.Name = "clnCurso";
         this.clnCurso.ReadOnly = true;
         this.clnCurso.Visible = false;
         // 
         // clnTurma
         // 
         this.clnTurma.HeaderText = "turma";
         this.clnTurma.Name = "clnTurma";
         this.clnTurma.ReadOnly = true;
         this.clnTurma.Visible = false;
         // 
         // clnCodigo
         // 
         this.clnCodigo.HeaderText = "codigo";
         this.clnCodigo.Name = "clnCodigo";
         this.clnCodigo.ReadOnly = true;
         this.clnCodigo.Visible = false;
         // 
         // button1
         // 
         this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.button1.FlatAppearance.BorderSize = 0;
         this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
         this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
         this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.button1.Location = new System.Drawing.Point(665, 205);
         this.button1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(114, 36);
         this.button1.TabIndex = 51;
         this.button1.Text = "Filtrar";
         this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
         this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.button1.UseVisualStyleBackColor = true;
         // 
         // rbNome
         // 
         this.rbNome.AutoSize = true;
         this.rbNome.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rbNome.Location = new System.Drawing.Point(21, 211);
         this.rbNome.Name = "rbNome";
         this.rbNome.Size = new System.Drawing.Size(144, 23);
         this.rbNome.TabIndex = 49;
         this.rbNome.TabStop = true;
         this.rbNome.Text = "Nome do aluno";
         this.rbNome.UseVisualStyleBackColor = true;
         // 
         // rbMatricula
         // 
         this.rbMatricula.AutoSize = true;
         this.rbMatricula.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rbMatricula.Location = new System.Drawing.Point(21, 189);
         this.rbMatricula.Name = "rbMatricula";
         this.rbMatricula.Size = new System.Drawing.Size(108, 23);
         this.rbMatricula.TabIndex = 50;
         this.rbMatricula.TabStop = true;
         this.rbMatricula.Text = "Matrícula";
         this.rbMatricula.UseVisualStyleBackColor = true;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(17, 160);
         this.label5.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(135, 19);
         this.label5.TabIndex = 48;
         this.label5.Text = "Pesquisar por:";
         // 
         // txbFiltro
         // 
         this.txbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txbFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txbFiltro.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbFiltro.Location = new System.Drawing.Point(170, 211);
         this.txbFiltro.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbFiltro.Name = "txbFiltro";
         this.txbFiltro.Size = new System.Drawing.Size(491, 25);
         this.txbFiltro.TabIndex = 47;
         // 
         // frmCadAluno
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.ClientSize = new System.Drawing.Size(800, 600);
         this.Name = "frmCadAluno";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Cadastro - Aluno";
         this.Load += new System.EventHandler(this.frmCadAluno_Load);
         this.panel1.ResumeLayout(false);
         this.pnDados.ResumeLayout(false);
         this.pnDados.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbFiltro;
    }
}
