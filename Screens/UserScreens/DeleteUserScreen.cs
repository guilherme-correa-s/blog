using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UsersScreens
{
    public static class DeleteUserScreen
    {
        public static void Load()
        {
            Console.WriteLine("---------- Deletar Usuário ----------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Id do usuário que será deletado:");
            var id = int.Parse(Console.ReadLine()!);

            var repository = new Repository<User>(DataBase.Connection);

            var user = repository.Get(id);

            Console.WriteLine($"Deseja deletar o usuário - {user.Name}?");
            Console.WriteLine("1 - Sim\n2 - Não");
            var response = short.Parse(Console.ReadLine()!);

            if (response == 1)
            {
                repository.Delete(user);
                Console.WriteLine("Usuário deletado com sucesso!");
                Console.ReadKey();
            }
        }
    }
}