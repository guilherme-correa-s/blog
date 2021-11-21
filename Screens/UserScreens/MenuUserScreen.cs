namespace Blog.Screens.UsersScreens
{
    public static class MenuUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("------Gestão  Usuários------");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Opções: ");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Todos os usuários");
            Console.WriteLine("2 - Buscar usuário por id");
            Console.WriteLine("3 - Criar usuário");
            Console.WriteLine("4 - Atualizar usuário");
            Console.WriteLine("5 - Deletar usuário");
            Console.WriteLine("6 - Voltar menu principal");
            Console.WriteLine("----------------------------");
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    ListAllUsersScreen.Load();
                    break;

                case 2:
                    ListUserScreen.Load();
                    break;

                case 3:
                    CreateUserScreen.Load();
                    break;

                case 4:
                    UpdateUserScreen.Load();
                    break;

                case 5:
                    DeleteUserScreen.Load();
                    break;

                case 6:
                    Program.Load();
                    break;
                default:
                    Load();
                    break;
            }
            Program.Load();
        }
    }
}