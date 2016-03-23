using iTextSharp.text;
using iTextSharp.text.pdf;
using NationalCriminalDB.EmailService.Entity;
using NationalCriminalDB.EmailService.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace NationalCriminalDB.EmailService.Helpers
{
    public class PDFHelper
    {
        /// <summary>
        /// Generate pdf Files for search result
        /// </summary>
        /// <param name="criminals">Criminals</param>
        /// <returns></returns>
        public static List<string> GeneratePdfFiles(List<Criminal> criminals)
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var files = new List<string>();
            foreach (var criminal in criminals)
            {
                var filename = generateCriminalFile(appDataPath, criminal);
                files.Add(filename);
            }
            return files;
        }

        private static string generateCriminalFile(string appDataPath, Criminal criminal)
        {
            var filename = string.Format("{0}\\criminal_{1}.pdf", appDataPath, criminal.Id);
            var fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            var doc = new Document();
            var writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            doc.AddTitle("National Criminal Database Result");
            doc.AddSubject(string.Format("Criminal : {0}", criminal.Name));
            doc.Add(new Paragraph("Criminal Record"));
            doc.Add(new Paragraph(string.Format("Name {0}", criminal.Name)));
            doc.Add(new Paragraph(string.Format("Nationality {0} kg", criminal.Nationality)));
            doc.Add(new Paragraph(string.Format("BirthDate {0}", criminal.BirthDate)));
            doc.Add(new Paragraph(string.Format("Age {0}", criminal.Age)));
            doc.Add(new Paragraph(string.Format("Sex {0}", Enum.GetName(typeof(EmailSendRequest.SexType), criminal.Sex))));
            doc.Add(new Paragraph(string.Format("Height {0} cm", criminal.Height)));
            doc.Add(new Paragraph(string.Format("Weight {0} kg", criminal.Weight)));
            doc.Close();
            return filename;
        }
    }
}