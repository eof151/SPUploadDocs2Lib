using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.SharePoint;
using SPUploadDocs2Lib.ErrorHandlers;
using SPUploadDocs2Lib.Office;

namespace SPUploadDocs2Lib
{
    public partial class Form1 : Form
    {
        const string WORDFILE = ".docx";
        const string EXCELFILE = ".xlsx";

        public Form1()
        {
            InitializeComponent();
        }

        private void btCreateWordFiles_Click(object sender, EventArgs e)
        {
            CreateFiles(true);
        }

        private void btCreateExcelFiles_Click(object sender, EventArgs e)
        {
            CreateFiles(false);
        }

        /// <summary>Создать набор файлов определенного типа
        /// </summary>
        /// <param name="isWord">флаг типа файла</param>
        private void CreateFiles(bool isWord)
        {
            try
            {
                using (SPSite siteCollection = new SPSite(tbSiteUrl.Text))
                {
                    SPWeb myWeb = siteCollection.OpenWeb();
                    SPList myList = myWeb.Lists[tbListName.Text];
                    if (myList is SPDocumentLibrary)
                    {
                        int count = 0;
                        if (int.TryParse(tbFilesCount.Text, out count))
                        {
                            for (int i = 0; i < count; i++)
                            {
                                GenerateFile(myList, isWord);
                            }
                        }
                        Logger.LogInformation("Готово!");
                    }
                    else
                    {
                        Logger.LogWarning("Выбранный список не является библиотекой документов!");
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ExceptionsHandler.HandleError(ex));
            }
        }

        /// <summary> Создать файл в библиотеке
        /// </summary>
        /// <param name="myList">библиотека</param>
        /// <param name="isWord">флаг типа файла</param>
        private void GenerateFile(SPList myList, bool isWord)
        {
            SPListItem item = null;
            string documentName = String.Empty;
            MemoryStream docStream = new MemoryStream();
            StreamWriter writer = new StreamWriter(docStream);

            if (isWord)//Word
            {
                documentName = GeneratePartFileName(tbFilenamePref.Text, WORDFILE);
                DocumentBuilder.GenerateWordDocument(docStream, tbWordText.Text);
            }
            else //Excel
            {
                documentName = GeneratePartFileName(tbExcFilenamePref.Text, EXCELFILE);
                DocumentBuilder.GenerateExcelDocument(docStream, tbExcelText.Text);
            }

            SPFile file = myList.RootFolder.Files.Add(documentName, docStream, true);
            writer.Flush();
            item = file.Item;
            //Заполняем свойство - Название
            item["Title"] = "TestFile_" + item.ID;
            item.Update();
        }

        #region Helpers
        /// <summary> Генератор названия файла
        /// </summary>
        /// <param name="filePref">префикс</param>
        /// <param name="fileExt">расширение файла</param>
        /// <returns></returns>
        private static string GeneratePartFileName(string filePref, string fileExt)
        {
            string dayOfYear = DateTime.Now.DayOfYear.ToString("000");
            string hourAndMinute = ((DateTime.Now.Hour * 60) + DateTime.Now.Minute).ToString("0000");
            string randString = filePref + "_" + RandomString(7, true) + "_" + dayOfYear + hourAndMinute + fileExt;
            return randString;
        }

        /// <summary> Генератор случайной строки
        /// </summary>
        /// <param name="size">число символов</param>
        /// <param name="lowerCase">регистр вывода</param>
        /// <returns></returns>
        public static string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        #endregion
    }
}
