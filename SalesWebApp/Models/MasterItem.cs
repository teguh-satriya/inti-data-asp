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
    
    public partial class MasterItem
    {
        public System.Guid Id { get; set; }
        public string ItemNo { get; set; }
        public string ItemDescription { get; set; }
        public string ForeignName { get; set; }
        public int ItemGroup { get; set; }
        public string SalesTaxDefinition { get; set; }
        public string BarCode { get; set; }
        public string PurchaseItem { get; set; }
        public string SalesItem { get; set; }
        public string InventoryItem { get; set; }
        public Nullable<int> UoMGroup { get; set; }
        public Nullable<int> DefaultPurchaseUoM { get; set; }
        public Nullable<int> DefaultSalesUoM { get; set; }
        public Nullable<int> InventoryUoM { get; set; }
        public string PartNumber { get; set; }
        public string Merk { get; set; }
        public string Rim { get; set; }
        public string COO { get; set; }
        public string Pattern { get; set; }
        public string HSCode { get; set; }
    }
}