using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalogue.API.Entities;
using MongoDB.Driver;

namespace Catalogue.API.DAL
{
    public interface ICatalogueContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
