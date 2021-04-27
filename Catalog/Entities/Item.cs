using System;

namespace Catalog.Entities
{
    public record Item
    {
        //init: only properties  C# 9:: { get; init; } init means set at intilize :: old { get; private set; }
        public Guid Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}