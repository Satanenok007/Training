using System;
namespace TypeOfValues
{

    struct Names
    {
        public string name;
        public string surname;
        public PlaceOfResidence country;
    }
    class PlaceOfResidence
    {
        public string country;
        public string city;
    }
    class Program
    {
        private static void MainStructureNames(string[] args)
        {
            Names person1 = new Names(); // Структура State
            Names person2 = new Names();

            person2.name = "Kate";
            person2.surname = "Paper";
            person1 = person2;
            person2.name = "Bob"; // person1.name = Kate по-прежнему

            Console.WriteLine(person1.name); // Kate
            Console.WriteLine(person2.name); // Bob


            PlaceOfResidence place1 = new PlaceOfResidence(); // Класс PlaceOfResidence
            PlaceOfResidence place2 = new PlaceOfResidence();

            place2.country = "America";
            place2.city = "Boston";
            place1 = place2;
            place2.country = "Mexico"; // теперь и place1.country = Mexico, так как обе ссылки и place1 и place2 указывают на один объект в хипе

            Console.WriteLine(place1.country); // Mexico
            Console.WriteLine(place2.country); // Mexico



            Names person3 = new Names();
            Names person4 = new Names();

            person4.country = new PlaceOfResidence();

            person4.country.city = "New Orlean";
            person3 = person4;
            person4.country.city = "New York"; // теперь и person3 = "New York", так как person3.country и person4.country указывают на один объект в хипе

            Console.WriteLine(person3.country.city); // New York
            Console.WriteLine(person4.country.city); // New York
        }
    }

    class Example2
    {
        struct Person
        {
            public string name;
            public int age;
            public PlaceOfWork company;
        }
        class PlaceOfWork
        {
            public string position;
            public string company;
        }
        class Program
        {
            private static void MainStructurePerson(string[] args)
            {
                Person p1 = new Person(); // Структура
                Person p2 = new Person();

                p2.name = "Liam";
                p2.age = 27;
                p1 = p2;
                p2.name = "Mason";

                Console.WriteLine(p1.name);
                Console.WriteLine(p2.name);


                PlaceOfWork pl1 = new PlaceOfWork(); // Класс
                PlaceOfWork pl2 = new PlaceOfWork();

                pl2.position = "Menager";
                pl2.company = "KFC";
                pl1 = pl2;
                pl2.position = "Order collector";

                Console.WriteLine(pl1.position);
                Console.WriteLine(pl2.position);



                Person p3 = new Person();
                Person p4 = new Person();

                p4.company = new PlaceOfWork();

                p4.company.company = "McDonald's";
                p3 = p4;
                p4.company.company = "KFC";

                Console.WriteLine(p3.company.company);
                Console.WriteLine(p4.company.company);
            }
        }
    }
}