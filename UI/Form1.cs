using Classes;
using Modelo;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
   public partial class Form1 : Form
   {
      private Random random;
      private int tempIndex;
      private Button currentButton;
      public Form1()
      {
         InitializeComponent();
         random = new Random();
         hideSubMenu();
      }
      private Color SelectThemeColor()
      {
         int index = random.Next(ThemeColor.ColorList.Count);
         while (tempIndex == index)
         {
            index = random.Next(ThemeColor.ColorList.Count);
         }
         tempIndex = index;
         string color = ThemeColor.ColorList[index];
         return ColorTranslator.FromHtml(color);
      }
      private void hideSubMenu()
      {
         panelMediaSubMenu.Visible = false;
         panelPlaylistSubMenu.Visible = false;
         panelToolsSubMenu.Visible = false;
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

      private void btnMedia_Click(object sender, EventArgs e)
      {
         showSubMenu(panelMediaSubMenu);
      }

      #region MediaSubMenu
      private void button2_Click(object sender, EventArgs e)
      {
         openChildForm(new frmModelo2());
         panelBotoes.Visible = true;
         //..
         //your codes
         //..
         hideSubMenu();
      }

      private void button3_Click(object sender, EventArgs e)
      {
         //..
         //your codes
         //..
         hideSubMenu();
      }

      private void button4_Click(object sender, EventArgs e)
      {
         //..
         //your codes
         //..
         hideSubMenu();
      }

      private void button5_Click(object sender, EventArgs e)
      {
         //..
         //your codes
         //..
         hideSubMenu();
      }
      #endregion

      private void btnPlaylist_Click(object sender, EventArgs e)
      {
         showSubMenu(panelPlaylistSubMenu);
      }

      #region PlayListManagemetSubMenu
      private void button8_Click(object sender, EventArgs e)
      {
         //..
         //your codes
         //..
         hideSubMenu();
      }

      private void button7_Click(object sender, EventArgs e)
      {
         //..
         //your codes
         //..
         hideSubMenu();
      }

      private void button6_Click(object sender, EventArgs e)
      {
         //..
         //your codes
         //..
         hideSubMenu();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         //..
         //your codes
         //..
         hideSubMenu();
      }
      #endregion

      private void btnTools_Click(object sender, EventArgs e)
      {
         showSubMenu(panelToolsSubMenu);
      }
      #region ToolsSubMenu
      private void button13_Click(object sender, EventArgs e)
      {
         //..
         //your codes
         //..
         hideSubMenu();
      }

      private void button12_Click(object sender, EventArgs e)
      {
         //..
         //your codes
         //..
         hideSubMenu();
      }

      private void button10_Click(object sender, EventArgs e)
      {
         //..
         //your codes
         //..
         hideSubMenu();
      }

      private void button9_Click(object sender, EventArgs e)
      {
         //..
         //your codes
         //..
         hideSubMenu();
      }
      #endregion

      private void btnEqualizer_Click(object sender, EventArgs e)
      {
         openChildForm(new Form3());
         //..
         //your codes
         //..
         hideSubMenu();
      }

      private void btnHelp_Click(object sender, EventArgs e)
      {
         //..
         //your codes
         //..
         hideSubMenu();
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
         
         panelBotoes.BackColor = ThemeColor.ChangeColorBrightness(color, -0.5);
         ThemeColor.PrimaryColor = color;
         ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.5);

         childForm.BackColor = color;
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
   }
}
