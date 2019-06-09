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
    
    public partial class GoodReceiptPO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoodReceiptPO()
        {
            this.GoodReceiptPODetails = new HashSet<GoodReceiptPODetail>();
        }
    
        public System.Guid Id { get; set; }
        public int DocEntry { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public int DocNum { get; set; }
        public string NumAtCard { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public Nullable<System.DateTime> DocDueDate { get; set; }
        public string DocType { get; set; }
        public string Printed { get; set; }
        public string DocStatus { get; set; }
        public string DocCur { get; set; }
        public Nullable<decimal> DocRate { get; set; }
        public string SalesOrderNo { get; set; }
        public Nullable<int> GroupNum { get; set; }
        public int BuyerEmployee { get; set; }
        public Nullable<int> ContactPerson { get; set; }
        public string ShipTo { get; set; }
        public string PayTo { get; set; }
        public Nullable<decimal> TaxRate { get; set; }
        public Nullable<decimal> TotalTax { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
        public Nullable<decimal> DiscountForDocument { get; set; }
        public Nullable<decimal> TotalDiscount { get; set; }
        public Nullable<decimal> TotalDiscountFC { get; set; }
        public Nullable<decimal> DocumentTotal { get; set; }
        public Nullable<decimal> DocumentTotalFC { get; set; }
        public Nullable<decimal> PaidToDate { get; set; }
        public Nullable<decimal> PaidFC { get; set; }
        public string Remark { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodReceiptPODetail> GoodReceiptPODetails { get; set; }
    }
}
