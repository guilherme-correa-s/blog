using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UsersScreens
{
    public static class UpdateUserScreen
    {
        public static void Load()
        {
            Console.WriteLine("---------- Atualizar Usuário ----------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Id do usuário que será atualizado:");
            var id = int.Parse(Console.ReadLine()!);

            var repository = new Repository<User>(DataBase.Connection);

            var user = repository.Get(id);

            Console.WriteLine("Digite o Nome atualizado do usuário:");
            var name = Console.ReadLine();
            Console.WriteLine("Digite o Email atualizado do usuário:");
            var email = Console.ReadLine();
            Console.WriteLine("Digite a senha atualizada do usuário:");
            var password = Console.ReadLine();
            Console.WriteLine("Digite a bio atualizada do usuário:");
            var bio = Console.ReadLine();
            Console.WriteLine("Digite o link atualizada da imagem do usuário:");
            var imagem = Console.ReadLine();
            Console.WriteLine("Digite o slug atualizado do usuário:");
            var slug = Console.ReadLine();

            if (name != null)
                user.Name = name;
            if (email != null)
                user.Email = email;
            if (password != null)
                user.PasswordHash = password;
            if (bio != null)
                user.Bio = bio;
            if (imagem != null)
                user.Image = imagem;
            if (slug != null)
                user.Slug = slug;

            repository.Update(user);
            Console.WriteLine("Usuário atualizado com sucesso!");
            Console.ReadKey();
        }
    }
}