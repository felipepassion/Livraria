﻿using Microsoft.EntityFrameworkCore;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Repositories;
using Niu.Nutri.Core.Domain.Seedwork;
using Niu.Nutri.Core.Infra.Data.Contexts;
using Niu.Nutri.Core.Infra.Data.Extensions;
using System.Linq.Expressions;

namespace Niu.Nutri.Core.Infra.Data.Repositories
{
    public class Repository<T> : IRepository<T>
        where T : class, new()
    {
        protected BaseContext _ctx;
        public IUnitOfWork UnitOfWork => _ctx;

        public Repository(BaseContext ctx)
        {
            _ctx = ctx;
        }

        public void MeuMetodo()
        {

        }

        public virtual void Add(T entity)
        {
            _ctx.Add(entity);
        }
        public virtual void Attach<K>(K entity)
        {
            _ctx.Entry(entity!).State = EntityState.Modified;
        }
        public virtual void Added<K>(K entity)
        {
            _ctx.Entry(entity!).State = EntityState.Added;
        }
        public virtual void Dettach<K>(K entity)
        {
            if (entity == null) return;
            _ctx.Entry(entity!).State = EntityState.Detached;
        }
        public virtual void AddRange(IEnumerable<T> entity)
        {
            _ctx.AddRange(entity);
        }
        public virtual void Delete(T entity)
        {
            _ctx.Remove(entity);
        }
        public virtual void DeleteRange(IEnumerable<T> entity)
        {
            _ctx.RemoveRange(entity);
        }
        public virtual async Task DeleteRange(Expression<Func<T, bool>> filter)
        {
            _ctx.RemoveRange(await FindAllAsync(filter));
        }

        public virtual void Update(T entity)
        {
            _ctx.Entry(entity).State = EntityState.Modified;
        }

        public async Task<bool> Exists(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> set = Set();

            return await set.AnyAsync(filter);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>>? filter = null)
        {
            IQueryable<T> set = Set();

            if (filter == null)
                return await set.CountAsync();
            else
                return await set.CountAsync(filter);
        }

        public async Task<K> MaxAsync<K>(Expression<Func<T, bool>> filter, Expression<Func<T, K>> selector)
        {
            IQueryable<T> set = Set();

            return await set.Where(filter).Select(selector).MaxAsync();
        }

        public bool IsEmpty()
        {
            return Any() is not true;
        }

        public bool Any(Expression<Func<T, bool>>? filter = null)
        {
            IQueryable<T> set = Set();

            if (filter == null)
                return set.Any();
            else
                return set.Any(filter);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>>? filter = null)
        {
            IQueryable<T> set = Set();
            if (filter == null)
                return await set.AnyAsync();
            else
                return await set.AnyAsync(filter);
        }

        protected IQueryable<T> Set(int maxDepth = 0)
        {
            return _ctx.Set<T>().Include(_ctx.GetIncludePaths(typeof(T), maxDepth)).AsQueryable();
        }

        protected IQueryable<T> Set(bool? insertRecursively)
        {
            return _ctx.Set<T>().Include(_ctx.GetIncludePaths(typeof(T), insertRecursively == true ? int.MaxValue : 0)).AsQueryable();
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> spec, bool includeAll = true)
        {
            return await FindOneAsync(spec, includeAll);
        }

        public virtual Task<T> FindAsync(
            Expression<Func<T, bool>> specification,
            bool includeAll = true,
            params Expression<Func<T, object>>[] include)
        {
            return FindOneAsync(specification, includeAll, include);
        }

        private async Task<T> FindOneAsync(
            Expression<Func<T, bool>> filter,
            bool includeAll = true,
            params Expression<Func<T, object>>[] include)
        {
            IQueryable<T> set = Set(includeAll);

            foreach (var item in include) set = set.Include(item);

            return await set.FirstOrDefaultAsync(filter);
        }

        private async Task<T> FindOneAsync(Expression<Func<T, bool>> filter, bool includeAll = true)
        {
            IQueryable<T> set = Set(includeAll);
            set = set.IncludeAllRecursively();

            return await set.FirstOrDefaultAsync(filter);
        }

        public Task<T> GetRandom()
        {
            IQueryable<T> set = Set();

            return set.OrderBy(x => Guid.NewGuid()).Take(1).FirstOrDefaultAsync()!;
        }

        public Task<List<T>> GetRandomList(int max = 10)
        {
            try
            {
                IQueryable<T> set = Set();

                return set.OrderBy(x => Guid.NewGuid()).Take(new Random().Next(max)).ToListAsync();
            }
            catch
            {

                throw;
            }
        }

        public static Guid GenerateGuid()
        {
            var guidBytes = new byte[16];
            new Random().NextBytes(guidBytes);
            return new Guid(guidBytes);
        }

        public async Task<IEnumerable<K>> SelectAllAsync<K>(
            Expression<Func<T, bool>> filter,
            Expression<Func<T, K>> selector,
            Expression<Func<T, object>>[]? orderBy = null,
            bool ascending = true,
            int? skip = null,
            int? take = null,
            bool includeAll = true,
            params Expression<Func<T, object>>[] include)
        {
            IQueryable<T> set = Set(includeAll);

            foreach (var item in include) set = set.Include(item);

            if (orderBy != null)
            {
                foreach (var item in orderBy)
                {
                    if (ascending)
                        set = set.OrderBy(item);
                    else
                        set = set.OrderByDescending(item);
                }
            }

            var set2 = set.Where(filter).Select(selector).Distinct();

            if (skip.HasValue)
                set2 = set2.Skip(skip.Value);

            if (take.HasValue)
                set2 = set2.Take(take.Value);

            return await set2.ToArrayAsync();
        }

        public async Task<K> SelectAsync<K>(
            Expression<Func<T, bool>> filter,
            Expression<Func<T, K>> selector,
            bool includeAll = true,
            params Expression<Func<T, object>>[] include)
        {
            IQueryable<T> set = Set(includeAll);

            foreach (var item in include) set = set.Include(item);


            return await set.Where(filter).Select(selector).FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<K>> FindAllAsync<K>(
                Expression<Func<T, bool>> filter,
                Expression<Func<T, K>> selector,
                Expression<Func<T, object>>[]? orderBy = null,
                bool ascending = true,
                int? skip = null,
                int? take = null,
                bool includeAll = true,
                params Expression<Func<T, object>>[] include)
        {
            IQueryable<T> set = Set(includeAll);

            foreach (var item in include) set = set.Include(item);

            if (orderBy != null)
            {
                foreach (var item in orderBy)
                {
                    if (ascending)
                        set = set.OrderBy(item);
                    else
                        set = set.OrderByDescending(item);
                }
            }

            set = set.Where(filter);

            if (skip.HasValue)
                set = set.Skip(skip.Value);

            if (take.HasValue)
                set = set.Take(take.Value);

            var cmd = set.Select(selector).ToQueryString();

            return await set.Select(selector).ToArrayAsync();
        }

        public async Task<K> FindAsync<K>(
            Expression<Func<T, K>> selector,
            Expression<Func<T, bool>> filter,
            bool includeAll = true,
            params Expression<Func<T, object>>[] include)
        {
            IQueryable<T> set = Set(includeAll);

            foreach (var item in include) set = set.Include(item);

            return await set.Where(filter).Select(selector).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> FindAllAsync(
            Expression<Func<T, bool>> filter,
            Expression<Func<T, object>>[]? orderBy = null,
            bool ascending = true,
            bool includeAll = true,
            params Expression<Func<T, object>>[] include)
        {
            IQueryable<T> set = Set(includeAll);

            if (include != null) { foreach (var item in include) set = set.Include(item); }

            if (orderBy != null)
            {
                foreach (var item in orderBy)
                {
                    if (ascending)
                        set = set.OrderBy(item);
                    else
                        set = set.OrderByDescending(item);
                }
            }

            return await set.Where(filter).ToArrayAsync();
        }

        public async Task<bool> ExecuteCommandAsync(string command)
        {
            return await this._ctx.ExecuteNpCommand(command);
        }

        public void Dispose()
        {
        }
    }

}
