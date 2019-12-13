namespace UI
{
    partial class frmRelResumoAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelResumoAluno));
            this.txbFiltro = new System.Windows.Forms.TextBox();
            this.btnGerarPDF = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSaldoRegistrado = new System.Windows.Forms.TextBox();
            this.gpbSaldo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSaltoTotal = new System.Windows.Forms.TextBox();
            this.txbSaldoExcedente = new System.Windows.Forms.TextBox();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pcbAtingiu = new System.Windows.Forms.PictureBox();
            this.pcbNaoAtingiu = new System.Windows.Forms.PictureBox();
            this.gpbSaldo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAtingiu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNaoAtingiu)).BeginInit();
            this.SuspendLayout();
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
            // btnGerarPDF
            // 
            this.btnGerarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarPDF.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarPDF.Image")));
            this.btnGerarPDF.Location = new System.Drawing.Point(211, 390);
            this.btnGerarPDF.Name = "btnGerarPDF";
            this.btnGerarPDF.Size = new System.Drawing.Size(55, 41);
            this.btnGerarPDF.TabIndex = 7;
            this.btnGerarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGerarPDF.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(566, 414);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(55, 41);
            this.btnSair.TabIndex = 8;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Digite a matrícula do aluno";
            // 
            // txbNome
            // 
            this.txbNome.Enabled = false;
            this.txbNome.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(218, 49);
            this.txbNome.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(333, 25);
            this.txbNome.TabIndex = 27;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(566, 41);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(55, 41);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Saldo de Horas Complementares Registradas:";
            // 
            // txbSaldoRegistrado
            // 
            this.txbSaldoRegistrado.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSaldoRegistrado.Location = new System.Drawing.Point(342, 28);
            this.txbSaldoRegistrado.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
            this.txbSaldoRegistrado.Name = "txbSaldoRegistrado";
            this.txbSaldoRegistrado.Size = new System.Drawing.Size(77, 25);
            this.txbSaldoRegistrado.TabIndex = 3;
            // 
            // gpbSaldo
            // 
            this.gpbSaldo.Controls.Add(this.label4);
            this.gpbSaldo.Controls.Add(this.label3);
            this.gpbSaldo.Controls.Add(this.label1);
            this.gpbSaldo.Controls.Add(this.txbSaltoTotal);
            this.gpbSaldo.Controls.Add(this.txbSaldoExcedente);
            this.gpbSaldo.Controls.Add(this.txbSaldoRegistrado);
            this.gpbSaldo.Controls.Add(this.btnVisualizar);
            this.gpbSaldo.Location = new System.Drawing.Point(76, 101);
            this.gpbSaldo.Name = "gpbSaldo";
            this.gpbSaldo.Size = new System.Drawing.Size(484, 152);
            this.gpbSaldo.TabIndex = 2;
            this.gpbSaldo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Total de Horas Complementares (mín. 200hs):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Saldo de Horas Complementares Excedentes:";
            // 
            // txbSaltoTotal
            // 
            this.txbSaltoTotal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSaltoTotal.Location = new System.Drawing.Point(342, 102);
            this.txbSaltoTotal.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
            this.txbSaltoTotal.Name = "txbSaltoTotal";
            this.txbSaltoTotal.Size = new System.Drawing.Size(77, 25);
            this.txbSaltoTotal.TabIndex = 6;
            // 
            // txbSaldoExcedente
            // 
            this.txbSaldoExcedente.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSaldoExcedente.Location = new System.Drawing.Point(342, 65);
            this.txbSaldoExcedente.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
            this.txbSaldoExcedente.Name = "txbSaldoExcedente";
            this.txbSaldoExcedente.Size = new System.Drawing.Size(77, 25);
            this.txbSaldoExcedente.TabIndex = 4;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.Location = new System.Drawing.Point(426, 63);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(37, 29);
            this.btnVisualizar.TabIndex = 5;
            this.btnVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Yellow;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(71, 295);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(335, 76);
            this.lblStatus.TabIndex = 28;
            this.lblStatus.Text = "CARGA HORÁRIA MINÍMA NÃO ATINGIDA";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbAtingiu
            // 
            this.pcbAtingiu.Image = ((System.Drawing.Image)(resources.GetObject("pcbAtingiu.Image")));
            this.pcbAtingiu.Location = new System.Drawing.Point(447, 276);
            this.pcbAtingiu.Name = "pcbAtingiu";
            this.pcbAtingiu.Size = new System.Drawing.Size(113, 115);
            this.pcbAtingiu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAtingiu.TabIndex = 30;
            this.pcbAtingiu.TabStop = false;
            // 
            // pcbNaoAtingiu
            // 
            this.pcbNaoAtingiu.Image = ((System.Drawing.Image)(resources.GetObject("pcbNaoAtingiu.Image")));
            this.pcbNaoAtingiu.Location = new System.Drawing.Point(447, 276);
            this.pcbNaoAtingiu.Name = "pcbNaoAtingiu";
            this.pcbNaoAtingiu.Size = new System.Drawing.Size(113, 115);
            this.pcbNaoAtingiu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbNaoAtingiu.TabIndex = 30;
            this.pcbNaoAtingiu.TabStop = false;
            // 
            // frmRelResumoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 475);
            this.Controls.Add(this.pcbNaoAtingiu);
            this.Controls.Add(this.pcbAtingiu);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.gpbSaldo);
            this.Controls.Add(this.txbFiltro);
            this.Controls.Add(this.btnGerarPDF);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btnPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelResumoAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios - Resumo das Horas Complementares por Aluno";
            this.Load += new System.EventHandler(this.frmRelResumoAluno_Load);
            this.gpbSaldo.ResumeLayout(false);
            this.gpbSaldo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAtingiu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNaoAtingiu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbFiltro;
        private System.Windows.Forms.Button btnGerarPDF;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSaldoRegistrado;
        private System.Windows.Forms.GroupBox gpbSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSaltoTotal;
        private System.Windows.Forms.TextBox txbSaldoExcedente;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pcbAtingiu;
        private System.Windows.Forms.PictureBox pcbNaoAtingiu;
    }
}