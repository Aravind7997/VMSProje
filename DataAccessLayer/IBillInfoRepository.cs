﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IBillInfoRepository<BillInfo>
    {
        IEnumerable<BillInfo> GetAllBill();
        BillInfo GetBillById(int Billid);
        bool SaveBill(BillInfo bill);
        bool DeleteBill(int id);
        bool UpdateBill(BillInfo bill);
    }
}