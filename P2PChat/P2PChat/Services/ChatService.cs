using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P2PChat.Data;
using P2PChat.Models;

namespace P2PChat.Services
{
    public class ChatService
    {
        public List<Message> Messages { get; set; }
        public ApplicationContext applicationContext;

        public ChatService(ApplicationContext appContext)
        {
            Messages = new List<Message>();
            this.applicationContext = appContext;
        }

        //public void SendMessage(string message)
        //{
        //    using (var database = applicationContext)
        //    {
        //        database.Messages.Add(new Message(message));
        //        database.SaveChanges();
        //    }
        //}
    }
}
