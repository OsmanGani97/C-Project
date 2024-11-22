﻿using Osman_1281404.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osman_1281404.Repositories
{
    public interface IGenecricRepostory<T> where T : EntityBase, new()
    {
        IEnumerable<T> Get();
        T Get(int Id);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(int Id);
    }
}
