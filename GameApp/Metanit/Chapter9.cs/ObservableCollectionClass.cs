using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace HelloApps
{
    class User
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void MainHelloApps(string[] args)
        {
            ObservableCollection<User> users = new ObservableCollection<User>
            {
                new User { Name = "Naiton"},
                new User { Name = "Sofia"},
                new User { Name = "Alice"}
            };




            users.CollectionChanged += Users_CollectionChanged;

            users.Add(new User { Name = "Rikki" });
            users.RemoveAt(1);
            users[0] = new User { Name = "Anders" };

            foreach (User user in users)
            {
                Console.WriteLine(user.Name);
            }
        }

        private static void Users_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    User newUser = e.NewItems[0] as User;
                    Console.WriteLine($"Добавлен новый объект: {newUser.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    User oldUser = e.OldItems[0] as User;
                    Console.WriteLine($"Удален объект: {oldUser.Name}");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    User replacedUser = e.OldItems[0] as User;
                    User replacingUser = e.NewItems[0] as User;
                    Console.WriteLine($"Объект {replacedUser.Name} заменен объектом {replacingUser.Name}");
                    break;
            }
        }
    }
}