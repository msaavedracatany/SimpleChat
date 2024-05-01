using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using SimpleChat.Models;


namespace Repositories
{
    public class MessagesRepository : BaseRepository<Message>
    {
        public MessagesRepository(SimpleChatContext context)
        {
            Context = context;
        }
        public override Message Get(int id)
        {
            if (!ExistsWithId(id))
            {
                throw new Exception();
            }
            else
            {
                return Context.Set<Message>().First(x => x.Id == id);
            }
        }
        public override IEnumerable<Message> GetAll()
        {
            return Context.Set<Message>().ToList();

        }

        public override bool Exists(Message message)
        {
            return Context.Set<Message>().Where(x => x.Id == message.Id).Count() > 0;
        }
        public override bool ExistsWithId(int id)
        {
            return Context.Set<Message>().Where(x => x.Id == id).Count() > 0;
        }
    }
}