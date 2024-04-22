using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using SimpleChat.Models;

namespace Repositories;

public abstract class BaseRepository<T> : IRepository<T> where T : class
{
    protected SimpleChatContext Context{get;set;}

    public void Add(T entity)
    {
        if (Exists(entity))
        {
            throw new Exception("Already Exists");
        }
        else
        {
            Context.Set<T>().Add(entity);
            Save();
        }
    }

    public void Update(T entity)
    {
        if (!Exists(entity)){
            throw new Exception("Entity does not exist");
        }else
        {
            Context.Entry(entity).State = EntityState.Modified;
            Save();
        }

    }

    public void Save()
    {
        Context.SaveChanges();
    }
    
    public abstract bool Exists(T entity);
    public abstract bool ExistsWithId(int id);

    public void Remove(T entity)
    {
        if(!Exists(entity))
        {
            throw new Exception("Entity does not exist");
        }
        else
        {
            Context.Set<T>().Remove(entity);
            Save();
        }   
    }

    public IEnumerable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public T Get(Guid id)
    {
        throw new NotImplementedException();
    }

    public bool ExistsWithId(Guid id)
    {
        throw new NotImplementedException();
    }
}