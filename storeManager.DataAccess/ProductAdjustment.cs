//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace storeManager.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductAdjustment
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int LocationID { get; set; }
        public int ProductLocationID { get; set; }
        public int CurrentQty { get; set; }
        public int NewQty { get; set; }
        public int Difference { get; set; }
        public Nullable<System.DateTime> AdjustmentDate { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> EmployeeID { get; set; }
    }
}
