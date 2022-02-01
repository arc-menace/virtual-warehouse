using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.Models.Interfaces;
using VirtualWarehouse.Models.Models;

namespace VirtualWarehouse.Website.Interfaces
{
    public interface IAttributeService<T> where T : IAttribute
    {
        public Task<T> CreateAttribute(T attribute);
        public Task<T> GetAttribute(int id);
    }
}
