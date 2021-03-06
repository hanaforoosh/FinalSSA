﻿using System;
using System.Collections.Generic;

namespace MAssenger.Models
{
    public class Channel : Conversation, IEquatable<Channel>
    {
        private System.Collections.Generic.ICollection<Account> Authors = new List<Account>();


        public override bool NewMessage(Message m)
        {
            Messages.Add(m);
            return true;
        }
        public bool Equals(Channel other)
        {
            return this.Id == other.Id;
        }

        internal bool AddAuthor(Account author)
        {
            Authors.Add(author);
            return true;
        }

        internal bool RemoveAuthor(Account author)
        {
            Authors.Remove(author);
            return true;
        }
    }
}