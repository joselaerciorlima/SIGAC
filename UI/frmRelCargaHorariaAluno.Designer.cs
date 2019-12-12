namespace SIGAC_Sistema_Gestao_Atividades_Complementares
{
   partial class frmRelCargaHorariaAluno
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelCargaHorariaAluno));
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         this.txbFiltro = new System.Windows.Forms.TextBox();
         this.btnGerarPDF = new System.Windows.Forms.Button();
         this.btnSair = new System.Windows.Forms.Button();
         this.dgvRelCargaHoraria = new System.Windows.Forms.DataGridView();
         this.label2 = new System.Windows.Forms.Label();
         this.txbNome = new System.Windows.Forms.TextBox();
         this.btnPesquisar = new System.Windows.Forms.Button();
         this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnCargaHoraria = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.dgvRelCargaHoraria)).BeginInit();
         this.SuspendLayout();
         // 
         // txbFiltro
         // 
         this.txbFiltro.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbFiltro.Location = new System.Drawing.Point(24, 49);
         this.txbFiltro.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbFiltro.Name = "txbFiltro";
         this.txbFiltro.Size = new System.Drawing.Size(184, 25);
         this.txbFiltro.TabIndex = 15;
         // 
         // btnGerarPDF
         // 
         this.btnGerarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnGerarPDF.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnGerarPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarPDF.Image")));
         this.btnGerarPDF.Location = new System.Drawing.Point(541, 464);
         this.btnGerarPDF.Name = "btnGerarPDF";
         this.btnGerarPDF.Size = new System.Drawing.Size(55, 41);
         this.btnGerarPDF.TabIndex = 18;
         this.btnGerarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnGerarPDF.UseVisualStyleBackColor = true;
         // 
         // btnSair
         // 
         this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnSair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
         this.btnSair.Location = new System.Drawing.Point(611, 464);
         this.btnSair.Name = "btnSair";
         this.btnSair.Size = new System.Drawing.Size(55, 41);
         this.btnSair.TabIndex = 19;
         this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnSair.UseVisualStyleBackColor = true;
         // 
         // dgvRelCargaHoraria
         // 
         this.dgvRelCargaHoraria.AllowUserToDeleteRows = false;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dgvRelCargaHoraria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.dgvRelCargaHoraria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         this.dgvRelCargaHoraria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnDescricao,
            this.clnCargaHoraria,
            this.clnStatus});
         this.dgvRelCargaHoraria.Location = new System.Drawing.Point(24, 117);
         this.dgvRelCargaHoraria.MultiSelect = false;
         this.dgvRelCargaHoraria.Name = "dgvRelCargaHoraria";
         this.dgvRelCargaHoraria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dgvRelCargaHoraria.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
         this.dgvRelCargaHoraria.RowHeadersVisible = false;
         this.dgvRelCargaHoraria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
         dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
         this.dgvRelCargaHoraria.RowsDefaultCellStyle = dataGridViewCellStyle4;
         this.dgvRelCargaHoraria.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         this.dgvRelCargaHoraria.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dgvRelCargaHoraria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dgvRelCargaHoraria.Size = new System.Drawing.Size(642, 326);
         this.dgvRelCargaHoraria.TabIndex = 17;
         this.dgvRelCargaHoraria.TabStop = false;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(20, 24);
         this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(188, 19);
         this.label2.TabIndex = 21;
         this.label2.Text = "Digite a matrícula do aluno";
         // 
         // txbNome
         // 
         this.txbNome.Enabled = false;
         this.txbNome.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbNome.Location = new System.Drawing.Point(218, 49);
         this.txbNome.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
         this.txbNome.Name = "txbNome";
         this.txbNome.Size = new System.Drawing.Size(378, 25);
         this.txbNome.TabIndex = 20;
         // 
         // btnPesquisar
         // 
         this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnPesquisar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
         this.btnPesquisar.Location = new System.Drawing.Point(611, 41);
         this.btnPesquisar.Name = "btnPesquisar";
         this.btnPesquisar.Size = new System.Drawing.Size(55, 41);
         this.btnPesquisar.TabIndex = 16;
         this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnPesquisar.UseVisualStyleBackColor = true;
         // 
         // clnDescricao
         // 
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         this.clnDescricao.DefaultCellStyle = dataGridViewCellStyle2;
         this.clnDescricao.HeaderText = "DESCRIÇÃO DA ATIVIDADE";
         this.clnDescricao.Name = "clnDescricao";
         this.clnDescricao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.clnDescricao.Width = 490;
         // 
         // clnCargaHoraria
         // 
         this.clnCargaHoraria.HeaderText = "C. H";
         this.clnCargaHoraria.Name = "clnCargaHoraria";
         this.clnCargaHoraria.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.clnCargaHoraria.Width = 70;
         // 
         // clnStatus
         // 
         this.clnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.clnStatus.HeaderText = "STATUS";
         this.clnStatus.Name = "clnStatus";
         // 
         // frmRelCargaHorariaAluno
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(689, 522);
         this.Controls.Add(this.txbFiltro);
         this.Controls.Add(this.btnGerarPDF);
         this.Controls.Add(this.btnSair);
         this.Controls.Add(this.dgvRelCargaHoraria);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txbNome);
         this.Controls.Add(this.btnPesquisar);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmRelCargaHorariaAluno";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Relatórios - Carga Horária Cadastrada por Aluno";
         ((System.ComponentModel.ISupportInitialize)(this.dgvRelCargaHoraria)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txbFiltro;
      private System.Windows.Forms.Button btnGerarPDF;
      private System.Windows.Forms.Button btnSair;
      private System.Windows.Forms.DataGridView dgvRelCargaHoraria;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txbNome;
      private System.Windows.Forms.Button btnPesquisar;
      private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
      private System.Windows.Forms.DataGridViewTextBoxColumn clnCargaHoraria;
      private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
   }
}