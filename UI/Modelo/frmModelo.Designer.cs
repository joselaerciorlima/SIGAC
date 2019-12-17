namespace UI
{
   partial class frmModelo
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
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModelo));
         this.panel1 = new System.Windows.Forms.Panel();
         this.pnDados = new System.Windows.Forms.Panel();
         this.panel2 = new System.Windows.Forms.Panel();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
         this.btnNovo = new System.Windows.Forms.Button();
         this.btnLocalizar = new System.Windows.Forms.Button();
         this.btnEditar = new System.Windows.Forms.Button();
         this.btnExcluir = new System.Windows.Forms.Button();
         this.btnSalvar = new System.Windows.Forms.Button();
         this.btnCancelar = new System.Windows.Forms.Button();
         this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
         this.panel1.SuspendLayout();
         this.panel2.SuspendLayout();
         this.statusStrip1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.SystemColors.Control;
         this.panel1.Controls.Add(this.btnNovo);
         this.panel1.Controls.Add(this.btnCancelar);
         this.panel1.Controls.Add(this.btnLocalizar);
         this.panel1.Controls.Add(this.btnSalvar);
         this.panel1.Controls.Add(this.btnEditar);
         this.panel1.Controls.Add(this.btnExcluir);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(784, 52);
         this.panel1.TabIndex = 0;
         // 
         // pnDados
         // 
         this.pnDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.pnDados.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pnDados.Location = new System.Drawing.Point(0, 52);
         this.pnDados.Name = "pnDados";
         this.pnDados.Size = new System.Drawing.Size(784, 479);
         this.pnDados.TabIndex = 2;
         // 
         // panel2
         // 
         this.panel2.BackColor = System.Drawing.Color.Lime;
         this.panel2.Controls.Add(this.statusStrip1);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel2.Location = new System.Drawing.Point(0, 531);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(784, 30);
         this.panel2.TabIndex = 1;
         // 
         // statusStrip1
         // 
         this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
         this.statusStrip1.Location = new System.Drawing.Point(0, 0);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(784, 30);
         this.statusStrip1.TabIndex = 0;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // toolStripProgressBar1
         // 
         this.toolStripProgressBar1.Name = "toolStripProgressBar1";
         this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 24);
         // 
         // btnNovo
         // 
         this.btnNovo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
         this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnNovo.Location = new System.Drawing.Point(28, 2);
         this.btnNovo.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
         this.btnNovo.Name = "btnNovo";
         this.btnNovo.Size = new System.Drawing.Size(87, 49);
         this.btnNovo.TabIndex = 0;
         this.btnNovo.Text = "Novo";
         this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnNovo.UseVisualStyleBackColor = true;
         // 
         // btnLocalizar
         // 
         this.btnLocalizar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.Image")));
         this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnLocalizar.Location = new System.Drawing.Point(130, 2);
         this.btnLocalizar.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
         this.btnLocalizar.Name = "btnLocalizar";
         this.btnLocalizar.Size = new System.Drawing.Size(105, 49);
         this.btnLocalizar.TabIndex = 0;
         this.btnLocalizar.Text = "Localizar";
         this.btnLocalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnLocalizar.UseVisualStyleBackColor = true;
         // 
         // btnEditar
         // 
         this.btnEditar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
         this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnEditar.Location = new System.Drawing.Point(250, 2);
         this.btnEditar.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
         this.btnEditar.Name = "btnEditar";
         this.btnEditar.Size = new System.Drawing.Size(87, 49);
         this.btnEditar.TabIndex = 0;
         this.btnEditar.Text = "Editar";
         this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnEditar.UseVisualStyleBackColor = true;
         // 
         // btnExcluir
         // 
         this.btnExcluir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
         this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnExcluir.Location = new System.Drawing.Point(352, 2);
         this.btnExcluir.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
         this.btnExcluir.Name = "btnExcluir";
         this.btnExcluir.Size = new System.Drawing.Size(91, 49);
         this.btnExcluir.TabIndex = 0;
         this.btnExcluir.Text = "Excluir";
         this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnExcluir.UseVisualStyleBackColor = true;
         // 
         // btnSalvar
         // 
         this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
         this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnSalvar.Location = new System.Drawing.Point(535, 2);
         this.btnSalvar.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
         this.btnSalvar.Name = "btnSalvar";
         this.btnSalvar.Size = new System.Drawing.Size(87, 49);
         this.btnSalvar.TabIndex = 0;
         this.btnSalvar.Text = "Salvar";
         this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnSalvar.UseVisualStyleBackColor = true;
         // 
         // btnCancelar
         // 
         this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
         this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnCancelar.Location = new System.Drawing.Point(639, 2);
         this.btnCancelar.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
         this.btnCancelar.Name = "btnCancelar";
         this.btnCancelar.Size = new System.Drawing.Size(103, 49);
         this.btnCancelar.TabIndex = 0;
         this.btnCancelar.Text = "Cancelar";
         this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnCancelar.UseVisualStyleBackColor = true;
         // 
         // frmModelo
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(784, 561);
         this.Controls.Add(this.pnDados);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmModelo";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "frmModelo";
         this.panel1.ResumeLayout(false);
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
         this.ResumeLayout(false);

      }

        #endregion

        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Panel pnDados;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.StatusStrip statusStrip1;
        protected System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.BindingSource bindingSource1;
        protected System.Windows.Forms.Button btnNovo;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnLocalizar;
        protected System.Windows.Forms.Button btnSalvar;
        protected System.Windows.Forms.Button btnEditar;
        protected System.Windows.Forms.Button btnExcluir;
    }
}