using ParserVyatsu.Models;

using System;
using System.Windows.Forms;
namespace ParserVyatsu.Settings
{
    internal class DownloadFolder
    {
        public int filter = 0;

        public string GetLink(StudyPeriod studyPeriod)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Сохранить как (*.xlsx)|*.xlsx|Сохранить как (*.pdf)|*.pdf";
            saveFileDialog.FileName = $"Расписание с {studyPeriod.StartDate:dd/MM/yyyy} по {studyPeriod.EndDate:dd/MM/yyyy}.xlsx";

            string link;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                link = saveFileDialog.FileName;
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        break;
                    case 2:
                        filter = 1;
                        break;
                }
            }
            else
            {
                return null;
            }

            return link;
        }
    }
}
