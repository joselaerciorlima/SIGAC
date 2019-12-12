namespace SIGAC_Sistema_Gestao_Atividades_Complementares
{
   partial class frmEditarCertificado
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarCertificado));
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.cobClassificacao = new System.Windows.Forms.ComboBox();
         this.txbCargaHoraria = new System.Windows.Forms.TextBox();
         this.txbData = new System.Windows.Forms.TextBox();
         this.txbDescricao = new System.Windows.Forms.TextBox();
         this.dgvCertificado = new System.Windows.Forms.DataGridView();
         this.clnMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.clnDescrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.label2 = new System.Windows.Forms.Label();
         this.txbFiltro = new System.Windows.Forms.TextBox();
         this.btnPesquisar = new System.Windows.Forms.Button();
         this.btnExcluir = new System.Windows.Forms.Button();
         this.btnSalvar = new System.Windows.Forms.Button();
         this.btnSair = new System.Windows.Forms.Button();
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvCertificado)).BeginInit();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.label6);
         this.groupBox1.Controls.Add(this.label4);
         this.groupBox1.Controls.Add(this.label5);
         this.groupBox1.Controls.Add(this.cobClassificacao);
         this.groupBox1.Controls.Add(this.txbCargaHoraria);
         this.groupBox1.Controls.Add(this.txbData);
         this.groupBox1.Controls.Add(this.txbDescricao);
         this.groupBox1.Location = new System.Drawing.Point(8, 358);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(604, 180);
         this.groupBox1.TabIndex = 3;
         this.groupBox1.TabStop = false;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(14, 99);
         this.label3.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(136, 19);
         this.label3.TabIndex = 18;
         this.label3.Text = "CLASSIFICAÇÃO";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(513, 99);
         this.label6.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(40, 19);
         this.label6.TabIndex = 19;
         this.label6.Text = "C. H";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(513, 31);
         this.label4.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(51, 19);
         this.label4.TabIndex = 20;
         this.label4.Text = "DATA";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(14, 31);
         this.label5.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(244, 19);
         this.label5.TabIndex = 21;
         this.label5.Text = "DESCRIÇÃO DO CERTIFICADO";
         // 
         // cobClassificacao
         // 
         this.cobClassificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cobClassificacao.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cobClassificacao.FormattingEnabled = true;
         this.cobClassificacao.Location = new System.Drawing.Point(18, 124);
         this.cobClassificacao.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
         this.cobClassificacao.Name = "cobClassificacao";
         this.cobClassificacao.Size = new System.Drawing.Size(480, 25);
         this.cobClassificacao.TabIndex = 6;
         // 
         // txbCargaHoraria
         // 
         this.txbCargaHoraria.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbCargaHoraria.Location = new System.Drawing.Point(517, 124);
         this.txbCargaHoraria.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbCargaHoraria.Name = "txbCargaHoraria";
         this.txbCargaHoraria.Size = new System.Drawing.Size(80, 25);
         this.txbCargaHoraria.TabIndex = 7;
         // 
         // txbData
         // 
         this.txbData.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbData.Location = new System.Drawing.Point(517, 56);
         this.txbData.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbData.Name = "txbData";
         this.txbData.Size = new System.Drawing.Size(80, 25);
         this.txbData.TabIndex = 5;
         // 
         // txbDescricao
         // 
         this.txbDescricao.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbDescricao.Location = new System.Drawing.Point(18, 56);
         this.txbDescricao.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbDescricao.Name = "txbDescricao";
         this.txbDescricao.Size = new System.Drawing.Size(480, 25);
         this.txbDescricao.TabIndex = 4;
         // 
         // dgvCertificado
         // 
         this.dgvCertificado.AllowUserToDeleteRows = false;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dgvCertificado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.dgvCertificado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         this.dgvCertificado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnMatricula,
            this.clnDescrição});
         this.dgvCertificado.Location = new System.Drawing.Point(26, 101);
         this.dgvCertificado.MultiSelect = false;
         this.dgvCertificado.Name = "dgvCertificado";
         this.dgvCertificado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dgvCertificado.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
         this.dgvCertificado.RowHeadersVisible = false;
         this.dgvCertificado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
         this.dgvCertificado.RowsDefaultCellStyle = dataGridViewCellStyle3;
         this.dgvCertificado.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         this.dgvCertificado.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dgvCertificado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dgvCertificado.Size = new System.Drawing.Size(566, 238);
         this.dgvCertificado.TabIndex = 2;
         this.dgvCertificado.TabStop = false;
         // 
         // clnMatricula
         // 
         this.clnMatricula.HeaderText = "MATRÍCULA";
         this.clnMatricula.Name = "clnMatricula";
         this.clnMatricula.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.clnMatricula.Width = 110;
         // 
         // clnDescrição
         // 
         this.clnDescrição.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.clnDescrição.HeaderText = "DESCRIÇÃO DO CERTIFICADO";
         this.clnDescrição.Name = "clnDescrição";
         this.clnDescrição.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(22, 24);
         this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(260, 19);
         this.label2.TabIndex = 23;
         this.label2.Text = "Digite a matrícula ou o nome do aluno";
         // 
         // txbFiltro
         // 
         this.txbFiltro.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbFiltro.Location = new System.Drawing.Point(26, 49);
         this.txbFiltro.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
         this.txbFiltro.Name = "txbFiltro";
         this.txbFiltro.Size = new System.Drawing.Size(445, 25);
         this.txbFiltro.TabIndex = 0;
         // 
         // btnPesquisar
         // 
         this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnPesquisar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
         this.btnPesquisar.Location = new System.Drawing.Point(496, 41);
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
         this.btnExcluir.Location = new System.Drawing.Point(27, 558);
         this.btnExcluir.Name = "btnExcluir";
         this.btnExcluir.Size = new System.Drawing.Size(55, 41);
         this.btnExcluir.TabIndex = 8;
         this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnExcluir.UseVisualStyleBackColor = true;
         // 
         // btnSalvar
         // 
         this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
         this.btnSalvar.Location = new System.Drawing.Point(282, 558);
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
         this.btnSair.Location = new System.Drawing.Point(537, 558);
         this.btnSair.Name = "btnSair";
         this.btnSair.Size = new System.Drawing.Size(55, 41);
         this.btnSair.TabIndex = 10;
         this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnSair.UseVisualStyleBackColor = true;
         // 
         // frmEditarCertificado
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(621, 614);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.dgvCertificado);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txbFiltro);
         this.Controls.Add(this.btnPesquisar);
         this.Controls.Add(this.btnExcluir);
         this.Controls.Add(this.btnSalvar);
         this.Controls.Add(this.btnSair);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmEditarCertificado";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Editar Cadastro - Certificados";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvCertificado)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.DataGridView dgvCertificado;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txbFiltro;
      private System.Windows.Forms.Button btnPesquisar;
      private System.Windows.Forms.Button btnExcluir;
      private System.Windows.Forms.Button btnSalvar;
      private System.Windows.Forms.Button btnSair;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.ComboBox cobClassificacao;
      private System.Windows.Forms.TextBox txbCargaHoraria;
      private System.Windows.Forms.TextBox txbData;
      private System.Windows.Forms.TextBox txbDescricao;
      private System.Windows.Forms.DataGridViewTextBoxColumn clnMatricula;
      private System.Windows.Forms.DataGridViewTextBoxColumn clnDescrição;
   }
}