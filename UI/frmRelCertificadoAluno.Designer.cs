namespace UI
{
    partial class frmRelCertificadoAluno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelCertificadoAluno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRelCertificado = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnGerarPDF = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txbFiltro = new System.Windows.Forms.TextBox();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCargaHoraria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelCertificado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRelCertificado
            // 
            this.dgvRelCertificado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRelCertificado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRelCertificado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRelCertificado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnDescricao,
            this.clnData,
            this.clnCargaHoraria});
            this.dgvRelCertificado.Location = new System.Drawing.Point(24, 117);
            this.dgvRelCertificado.MultiSelect = false;
            this.dgvRelCertificado.Name = "dgvRelCertificado";
            this.dgvRelCertificado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRelCertificado.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRelCertificado.RowHeadersVisible = false;
            this.dgvRelCertificado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dgvRelCertificado.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRelCertificado.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvRelCertificado.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRelCertificado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelCertificado.Size = new System.Drawing.Size(642, 326);
            this.dgvRelCertificado.TabIndex = 2;
            this.dgvRelCertificado.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 19);
            this.label2.TabIndex = 14;
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
            this.txbNome.TabIndex = 11;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(611, 41);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(55, 41);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnGerarPDF
            // 
            this.btnGerarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarPDF.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarPDF.Image")));
            this.btnGerarPDF.Location = new System.Drawing.Point(541, 464);
            this.btnGerarPDF.Name = "btnGerarPDF";
            this.btnGerarPDF.Size = new System.Drawing.Size(55, 41);
            this.btnGerarPDF.TabIndex = 3;
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
            this.btnSair.TabIndex = 4;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // txbFiltro
            // 
            this.txbFiltro.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFiltro.Location = new System.Drawing.Point(24, 49);
            this.txbFiltro.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(184, 25);
            this.txbFiltro.TabIndex = 0;
            // 
            // clnDescricao
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clnDescricao.DefaultCellStyle = dataGridViewCellStyle6;
            this.clnDescricao.HeaderText = "DESCRIÇÃO DO CERTIFICADO";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnDescricao.Width = 480;
            // 
            // clnData
            // 
            this.clnData.HeaderText = "DATA";
            this.clnData.Name = "clnData";
            this.clnData.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clnCargaHoraria
            // 
            this.clnCargaHoraria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnCargaHoraria.HeaderText = "C. H";
            this.clnCargaHoraria.Name = "clnCargaHoraria";
            // 
            // frmRelCertificadoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 522);
            this.Controls.Add(this.txbFiltro);
            this.Controls.Add(this.btnGerarPDF);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvRelCertificado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btnPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelCertificadoAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios - Certificados Cadastrados por Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelCertificado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRelCertificado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnGerarPDF;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txbFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCargaHoraria;
    }
}