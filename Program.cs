using System;
using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=220894gui123C/;Trust Server Certificate = true";
        static void Main(string[] args)
        {
            ReadUsers();
            ReadUser();
            CreateUser();
            UpdateUser();
            DeleteUser();
        }

        public static void ReadUsers()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var users = connection.GetAll<User>();

                foreach (var user in users)
                {
                    Console.WriteLine(user.Name);
                }
            }
        }

        public static void ReadUser()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(1);

                Console.WriteLine(user.Name);

            }
        }

        public static void CreateUser()
        {
            var user = new User()
            {
                Name = "Leticia C",
                Email = "l@h.com.br",
                Bio = "bio",
                Image = "https://imgurl",
                PasswordHash = "hashpassword",
                Slug = "leticia-c"
            };

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Insert<User>(user);

                Console.WriteLine("Cadastro realizado com sucesso");

            }
        }

        public static void UpdateUser()
        {
            var user = new User()
            {
                Id = 2,
                Name = "Leticia Correa",
                Email = "l@h.com.br",
                Bio = "bio update",
                Image = "https://imgurl",
                PasswordHash = "hashpassword",
                Slug = "leticia-correa"
            };

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Update<User>(user);

                Console.WriteLine("Cadastro atualizado com sucesso");

            }
        }

        public static void DeleteUser()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(2);
                connection.Delete<User>(user);

                Console.WriteLine("Cadastro deletado com sucesso");

            }
        }
    }
}