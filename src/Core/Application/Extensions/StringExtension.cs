using System.Globalization;
using System.Text.RegularExpressions;

namespace Application.Extensions
{
    public static class StringExtension
    {
        private static Dictionary<char, char> TrToEng = new Dictionary<char, char>{
            {'ç','c'},{'Ç','C'},{'ğ','g'},{'Ğ','G'},{'ı','i'},{'İ','I'},{'ö','o'},{'Ö','O'},{'ş','s'},{'Ş','S'},{'ü','u'},{'Ü','U'}
        };
        public static string TurkishToEnglish(this String str, bool toLower = true) =>
            toLower ?
            string.Concat(str.Select(c => TrToEng.ContainsKey(c) ? TrToEng[c] : c)).ToLower(CultureInfo.GetCultureInfoByIetfLanguageTag("en")) :
            string.Concat(str.Select(c => TrToEng.ContainsKey(c) ? TrToEng[c] : c));
        public static string RemoveSpecialChars(this String str) => new Regex(@"[^a-zA-Z0-9\-_ ]").Replace(str, string.Empty);
        public static string ReplaceSpaces(this String str, char replaceChar) => str.Trim().Replace(' ', replaceChar);
        public static string ToUrl(this String str) => str.TurkishToEnglish().ReplaceSpaces('-').RemoveSpecialChars();
        public static string ToUniqueUrl(this String str) => $"{str.ToUrl()}_{Guid.NewGuid()}";
    }
}
