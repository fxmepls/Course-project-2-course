namespace ParserVyatsu.Extensions
{
    internal static class StringExtensions
    {
        public static string Decode(this string value)
        {
            return System.Net.WebUtility.HtmlDecode(value).Trim();
        }
    }
}
