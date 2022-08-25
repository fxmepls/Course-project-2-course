using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

using ParserVyatsu.Models;
using ParserVyatsu.OpenFile;

using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

using Workbook = DocumentFormat.OpenXml.Spreadsheet.Workbook;
using Worksheet = DocumentFormat.OpenXml.Spreadsheet.Worksheet;

namespace ParserVyatsu.ExelFiles
{
    internal class ExcelCreate
    {
        public void CreateExcel(string fileName, MergedStudyPeriods studyPeriods, bool open)
        {
            var path = fileName;
            using (var document = SpreadsheetDocument.Create(path, SpreadsheetDocumentType.Workbook))
            {
                var workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();
                var worksheetPart = workbookPart.AddNewPart<WorksheetPart>();

                var fv = new FileVersion
                {
                    ApplicationName = "Microsoft Office Excel"
                };
                worksheetPart.Worksheet = new Worksheet(new SheetData());
                var workBookStylePart = workbookPart.AddNewPart<WorkbookStylesPart>();

                workBookStylePart.Stylesheet = CreateStyleSheet();
                workBookStylePart.Stylesheet.Save();

                Columns columnList = worksheetPart.Worksheet.GetFirstChild<Columns>();
                if (columnList == null)
                {
                    columnList = new Columns();
                    columnList.Append(new Column() { Min = 1, Max = 10, Width = 10, CustomWidth = true });
                    columnList.Append(new Column() { Min = 2, Max = 6, Width = 12, CustomWidth = true });
                    for (int i = 0; i < studyPeriods.TeacherNames.Count; i++)
                        columnList.Append(new Column() { Min = 3, Max = 15, Width = 60, CustomWidth = true });
                    worksheetPart.Worksheet.InsertAt(columnList, 0);
                }

                var sheets = workbookPart.Workbook.AppendChild(new Sheets());
                var sheet = new Sheet()
                {
                    Id = workbookPart.GetIdOfPart(worksheetPart),
                    SheetId = 1,
                    Name = "Расписание"
                };
                sheets.Append(sheet);

                var sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                Row row = new Row()
                {
                    RowIndex = 1
                };
                sheetData.Append(row);

                InsertCell(row, 1, "День", 1);
                InsertCell(row, 2, "Интервал", 2);
                for (var i = 0; i < studyPeriods.TeacherNames.Count; i++)
                    InsertCell(row, 3 + i, studyPeriods.TeacherNames[i], 3);

                UInt32Value rowIndex = 1;
                foreach (var day in studyPeriods.StudyDays)
                {
                    var first = true;
                    foreach (var lessonTimes in day.Value.Times)
                    {
                        rowIndex++;
                        row = new Row() { RowIndex = rowIndex };
                        sheetData.Append(row);

                        if (first)
                        {
                            InsertCell(row, 1, day.Key.ToString("dddd dd/MM/yy"), 1);
                            first = false;
                        }
                        else
                        {
                            InsertCell(row, 1, string.Empty, 1);
                        }
                        InsertCell(row, 2, $"{lessonTimes.Key:hh\\:mm} - {lessonTimes.Value:hh\\:mm}", 2);
                        var index = 0;
                        foreach (var teacherName in studyPeriods.TeacherNames)
                        {
                            InsertCell(row, 3 + index, day.Value.Lessons[lessonTimes.Key][teacherName], 3);
                            index++;
                        }
                    }
                }

                workbookPart.Workbook.Save();
                if (open)
                {
                    FileOpen.openFile(fileName);
                }
                document.Close();

            }
        }

        private static string ReplaceHexadecimalSymbols(string txt)
        {
            string r = "[\x00-\x08\x0B\x0C\x0E-\x1F\x26]";
            return Regex.Replace(txt, r, "", RegexOptions.Compiled);
        }

        private static void InsertCell(Row row, int cellIndex, string val, uint styleIndex)
        {
            Cell newCell = new Cell()
            {
                CellReference = cellIndex.ToString() + ":" + row.RowIndex.ToString(),
                StyleIndex = styleIndex
            };
            row.InsertBefore(newCell, null);

            newCell.CellValue = new CellValue(ReplaceHexadecimalSymbols(val));
            newCell.DataType = new EnumValue<CellValues>(CellValues.String);
        }

        private static Stylesheet CreateStyleSheet()
        {
            return new Stylesheet(
                new Fonts(
                    new Font(
                        new FontSize() { Val = 14 },
                        new Color() { Rgb = new HexBinaryValue() { Value = "000000" } },
                        new FontName() { Val = "Times New Roman" }),
                    new Font(
                        new FontSize() { Val = 14 },
                        new Color() { Rgb = new HexBinaryValue() { Value = "000000" } },
                        new FontName() { Val = "Times New Roman" }),
                    new Font(
                        new FontSize() { Val = 14 },
                        new Color() { Rgb = new HexBinaryValue() { Value = "000000" } },
                        new FontName() { Val = "Times New Roman" }),
                    new Font(
                        new FontSize() { Val = 14 },
                        new Color() { Rgb = new HexBinaryValue() { Value = "000000" } },
                        new FontName() { Val = "Times New Roman" })
                ),
                new Fills(
                    new Fill(new PatternFill() { PatternType = PatternValues.None }),
                    new Fill(new PatternFill() { PatternType = PatternValues.None }),
                    new Fill(new PatternFill() { PatternType = PatternValues.None })
                ),
                new Borders(
                    new Border(
                        new LeftBorder(),
                        new RightBorder(),
                        new TopBorder(),
                        new BottomBorder(),
                        new DiagonalBorder()),
                    new Border(
                        new LeftBorder(
                            new Color() { Auto = true }
                        )
                        { Style = BorderStyleValues.Thin },
                        new RightBorder(
                            new Color() { Indexed = (UInt32Value)64U }
                        )
                        { Style = BorderStyleValues.Thin },
                        new TopBorder(
                            new Color() { Auto = true }
                        )
                        { Style = BorderStyleValues.Thin },
                        new BottomBorder(
                            new Color() { Indexed = (UInt32Value)64U }
                        )
                        { Style = BorderStyleValues.Thin },
                        new DiagonalBorder()),
                    new Border(
                        new LeftBorder(
                            new Color() { Auto = true }
                        )
                        { Style = BorderStyleValues.Thin },
                        new RightBorder(
                            new Color() { Indexed = (UInt32Value)64U }
                        )
                        { Style = BorderStyleValues.Thin },
                        new TopBorder(
                            new Color() { Auto = true }
                        )
                        { Style = BorderStyleValues.Thin },
                        new BottomBorder(
                            new Color() { Indexed = (UInt32Value)64U }
                        )
                        { Style = BorderStyleValues.Thin },
                        new DiagonalBorder())
                ),
                new CellFormats(
                    new CellFormat() { FontId = 0, FillId = 0, BorderId = 0 },
                    new CellFormat(new Alignment() { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center, WrapText = true }) { FontId = 1, FillId = 2, BorderId = 1, ApplyFont = true },
                    new CellFormat(new Alignment() { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center, WrapText = true }) { FontId = 2, FillId = 0, BorderId = 2, ApplyFont = true },
                    new CellFormat(new Alignment() { Horizontal = HorizontalAlignmentValues.Left, Vertical = VerticalAlignmentValues.Top, WrapText = true }) { FontId = 3, FillId = 0, BorderId = 2, ApplyFont = true, NumberFormatId = 4 }
                )
            );
        }
    }
}
