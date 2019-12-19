﻿using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo
{
   public partial class frmModelo2 : Form
   {
      public frmModelo2()
      {
         InitializeComponent();
         
      }
      private void LoadTheme()
      {
         foreach (Control btns in this.Controls)
         {
            if (btns.GetType() == typeof(Button))
            {
               Button btn = (Button)btns;
               btn.BackColor = ThemeColor.PrimaryColor;
               btn.ForeColor = Color.White;
               btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            }
         }
         //label4.ForeColor = ThemeColor.SecondaryColor;
         //label5.ForeColor = ThemeColor.PrimaryColor;
      }
      private void button5_Click(object sender, EventArgs e)
      {
         Close();
      }

      private void frmModelo2_Load(object sender, EventArgs e)
      {
         LoadTheme();
      }
   }
}
