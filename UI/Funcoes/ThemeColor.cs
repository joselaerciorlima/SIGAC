﻿using System.Collections.Generic;
using System.Drawing;

namespace Classes
{
   public static class ThemeColor
   {
      //Declara as propriedades para as cores primaria e secundaria.
      public static Color PrimaryColor { get; set; }
      public static Color SecondaryColor { get; set; }

      //Cria uma lista com as cores que serão utilizadas no formato html.
      public static List<string> ColorList = new List<string>() { "#3F51B5", "#009688", "#FF5722", "#607D8B", "#FF9800", "#9C27B0", "#2196F3", "#EA676C", "#E41A4A", "#5978BB", "#018790", "#0E3441", "#00B0AD", "#721D47", "#EA4833", "#EF937E", "#F37521", "#A12059", "#126881", "#8BC240", "#364D5B", "#C7DC5B", "#0094BC", "#E4126B", "#43B76E", "#7BCFE9", "#B71C46"};
      
      public static List<string> ColorListGreen = new List<string>() { "#00FA9A","#00FF7F","#006400","#008000","#228B22","#32CD32","#00FF00"};

      //Método para alterar o brilho da cor. Podemos escurecer ou clarear uma cor, alterando o tom dela.
      public static Color ChangeColorBrightness(Color color, double correctionFactor)
      {
         double red = color.R;
         double green = color.G;
         double blue = color.B;

         //If correction factor is less than 0, darken color.
         if (correctionFactor < 0)
         {
            correctionFactor = 1 + correctionFactor;
            red *= correctionFactor;
            green *= correctionFactor;
            blue *= correctionFactor;
         }
         //If correction factor is greater than zero, lighten color.
         else
         {
            red = (255 - red) * correctionFactor + red;
            green = (255 - green) * correctionFactor + green;
            blue = (255 - blue) * correctionFactor + blue;
         }

         return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
      }
   }
}