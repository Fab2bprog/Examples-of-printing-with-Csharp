using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

// Author: Fabrice GARCIA (20290 BORGO, Haute-Corse, France. November 1, 2021)
// You are free to include this code in your programs.
// It is provided to you freely and free of charge without any liability on my part.
// I only ask you to respect my copyright by keeping my name
// You can also send me a thank you email to fab2bprog@outlook.fr that will make me happy.

namespace CellPrintReport
{
    public abstract class CommonCell
    {
        public float XCoord;
        public float YCoord;
        public float Height;
        public float Width;

        public float Zone_YCoord = 0;
        public float Zone_Height = 0;

        public float MarginTop = 0;
        public float MarginRight = 0;
        public float MarginLeft = 0;
        public float MarginBottom = 0;

        private float BorderTop = 1;
        private float BorderRight = 1;
        private float BorderLeft = 1;
        private float BorderBottom = 1;

        public float PaddingTop = 0;
        public float PaddingRight = 0;
        public float PaddingLeft = 0;
        public float PaddingBottom = 0;


        /// <summary>
        /// Police et taille de la police du texte :
        /// </summary>
        public Font CtArea_FontCell = new Font("Courier New", 8);
        /// <summary>
        /// Couleur de la police du texte :
        /// </summary>
        public Brush CtArea_Brush = Brushes.Black;

        /// <summary>
        /// Crayon utilisé pour dessiner la bordure de la cellule.
        /// </summary>
        public Pen   Border_LinePen= new Pen(Color.Black, 0.2F);
        public PrintPageEventArgs pg;



        //-----------------------------------------------------
        public bool Border_LineTop
        {
            get
            {
                if (this.BorderTop > 1) { return true; } else { return false; };
            }
            set
            {
                if (value == true) { this.BorderTop = 1; } else { this.BorderTop = 0; }
            }
        }

        public bool Border_LineRight
        {
            get
            {
                if (this.BorderRight > 1) { return true; } else { return false; };
            }
            set
            {
                if (value == true) { this.BorderRight = 1; } else { this.BorderRight = 0; }
            }
        }

        public bool Border_LineLeft
        {
            get
            {
                if (this.BorderLeft > 1) { return true; } else { return false; };
            }
            set
            {
                if (value == true) { this.BorderLeft = 1; } else { this.BorderLeft= 0; }
            }
        }

        public bool Border_LineBottom
        {
            get
            {
                if (this.BorderBottom > 1) { return true; } else { return false; };
            }
            set
            {
                if (value == true) { this.BorderBottom = 1; } else { this.BorderBottom= 0; }
            }
        }

        public float Margin_LeftX()
        {
            return XCoord;
        }

        public float Margin_RightX()
        {
            float result = XCoord + Margin_Width();
            return result;
        }

        public float Margin_TopY()
        {
            return YCoord + Zone_YCoord;
        }

        public float Margin_BottomY()
        {
            float result = YCoord + Zone_YCoord + Margin_Height();
            return result;
        }

        public float Margin_Width()
        {
            return Width;
        }

        public float Margin_Height()
        {
            return Height;
        }

        //-----------------------------------------------------

        //-----------------------------------------------------
        public float Border_LeftX()
        {
            float result = XCoord + MarginLeft;
            return result;
        }

        public float Border_RightX()
        {
            float result = Border_LeftX() + Border_Width();
            return result;
        }

        public float Border_TopY()
        {
            float result = YCoord + Zone_YCoord + MarginTop;
            return result;
        }

        public float Border_BottomY()
        {
            float result = Border_TopY() + Border_Height();
            return result;
        }

        public float Border_Width()
        {
            float result = Width - MarginLeft - MarginRight;
            return result;
        }

        public float Border_Height()
        {
            float result = Height - MarginTop - MarginBottom;
            return result;
        }
        //-----------------------------------------------------

        //-----------------------------------------------------
        public float Padding_LeftX()
        {
            float result = XCoord + MarginLeft + BorderLeft;
            return result;
        }

        public float Padding_RightX()
        {
            float result = Border_LeftX() + Padding_Width();
            return result;
        }

        public float Padding_TopY()
        {
            float result = YCoord + Zone_YCoord + MarginTop + BorderTop;
            return result;
        }

        public float Padding_BottomY()
        {
            float result = Border_TopY() + Padding_Height();
            return result;
        }

        public float Padding_Width()
        {
            float result = Width - (MarginLeft + BorderLeft) - (MarginRight + BorderRight);
            return result;
        }

        public float Padding_Height()
        {
            float result = Height - (MarginTop + BorderTop) - (MarginBottom + BorderBottom);
            return result;
        }

        //-----------------------------------------------------
        public float CtArea_LeftX()
        {
            float result = XCoord + MarginLeft + BorderLeft + PaddingLeft;
            return result;
        }

        public float CtArea_RightX()
        {
            float result = CtArea_LeftX() + CtArea_Width();
            return result;
        }

        public float CtArea_TopY()
        {
            float result = YCoord + Zone_YCoord + MarginTop + BorderTop + PaddingTop;
            return result;
        }

        public float CtArea_BottomY()
        {
            float result = CtArea_TopY() + CtArea_Height();
            return result;
        }

        public float CtArea_Width()
        {
            float result = Width - (MarginLeft + BorderLeft + PaddingLeft) - (MarginRight + BorderRight + PaddingRight);
            return result;
        }

