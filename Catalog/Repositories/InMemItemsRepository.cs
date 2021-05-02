using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Entities;
namespace Catalog.Repositories
{
    // public interface IInMemItemsRepository
    //     {
    //         Item GetItem(Guid id);
    //         IEnumerable<Item> GetItems();
    //     }
    public class InMemItemsRepository : IInMemItemsRepository
    {

        public class AGenericClass<T> where T : IComparable<T> { }
        //items = new List<Item>()
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "magic potion", Price = 14, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "magic knife", Price = 42, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "magic shield", Price = 29, CreatedDate = DateTimeOffset.UtcNow },
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.Where(item => item.id == id).SingleOrDefault();
        }
    }
}