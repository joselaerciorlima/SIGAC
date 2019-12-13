namespace UI
{
   partial class frmPrincipal
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
         this.panel1 = new System.Windows.Forms.Panel();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
         this.tabAtividade = new System.Windows.Forms.TabPage();
         this.tabAluno = new System.Windows.Forms.TabPage();
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.tabInicio = new System.Windows.Forms.TabPage();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.label3 = new System.Windows.Forms.Label();
         this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.panel1.SuspendLayout();
         this.menuStrip1.SuspendLayout();
         this.tabAtividade.SuspendLayout();
         this.tabAluno.SuspendLayout();
         this.tabControl1.SuspendLayout();
         this.tabInicio.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.menuStrip1);
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(784, 47);
         this.panel1.TabIndex = 0;
         // 
         // menuStrip1
         // 
         this.menuStrip1.AutoSize = false;
         this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
         this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.sobreToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(784, 47);
         this.menuStrip1.TabIndex = 0;
         this.menuStrip1.Text = "menuStrip1";
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
         this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
         // 
         // atividadeComplementarToolStripMenuItem
         // 
         this.atividadeComplementarToolStripMenuItem.Name = "atividadeComplementarToolStripMenuItem";
         this.atividadeComplementarToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
         this.atividadeComplementarToolStripMenuItem.Text = "Atividade Complementar";
         this.atividadeComplementarToolStripMenuItem.Click += new System.EventHandler(this.atividadeComplementarToolStripMenuItem_Click);
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
         this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
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
         // tabAtividade
         // 
         this.tabAtividade.Controls.Add(this.label2);
         this.tabAtividade.Location = new System.Drawing.Point(4, 22);
         this.tabAtividade.Name = "tabAtividade";
         this.tabAtividade.Padding = new System.Windows.Forms.Padding(3);
         this.tabAtividade.Size = new System.Drawing.Size(776, 485);
         this.tabAtividade.TabIndex = 1;
         this.tabAtividade.Text = "Atividade";
         this.tabAtividade.UseVisualStyleBackColor = true;
         // 
         // tabAluno
         // 
         this.tabAluno.Controls.Add(this.label1);
         this.tabAluno.Location = new System.Drawing.Point(4, 22);
         this.tabAluno.Name = "tabAluno";
         this.tabAluno.Padding = new System.Windows.Forms.Padding(3);
         this.tabAluno.Size = new System.Drawing.Size(776, 485);
         this.tabAluno.TabIndex = 0;
         this.tabAluno.Text = "Aluno";
         this.tabAluno.UseVisualStyleBackColor = true;
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabInicio);
         this.tabControl1.Controls.Add(this.tabAluno);
         this.tabControl1.Controls.Add(this.tabAtividade);
         this.tabControl1.Controls.Add(this.tabPage2);
         this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.tabControl1.Location = new System.Drawing.Point(0, 50);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(784, 511);
         this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
         this.tabControl1.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(217, 180);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(282, 31);
         this.label1.TabIndex = 0;
         this.label1.Text = "Estou na pagina aluno";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(211, 184);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(325, 31);
         this.label2.TabIndex = 1;
         this.label2.Text = "Estou na pagina atividade";
         // 
         // tabInicio
         // 
         this.tabInicio.Controls.Add(this.label3);
         this.tabInicio.Location = new System.Drawing.Point(4, 22);
         this.tabInicio.Name = "tabInicio";
         this.tabInicio.Padding = new System.Windows.Forms.Padding(3);
         this.tabInicio.Size = new System.Drawing.Size(776, 485);
         this.tabInicio.TabIndex = 2;
         this.tabInicio.Text = "inicio";
         this.tabInicio.UseVisualStyleBackColor = true;
         // 
         // tabPage2
         // 
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(776, 485);
         this.tabPage2.TabIndex = 3;
         this.tabPage2.Text = "tabPage2";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(215, 204);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(284, 31);
         this.label3.TabIndex = 1;
         this.label3.Text = "Estou na pagina inicial";
         // 
         // inicioToolStripMenuItem
         // 
         this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
         this.inicioToolStripMenuItem.Size = new System.Drawing.Size(64, 43);
         this.inicioToolStripMenuItem.Text = "Inicio";
         this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
         // 
         // frmPrincipal
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.Control;
         this.ClientSize = new System.Drawing.Size(784, 561);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.tabControl1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "frmPrincipal";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "SIGAC - Sistema de Gestão das Atividades Complementares";
         this.panel1.ResumeLayout(false);
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.tabAtividade.ResumeLayout(false);
         this.tabAtividade.PerformLayout();
         this.tabAluno.ResumeLayout(false);
         this.tabAluno.PerformLayout();
         this.tabControl1.ResumeLayout(false);
         this.tabInicio.ResumeLayout(false);
         this.tabInicio.PerformLayout();
         this.ResumeLayout(false);

      }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
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
        private System.Windows.Forms.TabPage tabAtividade;
        private System.Windows.Forms.TabPage tabAluno;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
    }
}