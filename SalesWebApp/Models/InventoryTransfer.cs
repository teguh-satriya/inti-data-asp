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
    
    public partial class InventoryTransfer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InventoryTransfer()
        {
            this.InventoryTransferDetails = new HashSet<InventoryTransferDetail>();
        }
    
        public System.Guid Id { get; set; }
        public int DocEntry { get; set; }
        public int DocNum { get; set; }
        public string Canceled { get; set; }
        public string Printed { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public Nullable<System.DateTime> DocDueDate { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string ShipTo { get; set; }
        public string NumAtCard { get; set; }
        public string DocCur { get; set; }
        public Nullable<decimal> DocRate { get; set; }
        public Nullable<decimal> DocumentTotal { get; set; }
        public Nullable<decimal> DocumentTotalFC { get; set; }
        public Nullable<decimal> PaidToDate { get; set; }
        public Nullable<decimal> PaidFC { get; set; }
        public string Remark { get; set; }
        public int SalesEmployee { get; set; }
        public string FromWarehouseCode { get; set; }
        public string ToWarehouseCode { get; set; }
        public string TransCode { get; set; }
        public string TransferReqNo { get; set; }
        public string NoContainer { get; set; }
        public string NoSeal { get; set; }
        public string NoPL { get; set; }
        public string Nopol { get; set; }
        public string Driver { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryTransferDetail> InventoryTransferDetails { get; set; }
    }
}
