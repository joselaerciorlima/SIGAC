using Classes;
using Modelo;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UI
{
   public partial class frmMenu : Form
   {
      private Random random;
      private int tempIndex;
      public string operacao;

      public frmMenu()
      {
         InitializeComponent();
         random = new Random();
         hideSubMenu();
      }
      private Color SelectThemeColor()
      {
         //int index = random.Next(ThemeColor.ColorList.Count);
         int index = random.Next(ThemeColor.ColorListGreen.Count);
         while (tempIndex == index)
         {
            //index = random.Next(ThemeColor.ColorList.Count);
            index = random.Next(ThemeColor.ColorListGreen.Count);
         }
         tempIndex = index;
         //string color = ThemeColor.ColorList[index];
         string color = ThemeColor.ColorListGreen[index];

         return ColorTranslator.FromHtml(color);

      }
      private void hideSubMenu()
      {
         panelCadSubMenu.Visible = false;
         panelRelSubMenu.Visible = false;
      }

      private void showSubMenu(Panel subMenu)
      {
         if (subMenu.Visible == false)
         {
            hideSubMenu();
            subMenu.Visible = true;
         }
         else
            subMenu.Visible = false;
      }

      private void btnExit_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private Form activeForm = null;
      private void openChildForm(Form childForm)
      {
         if (activeForm != null) activeForm.Close();
         Color color = SelectThemeColor();


         activeForm = childForm;

         //panelBotoes.BackColor = ThemeColor.ChangeColorBrightness(color, -0.5);
         //ThemeColor.PrimaryColor = color;
         //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.5);


         //childForm.BackColor = color;
         childForm.TopLevel = false;
         childForm.FormBorderStyle = FormBorderStyle.None;
         childForm.Dock = DockStyle.Fill;
         panelChildForm.Controls.Add(childForm);
         panelChildForm.Tag = childForm;
         childForm.BringToFront();
         childForm.Show();
      }

      private void btnCloseFormFilho_Click(object sender, EventArgs e)
      {
         panelBotoes.Visible = false;

         activeForm.Close();
      }

      //Método que sobrescreve o método que preenche a cor do formulário. Neste caso, ele preenche com um gradiente de dois tons de verde.
      //protected override void OnPaintBackground(PaintEventArgs e)
      //{

      //   //Color color1 = Color.FromArgb(1, 97, 49);

      //   //Color color2 = Color.FromArgb(119, 191, 57);

      //   //using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, color1,color2,300F))
      //   //{
      //   //   e.Graphics.FillRectangle(brush, this.ClientRectangle);
      //   //}
      //}

      private void Form1_Resize(object sender, EventArgs e)
      {
         //this.Invalidate();
      }

      private void btnCadastro_Click(object sender, EventArgs e)
      {
         showSubMenu(panelCadSubMenu);
      }

      private void btnAluno_Click(object sender, EventArgs e)
      {
         openChildForm(new frmCadAluno2());
         panelBotoes.Visible = true;
         alteraBotoes(1);


         hideSubMenu();
      }

      private void btnAtividade_Click(object sender, EventArgs e)
      {
         openChildForm(new frmModelo2());
         panelBotoes.Visible = true;
         //..
         //your codes
         //..
         hideSubMenu();
      }

      private void btnCertificado_Click(object sender, EventArgs e)
      {
         openChildForm(new frmModelo2());
         panelBotoes.Visible = true;
         //..
         //your codes
         //..
         hideSubMenu();
      }

      private void btnCurso_Click(object sender, EventArgs e)
      {
         openChildForm(new frmModelo2());
         panelBotoes.Visible = true;
         //..
         //your codes
         //..
         hideSubMenu();
      }

      private void btnUsuario_Click(object sender, EventArgs e)
      {
         openChildForm(new frmModelo2());
         panelBotoes.Visible = true;
         //..
         //your codes
         //..
         hideSubMenu();
      }

      private void btnRelatorio_Click(object sender, EventArgs e)
      {
         showSubMenu(panelRelSubMenu);
      }
      public void alteraBotoes(int op)
      {
         panelChildForm.Enabled = false;
         btnNovo.Enabled = false;
         btnEditar.Enabled = false;
         btnLocalizar.Enabled = false;
         btnSalvar.Enabled = false;
         btnCancelar.Enabled = false;
         btnExcluir.Enabled = false;

         switch (op)
         {
            case 1:
               btnNovo.Enabled = true;
               btnLocalizar.Enabled = true;
               break;
            case 2:
               panelChildForm.Enabled = true;
               btnSalvar.Enabled = true;
               btnCancelar.Enabled = true;
               break;
            case 3:
               btnEditar.Enabled = true;
               btnExcluir.Enabled = true;
               btnCancelar.Enabled = true;
               break;
         }
      }

      private void btnNovo_Click(object sender, EventArgs e)
      {
         operacao = "novo";
         alteraBotoes(2);
         
      }

      private void btnSalvar_Click(object sender, EventArgs e)
      {
         switch (activeForm.Name)
         {
            case "frmCadAluno2":
               operacao = "novo";
               break;
            case "frmCadAtividade2":
               break;
            case "frmCadCertificado2":
               break;
            case "frmCadCurso2":
               break;
         }
      }

      private void btnCancelar_Click(object sender, EventArgs e)
      {
         panelBotoes.Visible = false;

         activeForm.Close();
      }
   }
}
