using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using SimpleChat.Models;


namespace Repositories
{
    public class UsersRepository : BaseRepository<User>
    {
        public UsersRepository(SimpleChatContext context)
        {
            Context = context;
        }
        public override User Get(int id)
        {
            if (!ExistsWithId(id))
            {
                throw new Exception();
            }
            else
            {
                return Context.Set<User>().First(x => x.Id == id);
            }
        }
        public override IEnumerable<User> GetAll()
        {
            return Context.Set<User>().ToList();

        }

        public override bool Exists(User user)
        {
            return Context.Set<User>().Where(x => x.Id == user.Id).Count() > 0;
        }
        public override bool ExistsWithId(int id)
        {
            return Context.Set<User>().Where(x => x.Id == id).Count() > 0;
        }
    }
}