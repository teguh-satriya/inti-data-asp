//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalesWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GoodReceiptPODetail
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> GoodReceiptPOId { get; set; }
        public int DocEntry { get; set; }
        public int RowNumber { get; set; }
        public int TargetType { get; set; }
        public Nullable<int> TargetEntry { get; set; }
        public string BaseRef { get; set; }
        public int BaseType { get; set; }
        public int BaseEntry { get; set; }
        public int BaseLine { get; set; }
        public string RowStatus { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public string PartNumber { get; set; }
        public string InventoryUoM { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> InventoryUoMQuantity { get; set; }
        public string WarehouseCode { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public Nullable<decimal> OpenQuantity { get; set; }
        public string OcrCode { get; set; }
        public string OcrCode2 { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> DiscountPercent { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> RowTotal { get; set; }
        public Nullable<decimal> RowTotalFC { get; set; }
        public string AccountCode { get; set; }
    
        public virtual GoodReceiptPO GoodReceiptPO { get; set; }
    }
}
