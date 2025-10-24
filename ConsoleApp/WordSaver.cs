using System;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace ConsoleApp
{
 public class WordSaver
 {
 /// <summary>
 /// Saves the provided text into a Word document at the specified file path.
 /// </summary>
 /// <param name="text">The text to save.</param>
 /// <param name="filePath">The path where the Word document will be saved.</param>
 public void SaveStringToWord(string text, string filePath)
 {
 using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
 {
 MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
 mainPart.Document = new Document();
 Body body = new Body();
 Paragraph para = new Paragraph();
 Run run = new Run();
 run.Append(new Text(text));
 para.Append(run);
 body.Append(para);
 mainPart.Document.Append(body);
 }
 }
 }
}
