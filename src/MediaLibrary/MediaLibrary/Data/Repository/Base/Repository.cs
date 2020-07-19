using MediaLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Data
{

    public class Repository<TEntity>
        : IRepository<TEntity> where TEntity : EntityBase
    {

        protected readonly MediaContext _context;

        private DbSet<TEntity> entities;

        public Repository(MediaContext context)
        {
            _context = context;
            entities = _context.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            entities.Add(entity);
            SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            entities.Remove(entity);
            SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return entities;
        }

        public TEntity GetById(int id)
        {
            return entities.SingleOrDefault(x => x.Id == id);
        }

        public void Update(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            var getEntity = GetById(entity.Id);
            getEntity = entity;

            SaveChanges();
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }   
}
