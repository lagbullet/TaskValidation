using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ValidationApp
{
    class Validator
    {

        public bool IsValidURL(string url) => Regex.IsMatch(url, @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$", RegexOptions.IgnoreCase);

        public bool IsValidFilePath(string filepath) => Regex.IsMatch(filepath, @"^(([a-zA-Z]:|\\\\\w[ \w\.]*)(\\\w[ \w\.]*|\\%[ \w\.]+%+)+|%[ \w\.]+%(\\\w[ \w\.]*|\\%[ \w\.]+%+)*)$", RegexOptions.IgnoreCase);

        public bool IsValidEmail(string strIn) => Regex.IsMatch(strIn, @"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,17})$", RegexOptions.IgnoreCase);
    }
}
