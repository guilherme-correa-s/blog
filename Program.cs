using System;
using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=220894gui123C/;Trust Server Certificate = true";
        static void Main(string[] args)
        {
            using var connection = new SqlConnection(CONNECTION_STRING);

            connection.Open();

            // ReadUsers(connection);
            // ReadUser(connection);
            // CreateUser(connection);

            // CreateRole(connection);
            // UpdateRole(connection);
            // GetAllRoles(connection);
            // GetRole(connection);
            DeleteRole(connection);

            connection.Close();
        }

        public static void ReadUsers(SqlConnection connection)
        {
            var repository = new UserRepository(connection);

            var users = repository.GetAll();

            foreach (var user in users)
                Console.WriteLine(user.Email);
        }

        public static void ReadUser(SqlConnection connection)
        {
            var repository = new UserRepository(connection);

            var user = repository.GetOne(1);

            Console.WriteLine(user.Name);

        }

        public static void CreateUser(SqlConnection connection)
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

            var repository = new UserRepository(connection);
            repository.Create(user);
            Console.WriteLine("Cadastro realizado com sucesso");
        }

        public static void CreateRole(SqlConnection connection)
        {
            var role = new Role()
            {
                Name = "ADMIN",
                Slug = "admin"
            };

            var repository = new Repository<Role>(connection);

            repository.Create(role);
        }

        public static void GetAllRoles(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);

            var roles = repository.GetAll();

            foreach (var role in roles)
                Console.WriteLine(role.Name);
        }

        public static void GetRole(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);

            var role = repository.Get(1);

            Console.WriteLine(role.Name);
        }

        public static void UpdateRole(SqlConnection connection)
        {
            var role = new Role()
            {
                Id = 1,
                Name = "USER",
                Slug = "user"
            };

            var repository = new Repository<Role>(connection);

            repository.Update(role);
        }

        public static void DeleteRole(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);

            repository.Delete(1);
        }
    }
}