//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace roshankhadka
{
    using System;
    using System.Collections.Generic;
    
    public partial class order_details
    {
        public int details_id { get; set; }
        public Nullable<int> O_id { get; set; }
        public Nullable<int> P_id { get; set; }
        public Nullable<int> Order_qty { get; set; }
        public Nullable<decimal> Order_price { get; set; }
        public Nullable<decimal> Order_total { get; set; }
    
        public virtual order order { get; set; }
        public virtual product product { get; set; }
    }
}