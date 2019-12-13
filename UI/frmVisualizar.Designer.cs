namespace UI
{
    partial class frmVisualizar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRelCargaHoraria = new System.Windows.Forms.DataGridView();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCargaHoraria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelCargaHoraria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRelCargaHoraria
            // 
            this.dgvRelCargaHoraria.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRelCargaHoraria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRelCargaHoraria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRelCargaHoraria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnDescricao,
            this.clnCargaHoraria,
            this.clnStatus});
            this.dgvRelCargaHoraria.Location = new System.Drawing.Point(13, 12);
            this.dgvRelCargaHoraria.MultiSelect = false;
            this.dgvRelCargaHoraria.Name = "dgvRelCargaHoraria";
            this.dgvRelCargaHoraria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRelCargaHoraria.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRelCargaHoraria.RowHeadersVisible = false;
            this.dgvRelCargaHoraria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dgvRelCargaHoraria.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRelCargaHoraria.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvRelCargaHoraria.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRelCargaHoraria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelCargaHoraria.Size = new System.Drawing.Size(674, 419);
            this.dgvRelCargaHoraria.TabIndex = 18;
            this.dgvRelCargaHoraria.TabStop = false;
            // 
            // clnDescricao
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clnDescricao.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.clnStatus.HeaderText = "EXCEDENTE";
            this.clnStatus.Name = "clnStatus";
            // 
            // frmVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 443);
            this.Controls.Add(this.dgvRelCargaHoraria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVisualizar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga Horária Excedente";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelCargaHoraria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRelCargaHoraria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCargaHoraria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
    }
}