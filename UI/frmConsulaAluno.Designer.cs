namespace UI
{
   partial class frmConsulaAluno
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulaAluno));
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         this.label1 = new System.Windows.Forms.Label();
         this.txbFiltro = new System.Windows.Forms.TextBox();
         this.rbMatricula = new System.Windows.Forms.RadioButton();
         this.rbNome = new System.Windows.Forms.RadioButton();
         this.btnLocalizar = new System.Windows.Forms.Button();
         this.dgvDados = new System.Windows.Forms.DataGridView();
         this.clnMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(12, 24);
         this.label1.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(105, 19);
         this.label1.TabIndex = 31;
         this.label1.Text = "Pesquisar por:";
         // 
         // txbFiltro
         // 
         this.txbFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txbFiltro.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbFiltro.Location = new System.Drawing.Point(16, 89);
         this.txbFiltro.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbFiltro.Name = "txbFiltro";
         this.txbFiltro.Size = new System.Drawing.Size(541, 25);
         this.txbFiltro.TabIndex = 30;
         // 
         // rbMatricula
         // 
         this.rbMatricula.AutoSize = true;
         this.rbMatricula.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rbMatricula.Location = new System.Drawing.Point(30, 53);
         this.rbMatricula.Name = "rbMatricula";
         this.rbMatricula.Size = new System.Drawing.Size(84, 23);
         this.rbMatricula.TabIndex = 32;
         this.rbMatricula.TabStop = true;
         this.rbMatricula.Text = "Matrícula";
         this.rbMatricula.UseVisualStyleBackColor = true;
         this.rbMatricula.CheckedChanged += new System.EventHandler(this.rbMatricula_CheckedChanged);
         // 
         // rbNome
         // 
         this.rbNome.AutoSize = true;
         this.rbNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rbNome.Location = new System.Drawing.Point(134, 53);
         this.rbNome.Name = "rbNome";
         this.rbNome.Size = new System.Drawing.Size(121, 23);
         this.rbNome.TabIndex = 32;
         this.rbNome.TabStop = true;
         this.rbNome.Text = "Nome do aluno";
         this.rbNome.UseVisualStyleBackColor = true;
         this.rbNome.CheckedChanged += new System.EventHandler(this.rbNome_CheckedChanged);
         // 
         // btnLocalizar
         // 
         this.btnLocalizar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.Image")));
         this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnLocalizar.Location = new System.Drawing.Point(579, 75);
         this.btnLocalizar.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
         this.btnLocalizar.Name = "btnLocalizar";
         this.btnLocalizar.Size = new System.Drawing.Size(118, 49);
         this.btnLocalizar.TabIndex = 33;
         this.btnLocalizar.Text = "Localizar";
         this.btnLocalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnLocalizar.UseVisualStyleBackColor = true;
         this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
         // 
         // dgvDados
         // 
         this.dgvDados.AllowUserToAddRows = false;
         this.dgvDados.AllowUserToDeleteRows = false;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
         this.dgvDados.Location = new System.Drawing.Point(16, 146);
         this.dgvDados.MultiSelect = false;
         this.dgvDados.Name = "dgvDados";
         this.dgvDados.ReadOnly = true;
         this.dgvDados.RowHeadersVisible = false;
         this.dgvDados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
         this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dgvDados.Size = new System.Drawing.Size(746, 403);
         this.dgvDados.TabIndex = 34;
         this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
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
         // frmConsulaAluno
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(784, 561);
         this.Controls.Add(this.dgvDados);
         this.Controls.Add(this.btnLocalizar);
         this.Controls.Add(this.rbNome);
         this.Controls.Add(this.rbMatricula);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txbFiltro);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmConsulaAluno";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Cadastro - Aluno - Localizar";
         this.Load += new System.EventHandler(this.frmConsulaAluno_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFiltro;
        private System.Windows.Forms.RadioButton rbMatricula;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.DataGridView dgvDados;
      private System.Windows.Forms.DataGridViewTextBoxColumn clnMatricula;
      private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
      private System.Windows.Forms.DataGridViewTextBoxColumn clnCurso;
      private System.Windows.Forms.DataGridViewTextBoxColumn clnTurma;
      private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
   }
}