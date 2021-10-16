using System;

namespace SwitchPatterns
{
    class ReturningAValueFromSwitch
    {
        static int Select(int op, int a, int b)
        {
            switch (op)
            {
                case 1: return a + b;
                case 2: return a - b;
                case 3: return a * b;
                default: throw new ArgumentException("Недопустимый код операции");
            }
        }

        class AbbreviatedVersion
        {
            static int Select(int op, int a, int b) => op switch
            {
                1 => a + b,
                2 => a - b,
                3 => a * b,
                _ => throw new ArgumentException("Недопустимый код операции")
            };
        }

        class Program
        {
            static void MainSwitchPatterns(string[] args)
            {
                try
                {
                    int x = Select(1, 4, 10);
                    Console.WriteLine(x);

                    x = Select(12, 4, 10);
                    Console.WriteLine(x);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }
    }

    class PropertyPattern
    {
        class Person
        {
            public string Name { get; set; }
            public string Status { get; set; }
            public string Language { get; set; }
        }

        static string GetMessage(Person p) => p switch
        {
            { Language: "english" } => "Hello!",
            { Language: "german", Status: "admin" } => "Hallo, admin!",
            { Language: "french" } => "Salut!",
            { } => "undefined",
            null => "null"
        };

        class Program
        {
            static void MainPropertyPattern(string[] args)
            {
                Person pierre = new Person { Language = "french", Status = "user", Name = "Pierre" };
                string message = GetMessage(pierre);
                Console.WriteLine(message);

                Person tomas = new Person { Language = "german", Status = "admin", Name = "Tomas" };
                Console.WriteLine(GetMessage(tomas));

                Person pablo = new Person { Language = "spanish", Status = "user", Name = "Pablo" };
                Console.WriteLine(GetMessage(pablo));
            }
        }
    }

    class TuplePatterns
    {
        static string GetWelcome(string lang, string daytime, string status) => (lang, daytime, status) switch
        {
            ("english", "morning", _) => "Good morning",
            ("english", "evening", _) => "Good evening",
            ("german", "morning", _) => "Guten Morgen",
            ("german", "evening", _) => "Guten Abend",
            (_, _, "admin") => "Hello, Admin",
            _ => "Здрасьть"
        };

        class Program
        {
            static void MainTuplePatterns(string[] args)
            {
                string message = GetWelcome("english", "evening", "user");
                Console.WriteLine(message);

                message = GetWelcome("french", "morning", "admin");
                Console.WriteLine(message);
            }
        }
    }

    class PositionalPattern
    {
        class MessageDetails
        {
            public string Language { get; set; }    // язык пользователя
            public string DateTime { get; set; }    // время суток
            public string Status { get; set; }      // статус пользователя

            public void Deconstruct(out string lang, out string datetime, out string status)
            {
                lang = Language;
                datetime = DateTime;
                status = Status;
            }
        }

        static string GetWelcome(MessageDetails details) => details switch
        {
            ("english", "morning", _) => "Good morning",
            ("english", "evening", _) => "Good evening",
            ("german", "morning", _) => "Guten Morgen",
            ("german", "evening", _) => "Guten Abend",
            (_, _, "admin") => "Hello, Admin",
            _ => "Здрасьть"
        };

        class Program
        {
            static void MainMessageDetails(string[] args)
            {
                MessageDetails details1 = new MessageDetails { Language = "english", DateTime = "evening", Status = "user" };
                string message = GetWelcome(details1);
                Console.WriteLine(message);

                MessageDetails details2 = new MessageDetails { Language = "french", DateTime = "morning", Status = "admin" };
                message = GetWelcome(details2);
                Console.WriteLine(message);
            }
        }
    }

    class RelationalAndLogicalPatterns
    {
        class RelationalPattern

        {
            static decimal Calculate(decimal sum)
            {
                return sum switch
                {
                    <= 0 => 0,
                    < 50000 => sum * 0.05m,
                    < 100000 => sum * 0.1m,
                    _ => sum * 0.2m
                };
            }

            class Program
            {
                static void MainRelationalAndLogicalPatterns(string[] args)
                {
                    Console.WriteLine(Calculate(-200));
                    Console.WriteLine(Calculate(0));
                    Console.WriteLine(Calculate(10000));
                    Console.WriteLine(Calculate(60000));
                    Console.WriteLine(Calculate(200000));
                }
            }
        }

        class LogicalPattern
        {
            static string CheckAge(int age)
            {
                return age switch
                {
                    < 1 or > 110 => "Недействительный возраст",
                    >= 1 and < 18 => "Доступ запрещен",
                    _ => "Доступ разрешен"
                };
            }

            class Program
            {
                static void MainLogicalPattern(string[] args)
                {
                    Console.WriteLine(CheckAge(200));
                    Console.WriteLine(CheckAge(0));
                    Console.WriteLine(CheckAge(17));
                    Console.WriteLine(CheckAge(18));
                }
            }
        }
    }
}