﻿using MAssenger.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.Models
{
    public class User : Account, IEquatable<User>
    {
        private ICollection<Conversation> Conversations = new List<Conversation>();

        public string PhoneNumber { get; set; }
        
        public DateTime LastSeen { get; set; }
        public User()
        {
            
            
        }
        public User(Credential cr)
        {
            Id = UInt64.MaxValue;
            Credential.Password = cr.Password;
            Credential.Username = cr.Username;
        }


        public bool AddConversation(Conversation c)
        {
            Conversations.Add(c);
            return true;
        }

        public ICollection<Conversation> GetConversations()
        {
            return Conversations;
        }



        public bool Equals(User other)
        {
            return this.Id == other.Id;
        }
    }
}