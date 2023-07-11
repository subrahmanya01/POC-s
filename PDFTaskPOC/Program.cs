using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Text;


// Replace "path_to_pdf" with the actual path to your PDF file
string pdfPath = "C:\\Users\\SUBRAHMANYA BHAT\\Downloads\\SHAREit\\Asp.Net Core MVC Docs.pdf";

// Create a StringBuilder to store the extracted text
StringBuilder sb = new StringBuilder();

using (PdfReader reader = new PdfReader(pdfPath))
{
	for (int page = 1; page <= reader.NumberOfPages; page++)
	{
		// Extract text from the current page
		ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
		string pageText = PdfTextExtractor.GetTextFromPage(reader, page, strategy);

		// Append the extracted text to the StringBuilder
		sb.AppendLine(pageText);
	}
}

// Get the final extracted text
string extractedText = sb.ToString();

// Use the extracted text as needed
Console.WriteLine(extractedText);
