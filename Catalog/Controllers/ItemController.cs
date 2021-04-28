using System;
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

        [HttpGet]
        public IEquatable<Item> GetItems()
        {
            var items = repository.GetItems();
            return items;
        }
    }
}