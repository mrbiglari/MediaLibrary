using System.Collections.Generic;

namespace MediaLibrary.Data
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        
        void Create(TEntity model);
        void Update(TEntity model);
        void Delete(TEntity id);

        bool SaveChanges();

    }
}
