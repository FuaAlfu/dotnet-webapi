using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
using Catalog.Entities;
namespace Catalog.Controllers
{
    //Get /items :: [Route("[Controller]")]

    [ApiController]
    [Route("items")]
    public class ItemController : ControllerBase
    {
        private readonly InMemItemsRepository repository;

        //constructing data
        public ItemController()
        {
            repository = new InMemItemsRepository();
        }

        //Get /Items
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            var items = repository.GetItems();
            return items;
        }

        //Get /Items/id
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = repository.GetItem(id);
            if (item is null)
            {
                return NotFound();
            }
            return item;
        }
    }
}
