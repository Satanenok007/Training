using System;

// namespace ConsoleApplication1
// {
//     class MyArr
//     {
//         int[] arr;
//         public int Length;

//         public MyArr(int Size)
//         {
//             arr = new int[Size];
//             Length = Size;
//         }

//         // Создаем простейший индексатор
//         public int this[int index]
//         {
//             set
//             {
//                 arr[index] = value;
//             }

//             get
//             {
//                 return arr[index];
//             }
//         }
//     }

//     class Program
//     {
//         static void Main()
//         {
//             MyArr arr1 = new MyArr(Size: 5);
//             Random ran = new Random();

//             // Инициализируем каждый индекс экземпляра класса arr1
//             for (int i = 0; i < arr1.Length; i++)
//             {
//                 arr1[i] = ran.Next(1, 100);
//                 Console.Write("{0}\t", arr1[i]);
//             }

//             Console.ReadLine();
//         }
//     }
// }



// class Person
// {
//     public string Name { get; set; }
// }
// class People
// {
//     Person[] data;
//     public People()
//     {
//         data = new Person[5];
//     }
//     // индексатор
//     public Person this[int index]
//     {
//         get
//         {
//             return data[index];
//         }
//         set
//         {
//             data[index] = value;
//         }
//     }
// }


// class Program
// {
//     static void Main(string[] args)
//     {
//         People people = new People();
//         people[0] = new Person { Name = "Tom" };
//         people[1] = new Person { Name = "Bob" };

//         Person tom = people[0];
//         Console.WriteLine(tom?.Name);
//     }
// }


// Matrix matrix = new Matrix();
// Console.WriteLine(matrix[0, 0]);
// matrix[0, 0] = 111;
// Console.WriteLine(matrix[0, 0]);
// class Matrix
// {
//     private int[,] numbers = new int[,] { { 1, 2, 4}, { 2, 3, 6 }, { 3, 4, 8 } };
//     public int this[int i, int j]
//     {
//         get
//         {
//             return numbers[i,j];
//         }
//         set
//         {
//             numbers[i, j] = value;
//         }
//     }
// }


class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
class People
{
    Person[] data;
    public People()
    {
        data = new Person[5];
    }
    public Person this[int index]
    {
        get
        {
            return data[index];
        }
        set
        {
            data[index] = value;
        }
    }
    public Person this[string name]
    {
        get
        {
            Person person = null;
            foreach(var p in data)
            {
                if(p?.Name == name)
                {
                    person = p;
                    break;
                }
            }
            return person;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        People people = new People();
        people[0] = new Person { Name = "Tom" };
        people[1] = new Person { Name = "Bob" };
             
        Console.WriteLine(people[0].Name);      // Tom
        Console.WriteLine(people["Bob"].Name);  // Bob
 
        Console.ReadKey();
    }
}