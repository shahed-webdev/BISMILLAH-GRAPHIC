﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BismillahGraphic.DataCore
{
    public interface IProductRepository : IRepository<Product>, IAddCustom<ProductVM>
    {
        ICollection<ProductListCategoryWise> ToListCustom();
        Task<ICollection<ProductListCategoryWise>> ToListCustomAsync();
        // void AddCustom(ProductVM model);
        void UpdateCustom(ProductVM model);
        void AddStock(int productId, double stock);
        void SubtractStock(int productId, double stock);
        ProductVM FindCustom(int? id);
        bool RemoveCustom(int id);
        Task<ICollection<ProductVM>> SearchAsync(string key);
        ICollection<ProductSold> SoldReport(DateTime? fDateTime, DateTime? tDateTime);
    }
}
