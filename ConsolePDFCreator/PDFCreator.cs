using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace ConsolePDFCreator
{
    class PDFCreator
    {
        public static void DataRecive(string[] DataFormXML, string NameDocument)
        {
            //Position X
            int PositionX = 100;
            //Position Y
            int PositionY = 50;
            //Create PDF document
            PdfDocument DocumentPDF = new PdfDocument();
            //Add a new page in the PDF Document
            PdfPage Page = DocumentPDF.AddPage();
            //Create contoller for the page with dimentions
            XGraphics Gfx = XGraphics.FromPdfPage(Page);
            //Create the variables for control the font  of the document
            XFont fontEncP = new XFont("Calibri", 12, XFontStyle.Bold);
            XFont fontEnc = new XFont("Calibri", 8.5, XFontStyle.Bold);
            XFont font = new XFont("Calibri", 8, XFontStyle.Regular);
            //Start to create the structure of the document
            foreach (var itemDta in DataFormXML)
            {
                Gfx.DrawString(itemDta.ToString(), fontEncP, XBrushes.Black,//Texto en Duro
                        new XRect(PositionX, PositionY, Page.Width, Page.Height),
                        XStringFormat.TopLeft);
                //Change of the position X
                PositionY += 50;
            }
            DocumentPDF.Save(Singleton.Instance.FileOut + NameDocument + ".pdf");
            
        }
    }
}
