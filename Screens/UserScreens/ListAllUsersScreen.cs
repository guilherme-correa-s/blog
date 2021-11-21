using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UsersScreens
{
    public static class ListAllUsersScreen
    {
        public static void Load()
        {
            var repository = new Repository<User>(DataBase.Connection);

            var users = repository.GetAll();
            Console.Clear();
            Console.WriteLine("Usuários Cadastrados");
            foreach (var user in users)
                Console.WriteLine($"Name - {user.Name} ({user.Email})");
            Console.ReadKey();
        }

    }
}