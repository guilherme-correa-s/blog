using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UsersScreens
{
    public static class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("---------- Criar Usuário ----------");
            Console.WriteLine("Digite o Nome do usuário:");
            var name = Console.ReadLine();
            Console.WriteLine("Digite o Email do usuário:");
            var email = Console.ReadLine();
            Console.WriteLine("Digite a senha do usuário:");
            var password = Console.ReadLine();
            Console.WriteLine("Digite a bio do usuário:");
            var bio = Console.ReadLine();
            Console.WriteLine("Digite o link da imagem do usuário:");
            var imagem = Console.ReadLine();
            Console.WriteLine("Digite o slug do usuário:");
            var slug = Console.ReadLine();

            var user = new User()
            {
                Name = name,
                Email = email,
                PasswordHash = password,
                Bio = bio,
                Image = imagem,
                Slug = slug
            };

            var repository = new Repository<User>(DataBase.Connection);

            repository.Create(user);
            Console.WriteLine("Usuário criado com sucesso!");
            Console.ReadKey();
        }
    }
}