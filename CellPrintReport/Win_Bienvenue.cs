using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Printing;
using System.Linq.Expressions;

namespace CellPrintReport
{
    public partial class Win_Bienvenue : Form
    {
        
        PrintDocument printStuff = new PrintDocument();
        PrintPreviewDialog viewStuff = new PrintPreviewDialog();
        Font printFont;


        public Win_Bienvenue()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rad_Exemple1.Checked = true;
        }

        private void Btn_Preview_Click(object sender, EventArgs e)
        {
            printStuff = new PrintDocument();
            printStuff.PrintPage += new PrintPageEventHandler(MiseEnPage_Selection);
            viewStuff.Document = printStuff;
            viewStuff.Document.DocumentName = "PREVISUALISATION";
            viewStuff.Width = 400;
            viewStuff.Height = 600;         
            viewStuff.ShowDialog();
        }
        private void Btn_PrintWithSelect_Click(object sender, EventArgs e)
        {
            printStuff = new PrintDocument();
            printStuff.PrintPage += new PrintPageEventHandler(MiseEnPage_Selection);
            PrintDialog printSetup = new PrintDialog();
            printStuff.DocumentName = "Print1 Document Test";
            printSetup.AllowSomePages = true;
            if (printSetup.ShowDialog(this) == DialogResult.OK)
            {
                printStuff.PrinterSettings.PrinterName = printSetup.PrinterSettings.PrinterName;
                printStuff.Print(); return;
            }

        }

        private void Btn_PrintDefault_Click(object sender, EventArgs e)
        {
            printStuff = new PrintDocument();
            printStuff.PrintPage += new PrintPageEventHandler(MiseEnPage_Selection);
            PrintController stdPrintController = new StandardPrintController();
            printStuff.DocumentName = "Print1 Document Test";
            printStuff.Print();
        }

        private void MiseEnPage_Selection(Object sender, PrintPageEventArgs e)
        {
            if (Rad_Exemple1.Checked) { MiseEnPage_Exemple1(sender, e); }
            if (Rad_Exemple2.Checked) { MiseEnPage_Exemple2(sender, e); }
            if (Rad_Exemple3.Checked) { MiseEnPage_Exemple3(sender, e); }
            if (Rad_Exemple4.Checked) { MiseEnPage_Exemple4(sender, e); }
        }

