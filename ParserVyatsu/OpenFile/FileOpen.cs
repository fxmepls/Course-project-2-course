using System.Diagnostics;

namespace ParserVyatsu.OpenFile
{
    internal static class FileOpen
    {
        public static void openFile(string path)
        {
            Process process = new Process();
            process.StartInfo.FileName = path;
            process.Start();
        }
    }
}
