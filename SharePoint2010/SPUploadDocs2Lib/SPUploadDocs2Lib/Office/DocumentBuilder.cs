using System.IO;
using OfficeOpenXml;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace SPUploadDocs2Lib.Office
{
    public class DocumentBuilder
    {
        public static void GenerateWordDocument(Stream doc, string documentContentText)
        {
            //Создаем Wordprocessing документ 
            using (WordprocessingDocument myDoc = WordprocessingDocument.Create(doc, WordprocessingDocumentType.Document))
            {
                //Добавляем новую главную часть документа - main document part
                MainDocumentPart mainPart = myDoc.AddMainDocumentPart();
                mainPart.Document = new Document();
                //Создаем тело документа - Body (этот элемент содержит
                //другие элементы, которые мы хотим добавить в документ) 
                Body body = new Body();
                //Создаем параграф 
                Paragraph paragraph = new Paragraph();
                Run run_paragraph = new Run();
                //Размещаем текст в документе 
                Text text_paragraph = new Text(documentContentText);
                run_paragraph.Append(text_paragraph);
                paragraph.Append(run_paragraph);
                body.Append(paragraph);
                mainPart.Document.Append(body);
                //Сохраняем изменения в главной части документа 
                mainPart.Document.Save();
            }
        }

        public static void GenerateExcelDocument(Stream doc, string documentContentText)
        {
            using (var xls = new ExcelPackage(doc))
            {
                //Добавляем лист в книгу Excel
                var worksheet = xls.Workbook.Worksheets.Add("Worksheets1");
                //Задаем ширину первого столбца
                worksheet.Column(1).Width = 30;
                //Указываем содержимое первой ячейки в первом столбце
                worksheet.Cells[1, 1].Value = documentContentText;
                //Добавляем метаданные к файлу
                xls.Workbook.Properties.Title = "Excel2010";
                xls.Workbook.Properties.Author = "UploadDocs2Lib";
                xls.Save();
            }
        }
    }
}