        private void Btn_Navig_Click(object sender, EventArgs e)
        {
            try
            {
                String input = string.Empty;
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png|All files (*.*)|*.*";
                dialog.InitialDirectory = "C:";
                dialog.Title = "Selectionnez une image jpg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Txt_PathPicture.Text = dialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MiseEnPage_Exemple1(Object sender, PrintPageEventArgs e)
        {
            // Exemple simple impression d'une phrase.

            try
            {
            e.Graphics.PageUnit = GraphicsUnit.Millimeter;

            // Texte
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            e.Graphics.DrawString("Ceci est l'exemple numero 1.", drawFont, drawBrush, 19.4F, 19.4F);

            // Tracage d'une ligne horizontale
            Pen myPen = new Pen(Color.Gray, 0.2F);
            e.Graphics.DrawLine(myPen, 19.4F, 44F, 194.4F, 44F);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void MiseEnPage_Exemple2(Object sender, PrintPageEventArgs e)
        {
            // Impression d'une image que vous aurez selectionné.

            try
            {
                System.Drawing.Image img = System.Drawing.Image.FromFile(Txt_PathPicture.Text);
                Point loc = new Point(100, 100);
                e.Graphics.DrawImage(img, loc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void MiseEnPage_Exemple3(Object sender, PrintPageEventArgs e)
        { 
            
            // Mise en page du graphique en camenbert
            
            try
            {
                // Cette procedure vous permet de créer des cercles
                // et rectangles utilisant l'objet e.Graphics.
                Single RedGradius = 80;
                Single GreenGradius = 130;    
                Single BlueGradius = 100;    
                Single GreyGradius = 50;
                // Dessin d'un cercle  peint avec quatre couleurs.      
                Rectangle Circle = new Rectangle(60, 60, 350, 350);  
                e.Graphics.FillPie(Brushes.DarkRed, Circle, 0, RedGradius);   
                e.Graphics.FillPie(Brushes.GreenYellow, Circle, RedGradius, GreenGradius);  
                e.Graphics.FillPie(Brushes.Blue, Circle,  RedGradius+ GreenGradius, BlueGradius);  
                e.Graphics.FillPie(Brushes.LightGray, Circle,  RedGradius + GreenGradius+ BlueGradius, GreyGradius);   
                // Dessin des rectangles de la legende           
                Rectangle RedLegend = new Rectangle(50, 400, 25, 25);      
                e.Graphics.FillRectangle(Brushes.DarkRed, RedLegend);       
                Rectangle GreenLegend = new Rectangle(50, 430, 25, 25);      
                e.Graphics.FillRectangle(Brushes.GreenYellow, GreenLegend);       
                Rectangle BlueLegend = new Rectangle(50, 460, 25, 25);
                e.Graphics.FillRectangle(Brushes.Blue, BlueLegend);
                Rectangle GreyLegend = new Rectangle(50, 490, 25, 25);
                e.Graphics.FillRectangle(Brushes.LightGray, GreyLegend);  
                // Ecriture des phrases de la legende      
                e.Graphics.DrawString(Math.Round(RedGradius /360 * 100,2) + " %.", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(90, 400)); 
                e.Graphics.DrawString(Math.Round(GreenGradius / 360 * 100,2) + " %.", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(90, 430));  
                e.Graphics.DrawString(Math.Round(BlueGradius / 360 * 100,2) + " %.", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(90, 460)); 
                e.Graphics.DrawString(Math.Round(GreyGradius / 360 * 100,2) + " %.", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(90, 490));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void MiseEnPage_Exemple4(Object sender, PrintPageEventArgs e)
        {

            // Impression evoluée basé sur des classes dont
            // le principe reprend celui des cellules d'excel. Le document est
            // formé par un agencement de cellules dont les encadrements
            // respectifs dessinent le tableau.
            
            int lig = 0;
            decimal prix;
            int qte;
            decimal caht;
            decimal totcaht=0;
            bool AffBordBottom = false;

            Random rnd = new Random();

            try
            {

                    // On choisi d'utiliser le millimetre comme unité de mesure.   
                    e.Graphics.PageUnit = GraphicsUnit.Millimeter;
                    //MoneyCell macel = new MoneyCell();

                    // Impression entetes du tableau
                    TextCell CellPrixEntete = new TextCell();
                    CellPrixEntete.XCoord = 20F;
                    CellPrixEntete.YCoord = 20F;
                    CellPrixEntete.Width =   21F;
                    CellPrixEntete.Height =  5F ;
                    CellPrixEntete.Border_LinePen = new Pen(Color.Black, 0.2F);                 
                    CellPrixEntete.CtArea_FontCell= new Font("Courier New", 8);
                    CellPrixEntete.CtArea_HorizAlign = 1;
                    CellPrixEntete.CtArea_Data="Prix";
                    CellPrixEntete.pg = (PrintPageEventArgs)e;
                    CellPrixEntete.Draw_Cell();

                    TextCell CellX = new TextCell();
                    CellX.XCoord = 41F;
                    CellX.YCoord = 20F;
                    CellX.Width = 9F;
                    CellX.Height = 5F;
                    CellX.Border_LinePen = new Pen(Color.Black, 0.2F);
                    CellX.CtArea_HorizAlign = 1;
                    CellX.CtArea_Data="Op.";
                    CellX.pg = (PrintPageEventArgs)e;
                    CellX.Draw_Cell();

                    TextCell CellQteEntete = new TextCell();
                    CellQteEntete.XCoord = 50F;
                    CellQteEntete.YCoord = 20F;
                    CellQteEntete.Width = 23F;
                    CellQteEntete.Height = 5F;
                    CellQteEntete.Border_LinePen = new Pen(Color.Black, 0.2F);
                    CellQteEntete.CtArea_FontCell = new Font("Courier New", 8);
                    CellQteEntete.CtArea_HorizAlign = 1;
                    CellQteEntete.CtArea_Data="Quantité";
                    CellQteEntete.pg = (PrintPageEventArgs)e;
                
                    CellQteEntete.Draw_Cell();

                    TextCell Result = new TextCell();
                    Result.XCoord = 73F;
                    Result.YCoord = 20F;
                    Result.Width = 23F;
                    Result.Height = 5F;
                    Result.Border_LinePen = new Pen(Color.Black, 0.4F);
                    Result.CtArea_FontCell = new Font("Courier New", 8);
                    Result.CtArea_HorizAlign = 1;
                    Result.CtArea_Data="Total ";
                    Result.pg = (PrintPageEventArgs)e;
                    Result.Draw_Cell();

                // On dessine une grande cellule avec un grand X
                    CellX.XCoord = 41F;
                    CellX.YCoord = 25F ;
                    CellX.Height = 50F; 
                    CellX.CtArea_VertiAlign = 1;
                    CellX.CtArea_Data = "X";
                    CellX.CtArea_FontCell = new Font("Arial", 24);
                    CellX.CtArea_Brush = Brushes.Gray;
                    CellX.Draw_Cell();



                //Impression des lignes du tableau.
                for (int i = 1; i <= 10; i++)
                {
                    if (i==10) { AffBordBottom = true;};
                    lig = lig + 5;

                    prix= 10.52M * rnd.Next(1, 52);
                    qte = 3+rnd.Next(1,10);
                    caht = prix * qte;
                    totcaht = totcaht + caht;

                    MoneyCell CellPrixLig = new MoneyCell();
                    CellPrixLig.XCoord = 20F;
                    CellPrixLig.YCoord = 20F + lig;
                    CellPrixLig.Width = 21F;
                    CellPrixLig.Height = 5F;
                    CellPrixLig.Border_LineTop = false;
                    CellPrixLig.Border_LineBottom = AffBordBottom;
                    CellPrixLig.Border_LinePen = new Pen(Color.Black, 0.2F);
                    CellPrixLig.CtArea_Data=prix;
                    CellPrixLig.pg = (PrintPageEventArgs)e;
                    CellPrixLig.Draw_Cell();

                    NumericCell CellQteLig = new NumericCell();
                    CellQteLig.XCoord = 50F;
                    CellQteLig.YCoord = 20F + lig;
                    CellQteLig.Width = 23F;
                    CellQteLig.Height = 5F;
                    CellQteLig.Border_LineTop = false;
                    CellQteLig.Border_LineBottom = AffBordBottom;
                    CellQteLig.Border_LinePen = new Pen(Color.Black, 0.2F);
                    CellQteLig.CtArea_Data=qte;
                    CellQteLig.pg = (PrintPageEventArgs)e;
                    CellQteLig.Draw_Cell();
                   

                    MoneyCell ResultLig = new MoneyCell();
                    ResultLig.XCoord = 73F;
                    ResultLig.YCoord = 20F+lig;
                    ResultLig.Width = 23F;
                    ResultLig.Height = 5F;
                    ResultLig.Border_LineTop = false;
                    ResultLig.Border_LineBottom = AffBordBottom;
                    ResultLig.Border_LinePen = new Pen(Color.Black, 0.4F);
                    ResultLig.CtArea_Data=caht;
                    ResultLig.pg = (PrintPageEventArgs)e;
                    ResultLig.Draw_Cell();
                }

                // Impression des deux cellules formant le total final.
                TextCell CellLibTotal = new TextCell();
                CellLibTotal.XCoord = 41F;
                CellLibTotal.YCoord = 20F + lig+5;
                CellLibTotal.Width = 32F;
                CellLibTotal.Height = 5F;

                CellLibTotal.Border_LinePen = new Pen(Color.Black, 0.4F);
                CellLibTotal.CtArea_Data="Total général";
                CellLibTotal.pg = (PrintPageEventArgs)e;
                CellLibTotal.Draw_Cell();

                MoneyCell CellTotalGeneral = new MoneyCell();
                CellTotalGeneral.XCoord = 73F;
                CellTotalGeneral.YCoord = 20F + lig+5;
                CellTotalGeneral.Width = 23F;
                CellTotalGeneral.Height = 5F;
                CellTotalGeneral.Border_LinePen = new Pen(Color.DarkRed, 0.4F);
                CellTotalGeneral.CtArea_Brush = Brushes.Red;
                CellTotalGeneral.CtArea_Data=totcaht;
                CellTotalGeneral.pg = (PrintPageEventArgs)e;
                CellTotalGeneral.Draw_Cell();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void GBox_Exemples_Enter(object sender, EventArgs e)
        {

        }

        private void Rad_Exemple4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
