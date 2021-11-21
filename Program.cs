using Blog.Screens.UsersScreens;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=220894gui123C/;Trust Server Certificate = true";
        static void Main(string[] args)
        {
            DataBase.Connection = new SqlConnection(CONNECTION_STRING);
            DataBase.Connection.Open();

            Load();

            DataBase.Connection.Close();

        }

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("------- Gestão Blog -------");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Opções: ");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão Usuários");
            Console.WriteLine("2 - Gestão Tags");
            Console.WriteLine("3 - Gestão Category");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("----------------------------");
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    MenuUserScreen.Load();
                    break;

                case 4:
                    return;

                default:
                    Load();
                    break;
            }
        }
    }
}