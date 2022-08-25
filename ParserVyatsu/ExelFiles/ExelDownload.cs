using ParserVyatsu.Const;

using System.Net;
namespace ParserVyatsu.ExelFiles
{
    internal class ExelDownload
    {
        private readonly string Url = Urls.UrlHttp;
        public ExelDownload(string Url)
        {
            this.Url += Url;
        }
        public void DownLoadExel(string FileName)
        {
            WebClient webClient;
            webClient = new WebClient();
            webClient.DownloadFile(Url, FileName);
            webClient.Dispose();
        }

    }
}
