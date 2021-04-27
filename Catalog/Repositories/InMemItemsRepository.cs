using System.Collections.Generic;
using Catalog.Entities;
namespace Catalog.Repositories
{
    public class InMemItemsRepository
    {
        //items = new List<Item>()
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "magic potion", Price = 14, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "magic knife", Price = 42, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "magic shield", Price = 29, CreatedDate = DateTimeOffset.UtcNow },
        };
    }
}