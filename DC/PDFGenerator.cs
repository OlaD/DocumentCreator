using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace DC
{
				class PDFGenerator
				{
								public void GeneratePDF()
								{
												Document document = new Document(PageSize.A4, 50, 50, 50, 50);
												FileStream file = new FileStream("tmp.pdf", FileMode.Create);
												PdfWriter writer = PdfWriter.GetInstance(document, file);
												document.Open();

												Anchor anchorTarget = new Anchor("First page of the document.");
												anchorTarget.Name = "BackToTop";
												Paragraph paragraph1 = new Paragraph();
												paragraph1.SpacingBefore = 50;

												paragraph1.Add(anchorTarget);
												document.Add(paragraph1);

												document.Close();
								}
				}
}
