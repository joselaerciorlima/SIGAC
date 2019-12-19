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
         this.btnNovo = new System.Windows.Forms.Button();
         this.btnCancelar = new System.Windows.Forms.Button();
         this.btnLocalizar = new System.Windows.Forms.Button();
         this.btnSalvar = new System.Windows.Forms.Button();
         this.btnEditar = new System.Windows.Forms.Button();
         this.btnExcluir = new System.Windows.Forms.Button();
         this.pnDados = new System.Windows.Forms.Panel();
         this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
         this.panel1.SuspendLayout();
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
         // btnNovo
         // 
         this.btnNovo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
         this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnNovo.Location = new System.Drawing.Point(15, 2);
         this.btnNovo.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
         this.btnNovo.Name = "btnNovo";
         this.btnNovo.Size = new System.Drawing.Size(87, 49);
         this.btnNovo.TabIndex = 0;
         this.btnNovo.Text = "Novo";
         this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnNovo.UseVisualStyleBackColor = true;
         // 
         // btnCancelar
         // 
         this.btnCancelar.Font = new System.Drawing.Font("Consolas", 12F);
         this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
         this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnCancelar.Location = new System.Drawing.Point(639, 2);
         this.btnCancelar.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
         this.btnCancelar.Name = "btnCancelar";
         this.btnCancelar.Size = new System.Drawing.Size(127, 49);
         this.btnCancelar.TabIndex = 0;
         this.btnCancelar.Text = "Cancelar";
         this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnCancelar.UseVisualStyleBackColor = true;
         // 
         // btnLocalizar
         // 
         this.btnLocalizar.Font = new System.Drawing.Font("Consolas", 12F);
         this.btnLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.Image")));
         this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnLocalizar.Location = new System.Drawing.Point(117, 2);
         this.btnLocalizar.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
         this.btnLocalizar.Name = "btnLocalizar";
         this.btnLocalizar.Size = new System.Drawing.Size(134, 49);
         this.btnLocalizar.TabIndex = 0;
         this.btnLocalizar.Text = "Pesquisar";
         this.btnLocalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnLocalizar.UseVisualStyleBackColor = true;
         // 
         // btnSalvar
         // 
         this.btnSalvar.Font = new System.Drawing.Font("Consolas", 12F);
         this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
         this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnSalvar.Location = new System.Drawing.Point(529, 2);
         this.btnSalvar.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
         this.btnSalvar.Name = "btnSalvar";
         this.btnSalvar.Size = new System.Drawing.Size(104, 49);
         this.btnSalvar.TabIndex = 0;
         this.btnSalvar.Text = "Salvar";
         this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnSalvar.UseVisualStyleBackColor = true;
         // 
         // btnEditar
         // 
         this.btnEditar.Font = new System.Drawing.Font("Consolas", 12F);
         this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
         this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnEditar.Location = new System.Drawing.Point(266, 2);
         this.btnEditar.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
         this.btnEditar.Name = "btnEditar";
         this.btnEditar.Size = new System.Drawing.Size(104, 49);
         this.btnEditar.TabIndex = 0;
         this.btnEditar.Text = "Editar";
         this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnEditar.UseVisualStyleBackColor = true;
         // 
         // btnExcluir
         // 
         this.btnExcluir.Font = new System.Drawing.Font("Consolas", 12F);
         this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
         this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnExcluir.Location = new System.Drawing.Point(385, 2);
         this.btnExcluir.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
         this.btnExcluir.Name = "btnExcluir";
         this.btnExcluir.Size = new System.Drawing.Size(113, 49);
         this.btnExcluir.TabIndex = 0;
         this.btnExcluir.Text = "Excluir";
         this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnExcluir.UseVisualStyleBackColor = true;
         // 
         // pnDados
         // 
         this.pnDados.BackColor = System.Drawing.SystemColors.Control;
         this.pnDados.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pnDados.Location = new System.Drawing.Point(0, 52);
         this.pnDados.Name = "pnDados";
         this.pnDados.Size = new System.Drawing.Size(784, 509);
         this.pnDados.TabIndex = 2;
         // 
         // frmModelo
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(784, 561);
         this.Controls.Add(this.pnDados);
         this.Controls.Add(this.panel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmModelo";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "frmModelo";
         this.panel1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
         this.ResumeLayout(false);

      }

        #endregion

        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Panel pnDados;
        private System.Windows.Forms.BindingSource bindingSource1;
        protected System.Windows.Forms.Button btnNovo;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnLocalizar;
        protected System.Windows.Forms.Button btnSalvar;
        protected System.Windows.Forms.Button btnEditar;
        protected System.Windows.Forms.Button btnExcluir;
    }
}