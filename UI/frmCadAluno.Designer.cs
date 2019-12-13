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
         this.label2 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.cobTurma = new System.Windows.Forms.ComboBox();
         this.cobCurso = new System.Windows.Forms.ComboBox();
         this.prbAluno = new System.Windows.Forms.ProgressBar();
         this.txbNome = new System.Windows.Forms.TextBox();
         this.txbMatricula = new System.Windows.Forms.TextBox();
         this.btnSalvar = new System.Windows.Forms.Button();
         this.btnSair = new System.Windows.Forms.Button();
         this.panel1 = new System.Windows.Forms.Panel();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.atividadeComplementarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.certificadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.cargaHoráriaPorAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.certificadosCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(256, 39);
         this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(146, 19);
         this.label2.TabIndex = 7;
         this.label2.Text = "NOME DO ALUNO";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(355, 107);
         this.label4.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(108, 19);
         this.label4.TabIndex = 8;
         this.label4.Text = "ANO TURMA";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(139, 107);
         this.label3.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(64, 19);
         this.label3.TabIndex = 9;
         this.label3.Text = "CURSO";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(139, 39);
         this.label1.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(106, 19);
         this.label1.TabIndex = 10;
         this.label1.Text = "MATRÍCULA";
         // 
         // cobTurma
         // 
         this.cobTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cobTurma.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cobTurma.FormattingEnabled = true;
         this.cobTurma.Location = new System.Drawing.Point(359, 132);
         this.cobTurma.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
         this.cobTurma.Name = "cobTurma";
         this.cobTurma.Size = new System.Drawing.Size(119, 25);
         this.cobTurma.TabIndex = 13;
         // 
         // cobCurso
         // 
         this.cobCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cobCurso.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cobCurso.FormattingEnabled = true;
         this.cobCurso.Location = new System.Drawing.Point(143, 132);
         this.cobCurso.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
         this.cobCurso.Name = "cobCurso";
         this.cobCurso.Size = new System.Drawing.Size(206, 25);
         this.cobCurso.TabIndex = 12;
         // 
         // prbAluno
         // 
         this.prbAluno.Location = new System.Drawing.Point(120, 230);
         this.prbAluno.Name = "prbAluno";
         this.prbAluno.Size = new System.Drawing.Size(529, 23);
         this.prbAluno.TabIndex = 14;
         // 
         // txbNome
         // 
         this.txbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txbNome.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbNome.Location = new System.Drawing.Point(255, 64);
         this.txbNome.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
         this.txbNome.Name = "txbNome";
         this.txbNome.Size = new System.Drawing.Size(364, 25);
         this.txbNome.TabIndex = 11;
         // 
         // txbMatricula
         // 
         this.txbMatricula.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbMatricula.Location = new System.Drawing.Point(143, 64);
         this.txbMatricula.Margin = new System.Windows.Forms.Padding(15, 3, 4, 3);
         this.txbMatricula.Name = "txbMatricula";
         this.txbMatricula.Size = new System.Drawing.Size(102, 25);
         this.txbMatricula.TabIndex = 6;
         // 
         // btnSalvar
         // 
         this.btnSalvar.AutoSize = true;
         this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
         this.btnSalvar.Location = new System.Drawing.Point(488, 175);
         this.btnSalvar.Name = "btnSalvar";
         this.btnSalvar.Size = new System.Drawing.Size(55, 41);
         this.btnSalvar.TabIndex = 15;
         this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnSalvar.UseVisualStyleBackColor = true;
         this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
         // 
         // btnSair
         // 
         this.btnSair.AutoSize = true;
         this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnSair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
         this.btnSair.Location = new System.Drawing.Point(565, 175);
         this.btnSair.Name = "btnSair";
         this.btnSair.Size = new System.Drawing.Size(55, 41);
         this.btnSair.TabIndex = 16;
         this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnSair.UseVisualStyleBackColor = true;
         this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
         // 
         // panel1
         // 
         this.panel1.Location = new System.Drawing.Point(84, 262);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(265, 81);
         this.panel1.TabIndex = 17;
         // 
         // menuStrip1
         // 
         this.menuStrip1.AutoSize = false;
         this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
         this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
         this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.sobreToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(117, 346);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(564, 47);
         this.menuStrip1.TabIndex = 18;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // inicioToolStripMenuItem
         // 
         this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
         this.inicioToolStripMenuItem.Size = new System.Drawing.Size(64, 43);
         this.inicioToolStripMenuItem.Text = "Inicio";
         // 
         // cadastrarToolStripMenuItem
         // 
         this.cadastrarToolStripMenuItem.AutoSize = false;
         this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.atividadeComplementarToolStripMenuItem,
            this.certificadoToolStripMenuItem,
            this.cursoToolStripMenuItem,
            this.toolStripSeparator1,
            this.usuárioToolStripMenuItem,
            this.toolStripSeparator2,
            this.sairToolStripMenuItem});
         this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
         this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(122, 43);
         this.cadastrarToolStripMenuItem.Text = "Cadastrar";
         // 
         // alunoToolStripMenuItem
         // 
         this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
         this.alunoToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
         this.alunoToolStripMenuItem.Text = "Aluno";
         // 
         // atividadeComplementarToolStripMenuItem
         // 
         this.atividadeComplementarToolStripMenuItem.Name = "atividadeComplementarToolStripMenuItem";
         this.atividadeComplementarToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
         this.atividadeComplementarToolStripMenuItem.Text = "Atividade Complementar";
         // 
         // certificadoToolStripMenuItem
         // 
         this.certificadoToolStripMenuItem.Name = "certificadoToolStripMenuItem";
         this.certificadoToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
         this.certificadoToolStripMenuItem.Text = "Certificado";
         // 
         // cursoToolStripMenuItem
         // 
         this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
         this.cursoToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
         this.cursoToolStripMenuItem.Text = "Curso";
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(262, 6);
         // 
         // usuárioToolStripMenuItem
         // 
         this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
         this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
         this.usuárioToolStripMenuItem.Text = "Usuário";
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(262, 6);
         // 
         // sairToolStripMenuItem
         // 
         this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
         this.sairToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
         this.sairToolStripMenuItem.Text = "Sair";
         // 
         // relatórioToolStripMenuItem
         // 
         this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargaHoráriaPorAlunoToolStripMenuItem,
            this.certificadosCadastradosToolStripMenuItem});
         this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
         this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(90, 43);
         this.relatórioToolStripMenuItem.Text = "Relatório";
         // 
         // cargaHoráriaPorAlunoToolStripMenuItem
         // 
         this.cargaHoráriaPorAlunoToolStripMenuItem.Name = "cargaHoráriaPorAlunoToolStripMenuItem";
         this.cargaHoráriaPorAlunoToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
         this.cargaHoráriaPorAlunoToolStripMenuItem.Text = "Carga Horária por Aluno";
         // 
         // certificadosCadastradosToolStripMenuItem
         // 
         this.certificadosCadastradosToolStripMenuItem.Name = "certificadosCadastradosToolStripMenuItem";
         this.certificadosCadastradosToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
         this.certificadosCadastradosToolStripMenuItem.Text = "Certificados Cadastrados";
         // 
         // sobreToolStripMenuItem
         // 
         this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
         this.sobreToolStripMenuItem.Size = new System.Drawing.Size(67, 43);
         this.sobreToolStripMenuItem.Text = "Sobre";
         // 
         // frmCadAluno
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.menuStrip1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.cobTurma);
         this.Controls.Add(this.cobCurso);
         this.Controls.Add(this.prbAluno);
         this.Controls.Add(this.txbNome);
         this.Controls.Add(this.txbMatricula);
         this.Controls.Add(this.btnSalvar);
         this.Controls.Add(this.btnSair);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "frmCadAluno";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Cadastro - Aluno";
         this.Load += new System.EventHandler(this.frmCadAluno_Load);
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobTurma;
        protected System.Windows.Forms.ComboBox cobCurso;
        private System.Windows.Forms.ProgressBar prbAluno;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbMatricula;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividadeComplementarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certificadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaHoráriaPorAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certificadosCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}