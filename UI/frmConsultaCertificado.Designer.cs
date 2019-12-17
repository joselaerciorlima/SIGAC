namespace UI
{
   partial class frmConsultaCertificado
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCertificado));
         this.dgvDados = new System.Windows.Forms.DataGridView();
         this.clnMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnClassificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnCodAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.btnLocalizar = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.txbFiltro = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
         this.SuspendLayout();
         // 
         // dgvDados
         // 
         this.dgvDados.AllowUserToAddRows = false;
         this.dgvDados.AllowUserToDeleteRows = false;
         dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
         this.dgvDados.ColumnHeadersHeight = 27;
         this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnMatricula,
            this.clnDescricao,
            this.clnData,
            this.clnClassificacao,
            this.clnCarga,
            this.clnCodAluno,
            this.clnCodigo});
         this.dgvDados.Location = new System.Drawing.Point(16, 106);
         this.dgvDados.MultiSelect = false;
         this.dgvDados.Name = "dgvDados";
         this.dgvDados.ReadOnly = true;
         this.dgvDados.RowHeadersVisible = false;
         this.dgvDados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
         this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dgvDados.Size = new System.Drawing.Size(746, 443);
         this.dgvDados.TabIndex = 40;
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
         // clnDescricao
         // 
         this.clnDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.clnDescricao.HeaderText = "DESCRIÇÃO DO CERTIFICADO";
         this.clnDescricao.Name = "clnDescricao";
         this.clnDescricao.ReadOnly = true;
         // 
         // clnData
         // 
         this.clnData.HeaderText = "data";
         this.clnData.Name = "clnData";
         this.clnData.ReadOnly = true;
         this.clnData.Visible = false;
         // 
         // clnClassificacao
         // 
         this.clnClassificacao.HeaderText = "classificacao";
         this.clnClassificacao.Name = "clnClassificacao";
         this.clnClassificacao.ReadOnly = true;
         this.clnClassificacao.Visible = false;
         // 
         // clnCarga
         // 
         this.clnCarga.HeaderText = "carga";
         this.clnCarga.Name = "clnCarga";
         this.clnCarga.ReadOnly = true;
         this.clnCarga.Visible = false;
         // 
         // clnCodAluno
         // 
         this.clnCodAluno.HeaderText = "codigo aluno";
         this.clnCodAluno.Name = "clnCodAluno";
         this.clnCodAluno.ReadOnly = true;
         this.clnCodAluno.Visible = false;
         // 
         // clnCodigo
         // 
         this.clnCodigo.HeaderText = "codigo";
         this.clnCodigo.Name = "clnCodigo";
         this.clnCodigo.ReadOnly = true;
         this.clnCodigo.Visible = false;
         // 
         // btnLocalizar
         // 
         this.btnLocalizar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.Image")));
         this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnLocalizar.Location = new System.Drawing.Point(579, 35);
         this.btnLocalizar.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
         this.btnLocalizar.Name = "btnLocalizar";
         this.btnLocalizar.Size = new System.Drawing.Size(133, 49);
         this.btnLocalizar.TabIndex = 39;
         this.btnLocalizar.Text = "Localizar";
         this.btnLocalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnLocalizar.UseVisualStyleBackColor = true;
         this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(12, 24);
         this.label1.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(171, 19);
         this.label1.TabIndex = 42;
         this.label1.Text = "Matricula do Aluno";
         // 
         // txbFiltro
         // 
         this.txbFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txbFiltro.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbFiltro.Location = new System.Drawing.Point(16, 49);
         this.txbFiltro.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbFiltro.Name = "txbFiltro";
         this.txbFiltro.Size = new System.Drawing.Size(541, 25);
         this.txbFiltro.TabIndex = 41;
         // 
         // frmConsultaCertificado
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(784, 561);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txbFiltro);
         this.Controls.Add(this.dgvDados);
         this.Controls.Add(this.btnLocalizar);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "frmConsultaCertificado";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Cadastro - Certificado - Localizar Certificado Cadastrado";
         this.Load += new System.EventHandler(this.frmConsultaAluno_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnClassificacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFiltro;
    }
}