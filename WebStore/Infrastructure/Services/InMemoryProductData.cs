﻿using System.Collections.Generic;
using WebStore.Data;
using WebStore.Domain.Entityes;
using WebStore.Infrastructure.Interfaces;

namespace WebStore.Infrastructure.Services
{
    public class InMemoryProductData : IProductData
    {
        public IEnumerable<Section> GetSections() => TestData.Sections;

        public IEnumerable<Brand> GetBrands() => TestData.Brands;

        //public IEnumerable<Product> GetProducts(ProductFilter Filter = null)
        //{
        //    var query = TestData.Products;

        //    if (Filter?.SectionId is { } section_id) // сопоставление с образцом
        //        query = query.Where(product => product.SectionId == section_id);

        //    if (Filter?.BrandId != null)
        //        query = query.Where(product => product.BrandId == Filter.BrandId);

        //    return query;
        //}
    }
}