        public float CtArea_Height()
        {
            float result = Height - (MarginTop + BorderTop + PaddingTop) - (MarginBottom + BorderBottom + PaddingBottom);
            return result;
        }


        public bool Draw_Border()
        {

            if (BorderTop > 0) { pg.Graphics.DrawLine(Border_LinePen, Border_LeftX(), Border_TopY(), Border_RightX(), Border_TopY()); };
            if (BorderRight > 0) { pg.Graphics.DrawLine(Border_LinePen, Border_RightX(), Border_TopY(), Border_RightX(), Border_BottomY()); };
            if (BorderLeft > 0) { pg.Graphics.DrawLine(Border_LinePen, Border_LeftX(), Border_TopY(), Border_LeftX(), Border_BottomY()); };
            if (BorderBottom > 0) { pg.Graphics.DrawLine(Border_LinePen, Border_LeftX(), Border_BottomY(), Border_RightX(), Border_BottomY()); };

            return true;

        }


    }

    public class TextCell : CommonCell
    {

        /// <summary>
        /// Defini l'alignement horizontal du texte :
        /// left = 0, center = 1, right = 2
        /// </summary>
        public int CtArea_HorizAlign = 0; // left = 0, center = 1, right = 2
 
        /// <summary>
        /// Defini l'alignement vertical du texte :
        /// Top = 0, center = 1, Bottom = 2
        /// </summary>
        public int CtArea_VertiAlign = 0; // top = 0 , center = 1, bottom = 2
        public string CtArea_Data = string.Empty;

        public bool Draw_Cell()
        {
            Draw_Border();
            Draw_CtArea_Data(CtArea_Data, CtArea_LeftX(), CtArea_TopY());

            return true;

        }



        private bool Draw_CtArea_Data(string txt, float x, float y)
        {

            SizeF sf_string = pg.Graphics.MeasureString(txt, CtArea_FontCell);

            float CxLayout=0;
            float CyLayout=0;
             


            // Alignement horizontal  a gauche du texte
            if (CtArea_HorizAlign == 0) 
            {
                CxLayout = x;
            }
            // Alignement vertical  en haut
            if (CtArea_VertiAlign == 0)
            {
                CyLayout = y;
            }

            // Alignement horizontal  au centre du texte
            if (CtArea_HorizAlign==1)  {
                CxLayout = x + ((CtArea_Width() / 2) - (sf_string.Width / 2));
            }
            // Alignement vertical  au centre du texte
            if (CtArea_VertiAlign == 1)
            {
                CyLayout = y + ((CtArea_Height() / 2) - (sf_string.Height / 2));
            }

            // Alignement horizontal a  droite du texte
            if (CtArea_HorizAlign == 2)
            {
                CxLayout = x + (CtArea_Width() - sf_string.Width);

            }
            // Alignement vertical en bas de la cellule
            if (CtArea_VertiAlign == 2)
            {
                CyLayout = y + (CtArea_Height() - sf_string.Height);
            }

            pg.Graphics.DrawString(txt, CtArea_FontCell, CtArea_Brush, CxLayout, CyLayout);

            return true;
        }



    }
    public class NumericCell : CommonCell
    {
        public int DecimalNum;
        public float CtArea_Data = 0;

        public bool Draw_Cell()
        {
            Draw_Border();
            Draw_CtArea_Data(CtArea_Data, CtArea_RightX(), CtArea_TopY());
            return true;

        }

        private bool Draw_CtArea_Data(float number, float x, float y)
        {
            string cdecim = String.Empty;
            string txt = number.ToString();

            for (int i = 0; i < DecimalNum; i++)
            {
                cdecim = cdecim + "0";
            }
            
            SizeF sf_decim = pg.Graphics.MeasureString(cdecim, CtArea_FontCell);
            SizeF sf_string = pg.Graphics.MeasureString(txt, CtArea_FontCell);

            float.TryParse(txt, out float result);
            SizeF sf_IntPart = pg.Graphics.MeasureString(Math.Truncate(result).ToString(), CtArea_FontCell);

            pg.Graphics.DrawString(txt, CtArea_FontCell, CtArea_Brush, x - sf_IntPart.Width - sf_decim.Width, y);

            return true;
        }

    }
    public class MoneyCell : CommonCell
    {

        public decimal CtArea_Data = 0;

        public bool Draw_Cell()
        {
            Draw_Border();
            Draw_CtArea_Data(CtArea_Data, CtArea_RightX(), CtArea_TopY());

            return true;

        }

        private bool Draw_CtArea_Data(decimal number, float x, float y)
        {
            string txt = number.ToString("C");
            string textIntPart = Math.Truncate(number).ToString("N");
            textIntPart = textIntPart.Substring(0, textIntPart.Length - 3);

            SizeF sf_decim = pg.Graphics.MeasureString("00 €", CtArea_FontCell);

            SizeF sf_txt = pg.Graphics.MeasureString(txt, CtArea_FontCell);
            SizeF sf_textIntPart = pg.Graphics.MeasureString(textIntPart, CtArea_FontCell);

            pg.Graphics.DrawString(txt, CtArea_FontCell, CtArea_Brush, x - sf_textIntPart.Width - sf_decim.Width, y);

            return true;

        }

    }


}
