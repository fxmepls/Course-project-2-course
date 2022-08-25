using iTextSharp.text;
using iTextSharp.text.pdf;

using ParserVyatsu.Models;
using ParserVyatsu.OpenFile;

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ParserVyatsu.PdfFiles
{
    internal class PdfCreate
    {
        public void CreatePDF(string link, MergedStudyPeriods studyPeriods, bool open)
        {
            var path = link;

            //Объект документа пдф
            Document doc = new Document();
            if (studyPeriods.TeacherNames.Count > 3)
            {
                doc.SetPageSize(PageSize.A4.Rotate());
            }

            //Создаем объект записи пдф-документа в файл
            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));

            //Открываем документ
            doc.Open();

            //Определение шрифта необходимо для сохранения кириллического текста
            //Иначе мы не увидим кириллический текст
            //Если мы работаем только с англоязычными текстами, то шрифт можно не указывать
            BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\times.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            Font font = new Font(baseFont, Font.DEFAULTSIZE, Font.NORMAL);

            PdfPTable table = new PdfPTable(2 + studyPeriods.TeacherNames.Count);

            float[] widths = new float[2 + studyPeriods.TeacherNames.Count];
            widths[0] = 0.4f;
            widths[1] = 1f;
            for (int i = 2; i < widths.Length; i++)
                widths[i] = 2f;
            table.SetWidths(widths);

            InsertCell(table, "День", font);

            InsertCell(table, "Интервал", font);

            foreach (var teacherName in studyPeriods.TeacherNames)
            {
                InsertCell(table, teacherName, font);
            }

            foreach (var day in studyPeriods.StudyDays)
            {
                var first = true;
                foreach (var lessonTimes in day.Value.Times)
                {
                    if (first)
                    {
                        InsertCell(table, day.Key.ToString("dddd dd/MM/yy"), font, day.Value.Lessons.Count, 90, true);
                        first = false;
                    }
                    InsertCell(table, $"{lessonTimes.Key:hh\\:mm} - {lessonTimes.Value:hh\\:mm}", font);
                    foreach (var teacherName in studyPeriods.TeacherNames)
                    {
                        InsertCellLesson(table, day.Value.Lessons[lessonTimes.Key][teacherName], font);
                    }
                }
            }
            doc.Add(table);
            if (open)
            {
                FileOpen.openFile(link);
            }
            //Закрываем документ
            doc.Close();
        }

        private void InsertCell(PdfPTable table, string text, Font font, int rowSpan = 1, int rotation = 0, bool horizontalAlignment = false)
        {
            var cell = new PdfPCell(new Phrase(new Phrase(text, font)))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                Rowspan = rowSpan,
                Rotation = rotation
            };

            if (horizontalAlignment)
            {
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            }

            table.AddCell(cell);
        }
        private void InsertCellLesson(PdfPTable table, string text, Font font, int rowSpan = 1, int rotation = 0, bool horizontalAlignment = false)
        {
            var cell = new PdfPCell(new Phrase(new Phrase(text, font)))
            {
                HorizontalAlignment = Element.ALIGN_LEFT,
                Rowspan = rowSpan,
                Rotation = rotation,
            };

            if (horizontalAlignment)
            {
                cell.VerticalAlignment = Element.ALIGN_LEFT;
            }

            table.AddCell(cell);
        }
    }
}
