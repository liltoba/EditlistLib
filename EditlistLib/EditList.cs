using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EditlistLib
{

    //This Project Coded By Liltoba

    //    For Basic Work

    //https://t.me/ghoulblack
    //https://t.me/liltoba


    public class EditList
    {
        public static string SearchAndReplace(string Text , string Find , string Replace)
        {
            var replacement = Text.Replace(Find, Replace);

            return replacement;
        }


        public static string RemoveSpecialCharacters(string Text)
        {
     
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char c in Text)
            {
                bool flag = (c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_';
                bool flag2 = flag;
                if (flag2)
                {
                    stringBuilder.Append(c);
                }
            } 


            return stringBuilder.ToString();
        }

        private static bool isValid(string line)
        {
            return Regex.IsMatch(line, "[a-zA-Z0-9._%+-]+@(?:[a-zA-Z0-9]+\\.)+[a-zA-Z]{2,6}:(?:[a-zA-Z0-9!@#$%^&*?._-]{1,})");
        }

        public static string EmailToUser(string Text)
        {
           List<string> list = new List<string>();

            bool flag = isValid(Text);
            bool flag4 = flag;
            if (flag4)
            {
                string item = Text.Split(new char[]
                {
                        ':'
                })[0].Split(new char[]
                {
                        '@'
                })[0] + ":" + Text.Split(new char[]
                {
                        ':'
                })[1];
                list.Add(item);
            }
            List<string> list2 = list.Distinct<string>().ToList<string>();

            foreach (string value in list2)
            {
                return value.ToString();

            }
            return null;
           
        }


        public static string RemoveLineBreaks(string Text)
        {
            var sText = Text.Replace("\r", "").Replace("\n", "");
            return sText;


        }


        public static string RemoveDuplicates(string Text)
        {
            return new string(Text.ToCharArray().Distinct().ToArray());



        }


        public static string Extractor(string Text,string Regex)
        {
            Regex emailRegex = new Regex(Regex,
            RegexOptions.IgnoreCase);

            MatchCollection emailMatches = emailRegex.Matches(Text);

            StringBuilder sb = new StringBuilder();

            foreach (Match emailMatch in emailMatches)
            {
                sb.AppendLine(emailMatch.Value);
            }

            return sb.ToString();
        }


        public static string UserPassExtractor(string Text)
        {

            Regex emailRegex = new Regex(@"\w+([-+.]\w+)*:\w+([-+.]\w+)*",
                RegexOptions.IgnoreCase);

            MatchCollection emailMatches = emailRegex.Matches(Text);

            StringBuilder sb = new StringBuilder();

            foreach (Match emailMatch in emailMatches)
            {
                sb.AppendLine(emailMatch.Value);
            }

            return sb.ToString();
        }


        public static string MailExtractor(string Text)
        {

            Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
                RegexOptions.IgnoreCase);

            MatchCollection emailMatches = emailRegex.Matches(Text);

            StringBuilder sb = new StringBuilder();

            foreach (Match emailMatch in emailMatches)
            {
                sb.AppendLine(emailMatch.Value);
            }

            return sb.ToString();
        }


        public static string PasswordExtractor(string Text)
        {

            Regex emailRegex = new Regex(@":\w+([-+.]\w+)*",
                RegexOptions.IgnoreCase);

            MatchCollection emailMatches = emailRegex.Matches(Text);

            StringBuilder sb = new StringBuilder();

            foreach (Match emailMatch in emailMatches)
            {
                sb.AppendLine(emailMatch.Value);
            }

            return sb.ToString();
        }



        public static string UserExtractor(string Text)
        {

            Regex emailRegex = new Regex(@"\w+([-+.]\w+)*:",
                RegexOptions.IgnoreCase);

            MatchCollection emailMatches = emailRegex.Matches(Text);

            StringBuilder sb = new StringBuilder();

            foreach (Match emailMatch in emailMatches)
            {
                sb.AppendLine(emailMatch.Value);
            }

            return sb.ToString();
        }


        public static string MailPassExtractor(string Text)
        {

            Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*:\w+([-+.]\w+)*",
                RegexOptions.IgnoreCase);

            MatchCollection emailMatches = emailRegex.Matches(Text);

            StringBuilder sb = new StringBuilder();

            foreach (Match emailMatch in emailMatches)
            {
                sb.AppendLine(emailMatch.Value);
            }

            return sb.ToString();
        }
    }
}
