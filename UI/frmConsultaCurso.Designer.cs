namespace UI
{
   partial class frmConsultaCurso
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCurso));
         this.dgvDados = new System.Windows.Forms.DataGridView();
         this.btnLocalizar = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.txbFiltro = new System.Windows.Forms.TextBox();
         this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
         this.SuspendLayout();
         // 
         // dgvDados
         // 
         this.dgvDados.AllowUserToAddRows = false;
         this.dgvDados.AllowUserToDeleteRows = false;
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
            this.clnDescricao,
            this.clnPeriodo,
            this.clnCodigo});
         this.dgvDados.Location = new System.Drawing.Point(16, 106);
         this.dgvDados.MultiSelect = false;
         this.dgvDados.Name = "dgvDados";
         this.dgvDados.ReadOnly = true;
         this.dgvDados.RowHeadersVisible = false;
         this.dgvDados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
         this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dgvDados.Size = new System.Drawing.Size(746, 443);
         this.dgvDados.TabIndex = 44;
         this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
         // 
         // btnLocalizar
         // 
         this.btnLocalizar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.Image")));
         this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnLocalizar.Location = new System.Drawing.Point(579, 35);
         this.btnLocalizar.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
         this.btnLocalizar.Name = "btnLocalizar";
         this.btnLocalizar.Size = new System.Drawing.Size(134, 49);
         this.btnLocalizar.TabIndex = 43;
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
         this.label1.Text = "Descrição do Curso";
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
         // clnDescricao
         // 
         this.clnDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.clnDescricao.HeaderText = "DESCRIÇÃO DO CURSO";
         this.clnDescricao.Name = "clnDescricao";
         this.clnDescricao.ReadOnly = true;
         this.clnDescricao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         // 
         // clnPeriodo
         // 
         this.clnPeriodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.clnPeriodo.HeaderText = "periodo";
         this.clnPeriodo.Name = "clnPeriodo";
         this.clnPeriodo.ReadOnly = true;
         this.clnPeriodo.Visible = false;
         // 
         // clnCodigo
         // 
         this.clnCodigo.HeaderText = "codigo";
         this.clnCodigo.Name = "clnCodigo";
         this.clnCodigo.ReadOnly = true;
         this.clnCodigo.Visible = false;
         // 
         // frmConsultaCurso
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(784, 561);
         this.Controls.Add(this.dgvDados);
         this.Controls.Add(this.btnLocalizar);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txbFiltro);
         this.Name = "frmConsultaCurso";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "frmConsultaCurso";
         this.Load += new System.EventHandler(this.frmConsultaAtividade_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
    }
}