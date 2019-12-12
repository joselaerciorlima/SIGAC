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
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.atividadeComplementarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.certificadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.sobreToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(800, 27);
         this.menuStrip1.TabIndex = 0;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // cadastrarToolStripMenuItem
         // 
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
         this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
         this.cadastrarToolStripMenuItem.Text = "Cadastrar";
         // 
         // alunoToolStripMenuItem
         // 
         this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
         this.alunoToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
         this.alunoToolStripMenuItem.Text = "Aluno";
         this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
         // 
         // atividadeComplementarToolStripMenuItem
         // 
         this.atividadeComplementarToolStripMenuItem.Name = "atividadeComplementarToolStripMenuItem";
         this.atividadeComplementarToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
         this.atividadeComplementarToolStripMenuItem.Text = "Atividade Complementar";
         this.atividadeComplementarToolStripMenuItem.Click += new System.EventHandler(this.atividadeComplementarToolStripMenuItem_Click);
         // 
         // certificadoToolStripMenuItem
         // 
         this.certificadoToolStripMenuItem.Name = "certificadoToolStripMenuItem";
         this.certificadoToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
         this.certificadoToolStripMenuItem.Text = "Certificado";
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(226, 6);
         // 
         // usuárioToolStripMenuItem
         // 
         this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
         this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
         this.usuárioToolStripMenuItem.Text = "Usuário";
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(226, 6);
         // 
         // sairToolStripMenuItem
         // 
         this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
         this.sairToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
         this.sairToolStripMenuItem.Text = "Sair";
         this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
         // 
         // relatórioToolStripMenuItem
         // 
         this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
         this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(76, 23);
         this.relatórioToolStripMenuItem.Text = "Relatório";
         // 
         // sobreToolStripMenuItem
         // 
         this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
         this.sobreToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
         this.sobreToolStripMenuItem.Text = "Sobre";
         // 
         // cursoToolStripMenuItem
         // 
         this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
         this.cursoToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
         this.cursoToolStripMenuItem.Text = "Curso";
         this.cursoToolStripMenuItem.Click += new System.EventHandler(this.cursoToolStripMenuItem_Click);
         // 
         // frmPrincipal
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.menuStrip1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "frmPrincipal";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "SIGAC - Sistema de Gestão das Atividades Complementares";
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividadeComplementarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certificadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
    }
}