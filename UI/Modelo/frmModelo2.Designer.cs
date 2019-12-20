namespace Modelo
{
   partial class frmModelo2
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
         this.panelDados = new System.Windows.Forms.Panel();
         this.SuspendLayout();
         // 
         // panelDados
         // 
         this.panelDados.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panelDados.Location = new System.Drawing.Point(0, 0);
         this.panelDados.Name = "panelDados";
         this.panelDados.Size = new System.Drawing.Size(797, 498);
         this.panelDados.TabIndex = 0;
         // 
         // frmModelo2
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.Control;
         this.ClientSize = new System.Drawing.Size(797, 498);
         this.Controls.Add(this.panelDados);
         this.Name = "frmModelo2";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "frmModelo2";
         this.ResumeLayout(false);

      }

      #endregion

      public System.Windows.Forms.Panel panelDados;
   }
}