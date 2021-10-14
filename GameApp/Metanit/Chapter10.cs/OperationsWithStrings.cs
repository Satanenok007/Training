using System;

namespace OperationsWithString
{
    class OperationsWithStrings
    {

        static void OperationWitnString()
        {
            string v1 = "Find";
            string v2 = "me";
            string v3 = v1 + " " + v2;
            string v4 = String.Concat(v3, ":)");
            Console.WriteLine(v4);

            string v5 = "Hello,";
            string v6 = "Sofia";
            string v7 = "find";
            string v8 = "me";
            string v9 = ":)";
            string[] values = new string[] { v5, v6, v7, v8, v9 };
            String v10 = String.Join(" ", values);
        }
    }

    class StringComparison
    {
        static void StringsComparison()
        {
            string x1 = "Find";
            string x2 = "me";

            int result = String.Compare(x1, x2);
            if (result < 0)
            {
                Console.WriteLine("Строка x1 перед строкой x2");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка x1 стоит после строки x2");
            }
            else
            {
                Console.WriteLine("Строки x1 и x2 идентичны");
            }


            string x3 = "Get";
            string x4 = "the money";

            int conclusion = String.Compare(x3, x4);
            if (conclusion > 0)
            {
                Console.WriteLine("Строка x3 стоит после строки x4");
            }
            else if (conclusion < 0)
            {
                Console.WriteLine("Строка x3 перед строкой x4");
            }
            else
            {
                Console.WriteLine("Строки x3 и x4 идентичны");
            }
        }
    }

    class SearchInLine
    {
        static void Search()
        {
            string s1 = "Find me";
            char ch = 'd';
            int indexOfChar = s1.IndexOf(ch);
            Console.WriteLine(indexOfChar);

            string subString = "me";
            int indexOfSubstring = s1.IndexOf(subString);
            Console.WriteLine(indexOfSubstring);
        }
    }

    class SplittingLines
    {
        static void Splitting()
        {
            string text = "Не тот волк, кто волк, а тот, кто волк";

            string[] words = text.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
        }
    }

    class CroppingALine
    {
        static void CroppingALines()
        {
            string text1 = "Find me";

            text1 = text1.Trim();
            text1 = text1.Trim(new char[] { 'd', 'e' });

            string text2 = "Не перебивай немогоБ когда он говорит";
            text2 = text2.Substring(2);
            Console.WriteLine(text2);
            text2 = text2.Substring(0, text2.Length - 2);
            Console.WriteLine(text2);
        }
    }

    class Insert
    {
        static void Inserts()
        {
            string text = "Пасмурный день";
            string subString = "замечательный ";

            text = text.Insert(10, subString);
            Console.WriteLine(text);
        }
    }

    class DeletingRows
    {
        static void DeletingRow()
        {
            string result = "Грязное окно";
            int ind1 = result.Length - 1;
            result = result.Remove(ind1);
            Console.WriteLine(result);

            result = result.Remove(0, 2);
        }
    }

    class Replacement
    {
        static void Replacements()
        {
            string text1 = "хорошая собака";

            text1 = text1.Replace("хорошая", "плохая");
            Console.WriteLine(text1);

            text1 = text1.Replace("а", "");
            Console.WriteLine(text1);
        }
    }

    class CaseChange
    {
        static void CaseChanges()
        {
            string hello = "Помой окно!";

            Console.WriteLine(hello.ToLower());
            Console.WriteLine(hello.ToUpper());
        }
    }
}