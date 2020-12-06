using System.Collections.Generic;
using System.Collections.Specialized;
using WebStore.Domain;
using WebStore.Domain.Entityes;

namespace WebStore.Infrastructure.Interfaces
{
    public interface IProductData
    {
        IEnumerable<Section> GetSections();

        IEnumerable<Brand> GetBrands();

        IEnumerable<Product> GetProducts(ProductFilter Filter = null); 
    }
}