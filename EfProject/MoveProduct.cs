//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EfProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class MoveProduct
    {
        public int PId { get; set; }
        public string StTo { get; set; }
        public string StFrom { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<System.DateTime> ProdDate { get; set; }
    
        public virtual product product { get; set; }
        public virtual store store { get; set; }
        public virtual store store1 { get; set; }
    }
}
