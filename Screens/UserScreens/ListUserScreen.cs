using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UsersScreens
{
    public static class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("---- Listar Usuário ----");
            Console.WriteLine("Digite o Id do usuário:");
            var id = int.Parse(Console.ReadLine()!);

            var repository = new Repository<User>(DataBase.Connection);
            try
            {
                var user = repository.Get(id);
                Console.Clear();
                Console.WriteLine($"{user.Id} - {user.Name}");
                Console.ReadKey();
                MenuUserScreen.Load();
            }
            catch (System.Exception)
            {
                Console.WriteLine("Id inválido!");
                Console.ReadKey();
                Load();
                throw;
            }
        }
    }
}