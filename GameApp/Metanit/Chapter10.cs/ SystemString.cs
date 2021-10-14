using System;

namespace SystemString
{
    class CreatingStrings
    {
        string s1 = "String";
        string s2 = null;

        string s3 = new String('w', 4);
        string s4 = new String(new char[] { 's', 't', 'r', 'i', 'n', 'g' });
    }

    class StringAsASetOfCharacters
    {
        static void StringAsASetOfCharacter()
        {
            string string1 = "String";
            char char1 = string1[3];
            Console.WriteLine(char1);
            Console.WriteLine(string1.Length);
        }
    }
}