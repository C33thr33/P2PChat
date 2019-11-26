using P2PChat.Data;
using P2PChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2PChat.Services
{
    public class UserService
    {
        ApplicationContext applicationContext;
        public static User currentUser { get; set; }

        public UserService(ApplicationContext appContext)
        {
            this.applicationContext = appContext;
        }

        public void Login(string username)
        {
            using (var database = applicationContext)
            {
                currentUser = database.Users.FirstOrDefault(u => u.Name == username);
                if (currentUser == null)
                {
                    database.Users.Add(new User(username));
                    database.SaveChanges();
                    currentUser = database.Users.FirstOrDefault(u => u.Name == username);
                }
            }
        }
        public User GetCurrentUser()
        {
            return currentUser;
        }
        public void SendMessage(string message)
        {
            using (var database = applicationContext)
            {
                database.Messages.Add(new Message(message));
                database.SaveChanges();
            }
        }

    }
}
