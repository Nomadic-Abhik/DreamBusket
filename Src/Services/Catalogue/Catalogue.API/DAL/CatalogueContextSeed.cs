using Catalogue.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogue.API.DAL
{
    public class CatalogueContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool exist = productCollection.Find(p=> true).Any();
            if(!exist)
            {
                productCollection.InsertManyAsync(getPreConfiguredProduct());
            }
        }

        private static IEnumerable<Product> getPreConfiguredProduct()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id ="602d2149e773f2a3990b47f5",
                    product_name = "Prod1",
                    product_price = 425
                },
                  new Product()
                {
                    Id ="602d2149e773f2a3990b47f6",
                    product_name = "Prod2",
                    product_price = 457
                }
            };
        }
    }
}
