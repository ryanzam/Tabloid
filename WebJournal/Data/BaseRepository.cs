using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebJournal.Model;

namespace WebJournal.Data
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly JournalContext _context;
        public BaseRepository(JournalContext context)
        {
            _context = context;
        }
        public async Task<TEntity> CreateAsync(TEntity entity)
        {         
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }
                await _context.Set<TEntity>().AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception e)
            {
                throw new Exception($"{nameof(entity)} saving error: {e.Message}");
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            if(entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _context.Set<TEntity>().Remove(entity);
            return true;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            try
            {
                return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"couln't get entities: {ex.Message}");
            }
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            try
            {
                var entity = await _context.Set<TEntity>().FirstOrDefaultAsync(e => e.Id == id);
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"couln't get entity: {ex.Message}");
            }
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }
                _context.Set<TEntity>().Update(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"couln't update entity: {ex.Message}");
            }
        }
    }
}
