﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BismillahGraphic.DataCore
{
    public interface IVendorRepository : IRepository<Vendor>
    {
        DataResult<VendorVM> ToListCustom(DataRequest request);
        Task<ICollection<VendorVM>> ToListCustomAsync();
        Task<ICollection<VendorVM>> SearchAsync(string key);
        Vendor AddCustom(VendorVM model);
        void UpdateCustom(VendorVM model);
        VendorVM FindCustom(int? id);

        void UpdatePaidDue(int? id);

        bool RemoveCustom(int id);

        ICollection<VendorPaidDue> TopDue();
        DataResult<VendorPaidDue> PaidDues(DataRequest request);
        Vendor Details(int id);
        ICollection<SellingRecord> SellDateToDate(int id, DateTime? sDateTime, DateTime? eDateTime);
    }
}
