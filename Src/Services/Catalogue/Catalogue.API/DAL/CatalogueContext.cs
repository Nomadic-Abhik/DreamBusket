using Catalogue.API.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogue.API.DAL
{
    public class CatalogueContext : ICatalogueContext
    {
        public CatalogueContext(IConfiguration config)
        {
            var client = new MongoClient(config.GetValue<string>("DBSettings :connectionString"));
            var db = client.GetDatabase(config.GetValue<string>("DBSettings :DatabaseName"));
            var Products = db.GetCollection<Product>(config.GetValue<string>("DBSettings :CollectionName"));
            CatalogueContextSeed.SeedData(Products);
        }
        public IMongoCollection<Product> Products { get; }

    }
}
