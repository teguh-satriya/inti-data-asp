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
    
    public partial class MasterVendorContact
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> VendorId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Cellolar { get; set; }
        public string Gender { get; set; }
        public string BillToStreet { get; set; }
        public string BillToZipCode { get; set; }
        public string BillToCity { get; set; }
        public string BillToCountry { get; set; }
        public string BillToState { get; set; }
        public string BillToBlock { get; set; }
        public string BillToStreetNo { get; set; }
        public string ShipToStreet { get; set; }
        public string ShipToZipCode { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToCountry { get; set; }
        public string ShipToState { get; set; }
        public string ShipToBlock { get; set; }
        public string ShipToStreetNo { get; set; }
    
        public virtual MasterVendor MasterVendor { get; set; }
    }
}
