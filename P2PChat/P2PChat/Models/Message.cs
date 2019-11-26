using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P2PChat.Models
{
    public class Message
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Text { get; set; }
        public User User { get; set; }
        public DateTime DateCreated { get; set; }

        public Message(string text)
        {
            Text = text;
            DateCreated = DateTime.Now;
        }
    }
}
