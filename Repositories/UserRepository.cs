using MySql.Data.MySqlClient;
using OptiCare.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace OptiCare.Repositories
{
    public class UserRepository : RepositoryBase, IUserRepository
    {
        public UserRepository() : base()
        {
        }

        public void Add(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public bool AuthenticateUser(NetworkCredential credential)
        {
            bool validUser;
            using (var connection = GetConnection())
            using (var command = new MySqlCommand()) // Cambio SqlCommand a MySqlCommand
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM User WHERE username=@username AND password=@password";
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = credential.UserName;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = credential.Password;
                validUser = command.ExecuteScalar() == null ? false : true;
            }
            return validUser;
        }

        public void Edit(UserModel UserModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public UserModel GetByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
