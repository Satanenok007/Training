using System;

namespace PatternMatching
{
    class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Да работаю я, работаю");
        }
    }

    class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Отлично, работаем дальше");
        }
        public bool IsOnVacation { get; set; }
    }

    class Program
    {
        static void MainEmployeeClass(string[] args)
        {
            Employee emp = new Manager();
            UseEmployee(emp);
        }

        static void UseEmployee(Employee emp)
        {
            if (emp is Manager manager && manager.IsOnVacation == false)
            {
                manager.Work();
            }
            else
            {
                Console.WriteLine("Преобразование не допустимо");
            }
        }

        class ApplicatoinForSwitch
        {
            static void UseEmployee(Employee emp)
            {
                switch (emp)
                {
                    case Manager manager:
                        manager.Work();
                        break;
                    case null:
                        Console.WriteLine("Объект не задан");
                        break;
                    default:
                        Console.WriteLine("Объект не менеджер");
                        break;
                }
            }
        }

        class ExpressionWhen
        {
            static void UseEmployee(Employee emp)
            {
                switch (emp)
                {
                    case Manager manager:
                        manager.Work();
                        break;
                    case null:
                        Console.WriteLine("Объект не задан");
                        break;
                    default:
                        Console.WriteLine("Объект не менеджер");
                        break;
                }
            }
        }
    }
}