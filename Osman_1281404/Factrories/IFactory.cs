using Osman_1281404.Models;
using Osman_1281404.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osman_1281404.Factories
{
    public interface IRepositoryFactory
    {
        IGenecricRepostory<T> GetRepo<T>() where T : EntityBase, new();
    }
}
