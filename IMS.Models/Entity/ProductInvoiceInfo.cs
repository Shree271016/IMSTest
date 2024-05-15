﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Models.Entity
{
    public class ProductInvoiceInfo:BaseEntity
    {

        public int CategoryInfoId { get; set; }
        public int ProductInfoId { get; set; }
        public int ProductRateInfoId { get; set; }
        public int UnitInfoId { get; set; }
        public int StoreInfoId { get; set; }
        public float Rate { get; set; }
        public float Quantity { get; set; }
        public double Amount { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string MOdifiedBy { get; set; }
    }
}