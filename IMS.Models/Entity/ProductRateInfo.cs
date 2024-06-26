﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Models.Entity
{
    public class ProductRateInfo:BaseEntity
    {
        public int CategoryInfoId { get; set; }
        public int ProductInfoId {  get; set; }
        public int StoreInfoId {  get; set; }
        public int RackInfoId { get; set; }
        public int SupplierInfoId { get; set; } 
        public float CostPrice { get; set; }
        public float SellingPrice { get; set; }
        public float Quantity { get; set; }
        public float SoldQuantity { get; set; }
        public float RemainingQuantity { get; set; }
        public string BatchNo { get; set; }
        public DateTime Purchasedate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string MOdifiedBy { get; set; }
    }
}
