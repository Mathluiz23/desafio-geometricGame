using System;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace diamond_game
{
  public class PDFService
  {
    internal static void GeneratePDF(string geometric)
    {
      var document = new Document();
      var pdfWriter = PdfWriter.GetInstance(document, new FileStream("geometric.pdf", FileMode.Create));
      document.Open();

      _ = PageSize.A4;
      Paragraph paragraph = new(geometric)
      {
        Alignment = Element.ALIGN_JUSTIFIED,
        Font = FontFactory.GetFont("Arial", 20, 500, BaseColor.BLACK)
      };

      document.Add(paragraph);

      document.Close();
      pdfWriter.Close();

      Console.WriteLine("PDF gerado com sucesso!");
    }
  }
}

