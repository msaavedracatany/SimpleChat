using System;

namespace Repositories;

public interface IRepository<T>{
    void Add(T entity);
    void Remove(T entity);
    void Update(T entity);
    IEnumerable<T> GetAll();
    T Get(Guid id);
    void Save();
    bool Exists(T entity);
    bool ExistsWithId(Guid id);


}


    
