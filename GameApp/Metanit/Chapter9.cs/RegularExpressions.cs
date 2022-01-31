using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class C1
    {
        static void F1()
        {
            string obj1 = "aaa wwa bbbbbc aaa wwa rrt www aww wwa";
            Regex regex1 = new Regex(@"wwa(\w*)");
            MatchCollection matches1 = regex1.Matches(obj1);
            if (matches1.Count > 0)
            {
                foreach (Match match in matches1)
                {
                    Console.WriteLine(match.Value);
                }
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }

            string obj2 = "aaa wwa bbbbbc aaa wwa rrt www aww wwa";
            Regex regex2 = new Regex(@"\w*aaa\w*");

            string obj3 = "123-456-7891";
            Regex regex3 = new Regex(@"\d{3}-\d{3}-\d{4}");


            string pattern1 = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            var data = new string[]
            {
                "nastya@rabbit.com",
                "+37533587621",
                "cat@ysaimon.com",
                "+37599524182",
                "rinat@yandex.ru",
                "+37544218377"
            };

            Console.WriteLine("Email");
            for (int i = 0; i < data.Length; i++)
            {
                if (Regex.IsMatch(data[i], pattern1, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine(data[i]);
                }
            }

            string text = "Paradise  in  hell. ";
            string pattern2 = @"\s+";
            string target1 = " ";
            Regex regex4 = new Regex(pattern2);
            string res1 = regex4.Replace(text, target1);
            Console.WriteLine(res1);


            string phoneNumber = "+375(33)-123-45-67";
            string pattern3 = @"\D";
            string target2 = "";
            Regex regex5 = new Regex(pattern3);
            string res2 = regex5.Replace(phoneNumber, target2);
            Console.WriteLine(res2);
        }
    }
}