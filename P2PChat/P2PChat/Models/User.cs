using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P2PChat.Models
{
    public class User
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Message> Messages { get; set; }

        public User(string name)
        {
            Name = name;
            Messages = new List<Message>();
        }
        public User()
        {
            Messages = new List<Message>();
        }
    }
}
